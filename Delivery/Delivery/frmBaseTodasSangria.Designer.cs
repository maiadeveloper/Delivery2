namespace Delivery
{
    partial class frmBaseTodasSangria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaseTodasSangria));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDataFinal = new System.Windows.Forms.DateTimePicker();
            this.txtDataInicial = new System.Windows.Forms.DateTimePicker();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtParametroBusca = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMensagem = new System.Windows.Forms.Button();
            this.lwSangrias = new System.Windows.Forms.ListView();
            this.colunaId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaDescricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaParcela = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaVlor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctmenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cancelarPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtQtdeItem = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtTotalGeral = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.ctmenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "Sangria - Retirada de caixa";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox1.Location = new System.Drawing.Point(11, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(953, 31);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFiltrar.CausesValidation = false;
            this.btnFiltrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnFiltrar.Location = new System.Drawing.Point(777, 16);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(99, 29);
            this.btnFiltrar.TabIndex = 64;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(392, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 21);
            this.label3.TabIndex = 63;
            this.label3.Text = "Período de:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Highlight;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(622, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 21);
            this.label4.TabIndex = 62;
            this.label4.Text = "a";
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataFinal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataFinal.Location = new System.Drawing.Point(641, 16);
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Size = new System.Drawing.Size(130, 29);
            this.txtDataFinal.TabIndex = 61;
            // 
            // txtDataInicial
            // 
            this.txtDataInicial.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataInicial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataInicial.Location = new System.Drawing.Point(490, 15);
            this.txtDataInicial.Name = "txtDataInicial";
            this.txtDataInicial.Size = new System.Drawing.Size(130, 29);
            this.txtDataInicial.TabIndex = 60;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox3.Location = new System.Drawing.Point(7, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(938, 42);
            this.pictureBox3.TabIndex = 59;
            this.pictureBox3.TabStop = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 0;
            this.columnHeader1.Text = "Descrição";
            this.columnHeader1.Width = 400;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 1;
            this.columnHeader2.Text = "JAN";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 2;
            this.columnHeader3.Text = "FEV";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 3;
            this.columnHeader4.Text = "MARC";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 80;
            // 
            // columnHeader13
            // 
            this.columnHeader13.DisplayIndex = 4;
            this.columnHeader13.Text = "TOTAL ACUMULADO AO ANO";
            this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader13.Width = 250;
            // 
            // columnHeader14
            // 
            this.columnHeader14.DisplayIndex = 5;
            this.columnHeader14.Text = "MÉDIA MENSAL";
            this.columnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader14.Width = 150;
            // 
            // txtParametroBusca
            // 
            this.txtParametroBusca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParametroBusca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtParametroBusca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParametroBusca.Location = new System.Drawing.Point(52, 15);
            this.txtParametroBusca.Name = "txtParametroBusca";
            this.txtParametroBusca.Size = new System.Drawing.Size(334, 29);
            this.txtParametroBusca.TabIndex = 66;
            this.txtParametroBusca.TextChanged += new System.EventHandler(this.txtParametroBusca_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(11, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 37);
            this.button1.TabIndex = 65;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnMensagem);
            this.panel1.Controls.Add(this.txtParametroBusca);
            this.panel1.Controls.Add(this.lwSangrias);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnFiltrar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtDataFinal);
            this.panel1.Controls.Add(this.txtQtdeItem);
            this.panel1.Controls.Add(this.txtDataInicial);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.txtTotalGeral);
            this.panel1.Location = new System.Drawing.Point(8, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 391);
            this.panel1.TabIndex = 67;
            // 
            // btnMensagem
            // 
            this.btnMensagem.BackColor = System.Drawing.Color.Transparent;
            this.btnMensagem.Enabled = false;
            this.btnMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMensagem.Image = ((System.Drawing.Image)(resources.GetObject("btnMensagem.Image")));
            this.btnMensagem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMensagem.Location = new System.Drawing.Point(192, 182);
            this.btnMensagem.Name = "btnMensagem";
            this.btnMensagem.Size = new System.Drawing.Size(537, 45);
            this.btnMensagem.TabIndex = 87;
            this.btnMensagem.Text = "    Desculpe !  Não foi encontrado nenhum resultado para este período. Favor info" +
    "rmar um período válido!";
            this.btnMensagem.UseVisualStyleBackColor = false;
            this.btnMensagem.Visible = false;
            // 
            // lwSangrias
            // 
            this.lwSangrias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwSangrias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lwSangrias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colunaId,
            this.colunaDescricao,
            this.colunaParcela,
            this.colunaVlor});
            this.lwSangrias.ContextMenuStrip = this.ctmenuStrip;
            this.lwSangrias.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwSangrias.FullRowSelect = true;
            this.lwSangrias.GridLines = true;
            this.lwSangrias.Location = new System.Drawing.Point(6, 57);
            this.lwSangrias.Name = "lwSangrias";
            this.lwSangrias.Size = new System.Drawing.Size(939, 293);
            this.lwSangrias.TabIndex = 84;
            this.lwSangrias.UseCompatibleStateImageBehavior = false;
            this.lwSangrias.View = System.Windows.Forms.View.Details;
            // 
            // colunaId
            // 
            this.colunaId.Text = "ID";
            this.colunaId.Width = 55;
            // 
            // colunaDescricao
            // 
            this.colunaDescricao.Text = "Descrição";
            this.colunaDescricao.Width = 450;
            // 
            // colunaParcela
            // 
            this.colunaParcela.Text = "Data";
            this.colunaParcela.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colunaParcela.Width = 120;
            // 
            // colunaVlor
            // 
            this.colunaVlor.Text = "Valor";
            this.colunaVlor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colunaVlor.Width = 120;
            // 
            // ctmenuStrip
            // 
            this.ctmenuStrip.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelarPedidoToolStripMenuItem});
            this.ctmenuStrip.Name = "ctmenuStrip";
            this.ctmenuStrip.Size = new System.Drawing.Size(174, 28);
            // 
            // cancelarPedidoToolStripMenuItem
            // 
            this.cancelarPedidoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cancelarPedidoToolStripMenuItem.Image")));
            this.cancelarPedidoToolStripMenuItem.Name = "cancelarPedidoToolStripMenuItem";
            this.cancelarPedidoToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.cancelarPedidoToolStripMenuItem.Text = "Excluir sangria";
            this.cancelarPedidoToolStripMenuItem.Click += new System.EventHandler(this.cancelarPedidoToolStripMenuItem_Click);
            // 
            // txtQtdeItem
            // 
            this.txtQtdeItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtQtdeItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.txtQtdeItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdeItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQtdeItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdeItem.ForeColor = System.Drawing.Color.White;
            this.txtQtdeItem.Location = new System.Drawing.Point(7, 356);
            this.txtQtdeItem.Name = "txtQtdeItem";
            this.txtQtdeItem.ReadOnly = true;
            this.txtQtdeItem.Size = new System.Drawing.Size(64, 25);
            this.txtQtdeItem.TabIndex = 54;
            this.txtQtdeItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(502, 356);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(128, 25);
            this.textBox1.TabIndex = 53;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "TOTAL GERAL";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalGeral
            // 
            this.txtTotalGeral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalGeral.BackColor = System.Drawing.SystemColors.Highlight;
            this.txtTotalGeral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalGeral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalGeral.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalGeral.ForeColor = System.Drawing.Color.White;
            this.txtTotalGeral.Location = new System.Drawing.Point(631, 356);
            this.txtTotalGeral.Name = "txtTotalGeral";
            this.txtTotalGeral.ReadOnly = true;
            this.txtTotalGeral.Size = new System.Drawing.Size(121, 25);
            this.txtTotalGeral.TabIndex = 52;
            this.txtTotalGeral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNovo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovo.Location = new System.Drawing.Point(642, 433);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(166, 60);
            this.btnNovo.TabIndex = 69;
            this.btnNovo.Text = "Adicionar novo lançamento";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(814, 433);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 60);
            this.btnCancelar.TabIndex = 68;
            this.btnCancelar.Text = "Cancelar (Esc)";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmBaseTodasSangria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(976, 502);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmBaseTodasSangria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sangria - Retirada de caixa";
            this.Load += new System.EventHandler(this.frmBaseMovimentacaoGeral_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBaseTodasSangria_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ctmenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtDataFinal;
        private System.Windows.Forms.DateTimePicker txtDataInicial;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.TextBox txtParametroBusca;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMensagem;
        private System.Windows.Forms.ListView lwSangrias;
        private System.Windows.Forms.ColumnHeader colunaId;
        private System.Windows.Forms.ColumnHeader colunaParcela;
        private System.Windows.Forms.ColumnHeader colunaVlor;
        private System.Windows.Forms.ColumnHeader colunaDescricao;
        private System.Windows.Forms.TextBox txtQtdeItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtTotalGeral;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ContextMenuStrip ctmenuStrip;
        private System.Windows.Forms.ToolStripMenuItem cancelarPedidoToolStripMenuItem;
    }
}