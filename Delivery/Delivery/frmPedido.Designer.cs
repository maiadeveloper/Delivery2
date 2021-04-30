namespace Delivery
{
    partial class frmPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedido));
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtFuncionarioEntregador = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtQtdeItem = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtTotalSubtotal = new System.Windows.Forms.TextBox();
            this.btnIncluirProduto = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrecoUnit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigoBarra = new System.Windows.Forms.TextBox();
            this.lwItensPedido = new System.Windows.Forms.ListView();
            this.colunaCodBarra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaDescricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaPreco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaQtde = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctmenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctmenuItemExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.la = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHoraPedido = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDataVenda = new System.Windows.Forms.DateTimePicker();
            this.txtNumeroPedido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.btnAplicarDesconto = new System.Windows.Forms.Button();
            this.btnFinalizarPedido = new System.Windows.Forms.Button();
            this.btnPesquisarCliente = new System.Windows.Forms.Button();
            this.btnPesquisarProduto = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pcBoxFechar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pPrincipal.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.ctmenuStrip.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // pPrincipal
            // 
            this.pPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pPrincipal.Controls.Add(this.groupBox4);
            this.pPrincipal.Controls.Add(this.groupBox3);
            this.pPrincipal.Controls.Add(this.groupBox2);
            this.pPrincipal.Controls.Add(this.groupBox1);
            this.pPrincipal.Controls.Add(this.btnAplicarDesconto);
            this.pPrincipal.Controls.Add(this.btnFinalizarPedido);
            this.pPrincipal.Controls.Add(this.btnPesquisarCliente);
            this.pPrincipal.Controls.Add(this.btnPesquisarProduto);
            this.pPrincipal.Controls.Add(this.btnCancelar);
            this.pPrincipal.Location = new System.Drawing.Point(1, 62);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(1124, 594);
            this.pPrincipal.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtFuncionarioEntregador);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox4.Location = new System.Drawing.Point(387, 9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(702, 94);
            this.groupBox4.TabIndex = 47;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Entregador";
            // 
            // txtFuncionarioEntregador
            // 
            this.txtFuncionarioEntregador.FormattingEnabled = true;
            this.txtFuncionarioEntregador.Location = new System.Drawing.Point(12, 52);
            this.txtFuncionarioEntregador.Name = "txtFuncionarioEntregador";
            this.txtFuncionarioEntregador.Size = new System.Drawing.Size(679, 29);
            this.txtFuncionarioEntregador.TabIndex = 1;
            this.txtFuncionarioEntregador.Text = "Selecione...";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 21);
            this.label11.TabIndex = 31;
            this.label11.Text = "Nome:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtQtdeItem);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.txtTotalSubtotal);
            this.groupBox3.Controls.Add(this.btnIncluirProduto);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtSubtotal);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtQtde);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtPrecoUnit);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtDescricaoProduto);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtCodigoBarra);
            this.groupBox3.Controls.Add(this.lwItensPedido);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox3.Location = new System.Drawing.Point(12, 208);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1077, 295);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Itens do pedido";
            // 
            // txtQtdeItem
            // 
            this.txtQtdeItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtQtdeItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdeItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQtdeItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdeItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQtdeItem.Location = new System.Drawing.Point(14, 255);
            this.txtQtdeItem.Name = "txtQtdeItem";
            this.txtQtdeItem.ReadOnly = true;
            this.txtQtdeItem.Size = new System.Drawing.Size(59, 29);
            this.txtQtdeItem.TabIndex = 55;
            this.txtQtdeItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(813, 255);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(128, 29);
            this.textBox1.TabIndex = 51;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "TOTAL A PAGAR:";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalSubtotal
            // 
            this.txtTotalSubtotal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTotalSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalSubtotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalSubtotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotalSubtotal.Location = new System.Drawing.Point(947, 255);
            this.txtTotalSubtotal.Name = "txtTotalSubtotal";
            this.txtTotalSubtotal.ReadOnly = true;
            this.txtTotalSubtotal.Size = new System.Drawing.Size(119, 29);
            this.txtTotalSubtotal.TabIndex = 50;
            this.txtTotalSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnIncluirProduto
            // 
            this.btnIncluirProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIncluirProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluirProduto.Image")));
            this.btnIncluirProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluirProduto.Location = new System.Drawing.Point(945, 50);
            this.btnIncluirProduto.Name = "btnIncluirProduto";
            this.btnIncluirProduto.Size = new System.Drawing.Size(121, 32);
            this.btnIncluirProduto.TabIndex = 40;
            this.btnIncluirProduto.Text = "Incluir ";
            this.btnIncluirProduto.UseVisualStyleBackColor = true;
            this.btnIncluirProduto.Click += new System.EventHandler(this.btnIncluirProduto_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(838, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 21);
            this.label10.TabIndex = 47;
            this.label10.Text = "SubTotal:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubtotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSubtotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(839, 52);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 29);
            this.txtSubtotal.TabIndex = 48;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(732, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 21);
            this.label9.TabIndex = 45;
            this.label9.Text = "Qtde:";
            // 
            // txtQtde
            // 
            this.txtQtde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtde.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQtde.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtde.Location = new System.Drawing.Point(733, 52);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(100, 29);
            this.txtQtde.TabIndex = 3;
            this.txtQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(630, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 21);
            this.label8.TabIndex = 43;
            this.label8.Text = "Preço Unit:";
            // 
            // txtPrecoUnit
            // 
            this.txtPrecoUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecoUnit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrecoUnit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoUnit.Location = new System.Drawing.Point(630, 52);
            this.txtPrecoUnit.Name = "txtPrecoUnit";
            this.txtPrecoUnit.ReadOnly = true;
            this.txtPrecoUnit.Size = new System.Drawing.Size(98, 29);
            this.txtPrecoUnit.TabIndex = 44;
            this.txtPrecoUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecoUnit.Enter += new System.EventHandler(this.txtPrecoUnit_Enter_1);
            this.txtPrecoUnit.Leave += new System.EventHandler(this.txtPrecoUnit_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(214, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 21);
            this.label7.TabIndex = 41;
            this.label7.Text = "Descrição produto:";
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricaoProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricaoProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoProduto.Location = new System.Drawing.Point(218, 52);
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.ReadOnly = true;
            this.txtDescricaoProduto.Size = new System.Drawing.Size(406, 29);
            this.txtDescricaoProduto.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 21);
            this.label6.TabIndex = 40;
            this.label6.Text = "Código barra:";
            // 
            // txtCodigoBarra
            // 
            this.txtCodigoBarra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoBarra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoBarra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoBarra.Location = new System.Drawing.Point(11, 52);
            this.txtCodigoBarra.Name = "txtCodigoBarra";
            this.txtCodigoBarra.Size = new System.Drawing.Size(201, 29);
            this.txtCodigoBarra.TabIndex = 2;
            // 
            // lwItensPedido
            // 
            this.lwItensPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwItensPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lwItensPedido.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colunaCodBarra,
            this.colunaDescricao,
            this.colunaPreco,
            this.colunaQtde,
            this.colunaTotal});
            this.lwItensPedido.ContextMenuStrip = this.ctmenuStrip;
            this.lwItensPedido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwItensPedido.FullRowSelect = true;
            this.lwItensPedido.GridLines = true;
            this.lwItensPedido.HideSelection = false;
            this.lwItensPedido.Location = new System.Drawing.Point(11, 88);
            this.lwItensPedido.Name = "lwItensPedido";
            this.lwItensPedido.Size = new System.Drawing.Size(1055, 161);
            this.lwItensPedido.TabIndex = 34;
            this.lwItensPedido.UseCompatibleStateImageBehavior = false;
            this.lwItensPedido.View = System.Windows.Forms.View.Details;
            this.lwItensPedido.SelectedIndexChanged += new System.EventHandler(this.lwItensPedido_SelectedIndexChanged_1);
            // 
            // colunaCodBarra
            // 
            this.colunaCodBarra.Text = "Cód.";
            // 
            // colunaDescricao
            // 
            this.colunaDescricao.Text = "Descrição produto";
            this.colunaDescricao.Width = 665;
            // 
            // colunaPreco
            // 
            this.colunaPreco.Text = "Preço Unit.";
            this.colunaPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colunaPreco.Width = 100;
            // 
            // colunaQtde
            // 
            this.colunaQtde.Text = "Qtde.";
            this.colunaQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colunaQtde.Width = 100;
            // 
            // colunaTotal
            // 
            this.colunaTotal.Text = "SubTotal";
            this.colunaTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colunaTotal.Width = 100;
            // 
            // ctmenuStrip
            // 
            this.ctmenuStrip.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctmenuItemExcluir});
            this.ctmenuStrip.Name = "ctmenuStrip";
            this.ctmenuStrip.Size = new System.Drawing.Size(156, 28);
            // 
            // ctmenuItemExcluir
            // 
            this.ctmenuItemExcluir.Image = ((System.Drawing.Image)(resources.GetObject("ctmenuItemExcluir.Image")));
            this.ctmenuItemExcluir.Name = "ctmenuItemExcluir";
            this.ctmenuItemExcluir.Size = new System.Drawing.Size(155, 24);
            this.ctmenuItemExcluir.Text = "Excluir Item";
            this.ctmenuItemExcluir.Click += new System.EventHandler(this.ctmenuItemExcluir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtCelular);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtNomeCliente);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtCPF);
            this.groupBox2.Controls.Add(this.la);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1077, 94);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações do cliente";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(11, 51);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(81, 29);
            this.txtCodigo.TabIndex = 40;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 21);
            this.label5.TabIndex = 39;
            this.label5.Text = "Código:";
            // 
            // txtCelular
            // 
            this.txtCelular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCelular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCelular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(842, 51);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.ReadOnly = true;
            this.txtCelular.Size = new System.Drawing.Size(224, 29);
            this.txtCelular.TabIndex = 38;
            this.txtCelular.TabStop = false;
            this.txtCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(838, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 21);
            this.label4.TabIndex = 37;
            this.label4.Text = "Celular:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(98, 51);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(526, 29);
            this.txtNomeCliente.TabIndex = 36;
            this.txtNomeCliente.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nome cliente:";
            // 
            // txtCPF
            // 
            this.txtCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCPF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCPF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(630, 51);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.ReadOnly = true;
            this.txtCPF.Size = new System.Drawing.Size(203, 29);
            this.txtCPF.TabIndex = 34;
            this.txtCPF.TabStop = false;
            this.txtCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // la
            // 
            this.la.AutoSize = true;
            this.la.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la.Location = new System.Drawing.Point(631, 27);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(94, 21);
            this.la.TabIndex = 32;
            this.la.Text = "Documento:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHoraPedido);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtDataVenda);
            this.groupBox1.Controls.Add(this.txtNumeroPedido);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 94);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do pedido";
            // 
            // txtHoraPedido
            // 
            this.txtHoraPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHoraPedido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraPedido.Location = new System.Drawing.Point(162, 51);
            this.txtHoraPedido.Name = "txtHoraPedido";
            this.txtHoraPedido.ReadOnly = true;
            this.txtHoraPedido.Size = new System.Drawing.Size(91, 29);
            this.txtHoraPedido.TabIndex = 21;
            this.txtHoraPedido.TabStop = false;
            this.txtHoraPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(158, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 21);
            this.label12.TabIndex = 20;
            this.label12.Text = "Hora:";
            // 
            // txtDataVenda
            // 
            this.txtDataVenda.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataVenda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataVenda.Location = new System.Drawing.Point(11, 51);
            this.txtDataVenda.Name = "txtDataVenda";
            this.txtDataVenda.Size = new System.Drawing.Size(144, 29);
            this.txtDataVenda.TabIndex = 0;
            // 
            // txtNumeroPedido
            // 
            this.txtNumeroPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroPedido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroPedido.Location = new System.Drawing.Point(261, 51);
            this.txtNumeroPedido.Name = "txtNumeroPedido";
            this.txtNumeroPedido.ReadOnly = true;
            this.txtNumeroPedido.Size = new System.Drawing.Size(91, 29);
            this.txtNumeroPedido.TabIndex = 19;
            this.txtNumeroPedido.TabStop = false;
            this.txtNumeroPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(257, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nº Pedido:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(7, 28);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(119, 21);
            this.label24.TabIndex = 2;
            this.label24.Text = "Data do pedido:";
            // 
            // btnAplicarDesconto
            // 
            this.btnAplicarDesconto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAplicarDesconto.Enabled = false;
            this.btnAplicarDesconto.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicarDesconto.Image = ((System.Drawing.Image)(resources.GetObject("btnAplicarDesconto.Image")));
            this.btnAplicarDesconto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAplicarDesconto.Location = new System.Drawing.Point(633, 517);
            this.btnAplicarDesconto.Name = "btnAplicarDesconto";
            this.btnAplicarDesconto.Size = new System.Drawing.Size(156, 60);
            this.btnAplicarDesconto.TabIndex = 37;
            this.btnAplicarDesconto.Text = "Aplicar outros valores (F8)";
            this.btnAplicarDesconto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnAplicarDesconto, "Clique aqui para finalizar sua venda!");
            this.btnAplicarDesconto.UseVisualStyleBackColor = true;
            this.btnAplicarDesconto.Click += new System.EventHandler(this.btnAplicarDesconto_Click);
            // 
            // btnFinalizarPedido
            // 
            this.btnFinalizarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFinalizarPedido.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnFinalizarPedido.Image")));
            this.btnFinalizarPedido.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFinalizarPedido.Location = new System.Drawing.Point(478, 517);
            this.btnFinalizarPedido.Name = "btnFinalizarPedido";
            this.btnFinalizarPedido.Size = new System.Drawing.Size(150, 60);
            this.btnFinalizarPedido.TabIndex = 5;
            this.btnFinalizarPedido.Text = "Finalizar Pedido (F5)";
            this.btnFinalizarPedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnFinalizarPedido, "Clique aqui para finalizar sua venda!");
            this.btnFinalizarPedido.UseVisualStyleBackColor = true;
            this.btnFinalizarPedido.Click += new System.EventHandler(this.btnFinalizarPedido_Click);
            // 
            // btnPesquisarCliente
            // 
            this.btnPesquisarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPesquisarCliente.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarCliente.Image")));
            this.btnPesquisarCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPesquisarCliente.Location = new System.Drawing.Point(322, 517);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Size = new System.Drawing.Size(150, 60);
            this.btnPesquisarCliente.TabIndex = 35;
            this.btnPesquisarCliente.Text = "Pesquisar cliente (F3)";
            this.btnPesquisarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisarCliente.UseVisualStyleBackColor = true;
            this.btnPesquisarCliente.Click += new System.EventHandler(this.btnPesquisarCliente_Click);
            // 
            // btnPesquisarProduto
            // 
            this.btnPesquisarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPesquisarProduto.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarProduto.Image")));
            this.btnPesquisarProduto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPesquisarProduto.Location = new System.Drawing.Point(166, 517);
            this.btnPesquisarProduto.Name = "btnPesquisarProduto";
            this.btnPesquisarProduto.Size = new System.Drawing.Size(150, 60);
            this.btnPesquisarProduto.TabIndex = 34;
            this.btnPesquisarProduto.Text = "Pesquisar produto (F2)";
            this.btnPesquisarProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisarProduto.UseVisualStyleBackColor = true;
            this.btnPesquisarProduto.Click += new System.EventHandler(this.btnPesquisarProduto_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(795, 517);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 60);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar (ESC)";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
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
            this.panel2.Size = new System.Drawing.Size(1126, 50);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(4, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 36);
            this.pictureBox3.TabIndex = 97;
            this.pictureBox3.TabStop = false;
            // 
            // pcBoxFechar
            // 
            this.pcBoxFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcBoxFechar.BackgroundImage")));
            this.pcBoxFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcBoxFechar.Location = new System.Drawing.Point(1081, 6);
            this.pcBoxFechar.Name = "pcBoxFechar";
            this.pcBoxFechar.Size = new System.Drawing.Size(40, 38);
            this.pcBoxFechar.TabIndex = 28;
            this.pcBoxFechar.TabStop = false;
            this.pcBoxFechar.Click += new System.EventHandler(this.pcBoxFechar_Click_1);
            this.pcBoxFechar.MouseLeave += new System.EventHandler(this.pcBoxFechar_MouseLeave_1);
            this.pcBoxFechar.MouseHover += new System.EventHandler(this.pcBoxFechar_MouseHover_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 32);
            this.label1.TabIndex = 27;
            this.label1.Text = "Realizar Pedido - Comum";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1126, 657);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Realizar pedido";
            this.Load += new System.EventHandler(this.frmPedido_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPedido_KeyDown);
            this.pPrincipal.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ctmenuStrip.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxFechar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pPrincipal;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnPesquisarCliente;
        private System.Windows.Forms.Button btnPesquisarProduto;
        private System.Windows.Forms.ContextMenuStrip ctmenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ctmenuItemExcluir;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnAplicarDesconto;
        private System.Windows.Forms.Button btnFinalizarPedido;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pcBoxFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox txtFuncionarioEntregador;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtQtdeItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtTotalSubtotal;
        private System.Windows.Forms.Button btnIncluirProduto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrecoUnit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescricaoProduto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigoBarra;
        private System.Windows.Forms.ListView lwItensPedido;
        private System.Windows.Forms.ColumnHeader colunaCodBarra;
        private System.Windows.Forms.ColumnHeader colunaDescricao;
        private System.Windows.Forms.ColumnHeader colunaPreco;
        private System.Windows.Forms.ColumnHeader colunaQtde;
        private System.Windows.Forms.ColumnHeader colunaTotal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label la;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHoraPedido;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker txtDataVenda;
        private System.Windows.Forms.TextBox txtNumeroPedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label24;
    }
}