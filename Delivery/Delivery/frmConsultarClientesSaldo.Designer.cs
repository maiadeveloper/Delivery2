namespace Delivery
{
    partial class frmConsultarClientesSaldo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarClientesSaldo));
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.rbDecrescente = new System.Windows.Forms.RadioButton();
            this.rbCrescente = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtTotalGeral = new System.Windows.Forms.TextBox();
            this.txtQtdeItem = new System.Windows.Forms.TextBox();
            this.btnMensagem = new System.Windows.Forms.Button();
            this.txtParametroBusca = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lwClientesSaldos = new System.Windows.Forms.ListView();
            this.colunaId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaCPF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaSaldo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pPrincipal
            // 
            this.pPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pPrincipal.Controls.Add(this.btnGerarRelatorio);
            this.pPrincipal.Controls.Add(this.btnCancelar);
            this.pPrincipal.Controls.Add(this.panel1);
            this.pPrincipal.Controls.Add(this.label1);
            this.pPrincipal.Controls.Add(this.pictureBox1);
            this.pPrincipal.Location = new System.Drawing.Point(5, 11);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(1002, 510);
            this.pPrincipal.TabIndex = 1;
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGerarRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGerarRelatorio.CausesValidation = false;
            this.btnGerarRelatorio.Enabled = false;
            this.btnGerarRelatorio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarRelatorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGerarRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btnGerarRelatorio.Image")));
            this.btnGerarRelatorio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGerarRelatorio.Location = new System.Drawing.Point(690, 437);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(130, 60);
            this.btnGerarRelatorio.TabIndex = 66;
            this.btnGerarRelatorio.Text = "Gerar relatório";
            this.btnGerarRelatorio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGerarRelatorio.UseVisualStyleBackColor = true;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(836, 437);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 60);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rbDecrescente);
            this.panel1.Controls.Add(this.rbCrescente);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.txtTotalGeral);
            this.panel1.Controls.Add(this.txtQtdeItem);
            this.panel1.Controls.Add(this.btnMensagem);
            this.panel1.Controls.Add(this.txtParametroBusca);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lwClientesSaldos);
            this.panel1.Location = new System.Drawing.Point(12, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 385);
            this.panel1.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(38)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(530, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 18);
            this.label2.TabIndex = 60;
            this.label2.Text = "Exibir saldo em orderm:";
            // 
            // rbDecrescente
            // 
            this.rbDecrescente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbDecrescente.AutoSize = true;
            this.rbDecrescente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(38)))));
            this.rbDecrescente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDecrescente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbDecrescente.Location = new System.Drawing.Point(823, 22);
            this.rbDecrescente.Name = "rbDecrescente";
            this.rbDecrescente.Size = new System.Drawing.Size(110, 23);
            this.rbDecrescente.TabIndex = 59;
            this.rbDecrescente.TabStop = true;
            this.rbDecrescente.Text = "Decrescente";
            this.rbDecrescente.UseVisualStyleBackColor = false;
            // 
            // rbCrescente
            // 
            this.rbCrescente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbCrescente.AutoSize = true;
            this.rbCrescente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(38)))));
            this.rbCrescente.Checked = true;
            this.rbCrescente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCrescente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbCrescente.Location = new System.Drawing.Point(723, 22);
            this.rbCrescente.Name = "rbCrescente";
            this.rbCrescente.Size = new System.Drawing.Size(93, 23);
            this.rbCrescente.TabIndex = 58;
            this.rbCrescente.TabStop = true;
            this.rbCrescente.Text = "Crescente";
            this.rbCrescente.UseVisualStyleBackColor = false;
            this.rbCrescente.CheckedChanged += new System.EventHandler(this.rbCrescente_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(131)))), ((int)(((byte)(61)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(714, 352);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(128, 25);
            this.textBox1.TabIndex = 57;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "TOTAL GERAL";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalGeral
            // 
            this.txtTotalGeral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalGeral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(38)))));
            this.txtTotalGeral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalGeral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalGeral.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalGeral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotalGeral.Location = new System.Drawing.Point(843, 352);
            this.txtTotalGeral.Name = "txtTotalGeral";
            this.txtTotalGeral.ReadOnly = true;
            this.txtTotalGeral.Size = new System.Drawing.Size(97, 25);
            this.txtTotalGeral.TabIndex = 56;
            this.txtTotalGeral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtQtdeItem
            // 
            this.txtQtdeItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtQtdeItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(38)))));
            this.txtQtdeItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdeItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQtdeItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdeItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQtdeItem.Location = new System.Drawing.Point(16, 350);
            this.txtQtdeItem.Name = "txtQtdeItem";
            this.txtQtdeItem.ReadOnly = true;
            this.txtQtdeItem.Size = new System.Drawing.Size(64, 29);
            this.txtQtdeItem.TabIndex = 55;
            this.txtQtdeItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMensagem
            // 
            this.btnMensagem.BackColor = System.Drawing.Color.Transparent;
            this.btnMensagem.Enabled = false;
            this.btnMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMensagem.Image = ((System.Drawing.Image)(resources.GetObject("btnMensagem.Image")));
            this.btnMensagem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMensagem.Location = new System.Drawing.Point(225, 192);
            this.btnMensagem.Name = "btnMensagem";
            this.btnMensagem.Size = new System.Drawing.Size(537, 45);
            this.btnMensagem.TabIndex = 37;
            this.btnMensagem.Text = "    Desculpe !  Não foi encontrado nenhum resultado para esta busca.";
            this.btnMensagem.UseVisualStyleBackColor = false;
            // 
            // txtParametroBusca
            // 
            this.txtParametroBusca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParametroBusca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtParametroBusca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParametroBusca.Location = new System.Drawing.Point(57, 16);
            this.txtParametroBusca.Name = "txtParametroBusca";
            this.txtParametroBusca.Size = new System.Drawing.Size(466, 29);
            this.txtParametroBusca.TabIndex = 36;
            this.txtParametroBusca.TextChanged += new System.EventHandler(this.txtParametroBusca_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(38)))));
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(38)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(16, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 37);
            this.button1.TabIndex = 35;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(197)))), ((int)(((byte)(38)))));
            this.pictureBox2.Location = new System.Drawing.Point(15, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(940, 42);
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lwClientesSaldos
            // 
            this.lwClientesSaldos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwClientesSaldos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lwClientesSaldos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colunaId,
            this.colunaNome,
            this.colunaCPF,
            this.colunaSaldo});
            this.lwClientesSaldos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwClientesSaldos.FullRowSelect = true;
            this.lwClientesSaldos.GridLines = true;
            this.lwClientesSaldos.Location = new System.Drawing.Point(16, 66);
            this.lwClientesSaldos.Name = "lwClientesSaldos";
            this.lwClientesSaldos.Size = new System.Drawing.Size(939, 281);
            this.lwClientesSaldos.TabIndex = 33;
            this.lwClientesSaldos.UseCompatibleStateImageBehavior = false;
            this.lwClientesSaldos.View = System.Windows.Forms.View.Details;
            // 
            // colunaId
            // 
            this.colunaId.Text = "Cód.";
            this.colunaId.Width = 55;
            // 
            // colunaNome
            // 
            this.colunaNome.Text = "Nome cliente";
            this.colunaNome.Width = 450;
            // 
            // colunaCPF
            // 
            this.colunaCPF.Text = "Documento";
            this.colunaCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colunaCPF.Width = 200;
            // 
            // colunaSaldo
            // 
            this.colunaSaldo.Text = "Saldo";
            this.colunaSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colunaSaldo.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(131)))), ((int)(((byte)(61)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Listagem de clientes com saldo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(131)))), ((int)(((byte)(61)))));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1035, 31);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // frmConsultarClientesSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1010, 522);
            this.Controls.Add(this.pPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmConsultarClientesSaldo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar clientes com saldos";
            this.Load += new System.EventHandler(this.frmConsultarClientesSaldo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmConsultarClientesSaldo_KeyDown);
            this.pPrincipal.ResumeLayout(false);
            this.pPrincipal.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pPrincipal;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtQtdeItem;
        private System.Windows.Forms.Button btnMensagem;
        private System.Windows.Forms.TextBox txtParametroBusca;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListView lwClientesSaldos;
        private System.Windows.Forms.ColumnHeader colunaId;
        private System.Windows.Forms.ColumnHeader colunaNome;
        private System.Windows.Forms.ColumnHeader colunaCPF;
        private System.Windows.Forms.ColumnHeader colunaSaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtTotalGeral;
        private System.Windows.Forms.Button btnGerarRelatorio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbDecrescente;
        private System.Windows.Forms.RadioButton rbCrescente;
    }
}