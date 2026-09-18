using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Mapping;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AluguelRoupasJuninas
{
    public partial class FormAdicionar : Form
    {

        public static FormPrincipal FPrincipal = new FormPrincipal();
        public static Gerenciador G = new Gerenciador();
        
        public static FormOpcoes FOpcoes = new FormOpcoes();
        private ImageList imageListRoupas = new ImageList();

        private int Id { get; set; } // Propriedade para armazenar o ID da roupa
        public FormAdicionar()
        {
            InitializeComponent();
            Gerenciador.InicializarBanco();
            pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public FormAdicionar(int id)
        {
            InitializeComponent();
            Gerenciador.InicializarBanco();
            Gerenciador.CarregarRoupas(); // Carrega as roupas do banco de dados

            txtNome.Text = Gerenciador.ListRoupas.FirstOrDefault(r => r.Id == id)?.Nome; // Preenche o nome da roupa
            cbxTamanho.SelectedItem = Gerenciador.ListRoupas.FirstOrDefault(r => r.Id == id)?.Tamanho; // Preenche o tamanho da roupa
            cbxCategoria.SelectedItem = Gerenciador.ListRoupas.FirstOrDefault(r => r.Id == id)?.Categoria; // Preenche a categoria da roupa
            pictureBoxImage.ImageLocation = Gerenciador.ListRoupas.FirstOrDefault(r => r.Id == id)?.CaminhoImagem; // Preenche a imagem da roupa

            Id = id; // Armazena o ID da roupa
            btnSalvar.Visible = false; // Esconde o botão de salvar
            btnSalvarEdit.Visible = true; // Mostra o botão de editar
            pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage; // Ajusta o modo de exibição da imagem
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                imageListRoupas.Images.Clear(); // Limpa as imagens antes de adicionar novas

                if (string.IsNullOrEmpty(txtNome.Text))
                {
                    MessageBox.Show("Por favor, insira um nome.", "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNome.Focus();
                    return;
                }
                if (cbxTamanho.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, insira pelo menos um tamanho.", "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cbxTamanho.Focus();
                    return;
                }
                if (cbxCategoria.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, selecione uma categoria.", "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cbxCategoria.Focus();
                    return;
                }
                if (pictureBoxImage.ImageLocation == null)
                {
                    MessageBox.Show($"Por favor, Selecione uma imagem.");
                    return;
                }
                if (pictureBoxImage.Image.Width > 1000 || pictureBoxImage.Image.Height > 1000)
                {
                    MessageBox.Show("A imagem selecionada é muito grande. Por favor, selecione uma imagem menor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (pictureBoxImage.Image.Width < 100 || pictureBoxImage.Image.Height < 100)
                {
                    MessageBox.Show("A imagem selecionada é muito pequena. Por favor, selecione uma imagem maior.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var roupa = new Roupa
                {
                    Nome = txtNome.Text,
                    Categoria = cbxCategoria.SelectedItem.ToString(),
                    CaminhoImagem = pictureBoxImage.ImageLocation,
                };

                int index = 0;

                while (index < cbxTamanho.SelectedItems.Count)
                {
                    roupa.Tamanho += cbxTamanho.SelectedItems[index].ToString() + " "; // Concatena os tamanhos selecionados
                    index++;
                }

                G.SalvarRoupa(roupa);
                MessageBox.Show("Roupa adicionada com sucesso!");
                LimparCampos();
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao adicionar roupa: {ex.Message}");
            }

        }
        private void LimparCampos()
        {
            txtNome.Clear();
            cbxTamanho.SelectedIndex = -1; // Limpa a seleção do tamanho
            pictureBoxImage.ImageLocation = null; // Limpa a imagem após salvar
            cbxCategoria.SelectedIndex = -1;

            var roupa = new Roupa
            {
                Nome = "",
                Tamanho = "",
                CaminhoImagem = ""
            };
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            Close();
        }

        private void btnSelecionarImagem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "Imagens|*.jpg;*.jpeg;*.png";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxImage.ImageLocation = dlg.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao selecionar imagem: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            Close();
        }

        private void btnSalvarEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Por favor, insira um nome.", "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNome.Focus();
                return;
            }
            if (cbxTamanho.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, insira pelo menos um tamanho.", "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbxTamanho.Focus();
                return;
            }
            if (cbxCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione uma categoria.", "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbxCategoria.Focus();
                return;
            }
            if (pictureBoxImage.ImageLocation == null)
            {
                MessageBox.Show($"Por favor, Selecione uma imagem.");
                return;
            }
            if (pictureBoxImage.Image.Width > 1000 || pictureBoxImage.Image.Height > 1000)
            {
                MessageBox.Show("A imagem selecionada é muito grande. Por favor, selecione uma imagem menor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (pictureBoxImage.Image.Width < 100 || pictureBoxImage.Image.Height < 100)
            {
                MessageBox.Show("A imagem selecionada é muito pequena. Por favor, selecione uma imagem maior.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var roupa = new Roupa
            {
                Id = Id, // Usa o ID da roupa que está sendo editada
                Nome = txtNome.Text,
                Categoria = cbxCategoria.SelectedItem.ToString(),
                CaminhoImagem = pictureBoxImage.ImageLocation,
            };

            int index = 0;

            while (index < cbxTamanho.SelectedItems.Count)
            {
                roupa.Tamanho += cbxTamanho.SelectedItems[index].ToString() + " "; // Concatena os tamanhos selecionados
                index++;
            }

            G.AtualizarRoupaNoBanco(roupa);
            Gerenciador.CarregarRoupas(); // Recarrega a lista de roupas do banco de dados
            FPrincipal.AtualizarLista(); // Atualiza a lista de roupas na tela principal

            FOpcoes.RoupaNome = roupa.Nome;
            FOpcoes.RoupaTamanho = roupa.Tamanho;
            FOpcoes.RoupaCategoria = roupa.Categoria;
            FOpcoes.RoupaImage = pictureBoxImage.Image; // Atualiza a imagem da roupa na tela de opções

            MessageBox.Show("Roupa editada com sucesso!");
            Close();
        }

        private void btnFechar_MouseEnter(object sender, EventArgs e)
        {
            btnFechar.Image = Properties.Resources.fechar32E;
        }

        private void btnFechar_MouseLeave(object sender, EventArgs e)
        {
           btnFechar.Image = Properties.Resources.fechar32; // Volta para a imagem original quando o mouse sai
        }
    }
}
