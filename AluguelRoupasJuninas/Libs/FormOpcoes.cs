using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AluguelRoupasJuninas
{
    public partial class FormOpcoes : Form
    {

        public static FormAlugar FAlugar = new FormAlugar();
        public static Gerenciador Gerenciador = new Gerenciador();
        public static List<DateTime> DatasIndisponivel = new List<DateTime>();
        public static FormPrincipal FPrincipal = new FormPrincipal();
        public static int RoupaId { get; set; }
        public string RoupaNome { get; set; }
        public string RoupaTamanho { get; set; }
        public string RoupaCategoria { get; set; }
        public Image RoupaImage { get; set; }

        public FormOpcoes()
        {
            InitializeComponent();
            Gerenciador.NotificarAlugueis();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormAdicionar FEditar = new FormAdicionar(RoupaId);
            FEditar.lblTitulo.Text = "EDITAR ROUPA";
            FEditar.ShowDialog();
        }

        private void btnAlugar_Click(object sender, EventArgs e)
        {

            FAlugar.ShowDialog();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Tem certeza que deseja remover a roupa {RoupaNome}?\n" +
                $"Essa ação removerá todos alugueis relacionados a esta roupa.", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Gerenciador.RemoverRoupa(RoupaId);
                Gerenciador.RemoverAluguel(RoupaId);
                Gerenciador.CarregarRoupas();
                MessageBox.Show($"Roupa {RoupaNome} removida com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void FormOpcoes_Activated(object sender, EventArgs e)
        {

            var roupa = Gerenciador.ListRoupas.FirstOrDefault(r => r.Id == RoupaId);

            Gerenciador.CarregarAlugueis(RoupaId);
            AtualizarLista();

            if (roupa != null)
            {
                RoupaNome = roupa.Nome;
                RoupaTamanho = roupa.Tamanho;
                RoupaCategoria = roupa.Categoria;
                RoupaImage = Image.FromFile(roupa.CaminhoImagem);

                lblNome.Text = RoupaNome;
                lblTamanho.Text = RoupaTamanho;
                lblCategoria.Text = RoupaCategoria;
                pictureBoxRoupa.Image = RoupaImage;
            }
            else
            {
                Close();
                FPrincipal.Show();
            }
        }

        private void AtualizarLista()
        {
            try
            {

                listViewAluguel.Items.Clear();

                foreach (var aluguel in Gerenciador.ListAlugueis)
                {
                    if (aluguel.IdRoupa == RoupaId)
                    {

                        var item = new ListViewItem(aluguel.Id.ToString());
                        item.SubItems.Add(aluguel.DataAluguel.ToShortDateString());
                        item.SubItems.Add(aluguel.DataDevolucao.ToShortDateString());
                        item.SubItems.Add(aluguel.IdRoupa.ToString());
                        item.SubItems.Add(aluguel.Cliente.ToString());
                        item.SubItems.Add(aluguel.Valor.ToString("C2", System.Globalization.CultureInfo.CurrentCulture));
                        item.SubItems.Add(aluguel.FormaPagamento);
                        item.SubItems.Add(aluguel.Devolucao.ToString());
                        item.Tag = aluguel;

                        listViewAluguel.Items.Add(item);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar lista de aluguéis: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnRemoverAluguel_Click(object sender, EventArgs e)
        {
            int id = listViewAluguel.SelectedItems.Count > 0 ? Convert.ToInt32(listViewAluguel.SelectedItems[0].SubItems[0].Text) : 0;

            if (listViewAluguel.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um aluguel para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show($"Tem certeza que deseja remover o aluguel selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Gerenciador.RemoverAluguel(id);
                Gerenciador.CarregarAlugueis(RoupaId);
                MessageBox.Show("Aluguel removido com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCalendario FCalendario = new FormCalendario(RoupaId, "");
            FCalendario.RoupaId = RoupaId;
            FCalendario.ShowDialog();
        }

        private void FormOpcoes_Load(object sender, EventArgs e)
        {
            listViewAluguel.OwnerDraw = true;
            listViewAluguel.View = View.Details;

            listViewAluguel.DrawItem += listViewAluguel_DrawItem;
            listViewAluguel.DrawSubItem += listViewAluguel_DrawSubItem;
            listViewAluguel.DrawColumnHeader += listViewAluguel_DrawColumnHeader;
        }

        private void listViewAluguel_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void listViewAluguel_DrawItem(object sender, DrawListViewItemEventArgs e)
        {

        }

        private void listViewAluguel_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            Color corFundo;
            Color corTexto = Color.Black;
            DateTime hoje = DateTime.Today;

            if (e.Item.Tag is Aluguel aluguel)
            {
                if (aluguel.Devolucao == true)
                    corFundo = Color.LightGreen;
                else if (aluguel.DataDevolucao <= hoje)
                    corFundo = Color.LightCoral;
                else
                    corFundo = Color.White; // Cor padrão se não houver condição especial
            }
            else
            {
                corFundo = Color.White;

            }

            // Se estiver selecionado, sobrepõe a cor de fundo
            if (e.Item.Selected)
            {
                corFundo = Color.LightBlue;
                corTexto = Color.White;
            }

            using (SolidBrush fundo = new SolidBrush(corFundo))
            {
                e.Graphics.FillRectangle(fundo, e.Bounds);
            }

            TextRenderer.DrawText(e.Graphics, e.SubItem.Text, listViewAluguel.Font, e.Bounds, corTexto, TextFormatFlags.Left);
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.Image = Properties.Resources.voltarE; // Substitua pelo ícone hover de fechar
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.Image = Properties.Resources.voltar; // Substitua pelo ícone padrão de fechar
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (listViewAluguel.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um aluguel para verificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Verifica se o aluguel já foi devolvido
            if (listViewAluguel.SelectedItems[0].SubItems[7].Text == "True")
            {
                MessageBox.Show("Este aluguel já foi devolvido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var aluguel = new Aluguel
            {
                Id = Convert.ToInt32(listViewAluguel.SelectedItems[0].Text.Split(' ')[0]),
                Devolucao = true
            };

            Gerenciador.AtualizarAluguel(aluguel);
            Gerenciador.CarregarAlugueis(RoupaId);
            AtualizarLista();
        }
    }
}

