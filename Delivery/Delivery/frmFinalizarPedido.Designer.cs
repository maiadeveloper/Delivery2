namespace Delivery
{
    partial class frmFinalizarPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinalizarPedido));
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.btnAplicarTaxa = new System.Windows.Forms.Button();
            this.btnAplicarDesconto = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtSituacaoPedido = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTaxaEntrega = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPagando = new System.Windows.Forms.TextBox();
            this.lblCredito = new System.Windows.Forms.Label();
            this.txtTotalPedido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxFormaPagamento = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pcBoxFechar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // pPrincipal
            // 
            this.pPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pPrincipal.Controls.Add(this.btnAplicarTaxa);
            this.pPrincipal.Controls.Add(this.btnAplicarDesconto);
            this.pPrincipal.Controls.Add(this.btnCancelar);
            this.pPrincipal.Controls.Add(this.btnSalvar);
            this.pPrincipal.Controls.Add(this.panel1);
            this.pPrincipal.Location = new System.Drawing.Point(1, 58);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(901, 562);
            this.pPrincipal.TabIndex = 0;
            // 
            // btnAplicarTaxa
            // 
            this.btnAplicarTaxa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAplicarTaxa.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicarTaxa.Image = ((System.Drawing.Image)(resources.GetObject("btnAplicarTaxa.Image")));
            this.btnAplicarTaxa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAplicarTaxa.Location = new System.Drawing.Point(317, 491);
            this.btnAplicarTaxa.Name = "btnAplicarTaxa";
            this.btnAplicarTaxa.Size = new System.Drawing.Size(128, 60);
            this.btnAplicarTaxa.TabIndex = 39;
            this.btnAplicarTaxa.TabStop = false;
            this.btnAplicarTaxa.Text = "Taxa  Entrega (F9)";
            this.btnAplicarTaxa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAplicarTaxa.UseVisualStyleBackColor = true;
            this.btnAplicarTaxa.Click += new System.EventHandler(this.btnAplicarTaxa_Click);
            // 
            // btnAplicarDesconto
            // 
            this.btnAplicarDesconto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAplicarDesconto.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicarDesconto.Image = ((System.Drawing.Image)(resources.GetObject("btnAplicarDesconto.Image")));
            this.btnAplicarDesconto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAplicarDesconto.Location = new System.Drawing.Point(183, 491);
            this.btnAplicarDesconto.Name = "btnAplicarDesconto";
            this.btnAplicarDesconto.Size = new System.Drawing.Size(128, 60);
            this.btnAplicarDesconto.TabIndex = 38;
            this.btnAplicarDesconto.TabStop = false;
            this.btnAplicarDesconto.Text = "Aplicar Desconto (F8)";
            this.btnAplicarDesconto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAplicarDesconto.UseVisualStyleBackColor = true;
            this.btnAplicarDesconto.Click += new System.EventHandler(this.btnAplicarDesconto_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(585, 491);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(128, 60);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "Cancelar (ESC)";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(451, 491);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(128, 60);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar e Finalizar (F4)";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(9, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 464);
            this.panel1.TabIndex = 35;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtSituacaoPedido);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox5.Location = new System.Drawing.Point(392, 366);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(475, 84);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Situação pedido";
            // 
            // txtSituacaoPedido
            // 
            this.txtSituacaoPedido.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSituacaoPedido.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtSituacaoPedido.Enabled = false;
            this.txtSituacaoPedido.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSituacaoPedido.FormattingEnabled = true;
            this.txtSituacaoPedido.Items.AddRange(new object[] {
            "Selecionar...",
            "pago",
            "não pago"});
            this.txtSituacaoPedido.Location = new System.Drawing.Point(14, 24);
            this.txtSituacaoPedido.Name = "txtSituacaoPedido";
            this.txtSituacaoPedido.Size = new System.Drawing.Size(448, 48);
            this.txtSituacaoPedido.TabIndex = 5;
            this.txtSituacaoPedido.Text = "Selecionar...";
            this.txtSituacaoPedido.SelectedIndexChanged += new System.EventHandler(this.txtSituacaoPedido_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDesconto);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtTotalPagar);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtTaxaEntrega);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtTroco);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtPagando);
            this.groupBox3.Controls.Add(this.lblCredito);
            this.groupBox3.Controls.Add(this.txtTotalPedido);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox3.Location = new System.Drawing.Point(392, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(475, 359);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Valores ($)";
            // 
            // txtDesconto
            // 
            this.txtDesconto.BackColor = System.Drawing.Color.White;
            this.txtDesconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesconto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDesconto.Enabled = false;
            this.txtDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesconto.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtDesconto.Location = new System.Drawing.Point(251, 140);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(211, 44);
            this.txtDesconto.TabIndex = 42;
            this.txtDesconto.TabStop = false;
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDesconto.Enter += new System.EventHandler(this.txtDesconto_Enter);
            this.txtDesconto.Leave += new System.EventHandler(this.txtDesconto_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 33);
            this.label2.TabIndex = 43;
            this.label2.Text = "Desconto:";
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.BackColor = System.Drawing.Color.White;
            this.txtTotalPagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalPagar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPagar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtTotalPagar.Location = new System.Drawing.Point(251, 223);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.ReadOnly = true;
            this.txtTotalPagar.Size = new System.Drawing.Size(211, 44);
            this.txtTotalPagar.TabIndex = 39;
            this.txtTotalPagar.TabStop = false;
            this.txtTotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(244, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 33);
            this.label7.TabIndex = 38;
            this.label7.Text = "Total a Pagar:";
            // 
            // txtTaxaEntrega
            // 
            this.txtTaxaEntrega.BackColor = System.Drawing.Color.White;
            this.txtTaxaEntrega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaxaEntrega.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTaxaEntrega.Enabled = false;
            this.txtTaxaEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxaEntrega.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtTaxaEntrega.Location = new System.Drawing.Point(251, 57);
            this.txtTaxaEntrega.Name = "txtTaxaEntrega";
            this.txtTaxaEntrega.Size = new System.Drawing.Size(211, 44);
            this.txtTaxaEntrega.TabIndex = 1;
            this.txtTaxaEntrega.TabStop = false;
            this.txtTaxaEntrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTaxaEntrega.Enter += new System.EventHandler(this.txtTaxaEntrega_Enter);
            this.txtTaxaEntrega.Leave += new System.EventHandler(this.txtTaxaEntrega_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(244, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 33);
            this.label6.TabIndex = 37;
            this.label6.Text = "Taxa Entrega:";
            // 
            // txtTroco
            // 
            this.txtTroco.BackColor = System.Drawing.Color.White;
            this.txtTroco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTroco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTroco.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtTroco.Location = new System.Drawing.Point(251, 304);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.ReadOnly = true;
            this.txtTroco.Size = new System.Drawing.Size(211, 44);
            this.txtTroco.TabIndex = 36;
            this.txtTroco.TabStop = false;
            this.txtTroco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(244, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 33);
            this.label5.TabIndex = 35;
            this.label5.Text = "Troco:";
            // 
            // txtPagando
            // 
            this.txtPagando.BackColor = System.Drawing.Color.White;
            this.txtPagando.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPagando.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPagando.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagando.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPagando.Location = new System.Drawing.Point(14, 305);
            this.txtPagando.Name = "txtPagando";
            this.txtPagando.Size = new System.Drawing.Size(212, 44);
            this.txtPagando.TabIndex = 2;
            this.txtPagando.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPagando.Enter += new System.EventHandler(this.txtPagando_Enter);
            this.txtPagando.Leave += new System.EventHandler(this.txtPagando_Leave);
            // 
            // lblCredito
            // 
            this.lblCredito.AutoSize = true;
            this.lblCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredito.Location = new System.Drawing.Point(16, 268);
            this.lblCredito.Name = "lblCredito";
            this.lblCredito.Size = new System.Drawing.Size(138, 33);
            this.lblCredito.TabIndex = 33;
            this.lblCredito.Text = "Pagando:";
            // 
            // txtTotalPedido
            // 
            this.txtTotalPedido.BackColor = System.Drawing.Color.White;
            this.txtTotalPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPedido.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtTotalPedido.Location = new System.Drawing.Point(14, 57);
            this.txtTotalPedido.Name = "txtTotalPedido";
            this.txtTotalPedido.ReadOnly = true;
            this.txtTotalPedido.Size = new System.Drawing.Size(212, 44);
            this.txtTotalPedido.TabIndex = 32;
            this.txtTotalPedido.TabStop = false;
            this.txtTotalPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 33);
            this.label3.TabIndex = 31;
            this.label3.Text = "Total Pedido:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxFormaPagamento);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(10, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 444);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Forma Pagamento";
            // 
            // listBoxFormaPagamento
            // 
            this.listBoxFormaPagamento.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFormaPagamento.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listBoxFormaPagamento.FormattingEnabled = true;
            this.listBoxFormaPagamento.ItemHeight = 32;
            this.listBoxFormaPagamento.Location = new System.Drawing.Point(14, 25);
            this.listBoxFormaPagamento.Name = "listBoxFormaPagamento";
            this.listBoxFormaPagamento.Size = new System.Drawing.Size(347, 388);
            this.listBoxFormaPagamento.TabIndex = 0;
            this.listBoxFormaPagamento.Enter += new System.EventHandler(this.listBoxFormaPagamento_Enter);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pcBoxFechar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(903, 50);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(5, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 36);
            this.pictureBox3.TabIndex = 96;
            this.pictureBox3.TabStop = false;
            // 
            // pcBoxFechar
            // 
            this.pcBoxFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcBoxFechar.BackgroundImage")));
            this.pcBoxFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcBoxFechar.Location = new System.Drawing.Point(858, 6);
            this.pcBoxFechar.Name = "pcBoxFechar";
            this.pcBoxFechar.Size = new System.Drawing.Size(40, 38);
            this.pcBoxFechar.TabIndex = 28;
            this.pcBoxFechar.TabStop = false;
            this.pcBoxFechar.Click += new System.EventHandler(this.pcBoxFechar_Click);
            this.pcBoxFechar.MouseLeave += new System.EventHandler(this.pcBoxFechar_MouseLeave);
            this.pcBoxFechar.MouseHover += new System.EventHandler(this.pcBoxFechar_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 32);
            this.label1.TabIndex = 27;
            this.label1.Text = "Finalizar Pagamento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmFinalizarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(903, 621);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmFinalizarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finalizar pedido";
            this.Load += new System.EventHandler(this.frmFinalizarPedido_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFinalizarPedido_KeyDown);
            this.pPrincipal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxFechar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pPrincipal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTaxaEntrega;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPagando;
        private System.Windows.Forms.Label lblCredito;
        private System.Windows.Forms.TextBox txtTotalPedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxFormaPagamento;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAplicarDesconto;
        private System.Windows.Forms.Button btnAplicarTaxa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pcBoxFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox txtSituacaoPedido;
    }
}