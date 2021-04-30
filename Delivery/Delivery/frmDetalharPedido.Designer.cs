namespace Delivery
{
    partial class frmDetalharPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalharPedido));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ctmenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fecharPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarDataConsumoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblTotalItensNaoConsumido = new System.Windows.Forms.Label();
            this.lwItensPedidoNaoConsumido = new System.Windows.Forms.ListView();
            this.colunaCodBarra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaDescricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaPreco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblTotalItensConsumido = new System.Windows.Forms.Label();
            this.lwItensPedidoConsumido = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblTotalItens = new System.Windows.Forms.Label();
            this.lwItensPedidoTodos = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtObservacoesGeraies = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDataInicioEntrega = new System.Windows.Forms.TextBox();
            this.txtDiasEntrega = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTipoPedido = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValorPacote = new System.Windows.Forms.TextBox();
            this.txtNPedido = new System.Windows.Forms.TextBox();
            this.la = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDataPcote = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDataRetorno = new System.Windows.Forms.DateTimePicker();
            this.btnPausar = new System.Windows.Forms.Button();
            this.gbReativar = new System.Windows.Forms.GroupBox();
            this.ckReativar = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.ctmenuStrip.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbReativar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 572);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.ContextMenuStrip = this.ctmenuStrip;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(10, 247);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 10);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(999, 316);
            this.tabControl1.TabIndex = 40;
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
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblTotalItensNaoConsumido);
            this.tabPage1.Controls.Add(this.lwItensPedidoNaoConsumido);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(991, 268);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Item(s) Não Consumido";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblTotalItensNaoConsumido
            // 
            this.lblTotalItensNaoConsumido.AutoSize = true;
            this.lblTotalItensNaoConsumido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItensNaoConsumido.Location = new System.Drawing.Point(6, 239);
            this.lblTotalItensNaoConsumido.Name = "lblTotalItensNaoConsumido";
            this.lblTotalItensNaoConsumido.Size = new System.Drawing.Size(129, 21);
            this.lblTotalItensNaoConsumido.TabIndex = 43;
            this.lblTotalItensNaoConsumido.Text = "Total de item(s)";
            // 
            // lwItensPedidoNaoConsumido
            // 
            this.lwItensPedidoNaoConsumido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lwItensPedidoNaoConsumido.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colunaCodBarra,
            this.columnHeader1,
            this.colunaDescricao,
            this.colunaPreco,
            this.columnHeader2});
            this.lwItensPedidoNaoConsumido.ContextMenuStrip = this.ctmenuStrip;
            this.lwItensPedidoNaoConsumido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwItensPedidoNaoConsumido.ForeColor = System.Drawing.Color.Green;
            this.lwItensPedidoNaoConsumido.FullRowSelect = true;
            this.lwItensPedidoNaoConsumido.GridLines = true;
            this.lwItensPedidoNaoConsumido.Location = new System.Drawing.Point(3, 3);
            this.lwItensPedidoNaoConsumido.Name = "lwItensPedidoNaoConsumido";
            this.lwItensPedidoNaoConsumido.Size = new System.Drawing.Size(985, 233);
            this.lwItensPedidoNaoConsumido.TabIndex = 36;
            this.lwItensPedidoNaoConsumido.UseCompatibleStateImageBehavior = false;
            this.lwItensPedidoNaoConsumido.View = System.Windows.Forms.View.Details;
            // 
            // colunaCodBarra
            // 
            this.colunaCodBarra.Text = "Cód.";
            this.colunaCodBarra.Width = 115;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 65;
            // 
            // colunaDescricao
            // 
            this.colunaDescricao.Text = "Descrição produto";
            this.colunaDescricao.Width = 320;
            // 
            // colunaPreco
            // 
            this.colunaPreco.Text = "Preço Unit.";
            this.colunaPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colunaPreco.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Data p/consumo";
            this.columnHeader2.Width = 300;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblTotalItensConsumido);
            this.tabPage2.Controls.Add(this.lwItensPedidoConsumido);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(991, 268);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Item(s) Consumido";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblTotalItensConsumido
            // 
            this.lblTotalItensConsumido.AutoSize = true;
            this.lblTotalItensConsumido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItensConsumido.Location = new System.Drawing.Point(8, 239);
            this.lblTotalItensConsumido.Name = "lblTotalItensConsumido";
            this.lblTotalItensConsumido.Size = new System.Drawing.Size(129, 21);
            this.lblTotalItensConsumido.TabIndex = 43;
            this.lblTotalItensConsumido.Text = "Total de item(s)";
            // 
            // lwItensPedidoConsumido
            // 
            this.lwItensPedidoConsumido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lwItensPedidoConsumido.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lwItensPedidoConsumido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwItensPedidoConsumido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lwItensPedidoConsumido.FullRowSelect = true;
            this.lwItensPedidoConsumido.GridLines = true;
            this.lwItensPedidoConsumido.Location = new System.Drawing.Point(3, 3);
            this.lwItensPedidoConsumido.Name = "lwItensPedidoConsumido";
            this.lwItensPedidoConsumido.Size = new System.Drawing.Size(985, 233);
            this.lwItensPedidoConsumido.TabIndex = 37;
            this.lwItensPedidoConsumido.UseCompatibleStateImageBehavior = false;
            this.lwItensPedidoConsumido.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cód.";
            this.columnHeader3.Width = 115;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Item";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 65;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Descrição produto";
            this.columnHeader5.Width = 320;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Preço Unit.";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Data p/consumo";
            this.columnHeader7.Width = 300;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblTotalItens);
            this.tabPage3.Controls.Add(this.lwItensPedidoTodos);
            this.tabPage3.Location = new System.Drawing.Point(4, 44);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(991, 268);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Todos os Item(s)";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblTotalItens
            // 
            this.lblTotalItens.AutoSize = true;
            this.lblTotalItens.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItens.Location = new System.Drawing.Point(5, 239);
            this.lblTotalItens.Name = "lblTotalItens";
            this.lblTotalItens.Size = new System.Drawing.Size(129, 21);
            this.lblTotalItens.TabIndex = 42;
            this.lblTotalItens.Text = "Total de item(s)";
            // 
            // lwItensPedidoTodos
            // 
            this.lwItensPedidoTodos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lwItensPedidoTodos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.lwItensPedidoTodos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwItensPedidoTodos.ForeColor = System.Drawing.Color.Black;
            this.lwItensPedidoTodos.FullRowSelect = true;
            this.lwItensPedidoTodos.GridLines = true;
            this.lwItensPedidoTodos.Location = new System.Drawing.Point(0, 0);
            this.lwItensPedidoTodos.Name = "lwItensPedidoTodos";
            this.lwItensPedidoTodos.Size = new System.Drawing.Size(991, 235);
            this.lwItensPedidoTodos.TabIndex = 37;
            this.lwItensPedidoTodos.UseCompatibleStateImageBehavior = false;
            this.lwItensPedidoTodos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Cód.";
            this.columnHeader8.Width = 115;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Item";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 65;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Descrição produto";
            this.columnHeader10.Width = 320;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Preço Unit.";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader11.Width = 150;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Data p/consumo";
            this.columnHeader12.Width = 300;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtObservacoesGeraies);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtDataInicioEntrega);
            this.groupBox1.Controls.Add(this.txtDiasEntrega);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtTipoPedido);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCpf);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNomeCliente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtValorPacote);
            this.groupBox1.Controls.Add(this.txtNPedido);
            this.groupBox1.Controls.Add(this.la);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDataPcote);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(10, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(995, 202);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Pedido";
            // 
            // txtObservacoesGeraies
            // 
            this.txtObservacoesGeraies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservacoesGeraies.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacoesGeraies.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacoesGeraies.Location = new System.Drawing.Point(17, 160);
            this.txtObservacoesGeraies.Name = "txtObservacoesGeraies";
            this.txtObservacoesGeraies.ReadOnly = true;
            this.txtObservacoesGeraies.Size = new System.Drawing.Size(962, 29);
            this.txtObservacoesGeraies.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 21);
            this.label11.TabIndex = 45;
            this.label11.Text = "Observações gerais:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(849, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 21);
            this.label10.TabIndex = 44;
            this.label10.Text = "Data Inicio Entrega:";
            // 
            // txtDataInicioEntrega
            // 
            this.txtDataInicioEntrega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDataInicioEntrega.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDataInicioEntrega.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataInicioEntrega.Location = new System.Drawing.Point(859, 107);
            this.txtDataInicioEntrega.Name = "txtDataInicioEntrega";
            this.txtDataInicioEntrega.ReadOnly = true;
            this.txtDataInicioEntrega.Size = new System.Drawing.Size(120, 29);
            this.txtDataInicioEntrega.TabIndex = 43;
            this.txtDataInicioEntrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDiasEntrega
            // 
            this.txtDiasEntrega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiasEntrega.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDiasEntrega.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiasEntrega.Location = new System.Drawing.Point(438, 49);
            this.txtDiasEntrega.Name = "txtDiasEntrega";
            this.txtDiasEntrega.ReadOnly = true;
            this.txtDiasEntrega.Size = new System.Drawing.Size(541, 29);
            this.txtDiasEntrega.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(434, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 21);
            this.label9.TabIndex = 41;
            this.label9.Text = "Dia(s) para entrega:";
            // 
            // txtTipoPedido
            // 
            this.txtTipoPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTipoPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTipoPedido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoPedido.Location = new System.Drawing.Point(284, 49);
            this.txtTipoPedido.Name = "txtTipoPedido";
            this.txtTipoPedido.ReadOnly = true;
            this.txtTipoPedido.Size = new System.Drawing.Size(149, 29);
            this.txtTipoPedido.TabIndex = 40;
            this.txtTipoPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(280, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 21);
            this.label8.TabIndex = 39;
            this.label8.Text = "Tipo de Pedido:";
            // 
            // txtCpf
            // 
            this.txtCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCpf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCpf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(12, 107);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.ReadOnly = true;
            this.txtCpf.Size = new System.Drawing.Size(130, 29);
            this.txtCpf.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 21);
            this.label7.TabIndex = 38;
            this.label7.Text = "Documento:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(148, 107);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(569, 29);
            this.txtNomeCliente.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(719, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 21);
            this.label5.TabIndex = 35;
            this.label5.Text = "Total do Pedido:";
            // 
            // txtValorPacote
            // 
            this.txtValorPacote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorPacote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorPacote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPacote.Location = new System.Drawing.Point(723, 107);
            this.txtValorPacote.Name = "txtValorPacote";
            this.txtValorPacote.ReadOnly = true;
            this.txtValorPacote.Size = new System.Drawing.Size(130, 29);
            this.txtValorPacote.TabIndex = 34;
            this.txtValorPacote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNPedido
            // 
            this.txtNPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNPedido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNPedido.Location = new System.Drawing.Point(148, 49);
            this.txtNPedido.Name = "txtNPedido";
            this.txtNPedido.ReadOnly = true;
            this.txtNPedido.Size = new System.Drawing.Size(130, 29);
            this.txtNPedido.TabIndex = 32;
            this.txtNPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // la
            // 
            this.la.AutoSize = true;
            this.la.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la.Location = new System.Drawing.Point(144, 25);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(83, 21);
            this.la.TabIndex = 29;
            this.la.Text = "Nº Pedido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nome do cliente:";
            // 
            // txtDataPcote
            // 
            this.txtDataPcote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDataPcote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDataPcote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataPcote.Location = new System.Drawing.Point(12, 49);
            this.txtDataPcote.Name = "txtDataPcote";
            this.txtDataPcote.ReadOnly = true;
            this.txtDataPcote.Size = new System.Drawing.Size(130, 29);
            this.txtDataPcote.TabIndex = 0;
            this.txtDataPcote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Data do Pedido:";
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Detalhamento de pedido";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1015, 31);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // txtDataRetorno
            // 
            this.txtDataRetorno.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataRetorno.Enabled = false;
            this.txtDataRetorno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataRetorno.Location = new System.Drawing.Point(64, 25);
            this.txtDataRetorno.Name = "txtDataRetorno";
            this.txtDataRetorno.Size = new System.Drawing.Size(350, 29);
            this.txtDataRetorno.TabIndex = 53;
            // 
            // btnPausar
            // 
            this.btnPausar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPausar.BackgroundImage")));
            this.btnPausar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPausar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPausar.Location = new System.Drawing.Point(825, 592);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(192, 41);
            this.btnPausar.TabIndex = 46;
            this.btnPausar.Text = "xxxxxxx";
            this.btnPausar.UseVisualStyleBackColor = true;
            this.btnPausar.Click += new System.EventHandler(this.btnPausar_Click);
            // 
            // gbReativar
            // 
            this.gbReativar.Controls.Add(this.ckReativar);
            this.gbReativar.Controls.Add(this.txtDataRetorno);
            this.gbReativar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReativar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbReativar.Location = new System.Drawing.Point(383, 575);
            this.gbReativar.Name = "gbReativar";
            this.gbReativar.Size = new System.Drawing.Size(432, 65);
            this.gbReativar.TabIndex = 47;
            this.gbReativar.TabStop = false;
            this.gbReativar.Text = "Data de reativação ";
            // 
            // ckReativar
            // 
            this.ckReativar.AutoSize = true;
            this.ckReativar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckReativar.Location = new System.Drawing.Point(23, 34);
            this.ckReativar.Name = "ckReativar";
            this.ckReativar.Size = new System.Drawing.Size(15, 14);
            this.ckReativar.TabIndex = 54;
            this.ckReativar.UseVisualStyleBackColor = true;
            this.ckReativar.CheckedChanged += new System.EventHandler(this.ckReativar_CheckedChanged);
            // 
            // frmDetalharPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1040, 650);
            this.Controls.Add(this.gbReativar);
            this.Controls.Add(this.btnPausar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetalharPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhar Pedido";
            this.Load += new System.EventHandler(this.frmDetalharPedido_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDetalharPedido_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ctmenuStrip.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbReativar.ResumeLayout(false);
            this.gbReativar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValorPacote;
        private System.Windows.Forms.TextBox txtNPedido;
        private System.Windows.Forms.Label la;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDataPcote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip ctmenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fecharPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarDataConsumoToolStripMenuItem;
        private System.Windows.Forms.TextBox txtTipoPedido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiasEntrega;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDataInicioEntrega;
        private System.Windows.Forms.TextBox txtObservacoesGeraies;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnPausar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView lwItensPedidoNaoConsumido;
        private System.Windows.Forms.ColumnHeader colunaCodBarra;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader colunaDescricao;
        private System.Windows.Forms.ColumnHeader colunaPreco;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lwItensPedidoConsumido;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView lwItensPedidoTodos;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Label lblTotalItens;
        private System.Windows.Forms.Label lblTotalItensNaoConsumido;
        private System.Windows.Forms.Label lblTotalItensConsumido;
        private System.Windows.Forms.DateTimePicker txtDataRetorno;
        private System.Windows.Forms.GroupBox gbReativar;
        private System.Windows.Forms.CheckBox ckReativar;
    }
}