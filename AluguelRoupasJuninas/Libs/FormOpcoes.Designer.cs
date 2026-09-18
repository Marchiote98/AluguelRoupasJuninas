namespace AluguelRoupasJuninas
{
    partial class FormOpcoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOpcoes));
            this.panelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnReservar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panelInformacoes = new System.Windows.Forms.Panel();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnCalendario = new System.Windows.Forms.Button();
            this.btnRemoverAluguel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewAluguel = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataRetirada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataDevolucao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idRoupa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.formaPagamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.devoucao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.pictureBoxRoupa = new System.Windows.Forms.PictureBox();
            this.notifyDevolucao = new System.Windows.Forms.NotifyIcon(this.components);
            this.panelTop.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelInformacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoupa)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(83)))), ((int)(((byte)(103)))));
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(1, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(0, 0, 56, 0);
            this.panelTop.Size = new System.Drawing.Size(1415, 70);
            this.panelTop.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Consolas", 26.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1303, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "INFORMAÇÕES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(83)))), ((int)(((byte)(103)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(83)))), ((int)(((byte)(103)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::AluguelRoupasJuninas.Properties.Resources.voltar;
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 70);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(83)))), ((int)(((byte)(103)))));
            this.panelButtons.Controls.Add(this.label11);
            this.panelButtons.Controls.Add(this.label7);
            this.panelButtons.Controls.Add(this.btnRemover);
            this.panelButtons.Controls.Add(this.label8);
            this.panelButtons.Controls.Add(this.btnEditar);
            this.panelButtons.Controls.Add(this.label6);
            this.panelButtons.Controls.Add(this.btnReservar);
            this.panelButtons.Controls.Add(this.label5);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(1, 484);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Padding = new System.Windows.Forms.Padding(350, 15, 0, 15);
            this.panelButtons.Size = new System.Drawing.Size(1415, 98);
            this.panelButtons.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(83)))), ((int)(((byte)(103)))));
            this.label11.Dock = System.Windows.Forms.DockStyle.Left;
            this.label11.Location = new System.Drawing.Point(1099, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 68);
            this.label11.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(83)))), ((int)(((byte)(103)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.Location = new System.Drawing.Point(1079, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 68);
            this.label7.TabIndex = 32;
            // 
            // btnRemover
            // 
            this.btnRemover.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Image = global::AluguelRoupasJuninas.Properties.Resources.excluir;
            this.btnRemover.Location = new System.Drawing.Point(856, 15);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(223, 68);
            this.btnRemover.TabIndex = 24;
            this.btnRemover.Text = "   REMOVER ROUPA";
            this.btnRemover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(83)))), ((int)(((byte)(103)))));
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Location = new System.Drawing.Point(836, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 68);
            this.label8.TabIndex = 33;
            // 
            // btnEditar
            // 
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Image = global::AluguelRoupasJuninas.Properties.Resources.editar_texto;
            this.btnEditar.Location = new System.Drawing.Point(613, 15);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(223, 68);
            this.btnEditar.TabIndex = 25;
            this.btnEditar.Text = "   EDITAR ROUPA";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(83)))), ((int)(((byte)(103)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Location = new System.Drawing.Point(593, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 68);
            this.label6.TabIndex = 31;
            // 
            // btnReservar
            // 
            this.btnReservar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservar.ForeColor = System.Drawing.Color.White;
            this.btnReservar.Image = global::AluguelRoupasJuninas.Properties.Resources.reserva;
            this.btnReservar.Location = new System.Drawing.Point(370, 15);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(223, 68);
            this.btnReservar.TabIndex = 26;
            this.btnReservar.Text = "   RESERVAR ROUPA ";
            this.btnReservar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReservar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnAlugar_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(83)))), ((int)(((byte)(103)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Location = new System.Drawing.Point(350, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 68);
            this.label5.TabIndex = 30;
            // 
            // panelInformacoes
            // 
            this.panelInformacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.panelInformacoes.Controls.Add(this.btnVerificar);
            this.panelInformacoes.Controls.Add(this.btnCalendario);
            this.panelInformacoes.Controls.Add(this.btnRemoverAluguel);
            this.panelInformacoes.Controls.Add(this.label4);
            this.panelInformacoes.Controls.Add(this.label3);
            this.panelInformacoes.Controls.Add(this.label2);
            this.panelInformacoes.Controls.Add(this.listViewAluguel);
            this.panelInformacoes.Controls.Add(this.lblNome);
            this.panelInformacoes.Controls.Add(this.lblTamanho);
            this.panelInformacoes.Controls.Add(this.lblCategoria);
            this.panelInformacoes.Controls.Add(this.pictureBoxRoupa);
            this.panelInformacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInformacoes.Location = new System.Drawing.Point(1, 70);
            this.panelInformacoes.Name = "panelInformacoes";
            this.panelInformacoes.Size = new System.Drawing.Size(1415, 414);
            this.panelInformacoes.TabIndex = 26;
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(123)))), ((int)(((byte)(143)))));
            this.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificar.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.btnVerificar.ForeColor = System.Drawing.Color.White;
            this.btnVerificar.Image = global::AluguelRoupasJuninas.Properties.Resources.verificar;
            this.btnVerificar.Location = new System.Drawing.Point(1172, 19);
            this.btnVerificar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(188, 105);
            this.btnVerificar.TabIndex = 38;
            this.btnVerificar.Text = "MARCAR COMO DEVOLVIDA";
            this.btnVerificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVerificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnCalendario
            // 
            this.btnCalendario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(123)))), ((int)(((byte)(143)))));
            this.btnCalendario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendario.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.btnCalendario.ForeColor = System.Drawing.Color.White;
            this.btnCalendario.Image = global::AluguelRoupasJuninas.Properties.Resources.calendario;
            this.btnCalendario.Location = new System.Drawing.Point(1172, 147);
            this.btnCalendario.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnCalendario.Name = "btnCalendario";
            this.btnCalendario.Size = new System.Drawing.Size(188, 105);
            this.btnCalendario.TabIndex = 37;
            this.btnCalendario.Text = "CALENDARIO";
            this.btnCalendario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCalendario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCalendario.UseVisualStyleBackColor = false;
            this.btnCalendario.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRemoverAluguel
            // 
            this.btnRemoverAluguel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(123)))), ((int)(((byte)(143)))));
            this.btnRemoverAluguel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRemoverAluguel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverAluguel.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.btnRemoverAluguel.ForeColor = System.Drawing.Color.White;
            this.btnRemoverAluguel.Image = global::AluguelRoupasJuninas.Properties.Resources.borracha;
            this.btnRemoverAluguel.Location = new System.Drawing.Point(1172, 276);
            this.btnRemoverAluguel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnRemoverAluguel.Name = "btnRemoverAluguel";
            this.btnRemoverAluguel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnRemoverAluguel.Size = new System.Drawing.Size(188, 105);
            this.btnRemoverAluguel.TabIndex = 10;
            this.btnRemoverAluguel.Text = "REMOVER ALUGUEL";
            this.btnRemoverAluguel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRemoverAluguel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRemoverAluguel.UseVisualStyleBackColor = false;
            this.btnRemoverAluguel.Click += new System.EventHandler(this.btnRemoverAluguel_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(123)))), ((int)(((byte)(143)))));
            this.label4.Location = new System.Drawing.Point(18, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Tamanho:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(123)))), ((int)(((byte)(143)))));
            this.label3.Location = new System.Drawing.Point(18, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Categoria:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(123)))), ((int)(((byte)(143)))));
            this.label2.Location = new System.Drawing.Point(18, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Código:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewAluguel
            // 
            this.listViewAluguel.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listViewAluguel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.listViewAluguel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.dataRetirada,
            this.dataDevolucao,
            this.idRoupa,
            this.cliente,
            this.valor,
            this.formaPagamento,
            this.devoucao});
            this.listViewAluguel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewAluguel.ForeColor = System.Drawing.Color.Black;
            this.listViewAluguel.FullRowSelect = true;
            this.listViewAluguel.GridLines = true;
            this.listViewAluguel.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewAluguel.HideSelection = false;
            this.listViewAluguel.Location = new System.Drawing.Point(343, 19);
            this.listViewAluguel.MultiSelect = false;
            this.listViewAluguel.Name = "listViewAluguel";
            this.listViewAluguel.ShowGroups = false;
            this.listViewAluguel.Size = new System.Drawing.Size(774, 366);
            this.listViewAluguel.TabIndex = 23;
            this.listViewAluguel.UseCompatibleStateImageBehavior = false;
            this.listViewAluguel.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 0;
            // 
            // dataRetirada
            // 
            this.dataRetirada.Text = "Data Retirada";
            this.dataRetirada.Width = 180;
            // 
            // dataDevolucao
            // 
            this.dataDevolucao.Text = "Data Devolução";
            this.dataDevolucao.Width = 180;
            // 
            // idRoupa
            // 
            this.idRoupa.Text = "ID Roupa";
            this.idRoupa.Width = 0;
            // 
            // cliente
            // 
            this.cliente.Text = "Cliente";
            this.cliente.Width = 350;
            // 
            // valor
            // 
            this.valor.Text = "Valor";
            this.valor.Width = 0;
            // 
            // formaPagamento
            // 
            this.formaPagamento.Text = "Forma de Pagamento";
            this.formaPagamento.Width = 0;
            // 
            // devoucao
            // 
            this.devoucao.Text = "Devolução";
            this.devoucao.Width = 0;
            // 
            // lblNome
            // 
            this.lblNome.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(123)))), ((int)(((byte)(143)))));
            this.lblNome.Location = new System.Drawing.Point(171, 289);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(138, 25);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Código";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTamanho
            // 
            this.lblTamanho.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamanho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(123)))), ((int)(((byte)(143)))));
            this.lblTamanho.Location = new System.Drawing.Point(171, 324);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(139, 25);
            this.lblTamanho.TabIndex = 3;
            this.lblTamanho.Text = "Tamanho";
            this.lblTamanho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCategoria
            // 
            this.lblCategoria.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(123)))), ((int)(((byte)(143)))));
            this.lblCategoria.Location = new System.Drawing.Point(171, 358);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(139, 25);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoria";
            this.lblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxRoupa
            // 
            this.pictureBoxRoupa.BackColor = System.Drawing.Color.White;
            this.pictureBoxRoupa.Location = new System.Drawing.Point(23, 19);
            this.pictureBoxRoupa.Name = "pictureBoxRoupa";
            this.pictureBoxRoupa.Size = new System.Drawing.Size(287, 250);
            this.pictureBoxRoupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRoupa.TabIndex = 0;
            this.pictureBoxRoupa.TabStop = false;
            // 
            // notifyDevolucao
            // 
            this.notifyDevolucao.Text = "notifyIcon1";
            this.notifyDevolucao.Visible = true;
            // 
            // FormOpcoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1417, 582);
            this.ControlBox = false;
            this.Controls.Add(this.panelInformacoes);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOpcoes";
            this.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.FormOpcoes_Activated);
            this.Load += new System.EventHandler(this.FormOpcoes_Load);
            this.panelTop.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.panelInformacoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoupa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Panel panelInformacoes;
        private System.Windows.Forms.ListView listViewAluguel;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader dataRetirada;
        private System.Windows.Forms.ColumnHeader dataDevolucao;
        private System.Windows.Forms.ColumnHeader idRoupa;
        private System.Windows.Forms.ColumnHeader cliente;
        private System.Windows.Forms.Button btnRemoverAluguel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCalendario;
        public System.Windows.Forms.Label lblNome;
        public System.Windows.Forms.Label lblTamanho;
        public System.Windows.Forms.Label lblCategoria;
        public System.Windows.Forms.PictureBox pictureBoxRoupa;
        private System.Windows.Forms.ColumnHeader valor;
        private System.Windows.Forms.ColumnHeader formaPagamento;
        private System.Windows.Forms.NotifyIcon notifyDevolucao;
        private System.Windows.Forms.ColumnHeader devoucao;
        private System.Windows.Forms.Button btnVerificar;
    }
}