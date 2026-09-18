namespace AluguelRoupasJuninas
{
    partial class FormAdicionar
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.panelBar = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTamanho = new System.Windows.Forms.ListBox();
            this.btnSalvarEdit = new System.Windows.Forms.Button();
            this.btnSelecionarImagem = new System.Windows.Forms.Button();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panelBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(358, 86);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(220, 28);
            this.txtNome.TabIndex = 9;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNome.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(354, 59);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(66, 24);
            this.lblNome.TabIndex = 11;
            this.lblNome.Text = "Roupa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(354, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tamanho";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Acessório",
            "Infantil"});
            this.cbxCategoria.Location = new System.Drawing.Point(358, 306);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(220, 29);
            this.cbxCategoria.TabIndex = 13;
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCategoria.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoria.ForeColor = System.Drawing.Color.White;
            this.lbCategoria.Location = new System.Drawing.Point(354, 279);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(96, 24);
            this.lbCategoria.TabIndex = 14;
            this.lbCategoria.Text = "Categoria";
            // 
            // panelBar
            // 
            this.panelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.panelBar.Controls.Add(this.lblTitulo);
            this.panelBar.Controls.Add(this.btnFechar);
            this.panelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBar.Location = new System.Drawing.Point(0, 0);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(598, 35);
            this.panelBar.TabIndex = 15;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(123)))), ((int)(((byte)(143)))));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.lblTitulo.Size = new System.Drawing.Size(554, 35);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "ADICIONAR ROUPA";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = global::AluguelRoupasJuninas.Properties.Resources.fechar32;
            this.btnFechar.Location = new System.Drawing.Point(554, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(44, 35);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            this.btnFechar.MouseEnter += new System.EventHandler(this.btnFechar_MouseEnter);
            this.btnFechar.MouseLeave += new System.EventHandler(this.btnFechar_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Imagem";
            // 
            // cbxTamanho
            // 
            this.cbxTamanho.FormattingEnabled = true;
            this.cbxTamanho.ItemHeight = 16;
            this.cbxTamanho.Items.AddRange(new object[] {
            "P",
            "M",
            "G",
            "GG",
            "EG"});
            this.cbxTamanho.Location = new System.Drawing.Point(358, 165);
            this.cbxTamanho.Name = "cbxTamanho";
            this.cbxTamanho.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.cbxTamanho.Size = new System.Drawing.Size(220, 84);
            this.cbxTamanho.TabIndex = 19;
            // 
            // btnSalvarEdit
            // 
            this.btnSalvarEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarEdit.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarEdit.ForeColor = System.Drawing.Color.White;
            this.btnSalvarEdit.Image = global::AluguelRoupasJuninas.Properties.Resources.editar_texto;
            this.btnSalvarEdit.Location = new System.Drawing.Point(358, 374);
            this.btnSalvarEdit.Name = "btnSalvarEdit";
            this.btnSalvarEdit.Size = new System.Drawing.Size(220, 66);
            this.btnSalvarEdit.TabIndex = 18;
            this.btnSalvarEdit.Text = "   EDITAR";
            this.btnSalvarEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvarEdit.UseVisualStyleBackColor = true;
            this.btnSalvarEdit.Visible = false;
            this.btnSalvarEdit.Click += new System.EventHandler(this.btnSalvarEdit_Click);
            // 
            // btnSelecionarImagem
            // 
            this.btnSelecionarImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarImagem.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarImagem.ForeColor = System.Drawing.Color.White;
            this.btnSelecionarImagem.Image = global::AluguelRoupasJuninas.Properties.Resources.galeria_de_fotos;
            this.btnSelecionarImagem.Location = new System.Drawing.Point(22, 374);
            this.btnSelecionarImagem.Name = "btnSelecionarImagem";
            this.btnSelecionarImagem.Size = new System.Drawing.Size(311, 66);
            this.btnSelecionarImagem.TabIndex = 7;
            this.btnSelecionarImagem.Text = "   SELECIONAR IMAGEM";
            this.btnSelecionarImagem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelecionarImagem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelecionarImagem.UseVisualStyleBackColor = true;
            this.btnSelecionarImagem.Click += new System.EventHandler(this.btnSelecionarImagem_Click);
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.pictureBoxImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxImage.InitialImage = null;
            this.pictureBoxImage.Location = new System.Drawing.Point(22, 86);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(311, 250);
            this.pictureBoxImage.TabIndex = 6;
            this.pictureBoxImage.TabStop = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Image = global::AluguelRoupasJuninas.Properties.Resources.verificar;
            this.btnSalvar.Location = new System.Drawing.Point(358, 374);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(220, 66);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "   SALVAR";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FormAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(123)))), ((int)(((byte)(143)))));
            this.ClientSize = new System.Drawing.Size(598, 469);
            this.ControlBox = false;
            this.Controls.Add(this.cbxTamanho);
            this.Controls.Add(this.btnSalvarEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelBar);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnSelecionarImagem);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormAdicionar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnSelecionarImagem;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSalvarEdit;
        public System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.ListBox cbxTamanho;
    }
}