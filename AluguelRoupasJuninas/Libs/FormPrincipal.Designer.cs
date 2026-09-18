using System.Drawing;
using System.Windows.Forms;

namespace AluguelRoupasJuninas
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.limparTabRoupas = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.limparTabAluguel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExibirAluguel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExibirRoupa = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.panelListView = new System.Windows.Forms.Panel();
            this.tabRoupas = new System.Windows.Forms.TabControl();
            this.roupasFem = new System.Windows.Forms.TabPage();
            this.listViewRoupas = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tamanho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.toolFechar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPesquisar = new System.Windows.Forms.ToolStripTextBox();
            this.lblPesquisar = new System.Windows.Forms.ToolStripMenuItem();
            this.roupasMasc = new System.Windows.Forms.TabPage();
            this.menuM = new System.Windows.Forms.MenuStrip();
            this.toolFecharM = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPesquisarM = new System.Windows.Forms.ToolStripTextBox();
            this.pESQUISARToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listMasc = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.infantil = new System.Windows.Forms.TabPage();
            this.menuI = new System.Windows.Forms.MenuStrip();
            this.toolFecharI = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPesquisarI = new System.Windows.Forms.ToolStripTextBox();
            this.pESQUISARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listInfantil = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.acessorios = new System.Windows.Forms.TabPage();
            this.menuA = new System.Windows.Forms.MenuStrip();
            this.toolFecharA = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPesquisarA = new System.Windows.Forms.ToolStripTextBox();
            this.lblPesquisarA = new System.Windows.Forms.ToolStripMenuItem();
            this.listAcessorios = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuAluguel = new System.Windows.Forms.MenuStrip();
            this.toolFecharAluguel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDataDevolucao = new System.Windows.Forms.ToolStripTextBox();
            this.pESQUISARPORDATADEDEVOLUÇÃOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDataRetirada = new System.Windows.Forms.ToolStripTextBox();
            this.pESQUISARPORDATADERETIRADAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPesquisarAluguel = new System.Windows.Forms.ToolStripTextBox();
            this.lbPesquisarAluguel = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewAlugueis = new System.Windows.Forms.ListView();
            this.idRoupa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomeRoupa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataRet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataDev = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.formaPag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.devolucao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelTitulo.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelListView.SuspendLayout();
            this.tabRoupas.SuspendLayout();
            this.roupasFem.SuspendLayout();
            this.menu.SuspendLayout();
            this.roupasMasc.SuspendLayout();
            this.menuM.SuspendLayout();
            this.infantil.SuspendLayout();
            this.menuI.SuspendLayout();
            this.acessorios.SuspendLayout();
            this.menuA.SuspendLayout();
            this.menuAluguel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoScroll = true;
            this.ContentPanel.Size = new System.Drawing.Size(1920, 985);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(83)))), ((int)(((byte)(103)))));
            this.panelTitulo.Controls.Add(this.btnInicio);
            this.panelTitulo.Controls.Add(this.lbTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Padding = new System.Windows.Forms.Padding(24, 32, 24, 16);
            this.panelTitulo.Size = new System.Drawing.Size(1516, 115);
            this.panelTitulo.TabIndex = 18;
            // 
            // btnInicio
            // 
            this.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(83)))), ((int)(((byte)(103)))));
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(83)))), ((int)(((byte)(103)))));
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Verdana", 10.9F);
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.Location = new System.Drawing.Point(24, 32);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(98, 67);
            this.btnInicio.TabIndex = 17;
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            this.btnInicio.MouseEnter += new System.EventHandler(this.btnInicio_MouseEnter);
            this.btnInicio.MouseLeave += new System.EventHandler(this.btnInicio_MouseLeave);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoEllipsis = true;
            this.lbTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTitulo.Font = new System.Drawing.Font("Stencil", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbTitulo.Location = new System.Drawing.Point(24, 32);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(1468, 67);
            this.lbTitulo.TabIndex = 3;
            this.lbTitulo.Text = "ROUPAS";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTitulo.UseCompatibleTextRendering = true;
            this.lbTitulo.Visible = false;
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(83)))), ((int)(((byte)(103)))));
            this.panelButtons.Controls.Add(this.limparTabRoupas);
            this.panelButtons.Controls.Add(this.label6);
            this.panelButtons.Controls.Add(this.limparTabAluguel);
            this.panelButtons.Controls.Add(this.label2);
            this.panelButtons.Controls.Add(this.btnCaixa);
            this.panelButtons.Controls.Add(this.label1);
            this.panelButtons.Controls.Add(this.btnExibirAluguel);
            this.panelButtons.Controls.Add(this.label4);
            this.panelButtons.Controls.Add(this.btnExibirRoupa);
            this.panelButtons.Controls.Add(this.label5);
            this.panelButtons.Controls.Add(this.btnAdicionar);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 620);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Padding = new System.Windows.Forms.Padding(24, 8, 4, 8);
            this.panelButtons.Size = new System.Drawing.Size(1516, 79);
            this.panelButtons.TabIndex = 20;
            // 
            // limparTabRoupas
            // 
            this.limparTabRoupas.Dock = System.Windows.Forms.DockStyle.Left;
            this.limparTabRoupas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limparTabRoupas.Font = new System.Drawing.Font("Verdana", 10.9F);
            this.limparTabRoupas.ForeColor = System.Drawing.Color.White;
            this.limparTabRoupas.Image = global::AluguelRoupasJuninas.Properties.Resources.borracha;
            this.limparTabRoupas.Location = new System.Drawing.Point(1264, 8);
            this.limparTabRoupas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.limparTabRoupas.Name = "limparTabRoupas";
            this.limparTabRoupas.Size = new System.Drawing.Size(232, 63);
            this.limparTabRoupas.TabIndex = 26;
            this.limparTabRoupas.Text = "  LIMPAR ROUPAS";
            this.limparTabRoupas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.limparTabRoupas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.limparTabRoupas.UseVisualStyleBackColor = true;
            this.limparTabRoupas.Visible = false;
            this.limparTabRoupas.Click += new System.EventHandler(this.limparTabRoupas_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(83)))), ((int)(((byte)(103)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Location = new System.Drawing.Point(1248, 8);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 63);
            this.label6.TabIndex = 32;
            // 
            // limparTabAluguel
            // 
            this.limparTabAluguel.Dock = System.Windows.Forms.DockStyle.Left;
            this.limparTabAluguel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limparTabAluguel.Font = new System.Drawing.Font("Verdana", 10.9F);
            this.limparTabAluguel.ForeColor = System.Drawing.Color.White;
            this.limparTabAluguel.Image = global::AluguelRoupasJuninas.Properties.Resources.borracha;
            this.limparTabAluguel.Location = new System.Drawing.Point(1016, 8);
            this.limparTabAluguel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.limparTabAluguel.Name = "limparTabAluguel";
            this.limparTabAluguel.Size = new System.Drawing.Size(232, 63);
            this.limparTabAluguel.TabIndex = 25;
            this.limparTabAluguel.Text = "  LIMPAR ALUGUEIS";
            this.limparTabAluguel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.limparTabAluguel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.limparTabAluguel.UseVisualStyleBackColor = true;
            this.limparTabAluguel.Visible = false;
            this.limparTabAluguel.Click += new System.EventHandler(this.limparTabAluguel_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(83)))), ((int)(((byte)(103)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(1000, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 63);
            this.label2.TabIndex = 35;
            // 
            // btnCaixa
            // 
            this.btnCaixa.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaixa.Font = new System.Drawing.Font("Verdana", 10.9F);
            this.btnCaixa.ForeColor = System.Drawing.Color.White;
            this.btnCaixa.Image = ((System.Drawing.Image)(resources.GetObject("btnCaixa.Image")));
            this.btnCaixa.Location = new System.Drawing.Point(768, 8);
            this.btnCaixa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(232, 63);
            this.btnCaixa.TabIndex = 34;
            this.btnCaixa.Text = "  ABRIR CAIXA";
            this.btnCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCaixa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCaixa.UseVisualStyleBackColor = true;
            this.btnCaixa.Click += new System.EventHandler(this.btnCaixa_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(83)))), ((int)(((byte)(103)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(752, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 63);
            this.label1.TabIndex = 33;
            // 
            // btnExibirAluguel
            // 
            this.btnExibirAluguel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExibirAluguel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExibirAluguel.Font = new System.Drawing.Font("Verdana", 10.9F);
            this.btnExibirAluguel.ForeColor = System.Drawing.Color.White;
            this.btnExibirAluguel.Image = global::AluguelRoupasJuninas.Properties.Resources.tarefa;
            this.btnExibirAluguel.Location = new System.Drawing.Point(520, 8);
            this.btnExibirAluguel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExibirAluguel.Name = "btnExibirAluguel";
            this.btnExibirAluguel.Size = new System.Drawing.Size(232, 63);
            this.btnExibirAluguel.TabIndex = 36;
            this.btnExibirAluguel.Text = "  LISTA DE ALUGUEIS";
            this.btnExibirAluguel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExibirAluguel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExibirAluguel.UseVisualStyleBackColor = true;
            this.btnExibirAluguel.Click += new System.EventHandler(this.btnExibirAluguel_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(83)))), ((int)(((byte)(103)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(504, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 63);
            this.label4.TabIndex = 37;
            // 
            // btnExibirRoupa
            // 
            this.btnExibirRoupa.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExibirRoupa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExibirRoupa.Font = new System.Drawing.Font("Verdana", 10.9F);
            this.btnExibirRoupa.ForeColor = System.Drawing.Color.White;
            this.btnExibirRoupa.Image = global::AluguelRoupasJuninas.Properties.Resources.saia;
            this.btnExibirRoupa.Location = new System.Drawing.Point(272, 8);
            this.btnExibirRoupa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExibirRoupa.Name = "btnExibirRoupa";
            this.btnExibirRoupa.Size = new System.Drawing.Size(232, 63);
            this.btnExibirRoupa.TabIndex = 38;
            this.btnExibirRoupa.Text = "  LISTA DE ROUPAS";
            this.btnExibirRoupa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExibirRoupa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExibirRoupa.UseVisualStyleBackColor = true;
            this.btnExibirRoupa.Click += new System.EventHandler(this.btnExibirRoupa_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(83)))), ((int)(((byte)(103)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Location = new System.Drawing.Point(256, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 63);
            this.label5.TabIndex = 39;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Verdana", 10.9F);
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.Location = new System.Drawing.Point(24, 8);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(232, 63);
            this.btnAdicionar.TabIndex = 16;
            this.btnAdicionar.Text = "  ADICIONAR ROUPA";
            this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // panelListView
            // 
            this.panelListView.AutoScroll = true;
            this.panelListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panelListView.BackgroundImage = global::AluguelRoupasJuninas.Properties.Resources.logoQuadrilha;
            this.panelListView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelListView.Controls.Add(this.tabRoupas);
            this.panelListView.Controls.Add(this.listViewAlugueis);
            this.panelListView.Controls.Add(this.menuAluguel);
            this.panelListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelListView.Location = new System.Drawing.Point(0, 115);
            this.panelListView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelListView.Name = "panelListView";
            this.panelListView.Size = new System.Drawing.Size(1516, 505);
            this.panelListView.TabIndex = 16;
            // 
            // tabRoupas
            // 
            this.tabRoupas.Controls.Add(this.roupasFem);
            this.tabRoupas.Controls.Add(this.roupasMasc);
            this.tabRoupas.Controls.Add(this.infantil);
            this.tabRoupas.Controls.Add(this.acessorios);
            this.tabRoupas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabRoupas.Font = new System.Drawing.Font("Tahoma", 16.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tabRoupas.HotTrack = true;
            this.tabRoupas.ItemSize = new System.Drawing.Size(140, 40);
            this.tabRoupas.Location = new System.Drawing.Point(0, 0);
            this.tabRoupas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabRoupas.Name = "tabRoupas";
            this.tabRoupas.Padding = new System.Drawing.Point(10, 10);
            this.tabRoupas.SelectedIndex = 0;
            this.tabRoupas.Size = new System.Drawing.Size(1516, 505);
            this.tabRoupas.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabRoupas.TabIndex = 6;
            this.tabRoupas.Visible = false;
            this.tabRoupas.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabRoupas_Selecting);
            // 
            // roupasFem
            // 
            this.roupasFem.BackColor = System.Drawing.Color.White;
            this.roupasFem.Controls.Add(this.menu);
            this.roupasFem.Controls.Add(this.listViewRoupas);
            this.roupasFem.ForeColor = System.Drawing.Color.Black;
            this.roupasFem.Location = new System.Drawing.Point(4, 44);
            this.roupasFem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roupasFem.Name = "roupasFem";
            this.roupasFem.Size = new System.Drawing.Size(1508, 457);
            this.roupasFem.TabIndex = 0;
            this.roupasFem.Text = "FEMININAS";
            this.roupasFem.UseVisualStyleBackColor = true;
            // 
            // listViewRoupas
            // 
            this.listViewRoupas.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewRoupas.AutoArrange = false;
            this.listViewRoupas.BackColor = System.Drawing.Color.White;
            this.listViewRoupas.BackgroundImageTiled = true;
            this.listViewRoupas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewRoupas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.nome,
            this.tamanho,
            this.categoria});
            this.listViewRoupas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewRoupas.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.listViewRoupas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(83)))), ((int)(((byte)(103)))));
            this.listViewRoupas.FullRowSelect = true;
            this.listViewRoupas.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewRoupas.HideSelection = false;
            this.listViewRoupas.Location = new System.Drawing.Point(0, 0);
            this.listViewRoupas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewRoupas.MultiSelect = false;
            this.listViewRoupas.Name = "listViewRoupas";
            this.listViewRoupas.ShowGroups = false;
            this.listViewRoupas.ShowItemToolTips = true;
            this.listViewRoupas.Size = new System.Drawing.Size(1508, 457);
            this.listViewRoupas.TabIndex = 6;
            this.listViewRoupas.TileSize = new System.Drawing.Size(350, 100);
            this.listViewRoupas.UseCompatibleStateImageBehavior = false;
            this.listViewRoupas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewRoupas_MouseClick);
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 0;
            // 
            // nome
            // 
            this.nome.Text = "NOME";
            this.nome.Width = 100;
            // 
            // tamanho
            // 
            this.tamanho.Text = "TAMANHO";
            this.tamanho.Width = 20;
            // 
            // categoria
            // 
            this.categoria.Text = "CATEGORIA";
            this.categoria.Width = 80;
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolFechar,
            this.tsPesquisar,
            this.lblPesquisar});
            this.menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menu.Size = new System.Drawing.Size(1508, 34);
            this.menu.TabIndex = 7;
            this.menu.Text = " ";
            // 
            // toolFechar
            // 
            this.toolFechar.AutoSize = false;
            this.toolFechar.Image = global::AluguelRoupasJuninas.Properties.Resources.fechar32E;
            this.toolFechar.Name = "toolFechar";
            this.toolFechar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolFechar.RightToLeftAutoMirrorImage = true;
            this.toolFechar.ShowShortcutKeys = false;
            this.toolFechar.Size = new System.Drawing.Size(34, 30);
            this.toolFechar.Text = " ";
            this.toolFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolFechar.Click += new System.EventHandler(this.toolFechar_Click);
            // 
            // tsPesquisar
            // 
            this.tsPesquisar.AutoSize = false;
            this.tsPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tsPesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tsPesquisar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsPesquisar.MaxLength = 200;
            this.tsPesquisar.Name = "tsPesquisar";
            this.tsPesquisar.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.tsPesquisar.Size = new System.Drawing.Size(120, 26);
            this.tsPesquisar.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tsPesquisar.TextChanged += new System.EventHandler(this.tsPesquisar_TextChanged);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.Enabled = false;
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPesquisar.ShowShortcutKeys = false;
            this.lblPesquisar.Size = new System.Drawing.Size(79, 30);
            this.lblPesquisar.Text = "PESQUISAR";
            // 
            // roupasMasc
            // 
            this.roupasMasc.Controls.Add(this.menuM);
            this.roupasMasc.Controls.Add(this.listMasc);
            this.roupasMasc.ForeColor = System.Drawing.Color.Black;
            this.roupasMasc.Location = new System.Drawing.Point(4, 44);
            this.roupasMasc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roupasMasc.Name = "roupasMasc";
            this.roupasMasc.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roupasMasc.Size = new System.Drawing.Size(1227, 426);
            this.roupasMasc.TabIndex = 1;
            this.roupasMasc.Text = "MASCULINAS";
            this.roupasMasc.UseVisualStyleBackColor = true;
            // 
            // menuM
            // 
            this.menuM.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolFecharM,
            this.tsPesquisarM,
            this.pESQUISARToolStripMenuItem1});
            this.menuM.Location = new System.Drawing.Point(2, 2);
            this.menuM.Name = "menuM";
            this.menuM.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuM.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuM.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuM.Size = new System.Drawing.Size(1223, 30);
            this.menuM.TabIndex = 8;
            this.menuM.Text = " ";
            // 
            // toolFecharM
            // 
            this.toolFecharM.Image = global::AluguelRoupasJuninas.Properties.Resources.fechar32E;
            this.toolFecharM.Name = "toolFecharM";
            this.toolFecharM.ShowShortcutKeys = false;
            this.toolFecharM.Size = new System.Drawing.Size(32, 26);
            this.toolFecharM.Text = " ";
            this.toolFecharM.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolFecharM.Click += new System.EventHandler(this.toolFecharM_Click);
            // 
            // tsPesquisarM
            // 
            this.tsPesquisarM.AutoSize = false;
            this.tsPesquisarM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tsPesquisarM.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsPesquisarM.MaxLength = 200;
            this.tsPesquisarM.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.tsPesquisarM.Name = "tsPesquisarM";
            this.tsPesquisarM.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.tsPesquisarM.Size = new System.Drawing.Size(120, 26);
            this.tsPesquisarM.TextChanged += new System.EventHandler(this.tsPesquisar_TextChanged);
            // 
            // pESQUISARToolStripMenuItem1
            // 
            this.pESQUISARToolStripMenuItem1.Enabled = false;
            this.pESQUISARToolStripMenuItem1.Name = "pESQUISARToolStripMenuItem1";
            this.pESQUISARToolStripMenuItem1.ShowShortcutKeys = false;
            this.pESQUISARToolStripMenuItem1.Size = new System.Drawing.Size(79, 26);
            this.pESQUISARToolStripMenuItem1.Text = "PESQUISAR";
            // 
            // listMasc
            // 
            this.listMasc.AutoArrange = false;
            this.listMasc.BackColor = System.Drawing.Color.White;
            this.listMasc.BackgroundImageTiled = true;
            this.listMasc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listMasc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listMasc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listMasc.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.listMasc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(83)))), ((int)(((byte)(103)))));
            this.listMasc.FullRowSelect = true;
            this.listMasc.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listMasc.HideSelection = false;
            this.listMasc.Location = new System.Drawing.Point(2, 2);
            this.listMasc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listMasc.MultiSelect = false;
            this.listMasc.Name = "listMasc";
            this.listMasc.ShowGroups = false;
            this.listMasc.ShowItemToolTips = true;
            this.listMasc.Size = new System.Drawing.Size(1223, 422);
            this.listMasc.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listMasc.TabIndex = 7;
            this.listMasc.TileSize = new System.Drawing.Size(350, 100);
            this.listMasc.UseCompatibleStateImageBehavior = false;
            this.listMasc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listMasc_MouseClick);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ID";
            this.columnHeader5.Width = 0;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "NOME";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "TAMANHO";
            this.columnHeader7.Width = 20;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "CATEGORIA";
            this.columnHeader8.Width = 80;
            // 
            // infantil
            // 
            this.infantil.Controls.Add(this.menuI);
            this.infantil.Controls.Add(this.listInfantil);
            this.infantil.ForeColor = System.Drawing.Color.Black;
            this.infantil.Location = new System.Drawing.Point(4, 44);
            this.infantil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.infantil.Name = "infantil";
            this.infantil.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.infantil.Size = new System.Drawing.Size(1227, 426);
            this.infantil.TabIndex = 2;
            this.infantil.Text = "INFANTIL";
            this.infantil.UseVisualStyleBackColor = true;
            // 
            // menuI
            // 
            this.menuI.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolFecharI,
            this.tsPesquisarI,
            this.pESQUISARToolStripMenuItem});
            this.menuI.Location = new System.Drawing.Point(2, 2);
            this.menuI.Name = "menuI";
            this.menuI.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuI.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuI.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuI.Size = new System.Drawing.Size(1223, 30);
            this.menuI.TabIndex = 8;
            this.menuI.Text = " ";
            // 
            // toolFecharI
            // 
            this.toolFecharI.Image = global::AluguelRoupasJuninas.Properties.Resources.fechar32E;
            this.toolFecharI.Name = "toolFecharI";
            this.toolFecharI.Size = new System.Drawing.Size(32, 26);
            this.toolFecharI.Text = " ";
            this.toolFecharI.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolFecharI.Click += new System.EventHandler(this.toolFecharI_Click);
            // 
            // tsPesquisarI
            // 
            this.tsPesquisarI.AutoSize = false;
            this.tsPesquisarI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tsPesquisarI.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsPesquisarI.MaxLength = 200;
            this.tsPesquisarI.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.tsPesquisarI.Name = "tsPesquisarI";
            this.tsPesquisarI.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.tsPesquisarI.Size = new System.Drawing.Size(120, 26);
            this.tsPesquisarI.TextChanged += new System.EventHandler(this.tsPesquisar_TextChanged);
            // 
            // pESQUISARToolStripMenuItem
            // 
            this.pESQUISARToolStripMenuItem.Enabled = false;
            this.pESQUISARToolStripMenuItem.Name = "pESQUISARToolStripMenuItem";
            this.pESQUISARToolStripMenuItem.ShowShortcutKeys = false;
            this.pESQUISARToolStripMenuItem.Size = new System.Drawing.Size(79, 26);
            this.pESQUISARToolStripMenuItem.Text = "PESQUISAR";
            // 
            // listInfantil
            // 
            this.listInfantil.AutoArrange = false;
            this.listInfantil.BackColor = System.Drawing.Color.White;
            this.listInfantil.BackgroundImageTiled = true;
            this.listInfantil.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listInfantil.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.listInfantil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listInfantil.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.listInfantil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(83)))), ((int)(((byte)(103)))));
            this.listInfantil.FullRowSelect = true;
            this.listInfantil.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listInfantil.HideSelection = false;
            this.listInfantil.Location = new System.Drawing.Point(2, 2);
            this.listInfantil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listInfantil.MultiSelect = false;
            this.listInfantil.Name = "listInfantil";
            this.listInfantil.ShowGroups = false;
            this.listInfantil.ShowItemToolTips = true;
            this.listInfantil.Size = new System.Drawing.Size(1223, 422);
            this.listInfantil.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listInfantil.TabIndex = 7;
            this.listInfantil.TileSize = new System.Drawing.Size(350, 100);
            this.listInfantil.UseCompatibleStateImageBehavior = false;
            this.listInfantil.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listInfantil_MouseClick);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "ID";
            this.columnHeader9.Width = 0;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "NOME";
            this.columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "TAMANHO";
            this.columnHeader11.Width = 20;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "CATEGORIA";
            this.columnHeader12.Width = 80;
            // 
            // acessorios
            // 
            this.acessorios.Controls.Add(this.menuA);
            this.acessorios.Controls.Add(this.listAcessorios);
            this.acessorios.Location = new System.Drawing.Point(4, 44);
            this.acessorios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.acessorios.Name = "acessorios";
            this.acessorios.Size = new System.Drawing.Size(1227, 426);
            this.acessorios.TabIndex = 3;
            this.acessorios.Text = "ACESSÓRIOS";
            this.acessorios.UseVisualStyleBackColor = true;
            // 
            // menuA
            // 
            this.menuA.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolFecharA,
            this.tsPesquisarA,
            this.lblPesquisarA});
            this.menuA.Location = new System.Drawing.Point(0, 0);
            this.menuA.Name = "menuA";
            this.menuA.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuA.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuA.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuA.Size = new System.Drawing.Size(1227, 30);
            this.menuA.TabIndex = 8;
            this.menuA.Text = " ";
            // 
            // toolFecharA
            // 
            this.toolFecharA.Image = global::AluguelRoupasJuninas.Properties.Resources.fechar32E;
            this.toolFecharA.Name = "toolFecharA";
            this.toolFecharA.Size = new System.Drawing.Size(32, 26);
            this.toolFecharA.Text = " ";
            this.toolFecharA.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolFecharA.Click += new System.EventHandler(this.toolFecharA_Click);
            // 
            // tsPesquisarA
            // 
            this.tsPesquisarA.AutoSize = false;
            this.tsPesquisarA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tsPesquisarA.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsPesquisarA.MaxLength = 200;
            this.tsPesquisarA.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.tsPesquisarA.Name = "tsPesquisarA";
            this.tsPesquisarA.Size = new System.Drawing.Size(120, 26);
            this.tsPesquisarA.TextChanged += new System.EventHandler(this.tsPesquisar_TextChanged);
            // 
            // lblPesquisarA
            // 
            this.lblPesquisarA.Enabled = false;
            this.lblPesquisarA.Name = "lblPesquisarA";
            this.lblPesquisarA.ShowShortcutKeys = false;
            this.lblPesquisarA.Size = new System.Drawing.Size(79, 26);
            this.lblPesquisarA.Text = "PESQUISAR";
            // 
            // listAcessorios
            // 
            this.listAcessorios.AutoArrange = false;
            this.listAcessorios.BackColor = System.Drawing.Color.White;
            this.listAcessorios.BackgroundImageTiled = true;
            this.listAcessorios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listAcessorios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16});
            this.listAcessorios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listAcessorios.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.listAcessorios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(83)))), ((int)(((byte)(103)))));
            this.listAcessorios.FullRowSelect = true;
            this.listAcessorios.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listAcessorios.HideSelection = false;
            this.listAcessorios.Location = new System.Drawing.Point(0, 0);
            this.listAcessorios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listAcessorios.MultiSelect = false;
            this.listAcessorios.Name = "listAcessorios";
            this.listAcessorios.ShowGroups = false;
            this.listAcessorios.ShowItemToolTips = true;
            this.listAcessorios.Size = new System.Drawing.Size(1227, 426);
            this.listAcessorios.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listAcessorios.TabIndex = 7;
            this.listAcessorios.TileSize = new System.Drawing.Size(350, 100);
            this.listAcessorios.UseCompatibleStateImageBehavior = false;
            this.listAcessorios.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listAcessorios_MouseClick);
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "ID";
            this.columnHeader13.Width = 0;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "NOME";
            this.columnHeader14.Width = 100;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "TAMANHO";
            this.columnHeader15.Width = 20;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "CATEGORIA";
            this.columnHeader16.Width = 80;
            // 
            // menuAluguel
            // 
            this.menuAluguel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuAluguel.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuAluguel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolFecharAluguel,
            this.tsDataDevolucao,
            this.pESQUISARPORDATADEDEVOLUÇÃOToolStripMenuItem,
            this.tsDataRetirada,
            this.pESQUISARPORDATADERETIRADAToolStripMenuItem,
            this.tsPesquisarAluguel,
            this.lbPesquisarAluguel});
            this.menuAluguel.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuAluguel.Location = new System.Drawing.Point(0, 566);
            this.menuAluguel.Name = "menuAluguel";
            this.menuAluguel.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuAluguel.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuAluguel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuAluguel.Size = new System.Drawing.Size(1533, 27);
            this.menuAluguel.TabIndex = 9;
            this.menuAluguel.Text = " ";
            this.menuAluguel.Visible = false;
            // 
            // toolFecharAluguel
            // 
            this.toolFecharAluguel.AutoSize = false;
            this.toolFecharAluguel.Image = global::AluguelRoupasJuninas.Properties.Resources.fechar32E;
            this.toolFecharAluguel.Name = "toolFecharAluguel";
            this.toolFecharAluguel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolFecharAluguel.RightToLeftAutoMirrorImage = true;
            this.toolFecharAluguel.ShowShortcutKeys = false;
            this.toolFecharAluguel.Size = new System.Drawing.Size(34, 30);
            this.toolFecharAluguel.Text = " ";
            this.toolFecharAluguel.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolFecharAluguel.Click += new System.EventHandler(this.toolFecharAluguel_Click);
            // 
            // tsDataDevolucao
            // 
            this.tsDataDevolucao.AutoSize = false;
            this.tsDataDevolucao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tsDataDevolucao.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsDataDevolucao.MaxLength = 200;
            this.tsDataDevolucao.Name = "tsDataDevolucao";
            this.tsDataDevolucao.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.tsDataDevolucao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsDataDevolucao.Size = new System.Drawing.Size(120, 26);
            this.tsDataDevolucao.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tsDataDevolucao.Leave += new System.EventHandler(this.tsDataDevolucao_Leave);
            // 
            // pESQUISARPORDATADEDEVOLUÇÃOToolStripMenuItem
            // 
            this.pESQUISARPORDATADEDEVOLUÇÃOToolStripMenuItem.Enabled = false;
            this.pESQUISARPORDATADEDEVOLUÇÃOToolStripMenuItem.Name = "pESQUISARPORDATADEDEVOLUÇÃOToolStripMenuItem";
            this.pESQUISARPORDATADEDEVOLUÇÃOToolStripMenuItem.ShowShortcutKeys = false;
            this.pESQUISARPORDATADEDEVOLUÇÃOToolStripMenuItem.Size = new System.Drawing.Size(226, 23);
            this.pESQUISARPORDATADEDEVOLUÇÃOToolStripMenuItem.Text = "PESQUISAR POR DATA DE DEVOLUÇÃO";
            // 
            // tsDataRetirada
            // 
            this.tsDataRetirada.AutoSize = false;
            this.tsDataRetirada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tsDataRetirada.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsDataRetirada.MaxLength = 200;
            this.tsDataRetirada.Name = "tsDataRetirada";
            this.tsDataRetirada.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.tsDataRetirada.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsDataRetirada.Size = new System.Drawing.Size(120, 26);
            this.tsDataRetirada.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tsDataRetirada.Leave += new System.EventHandler(this.tsDataRetirada_Leave);
            // 
            // pESQUISARPORDATADERETIRADAToolStripMenuItem
            // 
            this.pESQUISARPORDATADERETIRADAToolStripMenuItem.Enabled = false;
            this.pESQUISARPORDATADERETIRADAToolStripMenuItem.Name = "pESQUISARPORDATADERETIRADAToolStripMenuItem";
            this.pESQUISARPORDATADERETIRADAToolStripMenuItem.ShowShortcutKeys = false;
            this.pESQUISARPORDATADERETIRADAToolStripMenuItem.Size = new System.Drawing.Size(211, 23);
            this.pESQUISARPORDATADERETIRADAToolStripMenuItem.Text = "PESQUISAR POR DATA DE RETIRADA";
            // 
            // tsPesquisarAluguel
            // 
            this.tsPesquisarAluguel.AutoSize = false;
            this.tsPesquisarAluguel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tsPesquisarAluguel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsPesquisarAluguel.MaxLength = 200;
            this.tsPesquisarAluguel.Name = "tsPesquisarAluguel";
            this.tsPesquisarAluguel.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.tsPesquisarAluguel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsPesquisarAluguel.Size = new System.Drawing.Size(120, 26);
            this.tsPesquisarAluguel.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tsPesquisarAluguel.Leave += new System.EventHandler(this.tsPesquisarAluguel_TextChanged);
            // 
            // lbPesquisarAluguel
            // 
            this.lbPesquisarAluguel.Enabled = false;
            this.lbPesquisarAluguel.Name = "lbPesquisarAluguel";
            this.lbPesquisarAluguel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPesquisarAluguel.ShowShortcutKeys = false;
            this.lbPesquisarAluguel.Size = new System.Drawing.Size(153, 23);
            this.lbPesquisarAluguel.Text = "PESQUISAR POR CLIENTE";
            // 
            // listViewAlugueis
            // 
            this.listViewAlugueis.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listViewAlugueis.AutoArrange = false;
            this.listViewAlugueis.BackColor = System.Drawing.Color.White;
            this.listViewAlugueis.BackgroundImageTiled = true;
            this.listViewAlugueis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewAlugueis.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idRoupa,
            this.nomeRoupa,
            this.cliente,
            this.dataRet,
            this.dataDev,
            this.valor,
            this.formaPag,
            this.devolucao});
            this.listViewAlugueis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewAlugueis.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewAlugueis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(123)))), ((int)(((byte)(143)))));
            this.listViewAlugueis.FullRowSelect = true;
            this.listViewAlugueis.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewAlugueis.HideSelection = false;
            this.listViewAlugueis.Location = new System.Drawing.Point(0, 0);
            this.listViewAlugueis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewAlugueis.MultiSelect = false;
            this.listViewAlugueis.Name = "listViewAlugueis";
            this.listViewAlugueis.OwnerDraw = true;
            this.listViewAlugueis.ShowGroups = false;
            this.listViewAlugueis.ShowItemToolTips = true;
            this.listViewAlugueis.Size = new System.Drawing.Size(1516, 505);
            this.listViewAlugueis.TabIndex = 8;
            this.listViewAlugueis.TileSize = new System.Drawing.Size(350, 100);
            this.listViewAlugueis.UseCompatibleStateImageBehavior = false;
            this.listViewAlugueis.View = System.Windows.Forms.View.Details;
            this.listViewAlugueis.Visible = false;
            // 
            // idRoupa
            // 
            this.idRoupa.Text = "Id Roupa";
            this.idRoupa.Width = 0;
            // 
            // nomeRoupa
            // 
            this.nomeRoupa.Text = "ROUPA";
            this.nomeRoupa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nomeRoupa.Width = 150;
            // 
            // cliente
            // 
            this.cliente.Text = "CLIENTE";
            this.cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cliente.Width = 560;
            // 
            // dataRet
            // 
            this.dataRet.Text = "DATA RETIRADA";
            this.dataRet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dataRet.Width = 200;
            // 
            // dataDev
            // 
            this.dataDev.Text = "DATA DEVOLUÇÃO";
            this.dataDev.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dataDev.Width = 200;
            // 
            // valor
            // 
            this.valor.Text = "VALOR";
            this.valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valor.Width = 150;
            // 
            // formaPag
            // 
            this.formaPag.Text = "FORMA DE PAGAMENTO";
            this.formaPag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.formaPag.Width = 272;
            // 
            // devolucao
            // 
            this.devolucao.Text = "DEVOLUÇÃO";
            this.devolucao.Width = 0;
            // 
            // FormPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1516, 699);
            this.Controls.Add(this.panelListView);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FormPrincipal_Activated);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.panelListView.ResumeLayout(false);
            this.panelListView.PerformLayout();
            this.tabRoupas.ResumeLayout(false);
            this.roupasFem.ResumeLayout(false);
            this.roupasFem.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.roupasMasc.ResumeLayout(false);
            this.roupasMasc.PerformLayout();
            this.menuM.ResumeLayout(false);
            this.menuM.PerformLayout();
            this.infantil.ResumeLayout(false);
            this.infantil.PerformLayout();
            this.menuI.ResumeLayout(false);
            this.menuI.PerformLayout();
            this.acessorios.ResumeLayout(false);
            this.acessorios.PerformLayout();
            this.menuA.ResumeLayout(false);
            this.menuA.PerformLayout();
            this.menuAluguel.ResumeLayout(false);
            this.menuAluguel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panelTitulo;
        private Button btnInicio;
        private Label lbTitulo;
        private Panel panelListView;
        private ListView listViewAlugueis;
        private ColumnHeader idRoupa;
        private ColumnHeader nomeRoupa;
        private ColumnHeader cliente;
        private ColumnHeader dataRet;
        private ColumnHeader dataDev;
        private ColumnHeader valor;
        private ColumnHeader formaPag;
        private ColumnHeader devolucao;
        private Panel panelButtons;
        private Button limparTabRoupas;
        private Label label6;
        private Button limparTabAluguel;
        private Label label2;
        private Button btnCaixa;
        private Label label1;
        private Button btnExibirAluguel;
        private Label label4;
        private Button btnExibirRoupa;
        private Label label5;
        private Button btnAdicionar;
        private TabControl tabRoupas;
        private TabPage roupasFem;
        private ListView listViewRoupas;
        private ColumnHeader id;
        private ColumnHeader nome;
        private ColumnHeader tamanho;
        private ColumnHeader categoria;
        private MenuStrip menu;
        private ToolStripTextBox tsPesquisar;
        private TabPage roupasMasc;
        private MenuStrip menuM;
        private ToolStripTextBox tsPesquisarM;
        private ListView listMasc;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private TabPage infantil;
        private MenuStrip menuI;
        private ToolStripTextBox tsPesquisarI;
        private ListView listInfantil;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private TabPage acessorios;
        private MenuStrip menuA;
        private ToolStripTextBox tsPesquisarA;
        private ListView listAcessorios;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
        private ToolStripMenuItem lblPesquisar;
        private ToolStripMenuItem toolFechar;
        private ToolStripMenuItem toolFecharA;
        private ToolStripMenuItem lblPesquisarA;
        private ToolStripMenuItem toolFecharM;
        private ToolStripMenuItem pESQUISARToolStripMenuItem1;
        private ToolStripMenuItem toolFecharI;
        private ToolStripMenuItem pESQUISARToolStripMenuItem;
        private MenuStrip menuAluguel;
        private ToolStripMenuItem toolFecharAluguel;
        private ToolStripTextBox tsPesquisarAluguel;
        private ToolStripMenuItem lbPesquisarAluguel;
        private ToolStripTextBox tsDataDevolucao;
        private ToolStripTextBox tsDataRetirada;
        private ToolStripMenuItem pESQUISARPORDATADERETIRADAToolStripMenuItem;
        private ToolStripMenuItem pESQUISARPORDATADEDEVOLUÇÃOToolStripMenuItem;
        private ToolStripPanel BottomToolStripPanel;
        private ToolStripPanel TopToolStripPanel;
        private ToolStripPanel RightToolStripPanel;
        private ToolStripPanel LeftToolStripPanel;
        private ToolStripContentPanel ContentPanel;
    }
}

