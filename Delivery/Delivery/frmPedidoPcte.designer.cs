namespace Delivery
{
    partial class frmPedidoPcte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedidoPcte));
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFuncionarioEntregador = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.la = new System.Windows.Forms.Label();
            this.btnAplicarDesconto = new System.Windows.Forms.Button();
            this.btnPesquisarProduto = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtQtdeTotalItens = new System.Windows.Forms.TextBox();
            this.txtQtdeItem = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtTotalPacote = new System.Windows.Forms.TextBox();
            this.btnIncluirProduto = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtValorUnitProduto = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCodigoBarra = new System.Windows.Forms.TextBox();
            this.lwItensPedido = new System.Windows.Forms.ListView();
            this.colunaCodBarra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaDescricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaPreco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaQtde = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctmenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctmenuItemExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDataInicioEntrega = new System.Windows.Forms.DateTimePicker();
            this.txtTipoPacote = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDataPacote = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumeroPedido = new System.Windows.Forms.TextBox();
            this.btnFinalizarPedido = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDomingo = new System.Windows.Forms.Button();
            this.btnSabado = new System.Windows.Forms.Button();
            this.btnSexta = new System.Windows.Forms.Button();
            this.btnQuinta = new System.Windows.Forms.Button();
            this.btnQuarta = new System.Windows.Forms.Button();
            this.btnTerca = new System.Windows.Forms.Button();
            this.btnSegundaFeira = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPesquisarCliente = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pcBoxFechar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pPrincipal.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.ctmenuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // pPrincipal
            // 
            this.pPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pPrincipal.Controls.Add(this.groupBox2);
            this.pPrincipal.Controls.Add(this.btnAplicarDesconto);
            this.pPrincipal.Controls.Add(this.btnPesquisarProduto);
            this.pPrincipal.Controls.Add(this.groupBox5);
            this.pPrincipal.Controls.Add(this.groupBox1);
            this.pPrincipal.Controls.Add(this.btnFinalizarPedido);
            this.pPrincipal.Controls.Add(this.groupBox3);
            this.pPrincipal.Controls.Add(this.btnPesquisarCliente);
            this.pPrincipal.Controls.Add(this.btnCancelar);
            this.pPrincipal.Location = new System.Drawing.Point(2, 61);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(1097, 623);
            this.pPrincipal.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFuncionarioEntregador);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtCelular);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtNomeCliente);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtCPF);
            this.groupBox2.Controls.Add(this.la);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(500, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(585, 163);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações do cliente / Entregador";
            // 
            // txtFuncionarioEntregador
            // 
            this.txtFuncionarioEntregador.FormattingEnabled = true;
            this.txtFuncionarioEntregador.Location = new System.Drawing.Point(10, 122);
            this.txtFuncionarioEntregador.Name = "txtFuncionarioEntregador";
            this.txtFuncionarioEntregador.Size = new System.Drawing.Size(560, 29);
            this.txtFuncionarioEntregador.TabIndex = 2;
            this.txtFuncionarioEntregador.Text = "Selecione...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 21);
            this.label4.TabIndex = 42;
            this.label4.Text = "Nome Entregador:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(129, 51);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(54, 29);
            this.txtCodigo.TabIndex = 40;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(126, 27);
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
            this.txtCelular.Location = new System.Drawing.Point(458, 51);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.ReadOnly = true;
            this.txtCelular.Size = new System.Drawing.Size(112, 29);
            this.txtCelular.TabIndex = 38;
            this.txtCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(454, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 37;
            this.label2.Text = "Celular:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(190, 51);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(262, 29);
            this.txtNomeCliente.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(186, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 21);
            this.label8.TabIndex = 35;
            this.label8.Text = "Nome cliente:";
            // 
            // txtCPF
            // 
            this.txtCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCPF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCPF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(7, 51);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.ReadOnly = true;
            this.txtCPF.Size = new System.Drawing.Size(117, 29);
            this.txtCPF.TabIndex = 34;
            this.txtCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // la
            // 
            this.la.AutoSize = true;
            this.la.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la.Location = new System.Drawing.Point(3, 27);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(94, 21);
            this.la.TabIndex = 32;
            this.la.Text = "Documento:";
            // 
            // btnAplicarDesconto
            // 
            this.btnAplicarDesconto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAplicarDesconto.Enabled = false;
            this.btnAplicarDesconto.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicarDesconto.Image = ((System.Drawing.Image)(resources.GetObject("btnAplicarDesconto.Image")));
            this.btnAplicarDesconto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAplicarDesconto.Location = new System.Drawing.Point(763, 548);
            this.btnAplicarDesconto.Name = "btnAplicarDesconto";
            this.btnAplicarDesconto.Size = new System.Drawing.Size(156, 60);
            this.btnAplicarDesconto.TabIndex = 53;
            this.btnAplicarDesconto.Text = "Aplicar outros valores (F8)";
            this.btnAplicarDesconto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAplicarDesconto.UseVisualStyleBackColor = true;
            this.btnAplicarDesconto.Click += new System.EventHandler(this.btnAplicarDesconto_Click);
            // 
            // btnPesquisarProduto
            // 
            this.btnPesquisarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPesquisarProduto.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarProduto.Image")));
            this.btnPesquisarProduto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPesquisarProduto.Location = new System.Drawing.Point(13, 548);
            this.btnPesquisarProduto.Name = "btnPesquisarProduto";
            this.btnPesquisarProduto.Size = new System.Drawing.Size(150, 60);
            this.btnPesquisarProduto.TabIndex = 52;
            this.btnPesquisarProduto.Text = "Pesquisar produto (F2)";
            this.btnPesquisarProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisarProduto.UseVisualStyleBackColor = true;
            this.btnPesquisarProduto.Click += new System.EventHandler(this.btnPesquisarProduto_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtQtdeTotalItens);
            this.groupBox5.Controls.Add(this.txtQtdeItem);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.txtTotalPacote);
            this.groupBox5.Controls.Add(this.btnIncluirProduto);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.txtSubtotal);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.txtQtde);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.txtValorUnitProduto);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.txtProduto);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.txtCodigoBarra);
            this.groupBox5.Controls.Add(this.lwItensPedido);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox5.Location = new System.Drawing.Point(13, 254);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1072, 281);
            this.groupBox5.TabIndex = 51;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Itens do pedido";
            // 
            // txtQtdeTotalItens
            // 
            this.txtQtdeTotalItens.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtQtdeTotalItens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdeTotalItens.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQtdeTotalItens.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdeTotalItens.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQtdeTotalItens.Location = new System.Drawing.Point(716, 246);
            this.txtQtdeTotalItens.Name = "txtQtdeTotalItens";
            this.txtQtdeTotalItens.ReadOnly = true;
            this.txtQtdeTotalItens.Size = new System.Drawing.Size(118, 29);
            this.txtQtdeTotalItens.TabIndex = 56;
            this.txtQtdeTotalItens.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQtdeItem
            // 
            this.txtQtdeItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtQtdeItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdeItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQtdeItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdeItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQtdeItem.Location = new System.Drawing.Point(15, 246);
            this.txtQtdeItem.Name = "txtQtdeItem";
            this.txtQtdeItem.ReadOnly = true;
            this.txtQtdeItem.Size = new System.Drawing.Size(68, 29);
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
            this.textBox1.Location = new System.Drawing.Point(526, 246);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(188, 29);
            this.textBox1.TabIndex = 51;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "TOTALIZADORES";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalPacote
            // 
            this.txtTotalPacote.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTotalPacote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalPacote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalPacote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPacote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotalPacote.Location = new System.Drawing.Point(837, 246);
            this.txtTotalPacote.Name = "txtTotalPacote";
            this.txtTotalPacote.ReadOnly = true;
            this.txtTotalPacote.Size = new System.Drawing.Size(166, 29);
            this.txtTotalPacote.TabIndex = 50;
            this.txtTotalPacote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnIncluirProduto
            // 
            this.btnIncluirProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIncluirProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluirProduto.Image")));
            this.btnIncluirProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluirProduto.Location = new System.Drawing.Point(936, 48);
            this.btnIncluirProduto.Name = "btnIncluirProduto";
            this.btnIncluirProduto.Size = new System.Drawing.Size(121, 32);
            this.btnIncluirProduto.TabIndex = 40;
            this.btnIncluirProduto.Text = "Incluir ";
            this.btnIncluirProduto.UseVisualStyleBackColor = true;
            this.btnIncluirProduto.Click += new System.EventHandler(this.btnIncluirProduto_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(830, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 21);
            this.label14.TabIndex = 47;
            this.label14.Text = "SubTotal:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubtotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSubtotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(831, 51);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 29);
            this.txtSubtotal.TabIndex = 48;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(725, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 21);
            this.label15.TabIndex = 45;
            this.label15.Text = "Qtde:";
            // 
            // txtQtde
            // 
            this.txtQtde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtde.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQtde.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtde.Location = new System.Drawing.Point(726, 51);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(100, 29);
            this.txtQtde.TabIndex = 46;
            this.txtQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQtde.Enter += new System.EventHandler(this.txtQtde_Enter_1);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(623, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 21);
            this.label16.TabIndex = 43;
            this.label16.Text = "Preço Unit:";
            // 
            // txtValorUnitProduto
            // 
            this.txtValorUnitProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorUnitProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorUnitProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorUnitProduto.Location = new System.Drawing.Point(623, 51);
            this.txtValorUnitProduto.Name = "txtValorUnitProduto";
            this.txtValorUnitProduto.ReadOnly = true;
            this.txtValorUnitProduto.Size = new System.Drawing.Size(98, 29);
            this.txtValorUnitProduto.TabIndex = 44;
            this.txtValorUnitProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValorUnitProduto.Enter += new System.EventHandler(this.txtValorUnitProduto_Enter_1);
            this.txtValorUnitProduto.Leave += new System.EventHandler(this.txtValorUnitProduto_Leave_1);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(214, 28);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(140, 21);
            this.label17.TabIndex = 41;
            this.label17.Text = "Descrição produto:";
            // 
            // txtProduto
            // 
            this.txtProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduto.Location = new System.Drawing.Point(215, 52);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.ReadOnly = true;
            this.txtProduto.Size = new System.Drawing.Size(402, 29);
            this.txtProduto.TabIndex = 42;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(11, 28);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(104, 21);
            this.label18.TabIndex = 40;
            this.label18.Text = "Código barra:";
            // 
            // txtCodigoBarra
            // 
            this.txtCodigoBarra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoBarra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoBarra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoBarra.Location = new System.Drawing.Point(15, 52);
            this.txtCodigoBarra.Name = "txtCodigoBarra";
            this.txtCodigoBarra.Size = new System.Drawing.Size(194, 29);
            this.txtCodigoBarra.TabIndex = 3;
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
            this.lwItensPedido.Location = new System.Drawing.Point(15, 88);
            this.lwItensPedido.Name = "lwItensPedido";
            this.lwItensPedido.Size = new System.Drawing.Size(1045, 155);
            this.lwItensPedido.TabIndex = 34;
            this.lwItensPedido.UseCompatibleStateImageBehavior = false;
            this.lwItensPedido.View = System.Windows.Forms.View.Details;
            this.lwItensPedido.SelectedIndexChanged += new System.EventHandler(this.lwItensPedido_SelectedIndexChanged);
            // 
            // colunaCodBarra
            // 
            this.colunaCodBarra.Text = "Cód.";
            this.colunaCodBarra.Width = 75;
            // 
            // colunaDescricao
            // 
            this.colunaDescricao.Text = "Descrição produto";
            this.colunaDescricao.Width = 500;
            // 
            // colunaPreco
            // 
            this.colunaPreco.Text = "Preço Unit.";
            this.colunaPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colunaPreco.Width = 120;
            // 
            // colunaQtde
            // 
            this.colunaQtde.Text = "Qtde.";
            this.colunaQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colunaQtde.Width = 120;
            // 
            // colunaTotal
            // 
            this.colunaTotal.Text = "SubTotal";
            this.colunaTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colunaTotal.Width = 160;
            // 
            // ctmenuStrip
            // 
            this.ctmenuStrip.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctmenuItemExcluir});
            this.ctmenuStrip.Name = "ctmenuStrip";
            this.ctmenuStrip.Size = new System.Drawing.Size(230, 28);
            this.ctmenuStrip.Click += new System.EventHandler(this.ctmenuStrip_Click);
            // 
            // ctmenuItemExcluir
            // 
            this.ctmenuItemExcluir.Image = ((System.Drawing.Image)(resources.GetObject("ctmenuItemExcluir.Image")));
            this.ctmenuItemExcluir.Name = "ctmenuItemExcluir";
            this.ctmenuItemExcluir.Size = new System.Drawing.Size(229, 24);
            this.ctmenuItemExcluir.Text = "Excluir item do pedido";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtDataInicioEntrega);
            this.groupBox1.Controls.Add(this.txtTipoPacote);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDataPacote);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNumeroPedido);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(13, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 162);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do pedido";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(149, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(224, 21);
            this.label10.TabIndex = 52;
            this.label10.Text = "Data Inicio da primeira entrega";
            // 
            // txtDataInicioEntrega
            // 
            this.txtDataInicioEntrega.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataInicioEntrega.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataInicioEntrega.Location = new System.Drawing.Point(149, 50);
            this.txtDataInicioEntrega.Name = "txtDataInicioEntrega";
            this.txtDataInicioEntrega.Size = new System.Drawing.Size(311, 29);
            this.txtDataInicioEntrega.TabIndex = 0;
            // 
            // txtTipoPacote
            // 
            this.txtTipoPacote.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTipoPacote.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtTipoPacote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoPacote.FormattingEnabled = true;
            this.txtTipoPacote.Items.AddRange(new object[] {
            "Selecionar...",
            "SEMANAL",
            "MENSAL"});
            this.txtTipoPacote.Location = new System.Drawing.Point(149, 121);
            this.txtTipoPacote.Name = "txtTipoPacote";
            this.txtTipoPacote.Size = new System.Drawing.Size(311, 29);
            this.txtTipoPacote.TabIndex = 1;
            this.txtTipoPacote.Text = "Selecionar...";
            this.txtTipoPacote.SelectedIndexChanged += new System.EventHandler(this.txtTipoPacote_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(145, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 21);
            this.label11.TabIndex = 51;
            this.label11.Text = "Tipo de Pacote:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 21);
            this.label6.TabIndex = 46;
            this.label6.Text = "Data do Pacote:";
            // 
            // txtDataPacote
            // 
            this.txtDataPacote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDataPacote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDataPacote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataPacote.Location = new System.Drawing.Point(12, 121);
            this.txtDataPacote.Name = "txtDataPacote";
            this.txtDataPacote.ReadOnly = true;
            this.txtDataPacote.Size = new System.Drawing.Size(128, 29);
            this.txtDataPacote.TabIndex = 47;
            this.txtDataPacote.TabStop = false;
            this.txtDataPacote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 21);
            this.label3.TabIndex = 42;
            this.label3.Text = "Número pedido:";
            // 
            // txtNumeroPedido
            // 
            this.txtNumeroPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroPedido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroPedido.Location = new System.Drawing.Point(12, 50);
            this.txtNumeroPedido.Name = "txtNumeroPedido";
            this.txtNumeroPedido.ReadOnly = true;
            this.txtNumeroPedido.Size = new System.Drawing.Size(128, 29);
            this.txtNumeroPedido.TabIndex = 43;
            this.txtNumeroPedido.TabStop = false;
            this.txtNumeroPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnFinalizarPedido
            // 
            this.btnFinalizarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFinalizarPedido.Enabled = false;
            this.btnFinalizarPedido.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnFinalizarPedido.Image")));
            this.btnFinalizarPedido.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFinalizarPedido.Location = new System.Drawing.Point(345, 548);
            this.btnFinalizarPedido.Name = "btnFinalizarPedido";
            this.btnFinalizarPedido.Size = new System.Drawing.Size(150, 60);
            this.btnFinalizarPedido.TabIndex = 5;
            this.btnFinalizarPedido.Text = "Finalizar Pacote (F5)";
            this.btnFinalizarPedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFinalizarPedido.UseVisualStyleBackColor = true;
            this.btnFinalizarPedido.Click += new System.EventHandler(this.btnFinalizarPedido_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox3.Location = new System.Drawing.Point(13, 175);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1072, 74);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dias de entrega";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDomingo);
            this.panel1.Controls.Add(this.btnSabado);
            this.panel1.Controls.Add(this.btnSexta);
            this.panel1.Controls.Add(this.btnQuinta);
            this.panel1.Controls.Add(this.btnQuarta);
            this.panel1.Controls.Add(this.btnTerca);
            this.panel1.Controls.Add(this.btnSegundaFeira);
            this.panel1.Location = new System.Drawing.Point(15, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 45);
            this.panel1.TabIndex = 2;
            // 
            // btnDomingo
            // 
            this.btnDomingo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDomingo.Location = new System.Drawing.Point(22, 8);
            this.btnDomingo.Name = "btnDomingo";
            this.btnDomingo.Size = new System.Drawing.Size(130, 30);
            this.btnDomingo.TabIndex = 6;
            this.btnDomingo.TabStop = false;
            this.btnDomingo.Text = "Domingo";
            this.btnDomingo.UseVisualStyleBackColor = true;
            this.btnDomingo.Click += new System.EventHandler(this.btnDomingo_Click);
            // 
            // btnSabado
            // 
            this.btnSabado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSabado.Location = new System.Drawing.Point(886, 8);
            this.btnSabado.Name = "btnSabado";
            this.btnSabado.Size = new System.Drawing.Size(130, 30);
            this.btnSabado.TabIndex = 5;
            this.btnSabado.TabStop = false;
            this.btnSabado.Text = "Sábado";
            this.btnSabado.UseVisualStyleBackColor = true;
            this.btnSabado.Click += new System.EventHandler(this.btnSabado_Click);
            // 
            // btnSexta
            // 
            this.btnSexta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSexta.Location = new System.Drawing.Point(742, 8);
            this.btnSexta.Name = "btnSexta";
            this.btnSexta.Size = new System.Drawing.Size(130, 30);
            this.btnSexta.TabIndex = 4;
            this.btnSexta.TabStop = false;
            this.btnSexta.Text = "Sexta-feira";
            this.btnSexta.UseVisualStyleBackColor = true;
            this.btnSexta.Click += new System.EventHandler(this.btnSexta_Click);
            // 
            // btnQuinta
            // 
            this.btnQuinta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuinta.Location = new System.Drawing.Point(598, 8);
            this.btnQuinta.Name = "btnQuinta";
            this.btnQuinta.Size = new System.Drawing.Size(130, 30);
            this.btnQuinta.TabIndex = 3;
            this.btnQuinta.TabStop = false;
            this.btnQuinta.Text = "Quinta-feira";
            this.btnQuinta.UseVisualStyleBackColor = true;
            this.btnQuinta.Click += new System.EventHandler(this.btnQuinta_Click);
            // 
            // btnQuarta
            // 
            this.btnQuarta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuarta.Location = new System.Drawing.Point(454, 8);
            this.btnQuarta.Name = "btnQuarta";
            this.btnQuarta.Size = new System.Drawing.Size(130, 30);
            this.btnQuarta.TabIndex = 2;
            this.btnQuarta.TabStop = false;
            this.btnQuarta.Text = "Quarta-feira";
            this.btnQuarta.UseVisualStyleBackColor = true;
            this.btnQuarta.Click += new System.EventHandler(this.btnQuarta_Click);
            // 
            // btnTerca
            // 
            this.btnTerca.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerca.Location = new System.Drawing.Point(310, 8);
            this.btnTerca.Name = "btnTerca";
            this.btnTerca.Size = new System.Drawing.Size(130, 30);
            this.btnTerca.TabIndex = 1;
            this.btnTerca.TabStop = false;
            this.btnTerca.Text = "Terça-feira";
            this.btnTerca.UseVisualStyleBackColor = true;
            this.btnTerca.Click += new System.EventHandler(this.btnTerca_Click);
            // 
            // btnSegundaFeira
            // 
            this.btnSegundaFeira.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSegundaFeira.Location = new System.Drawing.Point(166, 8);
            this.btnSegundaFeira.Name = "btnSegundaFeira";
            this.btnSegundaFeira.Size = new System.Drawing.Size(130, 30);
            this.btnSegundaFeira.TabIndex = 0;
            this.btnSegundaFeira.TabStop = false;
            this.btnSegundaFeira.Text = "Segunda-feira";
            this.btnSegundaFeira.UseVisualStyleBackColor = true;
            this.btnSegundaFeira.Click += new System.EventHandler(this.btnSegundaFeira_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(136, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 15);
            this.label7.TabIndex = 47;
            this.label7.Text = "* Não selecionado";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LimeGreen;
            this.label9.Location = new System.Drawing.Point(247, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 46;
            this.label9.Text = "* Selecionado";
            // 
            // btnPesquisarCliente
            // 
            this.btnPesquisarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPesquisarCliente.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarCliente.Image")));
            this.btnPesquisarCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPesquisarCliente.Location = new System.Drawing.Point(179, 548);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Size = new System.Drawing.Size(150, 60);
            this.btnPesquisarCliente.TabIndex = 35;
            this.btnPesquisarCliente.TabStop = false;
            this.btnPesquisarCliente.Text = "Pesquisar cliente (F3)";
            this.btnPesquisarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisarCliente.UseVisualStyleBackColor = true;
            this.btnPesquisarCliente.Click += new System.EventHandler(this.btnPesquisarCliente_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(935, 548);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 60);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "Cancelar (ESC)";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.panel2.Size = new System.Drawing.Size(1101, 50);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(5, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 36);
            this.pictureBox3.TabIndex = 98;
            this.pictureBox3.TabStop = false;
            // 
            // pcBoxFechar
            // 
            this.pcBoxFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcBoxFechar.BackgroundImage")));
            this.pcBoxFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcBoxFechar.Location = new System.Drawing.Point(1058, 6);
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
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 32);
            this.label1.TabIndex = 27;
            this.label1.Text = "Realizar Pedido - Pacote";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPedidoPcte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1101, 686);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmPedidoPcte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido de pacote";
            this.Load += new System.EventHandler(this.frmPedidoPcte_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPedidoPcte_KeyDown);
            this.pPrincipal.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ctmenuStrip.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxFechar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pPrincipal;
        private System.Windows.Forms.Button btnPesquisarCliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtNumeroPedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFinalizarPedido;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSexta;
        private System.Windows.Forms.Button btnQuinta;
        private System.Windows.Forms.Button btnQuarta;
        private System.Windows.Forms.Button btnTerca;
        private System.Windows.Forms.Button btnSegundaFeira;
        private System.Windows.Forms.Button btnDomingo;
        private System.Windows.Forms.Button btnSabado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDataPacote;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker txtDataInicioEntrega;
        private System.Windows.Forms.ComboBox txtTipoPacote;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtQtdeItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtTotalPacote;
        private System.Windows.Forms.Button btnIncluirProduto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtValorUnitProduto;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtCodigoBarra;
        private System.Windows.Forms.ListView lwItensPedido;
        private System.Windows.Forms.ColumnHeader colunaCodBarra;
        private System.Windows.Forms.ColumnHeader colunaDescricao;
        private System.Windows.Forms.ColumnHeader colunaPreco;
        private System.Windows.Forms.ColumnHeader colunaQtde;
        private System.Windows.Forms.ColumnHeader colunaTotal;
        private System.Windows.Forms.Button btnPesquisarProduto;
        private System.Windows.Forms.TextBox txtQtdeTotalItens;
        private System.Windows.Forms.ContextMenuStrip ctmenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ctmenuItemExcluir;
        private System.Windows.Forms.Button btnAplicarDesconto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label la;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pcBoxFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox txtFuncionarioEntregador;
    }
}