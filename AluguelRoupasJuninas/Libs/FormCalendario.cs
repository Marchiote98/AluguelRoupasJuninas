using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AluguelRoupasJuninas
{
    public partial class FormCalendario : Form
    {
        private DateTime DataAtual = DateTime.Today;
        public int RoupaId { get; set; }
        public string RoupaNome { get; set; }
        public string Cliente { get; set; }
        public double Valor { get; set; }
        public string FormaPagamento { get; set; }

        public static Gerenciador Gerenciador = new Gerenciador();
        private ToolTip toolTipGlobal = new ToolTip();


        public FormCalendario(int id)
        {

            InitializeComponent();
            InicializarCalendario();
            GerarCalendario(DataAtual, id);
            btnAnteriorV.Visible = false;
            btnProximoV.Visible = false;
            btnAtenrior.Visible = true;
            btnProximo.Visible = true;
        }

        public FormCalendario(int id, string vazia)
        {
            InitializeComponent();
            InicializarCalendarioVisual();
            GerarCalendarioVisual(DataAtual, id);
            btnAnteriorV.Visible = true;
            btnProximoV.Visible = true;
            btnAtenrior.Visible = false;
            btnProximo.Visible = false;
        }
        private void GerarCalendario(DateTime dataBase, int idRoupa)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                calendario.SuspendLayout();

                // Limpar botões antigos
                for (int i = 0; i < calendario.Controls.Count; i++)
                {
                    if (calendario.Controls[i] is Button btnDia)
                    {
                        btnDia.Text = "";
                        btnDia.BackColor = Color.Gainsboro;
                        btnDia.Tag = null;
                        btnDia.Click -= SelecionarData;
                        btnDia.Margin = new Padding(1, 2, 1, 2);
                        btnDia.Padding = new Padding(3);
                        btnDia.TextAlign = ContentAlignment.MiddleCenter;
                        btnDia.Dock = DockStyle.Fill;
                        btnDia.FlatStyle = FlatStyle.Flat;
                        btnDia.FlatAppearance.BorderSize = 1;
                        btnDia.FlatAppearance.BorderColor = Color.White;
                        btnDia.Font = new Font("Arial", 25, FontStyle.Bold);
                        toolTipGlobal.SetToolTip(btnDia, "");
                    }
                }

                lblMesAno.Text = dataBase.ToString("MMMM yyyy", new CultureInfo("pt-BR")).ToUpper();

                DateTime primeiroDia = new DateTime(dataBase.Year, dataBase.Month, 1);
                int offset = ((int)primeiroDia.DayOfWeek + 6) % 7; // Ajuste para semana começando na segunda
                int diasNoMes = DateTime.DaysInMonth(dataBase.Year, dataBase.Month);
                DateTime fimMes = primeiroDia.AddMonths(1).AddDays(-1);

                var alugueis = Gerenciador.ListAlugueis
                    .Where(a => a.IdRoupa == idRoupa && a.DataDevolucao >= primeiroDia && a.DataAluguel <= fimMes)
                    .ToList();

                int controleIndex = offset; // Começa após o cabeçalho + offset

                for (int dia = 1; dia <= diasNoMes; dia++, controleIndex++)
                {
                    Button btnDia;

                    if (controleIndex >= calendario.Controls.Count)
                    {
                        btnDia = new Button
                        {
                            Dock = DockStyle.Fill,
                            Margin = new Padding(1, 2, 1, 2),
                            Padding = new Padding(3),
                            TextAlign = ContentAlignment.MiddleCenter,
                            FlatStyle = FlatStyle.Flat,
                           
                        };
                        calendario.Controls.Add(btnDia);
                    }
                    else
                    {
                        btnDia = calendario.Controls[controleIndex] as Button;
                    }

                    DateTime dataClicada = new DateTime(dataBase.Year, dataBase.Month, dia);

                    btnDia.Text = dia.ToString();
                    btnDia.Tag = dataClicada;
                    btnDia.Click -= SelecionarData;  // Remove caso já exista
                    toolTipGlobal.SetToolTip(btnDia, "");

                    var aluguelDoDia = alugueis.FirstOrDefault(a =>
                        dataClicada >= a.DataAluguel && dataClicada <= a.DataDevolucao);

                    if (dataClicada < DateTime.Today)
                    {
                        btnDia.BackColor = Color.Gainsboro;
                        btnDia.ForeColor = Color.DarkGray;
                    }
                    else if (aluguelDoDia != null)
                    {
                        btnDia.BackColor = Color.IndianRed;
                        btnDia.ForeColor = Color.White;
                        toolTipGlobal.SetToolTip(btnDia,
                            $"Alugada por: {aluguelDoDia.Cliente}\nDe {aluguelDoDia.DataAluguel:d} até {aluguelDoDia.DataDevolucao:d}");
                    }
                    else
                    {
                        btnDia.BackColor = Color.LightSeaGreen;
                        btnDia.ForeColor = Color.White;
                        btnDia.Click += SelecionarData;
                    }
                }

                calendario.ResumeLayout();
                calendario.PerformLayout();
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar calendário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GerarCalendarioVisual(DateTime dataBase, int idRoupa)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                calendario.SuspendLayout();

                // Fonte e tooltip padrão
                Font fontePadrao = new Font("Arial", 25, FontStyle.Bold);

                lblMesAno.Text = dataBase.ToString("MMMM yyyy", new CultureInfo("pt-BR")).ToUpper();

                foreach (Control ctrl in calendario.Controls)
                {
                    if (ctrl is Label label)
                    {
                        label.Text = "";
                        label.BackColor = Color.Gainsboro;
                        label.ForeColor = Color.Black;
                        label.Tag = null;
                        label.Margin = new Padding(1, 2, 1, 2);
                        label.Padding = new Padding(3);
                        label.TextAlign = ContentAlignment.MiddleCenter;
                        label.Dock = DockStyle.Fill;
                        label.FlatStyle = FlatStyle.Flat;
                        label.Font = fontePadrao;
                        toolTipGlobal.SetToolTip(label, "");
                    }
                }

                DateTime primeiroDia = new DateTime(dataBase.Year, dataBase.Month, 1);
                int offset = ((int)primeiroDia.DayOfWeek + 6) % 7; // Ajuste para semana começando na segunda
                int diasNoMes = DateTime.DaysInMonth(dataBase.Year, dataBase.Month);
                DateTime fimMes = primeiroDia.AddMonths(1).AddDays(-1);

                var alugueis = Gerenciador.ListAlugueis
                    .Where(a => a.IdRoupa == idRoupa && a.DataDevolucao >= primeiroDia && a.DataAluguel <= fimMes)
                    .ToList();

                int controleIndex = offset;

                for (int dia = 1; dia <= diasNoMes; dia++, controleIndex++)
                {
                    Label labelDia;

                    if (controleIndex >= calendario.Controls.Count)
                    {
                        labelDia = new Label
                        {
                            Dock = DockStyle.Fill,
                            Margin = new Padding(1, 2, 1, 2),
                            Padding = new Padding(3),
                            TextAlign = ContentAlignment.MiddleCenter,
                            FlatStyle = FlatStyle.Flat,
                            Font = fontePadrao,
                        };
                        calendario.Controls.Add(labelDia);
                    }
                    else
                    {
                        labelDia = calendario.Controls[controleIndex] as Label;
                    }

                    DateTime dataClicada = new DateTime(dataBase.Year, dataBase.Month, dia);

                    labelDia.Text = dia.ToString();
                    labelDia.Tag = dataClicada;
                    toolTipGlobal.SetToolTip(labelDia, "");

                    var aluguelDoDia = alugueis.FirstOrDefault(a =>
                        dataClicada >= a.DataAluguel && dataClicada <= a.DataDevolucao);

                    if (dataClicada < DateTime.Today)
                    {
                        labelDia.BackColor = Color.Gainsboro;
                        labelDia.ForeColor = Color.DarkGray;
                    }
                    else if (aluguelDoDia != null)
                    {
                        labelDia.BackColor = Color.IndianRed;
                        labelDia.ForeColor = Color.White;
                        toolTipGlobal.SetToolTip(labelDia,
                            $"Alugada por: {aluguelDoDia.Cliente}\nDe {aluguelDoDia.DataAluguel:d} até {aluguelDoDia.DataDevolucao:d}");
                    }
                    else
                    {
                        labelDia.BackColor = Color.LightSeaGreen;
                        labelDia.ForeColor = Color.White;
                    }
                }

                calendario.ResumeLayout();
                calendario.PerformLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar calendário visual: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void InicializarCalendario()
        {
            calendario.Controls.Clear();
            calendario.RowCount = 6;
            calendario.ColumnCount = 7;
            calendario.ColumnStyles.Clear();
            calendario.RowStyles.Clear();

            for (int i = 0; i < 7; i++)
                calendario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / 7));

            for (int i = 0; i < 6; i++)
                calendario.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / 6));

            for (int i = 0; i < 42; i++)
            {
                Button btn = new Button
                {
                    Dock = DockStyle.Fill,
                    Margin = new Padding(1, 2, 1, 2),
                    Padding = new Padding(3),
                    TextAlign = ContentAlignment.MiddleCenter,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Arial", 25, FontStyle.Bold),
                    BackColor = Color.Gainsboro
                };
                calendario.Controls.Add(btn);
            }

        }
        private void InicializarCalendarioVisual()
        {
            calendario.Controls.Clear();
            calendario.RowCount = 6;
            calendario.ColumnCount = 7;
            calendario.ColumnStyles.Clear();
            calendario.RowStyles.Clear();

            for (int i = 0; i < 7; i++)
                calendario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / 7));

            for (int i = 0; i < 6; i++)
                calendario.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / 6));

            for (int i = 0; i < 42; i++)
            {
                Label label = new Label
                {
                    Dock = DockStyle.Fill,
                    Margin = new Padding(1, 2, 1, 2),
                    Padding = new Padding(3),
                    TextAlign = ContentAlignment.MiddleCenter,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Arial", 25, FontStyle.Bold),
                    BackColor = Color.Gainsboro
                };
                calendario.Controls.Add(label);
            }

        }

        private void SelecionarData(object sender, EventArgs e)
        {

            DateTime dataSelecionada = (DateTime)((Button)sender).Tag;
            DateTime dataDevolucao = dataSelecionada.AddDays(FormAlugar.Dias);
            Cliente = FormAlugar.Cliente;
            RoupaId = FormOpcoes.RoupaId;
            Valor = FormAlugar.Valor;
            FormaPagamento = FormAlugar.FormaPagamento;


            DialogResult resp = MessageBox.Show(
                $"Alugar roupa {RoupaNome} para dia {dataSelecionada:d}?",
                "Confirmar aluguel",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (resp == DialogResult.OK)
            {
                Gerenciador.AlugarRoupa(RoupaId, dataSelecionada, dataDevolucao, Valor, FormaPagamento, Cliente);
                Gerenciador.CarregarAlugueis();
                Hide();
            }
        }

        private void btnAtenrior_Click(object sender, EventArgs e)
        {
            DataAtual = DataAtual.AddMonths(-1);
            GerarCalendario(DataAtual, RoupaId);
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            DataAtual = DataAtual.AddMonths(+1);
            GerarCalendario(DataAtual, RoupaId);

        }

        private void btnCloseCalendario_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnAnteriorV_Click(object sender, EventArgs e)
        {
            DataAtual = DataAtual.AddMonths(-1); 
            GerarCalendarioVisual(DataAtual, RoupaId);
        }

        private void btnProximoV_Click(object sender, EventArgs e)
        {
            DataAtual = DataAtual.AddMonths(+1); 
            GerarCalendarioVisual(DataAtual, RoupaId);
        }

        private void btnProximoV_MouseEnter(object sender, EventArgs e)
        {
            btnProximoV.Image = Properties.Resources.setaA;
        }

        private void btnProximoV_MouseLeave(object sender, EventArgs e)
        {
            btnProximoV.Image = Properties.Resources.setaB;
        }

        private void btnProximo_MouseEnter(object sender, EventArgs e)
        {
            btnProximo.Image = Properties.Resources.setaA;
        }

        private void btnProximo_MouseLeave(object sender, EventArgs e)
        {
            btnProximo.Image = Properties.Resources.setaB;
        }

        private void btnAnteriorV_MouseEnter(object sender, EventArgs e)
        {
            btnAnteriorV.Image = Properties.Resources.setaEsquerdaA;
        }

        private void btnAnteriorV_MouseLeave(object sender, EventArgs e)
        {
            btnAnteriorV.Image = Properties.Resources.setaEsquerdaB;
        }

        private void btnAtenrior_MouseEnter(object sender, EventArgs e)
        {
            btnAtenrior.Image = Properties.Resources.setaEsquerdaA;
        }

        private void btnAtenrior_MouseLeave(object sender, EventArgs e)
        {
            btnAtenrior.Image = Properties.Resources.setaEsquerdaB;
        }

        private void btnCloseCalendario_MouseEnter(object sender, EventArgs e)
        {
            btnCloseCalendario.Image = Properties.Resources.fechar32E;
        }

        private void btnCloseCalendario_MouseLeave(object sender, EventArgs e)
        {
            btnCloseCalendario.Image = Properties.Resources.fechar32;
        }
    }

}

