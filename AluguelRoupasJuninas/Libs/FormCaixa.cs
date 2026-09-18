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
    public partial class FormCaixa : Form
    {
        Gerenciador G = new Gerenciador();
        public FormCaixa()
        {
            InitializeComponent();
            Gerenciador.InicializarBanco(); // Inicializa o banco de dados
            Gerenciador.CarregarRoupas(); // Carrega as roupas do banco de dados
            Gerenciador.CarregarAlugueis(); // Carrega os alugueis do banco de dados
            
            txtCredito.Text = string.Empty;
            txtDebito.Text = string.Empty;
            txtPix.Text = string.Empty;
            txtDinheiro.Text = string.Empty;
            txtTotal.Text = string.Empty;
            

            CalcularTotal();
        }

        private void CalcularTotal()
        {
            double pix = 0;
            double dinheiro = 0;
            double credito = 0;
            double debito = 0;
            double total = 0;

            foreach (var aluguel in Gerenciador.ListAlugueis)
            {
                if (aluguel != null && aluguel.FormaPagamento == "PIX")
                {
                    pix += aluguel.Valor;
                    txtPix.Text = pix.ToString("C2");
                }
                if (aluguel != null && aluguel.FormaPagamento == "DINHEIRO")
                {
                    dinheiro += aluguel.Valor;
                    txtDinheiro.Text = dinheiro.ToString("C2");
                }
                if (aluguel != null && aluguel.FormaPagamento == "CARTÃO CRÉDITO")
                {
                    credito += aluguel.Valor;
                    txtCredito.Text = credito.ToString("C2");
                }
                if (aluguel != null && aluguel.FormaPagamento == "CARTÃO DÉBITO")
                {
                    debito += aluguel.Valor;
                    txtDebito.Text = debito.ToString("C2");
                }

                total += aluguel.Valor;
                txtTotal.Text = total.ToString("C2");

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormCaixa_Load(object sender, EventArgs e)
        {
            Gerenciador.CarregarAlugueis(); // Carrega os alugueis do banco de dados
            Gerenciador.CarregarRoupas(); // Carrega as roupas do banco de dados
            Gerenciador.CarregarAlugueis(); // Carrega os alugueis do banco de dados
            CalcularTotal(); // Calcula o total de alugueis
        }
    }
}
