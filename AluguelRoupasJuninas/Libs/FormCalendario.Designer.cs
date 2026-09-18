using System.Drawing;
using System.Windows.Forms;

namespace AluguelRoupasJuninas
{
    partial class FormCalendario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalendario));
            this.panelBar = new System.Windows.Forms.Panel();
            this.btnCloseCalendario = new System.Windows.Forms.Button();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnProximoV = new System.Windows.Forms.Button();
            this.btnAnteriorV = new System.Windows.Forms.Button();
            this.btnAtenrior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.lblMesAno = new System.Windows.Forms.Label();
            this.panelCalendario = new System.Windows.Forms.Panel();
            this.calendario = new System.Windows.Forms.TableLayoutPanel();
            this.tabDiaSemana = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBar.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelCalendario.SuspendLayout();
            this.tabDiaSemana.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBar
            // 
            this.panelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(123)))), ((int)(((byte)(143)))));
            this.panelBar.Controls.Add(this.btnCloseCalendario);
            this.panelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBar.Location = new System.Drawing.Point(0, 0);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(1266, 30);
            this.panelBar.TabIndex = 4;
            // 
            // btnCloseCalendario
            // 
            this.btnCloseCalendario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCloseCalendario.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCloseCalendario.FlatAppearance.BorderSize = 0;
            this.btnCloseCalendario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.btnCloseCalendario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.btnCloseCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseCalendario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseCalendario.ForeColor = System.Drawing.Color.White;
            this.btnCloseCalendario.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseCalendario.Image")));
            this.btnCloseCalendario.Location = new System.Drawing.Point(1229, 0);
            this.btnCloseCalendario.Name = "btnCloseCalendario";
            this.btnCloseCalendario.Size = new System.Drawing.Size(37, 30);
            this.btnCloseCalendario.TabIndex = 0;
            this.btnCloseCalendario.UseVisualStyleBackColor = true;
            this.btnCloseCalendario.Click += new System.EventHandler(this.btnCloseCalendario_Click);
            this.btnCloseCalendario.MouseEnter += new System.EventHandler(this.btnCloseCalendario_MouseEnter);
            this.btnCloseCalendario.MouseLeave += new System.EventHandler(this.btnCloseCalendario_MouseLeave);
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.panelButtons.Controls.Add(this.btnProximoV);
            this.panelButtons.Controls.Add(this.btnAnteriorV);
            this.panelButtons.Controls.Add(this.btnAtenrior);
            this.panelButtons.Controls.Add(this.btnProximo);
            this.panelButtons.Controls.Add(this.lblMesAno);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 30);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(1266, 64);
            this.panelButtons.TabIndex = 5;
            // 
            // btnProximoV
            // 
            this.btnProximoV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.btnProximoV.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnProximoV.FlatAppearance.BorderSize = 0;
            this.btnProximoV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.btnProximoV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.btnProximoV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProximoV.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximoV.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnProximoV.Image = ((System.Drawing.Image)(resources.GetObject("btnProximoV.Image")));
            this.btnProximoV.Location = new System.Drawing.Point(1092, 0);
            this.btnProximoV.Margin = new System.Windows.Forms.Padding(0);
            this.btnProximoV.Name = "btnProximoV";
            this.btnProximoV.Size = new System.Drawing.Size(87, 64);
            this.btnProximoV.TabIndex = 8;
            this.btnProximoV.UseVisualStyleBackColor = false;
            this.btnProximoV.Visible = false;
            this.btnProximoV.Click += new System.EventHandler(this.btnProximoV_Click);
            this.btnProximoV.MouseEnter += new System.EventHandler(this.btnProximoV_MouseEnter);
            this.btnProximoV.MouseLeave += new System.EventHandler(this.btnProximoV_MouseLeave);
            // 
            // btnAnteriorV
            // 
            this.btnAnteriorV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.btnAnteriorV.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAnteriorV.FlatAppearance.BorderSize = 0;
            this.btnAnteriorV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.btnAnteriorV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.btnAnteriorV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnteriorV.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorV.Image = ((System.Drawing.Image)(resources.GetObject("btnAnteriorV.Image")));
            this.btnAnteriorV.Location = new System.Drawing.Point(85, 0);
            this.btnAnteriorV.Name = "btnAnteriorV";
            this.btnAnteriorV.Size = new System.Drawing.Size(85, 64);
            this.btnAnteriorV.TabIndex = 7;
            this.btnAnteriorV.UseVisualStyleBackColor = false;
            this.btnAnteriorV.Visible = false;
            this.btnAnteriorV.Click += new System.EventHandler(this.btnAnteriorV_Click);
            this.btnAnteriorV.MouseEnter += new System.EventHandler(this.btnAnteriorV_MouseEnter);
            this.btnAnteriorV.MouseLeave += new System.EventHandler(this.btnAnteriorV_MouseLeave);
            // 
            // btnAtenrior
            // 
            this.btnAtenrior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.btnAtenrior.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAtenrior.FlatAppearance.BorderSize = 0;
            this.btnAtenrior.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.btnAtenrior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.btnAtenrior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtenrior.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtenrior.Image = ((System.Drawing.Image)(resources.GetObject("btnAtenrior.Image")));
            this.btnAtenrior.Location = new System.Drawing.Point(0, 0);
            this.btnAtenrior.Name = "btnAtenrior";
            this.btnAtenrior.Size = new System.Drawing.Size(85, 64);
            this.btnAtenrior.TabIndex = 4;
            this.btnAtenrior.UseVisualStyleBackColor = false;
            this.btnAtenrior.Visible = false;
            this.btnAtenrior.Click += new System.EventHandler(this.btnAtenrior_Click);
            this.btnAtenrior.MouseEnter += new System.EventHandler(this.btnAtenrior_MouseEnter);
            this.btnAtenrior.MouseLeave += new System.EventHandler(this.btnAtenrior_MouseLeave);
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.btnProximo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnProximo.FlatAppearance.BorderSize = 0;
            this.btnProximo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.btnProximo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProximo.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnProximo.Image = ((System.Drawing.Image)(resources.GetObject("btnProximo.Image")));
            this.btnProximo.Location = new System.Drawing.Point(1179, 0);
            this.btnProximo.Margin = new System.Windows.Forms.Padding(0);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(87, 64);
            this.btnProximo.TabIndex = 6;
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Visible = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            this.btnProximo.MouseEnter += new System.EventHandler(this.btnProximo_MouseEnter);
            this.btnProximo.MouseLeave += new System.EventHandler(this.btnProximo_MouseLeave);
            // 
            // lblMesAno
            // 
            this.lblMesAno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.lblMesAno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMesAno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMesAno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesAno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(123)))), ((int)(((byte)(143)))));
            this.lblMesAno.Location = new System.Drawing.Point(0, 0);
            this.lblMesAno.Name = "lblMesAno";
            this.lblMesAno.Size = new System.Drawing.Size(1266, 64);
            this.lblMesAno.TabIndex = 5;
            this.lblMesAno.Text = "MÊS";
            this.lblMesAno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelCalendario
            // 
            this.panelCalendario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.panelCalendario.Controls.Add(this.calendario);
            this.panelCalendario.Controls.Add(this.tabDiaSemana);
            this.panelCalendario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCalendario.Location = new System.Drawing.Point(0, 94);
            this.panelCalendario.Name = "panelCalendario";
            this.panelCalendario.Size = new System.Drawing.Size(1266, 912);
            this.panelCalendario.TabIndex = 6;
            // 
            // calendario
            // 
            this.calendario.AutoSize = true;
            this.calendario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.calendario.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.calendario.ColumnCount = 7;
            this.calendario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.calendario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.calendario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.calendario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.calendario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.calendario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.calendario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.calendario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendario.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calendario.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.calendario.Location = new System.Drawing.Point(0, 35);
            this.calendario.Name = "calendario";
            this.calendario.RowCount = 6;
            this.calendario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.calendario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.calendario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.calendario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.calendario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.calendario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.calendario.Size = new System.Drawing.Size(1266, 877);
            this.calendario.TabIndex = 2;
            // 
            // tabDiaSemana
            // 
            this.tabDiaSemana.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabDiaSemana.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tabDiaSemana.ColumnCount = 7;
            this.tabDiaSemana.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tabDiaSemana.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tabDiaSemana.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tabDiaSemana.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tabDiaSemana.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tabDiaSemana.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tabDiaSemana.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tabDiaSemana.Controls.Add(this.label7, 6, 0);
            this.tabDiaSemana.Controls.Add(this.label6, 5, 0);
            this.tabDiaSemana.Controls.Add(this.label5, 4, 0);
            this.tabDiaSemana.Controls.Add(this.label4, 3, 0);
            this.tabDiaSemana.Controls.Add(this.label3, 2, 0);
            this.tabDiaSemana.Controls.Add(this.label2, 1, 0);
            this.tabDiaSemana.Controls.Add(this.label1, 0, 0);
            this.tabDiaSemana.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabDiaSemana.Location = new System.Drawing.Point(0, 0);
            this.tabDiaSemana.Name = "tabDiaSemana";
            this.tabDiaSemana.RowCount = 1;
            this.tabDiaSemana.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabDiaSemana.Size = new System.Drawing.Size(1266, 35);
            this.tabDiaSemana.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Red;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(1081, 1);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 33);
            this.label7.TabIndex = 6;
            this.label7.Text = "DOMINGO";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(123)))), ((int)(((byte)(143)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(901, 1);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 33);
            this.label6.TabIndex = 5;
            this.label6.Text = "SÁBADO";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(123)))), ((int)(((byte)(143)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(721, 1);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "SEXTA";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(123)))), ((int)(((byte)(143)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(541, 1);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "QUINTA";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(123)))), ((int)(((byte)(143)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(361, 1);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "QUARTA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(123)))), ((int)(((byte)(143)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(181, 1);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "TERÇA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(123)))), ((int)(((byte)(143)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "SEGUNDA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(1266, 1006);
            this.ControlBox = false;
            this.Controls.Add(this.panelCalendario);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCalendario";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.panelBar.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.panelCalendario.ResumeLayout(false);
            this.panelCalendario.PerformLayout();
            this.tabDiaSemana.ResumeLayout(false);
            this.tabDiaSemana.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panelBar;
        private Panel panelButtons;
        private Button btnAtenrior;
        private Button btnProximo;
        private Label lblMesAno;
        private Panel panelCalendario;
        private TableLayoutPanel tabDiaSemana;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TableLayoutPanel calendario;
        private Button btnProximoV;
        private Button btnAnteriorV;
        private Button btnCloseCalendario;
    }
}