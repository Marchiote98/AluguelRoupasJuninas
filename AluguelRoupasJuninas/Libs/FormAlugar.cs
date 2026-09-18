using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AluguelRoupasJuninas
{
    public partial class FormAlugar : Form
    {
        public static int Dias { get; set; }
        public static string Cliente { get; set; }
        public static double Valor { get; set; }
        public static string FormaPagamento { get; set; }
        public FormAlugar()
        {
            InitializeComponent();
            Dias = 0;
            Cliente = string.Empty;
            txtDias.Clear();
            txtNome.Clear();
            txtValor.Clear();
            cbxFormaP.SelectedIndex = -1;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txtDias.Text))
            {
                MessageBox.Show("Por favor, preencha o número de dias.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDias.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Por favor, preencha o nome do cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtValor.Text) || !double.TryParse(txtValor.Text, out _))
            {
                MessageBox.Show("Por favor, preencha um valor válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor.Focus();
                return;
            }
            if (cbxFormaP.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione uma forma de pagamento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxFormaP.Focus();
                return;
            }


            Dias = Convert.ToInt32(txtDias.Text);
            Cliente = txtNome.Text;
            Valor = Convert.ToDouble(txtValor.Text);
            FormaPagamento = cbxFormaP.SelectedItem?.ToString() ?? string.Empty;

            FormCalendario FCalendario = new FormCalendario(FormOpcoes.RoupaId);
            FCalendario.RoupaId = FormOpcoes.RoupaId;
            FCalendario.Show();

            Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtDias.Clear();
            txtNome.Clear();
            txtValor.Clear();
            cbxFormaP.SelectedIndex = -1;
            Close();
        }

        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancel.Image = Properties.Resources.fechar32E;
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.Image = Properties.Resources.fechar32;
        }

        private void btnOk_MouseEnter(object sender, EventArgs e)
        {
            btnOk.Image = Properties.Resources.verificarV;
        }

        private void btnOk_MouseLeave(object sender, EventArgs e)
        {
            btnOk.Image = Properties.Resources.verificar;
        }

        private void txtDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) // Permite dígitos e caracteres de controle (ex: Backspace)
            {
                e.Handled = true; // Cancele o evento para não permitir a tecla pressionada
            }
        }

        private void FormAlugar_Load(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            txtDias.Text = string.Empty;
            txtValor.Text = string.Empty;
            cbxFormaP.SelectedIndex = -1; // Limpa a seleção do ComboBox
        }

        private void txtDias_Leave(object sender, EventArgs e)
        {
            if (Convert.ToUInt32(txtDias.Text) > 4)
            {
                DialogResult dialogResult = MessageBox.Show("Você inseriu mais que 4 dias! \n" +
                    "Tem certeza ?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.No)
                {
                    txtDias.Clear();
                    txtDias.Focus();
                }
                else
                {
                    return;
                    // O usuário confirmou, não faz nada
                }
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir apenas números, backspace e vírgula
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // Só permitir uma vírgula
            if (e.KeyChar == ',' && txtValor.Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtValor.Text, out decimal valor))
            {
                txtValor.Text = valor.ToString("N2");  // Formato com 2 casas decimais
            }
            else
            {
                txtValor.Text = "0,00";
            }
        }
    }
}
