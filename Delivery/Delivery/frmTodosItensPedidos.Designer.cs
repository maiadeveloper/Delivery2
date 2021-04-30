namespace Delivery
{
    partial class frmTodosItensPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTodosItensPedidos));
            this.colunaData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaCPF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaCod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaProduto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.ckSelecionar = new System.Windows.Forms.CheckBox();
            this.txtQtdeItem = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtTotalGeral = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataFinal = new System.Windows.Forms.DateTimePicker();
            this.txtDataInicial = new System.Windows.Forms.DateTimePicker();
            this.colunaTotalPagar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaRestricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMensagem = new System.Windows.Forms.Button();
            this.txtParametroBusca = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lwItensPedidos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaPedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaDataPedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColunaItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctmenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fecharPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarDataConsumoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGerarEtiquetas = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbProdutos = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtTotalConsumido = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtTotalNaoConsumido = new System.Windows.Forms.TextBox();
            this.txtSituacaoIsConsumido = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.ctmenuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // colunaData
            // 
            this.colunaData.Text = "Data p/consumo";
            this.colunaData.Width = 190;
            // 
            // colunaCPF
            // 
            this.colunaCPF.Text = "Documento";
            this.colunaCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colunaCPF.Width = 128;
            // 
            // colunaCod
            // 
            this.colunaCod.Text = "Cód";
            this.colunaCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colunaCod.Width = 42;
            // 
            // colunaProduto
            // 
            this.colunaProduto.Text = "Produto";
            this.colunaProduto.Width = 185;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFiltrar.CausesValidation = false;
            this.btnFiltrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnFiltrar.Location = new System.Drawing.Point(1093, 16);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(99, 29);
            this.btnFiltrar.TabIndex = 58;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // ckSelecionar
            // 
            this.ckSelecionar.AutoSize = true;
            this.ckSelecionar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckSelecionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ckSelecionar.Location = new System.Drawing.Point(15, 55);
            this.ckSelecionar.Name = "ckSelecionar";
            this.ckSelecionar.Size = new System.Drawing.Size(158, 25);
            this.ckSelecionar.TabIndex = 55;
            this.ckSelecionar.Text = "Selecionar Todos";
            this.ckSelecionar.UseVisualStyleBackColor = false;
            this.ckSelecionar.CheckedChanged += new System.EventHandler(this.ckSelecionar_CheckedChanged);
            // 
            // txtQtdeItem
            // 
            this.txtQtdeItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtQtdeItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtQtdeItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdeItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQtdeItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdeItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQtdeItem.Location = new System.Drawing.Point(144, 386);
            this.txtQtdeItem.Name = "txtQtdeItem";
            this.txtQtdeItem.ReadOnly = true;
            this.txtQtdeItem.Size = new System.Drawing.Size(64, 25);
            this.txtQtdeItem.TabIndex = 54;
            this.txtQtdeItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(981, 385);
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
            this.txtTotalGeral.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTotalGeral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalGeral.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalGeral.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalGeral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotalGeral.Location = new System.Drawing.Point(1110, 385);
            this.txtTotalGeral.Name = "txtTotalGeral";
            this.txtTotalGeral.ReadOnly = true;
            this.txtTotalGeral.Size = new System.Drawing.Size(97, 25);
            this.txtTotalGeral.TabIndex = 52;
            this.txtTotalGeral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(323, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 41;
            this.label3.Text = "Período de";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(546, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 21);
            this.label2.TabIndex = 40;
            this.label2.Text = "a";
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataFinal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataFinal.Location = new System.Drawing.Point(567, 16);
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Size = new System.Drawing.Size(123, 29);
            this.txtDataFinal.TabIndex = 39;
            // 
            // txtDataInicial
            // 
            this.txtDataInicial.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataInicial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataInicial.Location = new System.Drawing.Point(420, 16);
            this.txtDataInicial.Name = "txtDataInicial";
            this.txtDataInicial.Size = new System.Drawing.Size(123, 29);
            this.txtDataInicial.TabIndex = 38;
            // 
            // colunaTotalPagar
            // 
            this.colunaTotalPagar.Text = "Total Pagar";
            this.colunaTotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colunaTotalPagar.Width = 95;
            // 
            // colunaRestricao
            // 
            this.colunaRestricao.Text = "Restrições";
            this.colunaRestricao.Width = 200;
            // 
            // colunaNome
            // 
            this.colunaNome.Text = "Nome cliente";
            this.colunaNome.Width = 260;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Location = new System.Drawing.Point(11, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1222, 31);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // btnMensagem
            // 
            this.btnMensagem.BackColor = System.Drawing.Color.Transparent;
            this.btnMensagem.Enabled = false;
            this.btnMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMensagem.Image = ((System.Drawing.Image)(resources.GetObject("btnMensagem.Image")));
            this.btnMensagem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMensagem.Location = new System.Drawing.Point(388, 259);
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
            this.txtParametroBusca.Size = new System.Drawing.Size(262, 29);
            this.txtParametroBusca.TabIndex = 36;
            this.txtParametroBusca.TextChanged += new System.EventHandler(this.txtParametroBusca_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
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
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox2.Location = new System.Drawing.Point(15, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1191, 42);
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // lwItensPedidos
            // 
            this.lwItensPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwItensPedidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lwItensPedidos.CheckBoxes = true;
            this.lwItensPedidos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.colunaPedido,
            this.colunaDataPedido,
            this.ColunaItem,
            this.columnHeader2,
            this.colunaData,
            this.colunaCPF,
            this.colunaNome,
            this.colunaCod,
            this.colunaProduto,
            this.colunaRestricao,
            this.colunaTotalPagar});
            this.lwItensPedidos.ContextMenuStrip = this.ctmenuStrip;
            this.lwItensPedidos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwItensPedidos.FullRowSelect = true;
            this.lwItensPedidos.GridLines = true;
            this.lwItensPedidos.Location = new System.Drawing.Point(15, 81);
            this.lwItensPedidos.Name = "lwItensPedidos";
            this.lwItensPedidos.Size = new System.Drawing.Size(1192, 292);
            this.lwItensPedidos.TabIndex = 33;
            this.lwItensPedidos.UseCompatibleStateImageBehavior = false;
            this.lwItensPedidos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 50;
            // 
            // colunaPedido
            // 
            this.colunaPedido.Text = "Pedido";
            this.colunaPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colunaPedido.Width = 65;
            // 
            // colunaDataPedido
            // 
            this.colunaDataPedido.Text = "Data Pedido";
            this.colunaDataPedido.Width = 200;
            // 
            // ColunaItem
            // 
            this.ColunaItem.Text = "Cod.Item";
            this.ColunaItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ColunaItem.Width = 76;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Item";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 45;
            // 
            // ctmenuStrip
            // 
            this.ctmenuStrip.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fecharPedidoToolStripMenuItem,
            this.alterarDataConsumoToolStripMenuItem});
            this.ctmenuStrip.Name = "ctmenuStrip";
            this.ctmenuStrip.Size = new System.Drawing.Size(256, 52);
            // 
            // fecharPedidoToolStripMenuItem
            // 
            this.fecharPedidoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fecharPedidoToolStripMenuItem.Image")));
            this.fecharPedidoToolStripMenuItem.Name = "fecharPedidoToolStripMenuItem";
            this.fecharPedidoToolStripMenuItem.Size = new System.Drawing.Size(255, 24);
            this.fecharPedidoToolStripMenuItem.Text = "Alterar situação";
            this.fecharPedidoToolStripMenuItem.Click += new System.EventHandler(this.fecharPedidoToolStripMenuItem_Click);
            // 
            // alterarDataConsumoToolStripMenuItem
            // 
            this.alterarDataConsumoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("alterarDataConsumoToolStripMenuItem.Image")));
            this.alterarDataConsumoToolStripMenuItem.Name = "alterarDataConsumoToolStripMenuItem";
            this.alterarDataConsumoToolStripMenuItem.Size = new System.Drawing.Size(255, 24);
            this.alterarDataConsumoToolStripMenuItem.Text = "Alterar data para consumo";
            this.alterarDataConsumoToolStripMenuItem.Click += new System.EventHandler(this.alterarDataConsumoToolStripMenuItem_Click);
            // 
            // btnGerarEtiquetas
            // 
            this.btnGerarEtiquetas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGerarEtiquetas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGerarEtiquetas.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarEtiquetas.Image = ((System.Drawing.Image)(resources.GetObject("btnGerarEtiquetas.Image")));
            this.btnGerarEtiquetas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGerarEtiquetas.Location = new System.Drawing.Point(928, 482);
            this.btnGerarEtiquetas.Name = "btnGerarEtiquetas";
            this.btnGerarEtiquetas.Size = new System.Drawing.Size(150, 60);
            this.btnGerarEtiquetas.TabIndex = 36;
            this.btnGerarEtiquetas.Text = "Gerar etiqueta(s)";
            this.btnGerarEtiquetas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGerarEtiquetas.UseVisualStyleBackColor = true;
            this.btnGerarEtiquetas.Click += new System.EventHandler(this.btnGerarEtiquetas_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(1084, 482);
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
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbProdutos);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.txtTotalConsumido);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.txtTotalNaoConsumido);
            this.panel1.Controls.Add(this.txtSituacaoIsConsumido);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.btnFiltrar);
            this.panel1.Controls.Add(this.ckSelecionar);
            this.panel1.Controls.Add(this.txtQtdeItem);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.txtTotalGeral);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDataFinal);
            this.panel1.Controls.Add(this.txtDataInicial);
            this.panel1.Controls.Add(this.btnMensagem);
            this.panel1.Controls.Add(this.txtParametroBusca);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lwItensPedidos);
            this.panel1.Location = new System.Drawing.Point(11, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1222, 423);
            this.panel1.TabIndex = 33;
            // 
            // cbProdutos
            // 
            this.cbProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProdutos.AutoCompleteCustomSource.AddRange(new string[] {
            "Selecione..."});
            this.cbProdutos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbProdutos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbProdutos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProdutos.FormattingEnabled = true;
            this.cbProdutos.Items.AddRange(new object[] {
            "TODOS",
            "CONSUMIDO",
            "NÃO CONSUMIDO"});
            this.cbProdutos.Location = new System.Drawing.Point(879, 16);
            this.cbProdutos.Name = "cbProdutos";
            this.cbProdutos.Size = new System.Drawing.Size(209, 29);
            this.cbProdutos.TabIndex = 88;
            this.cbProdutos.Text = "TODOS";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.BackColor = System.Drawing.Color.SteelBlue;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(465, 386);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(140, 25);
            this.textBox3.TabIndex = 87;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "TOTAL CONSUMIDO";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalConsumido
            // 
            this.txtTotalConsumido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalConsumido.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTotalConsumido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalConsumido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalConsumido.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalConsumido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotalConsumido.Location = new System.Drawing.Point(606, 386);
            this.txtTotalConsumido.Name = "txtTotalConsumido";
            this.txtTotalConsumido.ReadOnly = true;
            this.txtTotalConsumido.Size = new System.Drawing.Size(97, 25);
            this.txtTotalConsumido.TabIndex = 86;
            this.txtTotalConsumido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.BackColor = System.Drawing.Color.SteelBlue;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(711, 386);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(162, 25);
            this.textBox4.TabIndex = 85;
            this.textBox4.TabStop = false;
            this.textBox4.Text = "TOTAL NÃO CONSUMIDO";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalNaoConsumido
            // 
            this.txtTotalNaoConsumido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalNaoConsumido.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTotalNaoConsumido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalNaoConsumido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalNaoConsumido.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalNaoConsumido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotalNaoConsumido.Location = new System.Drawing.Point(874, 386);
            this.txtTotalNaoConsumido.Name = "txtTotalNaoConsumido";
            this.txtTotalNaoConsumido.ReadOnly = true;
            this.txtTotalNaoConsumido.Size = new System.Drawing.Size(97, 25);
            this.txtTotalNaoConsumido.TabIndex = 84;
            this.txtTotalNaoConsumido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSituacaoIsConsumido
            // 
            this.txtSituacaoIsConsumido.AutoCompleteCustomSource.AddRange(new string[] {
            "Selecione..."});
            this.txtSituacaoIsConsumido.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSituacaoIsConsumido.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtSituacaoIsConsumido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSituacaoIsConsumido.FormattingEnabled = true;
            this.txtSituacaoIsConsumido.Items.AddRange(new object[] {
            "TODOS",
            "CONSUMIDO",
            "NÃO CONSUMIDO"});
            this.txtSituacaoIsConsumido.Location = new System.Drawing.Point(696, 16);
            this.txtSituacaoIsConsumido.Name = "txtSituacaoIsConsumido";
            this.txtSituacaoIsConsumido.Size = new System.Drawing.Size(177, 29);
            this.txtSituacaoIsConsumido.TabIndex = 60;
            this.txtSituacaoIsConsumido.Text = "Selecionar...";
            this.txtSituacaoIsConsumido.SelectedIndexChanged += new System.EventHandler(this.txtSituacaoIsConsumido_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(15, 386);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(128, 25);
            this.textBox2.TabIndex = 59;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "QTDE ITENS";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Listagem itens por pedidos - Etiqueta";
            // 
            // pPrincipal
            // 
            this.pPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pPrincipal.Controls.Add(this.label6);
            this.pPrincipal.Controls.Add(this.label5);
            this.pPrincipal.Controls.Add(this.label4);
            this.pPrincipal.Controls.Add(this.btnGerarEtiquetas);
            this.pPrincipal.Controls.Add(this.btnCancelar);
            this.pPrincipal.Controls.Add(this.panel1);
            this.pPrincipal.Controls.Add(this.label1);
            this.pPrincipal.Controls.Add(this.pictureBox1);
            this.pPrincipal.Location = new System.Drawing.Point(2, -2);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(1245, 562);
            this.pPrincipal.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(546, 482);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 21);
            this.label6.TabIndex = 45;
            this.label6.Text = "* Ultimo item pacote";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(301, 482);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 21);
            this.label5.TabIndex = 43;
            this.label5.Text = "* Item consumido pelo cliente";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(23, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 21);
            this.label4.TabIndex = 42;
            this.label4.Text = "* Item não consumido pelo cliente";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "677-mortar-pestle.png");
            // 
            // frmTodosItensPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1249, 569);
            this.Controls.Add(this.pPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "frmTodosItensPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista geral de itens pedidos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTodosItensPedidos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTodosItensPedidos_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ctmenuStrip.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pPrincipal.ResumeLayout(false);
            this.pPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader colunaData;
        private System.Windows.Forms.ColumnHeader colunaCPF;
        private System.Windows.Forms.ColumnHeader colunaCod;
        private System.Windows.Forms.ColumnHeader colunaProduto;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.CheckBox ckSelecionar;
        private System.Windows.Forms.TextBox txtQtdeItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtTotalGeral;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtDataFinal;
        private System.Windows.Forms.DateTimePicker txtDataInicial;
        private System.Windows.Forms.ColumnHeader colunaTotalPagar;
        private System.Windows.Forms.ColumnHeader colunaRestricao;
        private System.Windows.Forms.ColumnHeader colunaNome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMensagem;
        private System.Windows.Forms.TextBox txtParametroBusca;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListView lwItensPedidos;
        private System.Windows.Forms.ColumnHeader ColunaItem;
        private System.Windows.Forms.Button btnGerarEtiquetas;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pPrincipal;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ColumnHeader colunaPedido;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtSituacaoIsConsumido;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtTotalConsumido;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtTotalNaoConsumido;
        private System.Windows.Forms.ContextMenuStrip ctmenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fecharPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarDataConsumoToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbProdutos;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader colunaDataPedido;
    }
}