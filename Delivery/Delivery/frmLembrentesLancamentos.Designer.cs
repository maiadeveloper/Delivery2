namespace Delivery
{
    partial class frmLembrentesLancamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLembrentesLancamentos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnTodosLançamentos = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtTotalGeral = new System.Windows.Forms.TextBox();
            this.listViewLancamentos = new System.Windows.Forms.ListView();
            this.colunaId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaFavorecido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaDescricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaDataVcto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaVlor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaDiasAVencer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtQtdeItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.txtQtde);
            this.panel1.Controls.Add(this.txtTotalGeral);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.btnTodosLançamentos);
            this.panel1.Controls.Add(this.btnAtualizar);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtQtdeItem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 433);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox3.Location = new System.Drawing.Point(13, 346);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(227, 80);
            this.groupBox3.TabIndex = 96;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informações";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 21);
            this.label14.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(111, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 56);
            this.button1.TabIndex = 93;
            this.button1.TabStop = false;
            this.button1.Text = "Dias vencido";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(24, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 56);
            this.button2.TabIndex = 94;
            this.button2.TabStop = false;
            this.button2.Text = "Dias a vencer";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnTodosLançamentos
            // 
            this.btnTodosLançamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTodosLançamentos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTodosLançamentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTodosLançamentos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodosLançamentos.Image = ((System.Drawing.Image)(resources.GetObject("btnTodosLançamentos.Image")));
            this.btnTodosLançamentos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTodosLançamentos.Location = new System.Drawing.Point(477, 366);
            this.btnTodosLançamentos.Name = "btnTodosLançamentos";
            this.btnTodosLançamentos.Size = new System.Drawing.Size(150, 60);
            this.btnTodosLançamentos.TabIndex = 95;
            this.btnTodosLançamentos.Text = "Todos lançamentos";
            this.btnTodosLançamentos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTodosLançamentos.UseVisualStyleBackColor = false;
            this.btnTodosLançamentos.Click += new System.EventHandler(this.btnTodosLançamentos_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtualizar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAtualizar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAtualizar.Location = new System.Drawing.Point(633, 366);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(150, 60);
            this.btnAtualizar.TabIndex = 92;
            this.btnAtualizar.Text = "Atualizar (F5)";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(13, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 22);
            this.pictureBox2.TabIndex = 91;
            this.pictureBox2.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(789, 366);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 60);
            this.btnCancelar.TabIndex = 90;
            this.btnCancelar.Text = "Cancelar (Esc)";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.listViewLancamentos);
            this.panel2.Location = new System.Drawing.Point(10, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(923, 270);
            this.panel2.TabIndex = 89;
            // 
            // txtQtde
            // 
            this.txtQtde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtQtde.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtQtde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtde.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQtde.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQtde.Location = new System.Drawing.Point(13, 326);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.ReadOnly = true;
            this.txtQtde.Size = new System.Drawing.Size(42, 25);
            this.txtQtde.TabIndex = 93;
            this.txtQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(725, 326);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(106, 25);
            this.textBox1.TabIndex = 92;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "TOTAL GERAL";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalGeral
            // 
            this.txtTotalGeral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalGeral.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTotalGeral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalGeral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalGeral.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalGeral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotalGeral.Location = new System.Drawing.Point(840, 325);
            this.txtTotalGeral.Name = "txtTotalGeral";
            this.txtTotalGeral.ReadOnly = true;
            this.txtTotalGeral.Size = new System.Drawing.Size(92, 25);
            this.txtTotalGeral.TabIndex = 91;
            this.txtTotalGeral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // listViewLancamentos
            // 
            this.listViewLancamentos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewLancamentos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colunaId,
            this.colunaFavorecido,
            this.colunaDescricao,
            this.colunaDataVcto,
            this.colunaVlor,
            this.colunaDiasAVencer});
            this.listViewLancamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewLancamentos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewLancamentos.FullRowSelect = true;
            this.listViewLancamentos.GridLines = true;
            this.listViewLancamentos.Location = new System.Drawing.Point(0, 0);
            this.listViewLancamentos.Name = "listViewLancamentos";
            this.listViewLancamentos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listViewLancamentos.Size = new System.Drawing.Size(921, 268);
            this.listViewLancamentos.TabIndex = 90;
            this.listViewLancamentos.UseCompatibleStateImageBehavior = false;
            this.listViewLancamentos.View = System.Windows.Forms.View.Details;
            // 
            // colunaId
            // 
            this.colunaId.Text = "Cod";
            this.colunaId.Width = 40;
            // 
            // colunaFavorecido
            // 
            this.colunaFavorecido.Text = "Favorecido";
            this.colunaFavorecido.Width = 250;
            // 
            // colunaDescricao
            // 
            this.colunaDescricao.Text = "Descrição";
            this.colunaDescricao.Width = 250;
            // 
            // colunaDataVcto
            // 
            this.colunaDataVcto.Text = "Data Vcto";
            this.colunaDataVcto.Width = 200;
            // 
            // colunaVlor
            // 
            this.colunaVlor.Text = "Valor";
            this.colunaVlor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colunaVlor.Width = 90;
            // 
            // colunaDiasAVencer
            // 
            this.colunaDiasAVencer.Text = "Dia(s)";
            this.colunaDiasAVencer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colunaDiasAVencer.Width = 55;
            // 
            // txtQtdeItem
            // 
            this.txtQtdeItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtQtdeItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(38)))));
            this.txtQtdeItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdeItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQtdeItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdeItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQtdeItem.Location = new System.Drawing.Point(-175, 374);
            this.txtQtdeItem.Name = "txtQtdeItem";
            this.txtQtdeItem.ReadOnly = true;
            this.txtQtdeItem.Size = new System.Drawing.Size(64, 25);
            this.txtQtdeItem.TabIndex = 88;
            this.txtQtdeItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "Lembretes de contas a pagar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox1.Location = new System.Drawing.Point(10, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(923, 31);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // frmLembrentesLancamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(952, 443);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmLembrentesLancamentos";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lembretes de contas a pagar";
            this.Load += new System.EventHandler(this.frmLembrentesLancamentos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLembrentesLancamentos_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtQtdeItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtTotalGeral;
        private System.Windows.Forms.ListView listViewLancamentos;
        private System.Windows.Forms.ColumnHeader colunaId;
        private System.Windows.Forms.ColumnHeader colunaDataVcto;
        private System.Windows.Forms.ColumnHeader colunaVlor;
        private System.Windows.Forms.ColumnHeader colunaDescricao;
        private System.Windows.Forms.ColumnHeader colunaFavorecido;
        private System.Windows.Forms.ColumnHeader colunaDiasAVencer;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTodosLançamentos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label14;
    }
}