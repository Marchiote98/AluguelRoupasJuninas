using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AluguelRoupasJuninas
{
    public partial class FormPrincipal : Form
    {

        private ImageList imageListRoupas = new ImageList();

        public static List<Aluguel> ListAlugueis = new List<Aluguel>();
        public static Aluguel Aluguel = new Aluguel();
        public static FormAdicionar FAdicionar = new FormAdicionar();
        public static Gerenciador gerenciador = new Gerenciador();
        public static FormOpcoes FOpcoes = new FormOpcoes();
        public static FormCaixa FCaixa = new FormCaixa();
        public static FormCalendario FCalendario;

        public FormPrincipal()
        {
            Gerenciador.InicializarBanco(); // Inicializa o banco de dados
            Gerenciador.CarregarRoupas(); // Carrega as roupas do banco de dados
            Gerenciador.CarregarAlugueis(); // Carrega os alugueis do banco de dados
            InitializeComponent();
            AtualizarLista();
            AtualizarListaAluguel();

            imageListRoupas.ImageSize = new Size(150, 150); // Tamanho dos ícones

            listViewRoupas.LargeImageList = imageListRoupas;
            listMasc.LargeImageList = imageListRoupas;
            listInfantil.LargeImageList = imageListRoupas;
            listAcessorios.LargeImageList = imageListRoupas;

        }

        public void AtualizarLista()
        {
            try
            {
                listViewRoupas.Items.Clear();
                listMasc.Items.Clear();
                listInfantil.Items.Clear();
                listAcessorios.Items.Clear();
                imageListRoupas.Images.Clear(); // Limpa as imagens antes de adicionar novas

                int index = 0;
                foreach (var roupa in Gerenciador.ListRoupas)
                {
                    if (File.Exists(roupa.CaminhoImagem))
                    {
                        // Adiciona a imagem ao ImageList
                        imageListRoupas.Images.Add(Image.FromFile(roupa.CaminhoImagem));
                    }
                    else
                    {
                        imageListRoupas.Images.Add(SystemIcons.Question.ToBitmap()); // Imagem padrão se não encontrada
                    }

                    if (roupa.Categoria == "Feminino")
                    {
                        var feminino = new ListViewItem($"{roupa.Id} - Código: {roupa.Nome} \n{roupa.Tamanho.ToUpper()} \n{roupa.Categoria.ToUpper()}", index);
                        listViewRoupas.Items.Add(feminino);
                    }
                    else if (roupa.Categoria == "Masculino")
                    {
                        var masculino = new ListViewItem($"{roupa.Id} - Código: {roupa.Nome} \n{roupa.Tamanho.ToUpper()} \n{roupa.Categoria.ToUpper()}", index);
                        listMasc.Items.Add(masculino);
                    }
                    else if (roupa.Categoria == "Infantil")
                    {
                        var infantil = new ListViewItem($"{roupa.Id} - Código: {roupa.Nome} \n{roupa.Tamanho.ToUpper()} \n{roupa.Categoria.ToUpper()}", index);
                        listInfantil.Items.Add(infantil);
                    }
                    else
                    {
                        var item = new ListViewItem($"{roupa.Id} - Código: {roupa.Nome} \n{roupa.Tamanho.ToUpper()} \n{roupa.Categoria.ToUpper()}", index);
                        listAcessorios.Items.Add(item);
                    }

                    //var item = new ListViewItem($"{roupa.Id} - Código: {roupa.Nome} \n{roupa.Tamanho.ToUpper()} \n{roupa.Categoria.ToUpper()}", index);
                    //listViewRoupas.Items.Add(item);
                    index++;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar lista: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }
        public void AtualizarLista(string pesquisar)
        {
            try
            {
                listViewRoupas.Items.Clear();
                listMasc.Items.Clear();
                listInfantil.Items.Clear();
                listAcessorios.Items.Clear();
                imageListRoupas.Images.Clear(); // Limpa as imagens antes de adicionar novas

                int index = 0;

                foreach (var roupa in Gerenciador.ListRoupas)
                {
                    if (File.Exists(roupa.CaminhoImagem))
                    {
                        // Adiciona a imagem ao ImageList
                        imageListRoupas.Images.Add(Image.FromFile(roupa.CaminhoImagem));
                    }
                    else
                    {
                        imageListRoupas.Images.Add(SystemIcons.Question.ToBitmap()); // Imagem padrão se não encontrada
                    }

                    if (roupa.Categoria == "Feminino" && roupa.Nome == pesquisar)
                    {
                        var feminino = new ListViewItem($"{roupa.Id} - Código: {roupa.Nome} \n{roupa.Tamanho.ToUpper()} \n{roupa.Categoria.ToUpper()}", index);
                        listViewRoupas.Items.Add(feminino);
                    }

                    else if (roupa.Categoria == "Masculino" || roupa.Nome == pesquisar)
                    {
                        var masculino = new ListViewItem($"{roupa.Id} - Código: {roupa.Nome} \n{roupa.Tamanho.ToUpper()} \n{roupa.Categoria.ToUpper()}", index);
                        listMasc.Items.Add(masculino);
                    }
                    else if (roupa.Categoria == "Infantil" || roupa.Nome == pesquisar)
                    {
                        var infantil = new ListViewItem($"{roupa.Id} - Código: {roupa.Nome} \n{roupa.Tamanho.ToUpper()} \n{roupa.Categoria.ToUpper()}", index);
                        listInfantil.Items.Add(infantil);
                    }
                    else if (roupa.Categoria == "Acessórios" || roupa.Nome == pesquisar)
                    {
                        var item = new ListViewItem($"{roupa.Id} - Código: {roupa.Nome} \n{roupa.Tamanho.ToUpper()} \n{roupa.Categoria.ToUpper()}", index);
                        listAcessorios.Items.Add(item);
                    }

                    index++;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar lista: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            FAdicionar.ShowDialog();
        }
        private void FormPrincipal_Activated(object sender, EventArgs e)
        {
            AtualizarLista();
            AtualizarListaAluguel();
            Gerenciador.CarregarAlugueis();
        }

        private void listViewRoupas_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int idSelecionado = Convert.ToInt32(listViewRoupas.SelectedItems[0].Text.Split(' ')[0]);
                string roupaSelecionada = listViewRoupas.SelectedItems[0].Text.Split(' ')[3];
                string tamanhoSelecionado = listViewRoupas.SelectedItems[0].Text.Split('\n')[1];
                string categoriaSelecionada = listViewRoupas.SelectedItems[0].Text.Split('\n')[2];
                var imagemSelecionada = imageListRoupas.Images[listViewRoupas.SelectedItems[0].ImageIndex];

                FormOpcoes.RoupaId = idSelecionado;
                FOpcoes.RoupaNome = roupaSelecionada;
                FOpcoes.RoupaTamanho = tamanhoSelecionado;
                FOpcoes.RoupaCategoria = categoriaSelecionada;
                FOpcoes.RoupaImage = imagemSelecionada;
                FOpcoes.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao selecionar roupa: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void limparTabRoupas_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja limpar a tabela de roupas?"
                    , "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    dialogResult = MessageBox.Show("Essa ação removerá todas as roupas. Deseja continuar?"
                        , "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        var conn = new SQLiteConnection("Data Source=roupas.db;Version=3;");

                        conn.Open();
                        string sql = $"DELETE FROM TB_Roupas";

                        var cmd = new SQLiteCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Tabela de roupas limpa com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        listAcessorios.Items.Clear();
                        listInfantil.Items.Clear();
                        listMasc.Items.Clear();
                        listViewRoupas.Items.Clear();
                    }
                    else { return; }
                }
                else
                {
                    return;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao limpar a tabela: {ex.Message}");
            }
        }

        private void limparTabAluguel_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja limpar a tabela de aluguéis?"
                    , "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    dialogResult = MessageBox.Show("Essa ação removerá todos os aluguéis. Deseja continuar?"
                        , "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes)
                    {
                        var conn = new SQLiteConnection("Data Source=roupas.db;Version=3;");

                        conn.Open();
                        string sql = $"DELETE FROM TB_Aluguel";

                        var cmd = new SQLiteCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Tabela de Alugueis limpa com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Erro ao limpar a tabela: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            //btnClose.Image = Properties.Resources.fecharXR;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            //btnClose.Image = Properties.Resources.fecharX;
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            Gerenciador.CarregarAlugueis();
            FCaixa.ShowDialog();
        }

        private void listMasc_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int idSelecionado = Convert.ToInt32(listMasc.SelectedItems[0].Text.Split(' ')[0]);
                string roupaSelecionada = listMasc.SelectedItems[0].Text.Split(' ')[3];
                string tamanhoSelecionado = listMasc.SelectedItems[0].Text.Split('\n')[1];
                string categoriaSelecionada = listMasc.SelectedItems[0].Text.Split('\n')[2];
                var imagemSelecionada = imageListRoupas.Images[listMasc.SelectedItems[0].ImageIndex];

                FormOpcoes.RoupaId = idSelecionado;
                FOpcoes.RoupaNome = roupaSelecionada;
                FOpcoes.RoupaTamanho = tamanhoSelecionado;
                FOpcoes.RoupaCategoria = categoriaSelecionada;
                FOpcoes.RoupaImage = imagemSelecionada;
                FOpcoes.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao selecionar roupa: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listInfantil_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int idSelecionado = Convert.ToInt32(listInfantil.SelectedItems[0].Text.Split(' ')[0]);
                string roupaSelecionada = listInfantil.SelectedItems[0].Text.Split(' ')[3];
                string tamanhoSelecionado = listInfantil.SelectedItems[0].Text.Split('\n')[1];
                string categoriaSelecionada = listInfantil.SelectedItems[0].Text.Split('\n')[2];
                var imagemSelecionada = imageListRoupas.Images[listInfantil.SelectedItems[0].ImageIndex];

                FormOpcoes.RoupaId = idSelecionado;
                FOpcoes.RoupaNome = roupaSelecionada;
                FOpcoes.RoupaTamanho = tamanhoSelecionado;
                FOpcoes.RoupaCategoria = categoriaSelecionada;
                FOpcoes.RoupaImage = imagemSelecionada;
                FOpcoes.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao selecionar roupa: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listAcessorios_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int idSelecionado = Convert.ToInt32(listAcessorios.SelectedItems[0].Text.Split(' ')[0]);
                string roupaSelecionada = listAcessorios.SelectedItems[0].Text.Split(' ')[3];
                string tamanhoSelecionado = listAcessorios.SelectedItems[0].Text.Split('\n')[1];
                string categoriaSelecionada = listAcessorios.SelectedItems[0].Text.Split('\n')[2];
                var imagemSelecionada = imageListRoupas.Images[listAcessorios.SelectedItems[0].ImageIndex];

                FormOpcoes.RoupaId = idSelecionado;
                FOpcoes.RoupaNome = roupaSelecionada;
                FOpcoes.RoupaTamanho = tamanhoSelecionado;
                FOpcoes.RoupaCategoria = categoriaSelecionada;
                FOpcoes.RoupaImage = imagemSelecionada;
                FOpcoes.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao selecionar roupa: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExibirRoupa_Click(object sender, EventArgs e)
        {
            tabRoupas.Visible = true;
            listViewAlugueis.Visible = false;
            menuAluguel.Visible = false;
            btnCaixa.Visible = false;
            limparTabAluguel.Visible = false;
            label1.Visible = false;
            label6.Visible = false;

            btnAdicionar.Visible = true;
            limparTabRoupas.Visible = true;
            lbTitulo.Visible = true;
            lbTitulo.Text = "ROUPAS " + tabRoupas.SelectedTab.Text;
        }

        private void btnExibirAluguel_Click(object sender, EventArgs e)
        {
            listViewAlugueis.Visible = true;
            tabRoupas.Visible = false;
            btnAdicionar.Visible = false;
            btnCaixa.Visible = false;
            limparTabRoupas.Visible = false;
            label1.Visible = false;

            limparTabAluguel.Visible = true;
            lbTitulo.Visible = true;
            menuAluguel.Visible = true;
            lbTitulo.Text = "ALUGUEIS";
        }

        private void AtualizarListaAluguel()
        {
            try
            {

                listViewAlugueis.Items.Clear();

                foreach (var roupa in Gerenciador.ListRoupas)
                {
                    var item = new ListViewItem(roupa.Id.ToString());
                    item.SubItems.Add(roupa.Nome.ToString());

                    foreach (var aluguel in Gerenciador.ListAlugueis)
                    {

                        if (roupa.Id == aluguel.IdRoupa)
                        {
                            item.SubItems.Add(aluguel.Cliente.ToString());
                            item.SubItems.Add(aluguel.DataAluguel.ToShortDateString());
                            item.SubItems.Add(aluguel.DataDevolucao.ToShortDateString());
                            item.SubItems.Add(aluguel.Valor.ToString("C2", System.Globalization.CultureInfo.CurrentCulture));
                            item.SubItems.Add(aluguel.FormaPagamento);
                            item.SubItems.Add(aluguel.Devolucao.ToString());
                            item.Tag = aluguel;
                            listViewAlugueis.Items.Add(item);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar lista de aluguéis: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarListaAluguel(string cliente)
        {
            try
            {

                listViewAlugueis.Items.Clear();

                foreach (var roupa in Gerenciador.ListRoupas)
                {
                    var item = new ListViewItem(roupa.Id.ToString());
                    item.SubItems.Add(roupa.Nome.ToString());

                    foreach (var aluguel in Gerenciador.ListAlugueis)
                    {
                        if (aluguel.Cliente == cliente && roupa.Id == aluguel.IdRoupa)
                        {
                            item.SubItems.Add(aluguel.Cliente.ToString());
                            item.SubItems.Add(aluguel.DataAluguel.ToShortDateString());
                            item.SubItems.Add(aluguel.DataDevolucao.ToShortDateString());
                            item.SubItems.Add(aluguel.Valor.ToString("C2", System.Globalization.CultureInfo.CurrentCulture));
                            item.SubItems.Add(aluguel.FormaPagamento);
                            item.SubItems.Add(aluguel.Devolucao.ToString());
                            item.Tag = aluguel;
                            listViewAlugueis.Items.Add(item);

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar lista de aluguéis: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FiltrarDataRetirada(DateTime data)
        {
            try
            {

                listViewAlugueis.Items.Clear();

                foreach (var roupa in Gerenciador.ListRoupas)
                {
                    var item = new ListViewItem(roupa.Id.ToString());
                    item.SubItems.Add(roupa.Nome.ToString());

                    foreach (var aluguel in Gerenciador.ListAlugueis)
                    {
                        if (roupa.Id == aluguel.IdRoupa && aluguel.DataAluguel == data)
                        {
                            item.SubItems.Add(aluguel.Cliente.ToString());
                            item.SubItems.Add(aluguel.DataAluguel.ToShortDateString());
                            item.SubItems.Add(aluguel.DataDevolucao.ToShortDateString());
                            item.SubItems.Add(aluguel.Valor.ToString("C2", System.Globalization.CultureInfo.CurrentCulture));
                            item.SubItems.Add(aluguel.FormaPagamento);
                            item.SubItems.Add(aluguel.Devolucao.ToString());
                            item.Tag = aluguel;
                            listViewAlugueis.Items.Add(item);

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar lista de aluguéis: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FiltrarDataDevolucao(DateTime data)
        {
            try
            {

                listViewAlugueis.Items.Clear();

                foreach (var roupa in Gerenciador.ListRoupas)
                {
                    var item = new ListViewItem(roupa.Id.ToString());
                    item.SubItems.Add(roupa.Nome.ToString());

                    foreach (var aluguel in Gerenciador.ListAlugueis)
                    {
                        if (roupa.Id == aluguel.IdRoupa && aluguel.DataDevolucao == data)
                        {
                            item.SubItems.Add(aluguel.Cliente.ToString());
                            item.SubItems.Add(aluguel.DataAluguel.ToShortDateString());
                            item.SubItems.Add(aluguel.DataDevolucao.ToShortDateString());
                            item.SubItems.Add(aluguel.Valor.ToString("C2", System.Globalization.CultureInfo.CurrentCulture));
                            item.SubItems.Add(aluguel.FormaPagamento);
                            item.SubItems.Add(aluguel.Devolucao.ToString());
                            item.Tag = aluguel;
                            listViewAlugueis.Items.Add(item);

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar lista de aluguéis: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            listViewAlugueis.Visible = false;
            tabRoupas.Visible = false;
            lbTitulo.Visible = false;
            menuAluguel.Visible = false;

            limparTabAluguel.Visible = false;
            limparTabRoupas.Visible = false;

            label2.Visible = false;
            label6.Visible = false;

            label1.Visible = true;
            btnAdicionar.Visible = true;
            btnCaixa.Visible = true;
        }

        private void listViewAluguel_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {

            Color corFundo = Color.FromArgb(250, 83, 103);
            Color corLetra = Color.White;

            using (SolidBrush titulo = new SolidBrush(corFundo))
            {
                e.Graphics.FillRectangle(titulo, e.Bounds);
                TextRenderer.DrawText(e.Graphics, e.Header.Text, e.Font, e.Bounds, corFundo);
                TextRenderer.DrawText(e.Graphics, e.Header.Text, e.Font, e.Bounds, corLetra);
            }

            using (Pen pen = new Pen(Color.White, 2))
            {
                Point p1 = new Point(e.Bounds.Left, e.Bounds.Top + 1);
                Point p2 = new Point(e.Bounds.Right, e.Bounds.Top + 1);
                Point p3 = new Point(e.Bounds.Left, e.Bounds.Bottom - 1);
                Point p4 = new Point(e.Bounds.Right, e.Bounds.Bottom - 1);

                e.Graphics.DrawLine(pen, p1, p2);
                e.Graphics.DrawLine(pen, p3, p4);
            }
        }
        private void listViewAluguel_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {

            Color corFundo;
            Color corTexto = Color.FromArgb(66, 123, 143);
            DateTime hoje = DateTime.Today;

            if (e.Item.Tag is Aluguel aluguel)
            {
                if (aluguel.Devolucao == true)
                {
                    corFundo = Color.LightGreen;
                }
                else if (aluguel.DataDevolucao <= hoje)
                {
                    corFundo = Color.LightCoral;
                }
                else
                    corFundo = Color.White;
            }
            else
            {
                corFundo = Color.White;

            }

            // Se estiver selecionado, sobrepõe a cor de fundo
            if (e.Item.Selected)
            {
                corFundo = Color.DarkCyan;
                corTexto = Color.White;
            }

            using (SolidBrush fundo = new SolidBrush(corFundo))
            {
                e.Graphics.FillRectangle(fundo, e.Bounds);
            }

            TextRenderer.DrawText(e.Graphics, e.SubItem.Text, listViewAlugueis.Font, e.Bounds, corTexto, TextFormatFlags.HorizontalCenter);
        }

        private void listViewAluguel_DrawItem(object sender, DrawListViewItemEventArgs e)
        {

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            listViewAlugueis.OwnerDraw = true;
            listViewAlugueis.View = View.Details;

            listViewAlugueis.DrawItem += listViewAluguel_DrawItem;
            listViewAlugueis.DrawSubItem += listViewAluguel_DrawSubItem;
            listViewAlugueis.DrawColumnHeader += listViewAluguel_DrawColumnHeader;
        }

        private void ListViewAlugueis_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnInicio_MouseEnter(object sender, EventArgs e)
        {
            btnInicio.Image = Properties.Resources.HomeR;
        }

        private void btnInicio_MouseLeave(object sender, EventArgs e)
        {
            btnInicio.Image = Properties.Resources.HomeB;
        }

        private void tabRoupas_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (tabRoupas.SelectedTab.Text == "ACESSÓRIOS")
            {
                lbTitulo.Text = tabRoupas.SelectedTab.Text;
            }
            else
            {
                lbTitulo.Text = "ROUPAS " + tabRoupas.SelectedTab.Text;
            }

            AtualizarLista();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

        }

        private void tsPesquisar_TextChanged(object sender, EventArgs e)
        {
            AtualizarLista(tsPesquisar.Text);
        }

        private void tsPesquisar_Leave(object sender, EventArgs e)
        {
            AtualizarLista(tsPesquisar.Text);
        }

        private void toolFechar_Click(object sender, EventArgs e)
        {
            tsPesquisar.Text = string.Empty;
            AtualizarLista();
        }

        private void toolFecharM_Click(object sender, EventArgs e)
        {
            tsPesquisarM.Text = string.Empty;
            AtualizarLista();
        }

        private void toolFecharI_Click(object sender, EventArgs e)
        {
            tsPesquisarI.Text = string.Empty;
            AtualizarLista();
        }

        private void toolFecharA_Click(object sender, EventArgs e)
        {
            tsPesquisarA.Text = string.Empty;
            AtualizarLista();
        }

        private void tsPesquisarAluguel_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tsPesquisarAluguel.Text))
            {
                AtualizarListaAluguel();
            }
            else
            {
                AtualizarListaAluguel(tsPesquisarAluguel.Text);
            }
        }

        private void toolFecharAluguel_Click(object sender, EventArgs e)
        {
            tsPesquisarAluguel.Text = string.Empty;
            tsDataDevolucao.Text = string.Empty;
            tsDataRetirada.Text = string.Empty;
            AtualizarListaAluguel();
        }

        private void tsDataDevolucao_Leave(object sender, EventArgs e)
        {
            if (tsDataDevolucao.Text == string.Empty)
            {
                AtualizarListaAluguel();
            }
            
            else if(!DateTime.TryParseExact(tsDataDevolucao.Text, "dd/MM", null, System.Globalization.DateTimeStyles.None, out _))
            {
                MessageBox.Show("Insira uma data válida! Ex: 12/12", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FiltrarDataDevolucao(DateTime.ParseExact(tsDataDevolucao.Text, "dd/MM", null));
            }
        }

        private void tsDataRetirada_Leave(object sender, EventArgs e)
        {
            if (tsDataRetirada.Text == string.Empty)
            {
                AtualizarListaAluguel();
            }
            
            else if (!DateTime.TryParseExact(tsDataRetirada.Text, "dd/MM", null, System.Globalization.DateTimeStyles.None, out _))
            {
                MessageBox.Show("Insira uma data válida! Ex: 12/12", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FiltrarDataRetirada(DateTime.ParseExact(tsDataRetirada.Text, "dd/MM", null));
            }
        }

        private void tsMinimizarApp_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void tsMaximizarApp_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void tsFecharApp_Click(object sender, EventArgs e)
        {
            MessageBoxButtons boxButtons = MessageBoxButtons.YesNo;

            DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja fechar o aplicativo?", 
                "Confirmação", boxButtons, MessageBoxIcon.Question);
            
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }
    }
}



