namespace Delivery
{
    partial class frmLancamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLancamento));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAddSubClasseLancamento = new System.Windows.Forms.Button();
            this.btnAddClasseLancamento = new System.Windows.Forms.Button();
            this.txtTotalParcelas = new System.Windows.Forms.TextBox();
            this.txtQtdeParcela = new System.Windows.Forms.ComboBox();
            this.txtValorDocumento = new System.Windows.Forms.TextBox();
            this.txtDescricaoLancamento = new System.Windows.Forms.TextBox();
            this.txtNumeroDoc = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTipoDocumento = new System.Windows.Forms.ComboBox();
            this.txtSubClasseLancamento = new System.Windows.Forms.ComboBox();
            this.txtClasseLancamento = new System.Windows.Forms.ComboBox();
            this.txtFavorecido = new System.Windows.Forms.ComboBox();
            this.txtCategoria = new System.Windows.Forms.ComboBox();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtVencimentoInicial = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnGerarParcelas = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.listViewParcelas = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label16 = new System.Windows.Forms.Label();
            this.btnAddTipoDespesa = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDataEmissao = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageBaixar = new System.Windows.Forms.TabPage();
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox2.Location = new System.Drawing.Point(11, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(992, 31);
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoEllipsis = true;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Highlight;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(17, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(235, 25);
            this.label12.TabIndex = 38;
            this.label12.Text = "Cadastro de lançamentos";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(693, 548);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(150, 60);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(849, 548);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 60);
            this.btnCancelar.TabIndex = 40;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(537, 548);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(150, 60);
            this.btnExcluir.TabIndex = 41;
            this.btnExcluir.TabStop = false;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Visible = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPageBaixar);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(11, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(20, 5);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(992, 500);
            this.tabControl1.TabIndex = 42;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage2.Controls.Add(this.btnAddSubClasseLancamento);
            this.tabPage2.Controls.Add(this.btnAddClasseLancamento);
            this.tabPage2.Controls.Add(this.txtTotalParcelas);
            this.tabPage2.Controls.Add(this.txtQtdeParcela);
            this.tabPage2.Controls.Add(this.txtValorDocumento);
            this.tabPage2.Controls.Add(this.txtDescricaoLancamento);
            this.tabPage2.Controls.Add(this.txtNumeroDoc);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.txtTipoDocumento);
            this.tabPage2.Controls.Add(this.txtSubClasseLancamento);
            this.tabPage2.Controls.Add(this.txtClasseLancamento);
            this.tabPage2.Controls.Add(this.txtFavorecido);
            this.tabPage2.Controls.Add(this.txtCategoria);
            this.tabPage2.Controls.Add(this.txtEmpresa);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.txtVencimentoInicial);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.panel7);
            this.tabPage2.Controls.Add(this.btnGerarParcelas);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.listViewParcelas);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.btnAddTipoDespesa);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtDataEmissao);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtDataEntrada);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(984, 462);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Informações gerais";
            // 
            // btnAddSubClasseLancamento
            // 
            this.btnAddSubClasseLancamento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSubClasseLancamento.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSubClasseLancamento.Image")));
            this.btnAddSubClasseLancamento.Location = new System.Drawing.Point(942, 148);
            this.btnAddSubClasseLancamento.Name = "btnAddSubClasseLancamento";
            this.btnAddSubClasseLancamento.Size = new System.Drawing.Size(28, 28);
            this.btnAddSubClasseLancamento.TabIndex = 139;
            this.btnAddSubClasseLancamento.TabStop = false;
            this.toolTip1.SetToolTip(this.btnAddSubClasseLancamento, "Clique aqui para adicionar uma nova sub-classe de lançamento!");
            this.btnAddSubClasseLancamento.UseVisualStyleBackColor = true;
            this.btnAddSubClasseLancamento.Click += new System.EventHandler(this.btnAddSubClasseLancamento_Click);
            // 
            // btnAddClasseLancamento
            // 
            this.btnAddClasseLancamento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClasseLancamento.Image = ((System.Drawing.Image)(resources.GetObject("btnAddClasseLancamento.Image")));
            this.btnAddClasseLancamento.Location = new System.Drawing.Point(542, 150);
            this.btnAddClasseLancamento.Name = "btnAddClasseLancamento";
            this.btnAddClasseLancamento.Size = new System.Drawing.Size(28, 28);
            this.btnAddClasseLancamento.TabIndex = 138;
            this.btnAddClasseLancamento.TabStop = false;
            this.btnAddClasseLancamento.UseVisualStyleBackColor = true;
            this.btnAddClasseLancamento.Click += new System.EventHandler(this.btnAddClasseLancamento_Click);
            // 
            // txtTotalParcelas
            // 
            this.txtTotalParcelas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalParcelas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalParcelas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalParcelas.Location = new System.Drawing.Point(812, 427);
            this.txtTotalParcelas.Name = "txtTotalParcelas";
            this.txtTotalParcelas.Size = new System.Drawing.Size(158, 29);
            this.txtTotalParcelas.TabIndex = 137;
            this.txtTotalParcelas.TabStop = false;
            this.txtTotalParcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtQtdeParcela
            // 
            this.txtQtdeParcela.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtQtdeParcela.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtQtdeParcela.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdeParcela.FormattingEnabled = true;
            this.txtQtdeParcela.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.txtQtdeParcela.Location = new System.Drawing.Point(704, 208);
            this.txtQtdeParcela.Name = "txtQtdeParcela";
            this.txtQtdeParcela.Size = new System.Drawing.Size(108, 29);
            this.txtQtdeParcela.TabIndex = 11;
            this.txtQtdeParcela.Text = "Selecionar...";
            // 
            // txtValorDocumento
            // 
            this.txtValorDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorDocumento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDocumento.Location = new System.Drawing.Point(443, 207);
            this.txtValorDocumento.Name = "txtValorDocumento";
            this.txtValorDocumento.Size = new System.Drawing.Size(132, 29);
            this.txtValorDocumento.TabIndex = 9;
            this.txtValorDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValorDocumento.Leave += new System.EventHandler(this.txtValorDocumento_Leave);
            // 
            // txtDescricaoLancamento
            // 
            this.txtDescricaoLancamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricaoLancamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricaoLancamento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoLancamento.Location = new System.Drawing.Point(16, 208);
            this.txtDescricaoLancamento.Name = "txtDescricaoLancamento";
            this.txtDescricaoLancamento.Size = new System.Drawing.Size(421, 29);
            this.txtDescricaoLancamento.TabIndex = 8;
            // 
            // txtNumeroDoc
            // 
            this.txtNumeroDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumeroDoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroDoc.Location = new System.Drawing.Point(582, 91);
            this.txtNumeroDoc.Name = "txtNumeroDoc";
            this.txtNumeroDoc.Size = new System.Drawing.Size(105, 29);
            this.txtNumeroDoc.TabIndex = 4;
            this.txtNumeroDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(582, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 21);
            this.label14.TabIndex = 132;
            this.label14.Text = "Nº Doc.";
            // 
            // txtTipoDocumento
            // 
            this.txtTipoDocumento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTipoDocumento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtTipoDocumento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoDocumento.FormattingEnabled = true;
            this.txtTipoDocumento.Location = new System.Drawing.Point(693, 91);
            this.txtTipoDocumento.Name = "txtTipoDocumento";
            this.txtTipoDocumento.Size = new System.Drawing.Size(277, 29);
            this.txtTipoDocumento.TabIndex = 5;
            this.txtTipoDocumento.Text = "Selecionar...";
            // 
            // txtSubClasseLancamento
            // 
            this.txtSubClasseLancamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSubClasseLancamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtSubClasseLancamento.Enabled = false;
            this.txtSubClasseLancamento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubClasseLancamento.FormattingEnabled = true;
            this.txtSubClasseLancamento.Location = new System.Drawing.Point(582, 149);
            this.txtSubClasseLancamento.Name = "txtSubClasseLancamento";
            this.txtSubClasseLancamento.Size = new System.Drawing.Size(358, 29);
            this.txtSubClasseLancamento.TabIndex = 7;
            this.txtSubClasseLancamento.Text = "Selecionar...";
            // 
            // txtClasseLancamento
            // 
            this.txtClasseLancamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtClasseLancamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtClasseLancamento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClasseLancamento.FormattingEnabled = true;
            this.txtClasseLancamento.Location = new System.Drawing.Point(16, 150);
            this.txtClasseLancamento.Name = "txtClasseLancamento";
            this.txtClasseLancamento.Size = new System.Drawing.Size(525, 29);
            this.txtClasseLancamento.TabIndex = 6;
            this.txtClasseLancamento.Text = "Selecionar...";
            this.toolTip1.SetToolTip(this.txtClasseLancamento, "Clique aqui para adicionar uma nova classe de lançamento!");
            this.txtClasseLancamento.SelectedIndexChanged += new System.EventHandler(this.txtClasseLancamento_SelectedIndexChanged);
            // 
            // txtFavorecido
            // 
            this.txtFavorecido.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtFavorecido.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtFavorecido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFavorecido.FormattingEnabled = true;
            this.txtFavorecido.Location = new System.Drawing.Point(17, 91);
            this.txtFavorecido.Name = "txtFavorecido";
            this.txtFavorecido.Size = new System.Drawing.Size(524, 29);
            this.txtFavorecido.TabIndex = 3;
            this.txtFavorecido.Text = "Selecionar...";
            // 
            // txtCategoria
            // 
            this.txtCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtCategoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.FormattingEnabled = true;
            this.txtCategoria.Items.AddRange(new object[] {
            "DESPESA",
            "RECEITA"});
            this.txtCategoria.Location = new System.Drawing.Point(693, 32);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(277, 29);
            this.txtCategoria.TabIndex = 2;
            this.txtCategoria.Text = "Selecionar...";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmpresa.Enabled = false;
            this.txtEmpresa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpresa.Location = new System.Drawing.Point(298, 33);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(389, 29);
            this.txtEmpresa.TabIndex = 126;
            this.txtEmpresa.Text = "GRÉCIA GASTRONOMIA";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label17.Location = new System.Drawing.Point(578, 184);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 21);
            this.label17.TabIndex = 125;
            this.label17.Text = "Vcto Inicial:";
            // 
            // txtVencimentoInicial
            // 
            this.txtVencimentoInicial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVencimentoInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtVencimentoInicial.Location = new System.Drawing.Point(581, 207);
            this.txtVencimentoInicial.Name = "txtVencimentoInicial";
            this.txtVencimentoInicial.Size = new System.Drawing.Size(117, 29);
            this.txtVencimentoInicial.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(708, 435);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 21);
            this.label10.TabIndex = 124;
            this.label10.Text = "Total Parcela:";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.LightGray;
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.pictureBox3);
            this.panel7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(17, 246);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(953, 24);
            this.panel7.TabIndex = 123;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(4, 1);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 20);
            this.label15.TabIndex = 51;
            this.label15.Text = "Parcela(s)";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(81, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 21);
            this.pictureBox3.TabIndex = 50;
            this.pictureBox3.TabStop = false;
            // 
            // btnGerarParcelas
            // 
            this.btnGerarParcelas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarParcelas.Image = ((System.Drawing.Image)(resources.GetObject("btnGerarParcelas.Image")));
            this.btnGerarParcelas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerarParcelas.Location = new System.Drawing.Point(816, 206);
            this.btnGerarParcelas.Name = "btnGerarParcelas";
            this.btnGerarParcelas.Size = new System.Drawing.Size(154, 31);
            this.btnGerarParcelas.TabIndex = 12;
            this.btnGerarParcelas.Text = "Gerar Parcela(s)";
            this.btnGerarParcelas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnGerarParcelas, "Clique aqui para pré visualizar as parcelas!");
            this.btnGerarParcelas.UseVisualStyleBackColor = true;
            this.btnGerarParcelas.Click += new System.EventHandler(this.btnGerarParcelas_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(700, 184);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 21);
            this.label13.TabIndex = 122;
            this.label13.Text = "Nº Parc:";
            // 
            // listViewParcelas
            // 
            this.listViewParcelas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewParcelas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listViewParcelas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewParcelas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewParcelas.FullRowSelect = true;
            this.listViewParcelas.GridLines = true;
            this.listViewParcelas.HideSelection = false;
            this.listViewParcelas.Location = new System.Drawing.Point(17, 273);
            this.listViewParcelas.Name = "listViewParcelas";
            this.listViewParcelas.Size = new System.Drawing.Size(953, 149);
            this.listViewParcelas.TabIndex = 121;
            this.listViewParcelas.TabStop = false;
            this.listViewParcelas.UseCompatibleStateImageBehavior = false;
            this.listViewParcelas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Parc";
            this.columnHeader1.Width = 45;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Descrição";
            this.columnHeader2.Width = 400;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Data Vcto";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Vlr Parcela";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 145;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(13, 125);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(142, 21);
            this.label16.TabIndex = 118;
            this.label16.Text = "Classe lançamento:";
            // 
            // btnAddTipoDespesa
            // 
            this.btnAddTipoDespesa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTipoDespesa.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTipoDespesa.Image")));
            this.btnAddTipoDespesa.Location = new System.Drawing.Point(542, 91);
            this.btnAddTipoDespesa.Name = "btnAddTipoDespesa";
            this.btnAddTipoDespesa.Size = new System.Drawing.Size(28, 28);
            this.btnAddTipoDespesa.TabIndex = 117;
            this.btnAddTipoDespesa.TabStop = false;
            this.toolTip1.SetToolTip(this.btnAddTipoDespesa, "Clique aqui para adicionar um novo fornecedor(Favorecido)!");
            this.btnAddTipoDespesa.UseVisualStyleBackColor = true;
            this.btnAddTipoDespesa.Click += new System.EventHandler(this.btnAddTipoDespesa_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(297, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 21);
            this.label11.TabIndex = 116;
            this.label11.Text = "Empresa:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(441, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 21);
            this.label9.TabIndex = 115;
            this.label9.Text = "Valor Documento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(154, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 21);
            this.label8.TabIndex = 114;
            this.label8.Text = "Data Emissão:";
            // 
            // txtDataEmissao
            // 
            this.txtDataEmissao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataEmissao.Location = new System.Drawing.Point(157, 32);
            this.txtDataEmissao.Name = "txtDataEmissao";
            this.txtDataEmissao.Size = new System.Drawing.Size(135, 29);
            this.txtDataEmissao.TabIndex = 1;
            this.txtDataEmissao.ValueChanged += new System.EventHandler(this.txtDataEmissao_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(13, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 21);
            this.label7.TabIndex = 113;
            this.label7.Text = "Data Entrada:";
            // 
            // txtDataEntrada
            // 
            this.txtDataEntrada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataEntrada.Location = new System.Drawing.Point(16, 32);
            this.txtDataEntrada.Name = "txtDataEntrada";
            this.txtDataEntrada.Size = new System.Drawing.Size(135, 29);
            this.txtDataEntrada.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(14, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 21);
            this.label6.TabIndex = 112;
            this.label6.Text = "Descrição:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(575, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 21);
            this.label5.TabIndex = 111;
            this.label5.Text = "Sub classe lançamento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(575, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 110;
            this.label4.Text = "Nº Doc.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(689, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 21);
            this.label3.TabIndex = 109;
            this.label3.Text = "Tipo Documento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(15, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 21);
            this.label1.TabIndex = 108;
            this.label1.Text = "Favorecido (Fornecedor):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(689, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 106;
            this.label2.Text = "Classificação:";
            // 
            // tabPageBaixar
            // 
            this.tabPageBaixar.Location = new System.Drawing.Point(4, 34);
            this.tabPageBaixar.Name = "tabPageBaixar";
            this.tabPageBaixar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBaixar.Size = new System.Drawing.Size(984, 462);
            this.tabPageBaixar.TabIndex = 2;
            this.tabPageBaixar.Text = "Realizar baixar";
            this.tabPageBaixar.UseVisualStyleBackColor = true;
            // 
            // pPrincipal
            // 
            this.pPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pPrincipal.Controls.Add(this.tabControl1);
            this.pPrincipal.Controls.Add(this.btnExcluir);
            this.pPrincipal.Controls.Add(this.btnCancelar);
            this.pPrincipal.Controls.Add(this.btnSalvar);
            this.pPrincipal.Controls.Add(this.label12);
            this.pPrincipal.Controls.Add(this.pictureBox2);
            this.pPrincipal.Location = new System.Drawing.Point(5, 7);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(1017, 619);
            this.pPrincipal.TabIndex = 0;
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(131)))), ((int)(((byte)(61)))));
            this.toolTip1.IsBalloon = true;
            // 
            // frmLancamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1035, 634);
            this.Controls.Add(this.pPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmLancamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de lançamento";
            this.Load += new System.EventHandler(this.frmLancamento_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLancamento_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pPrincipal.ResumeLayout(false);
            this.pPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPageBaixar;
        private System.Windows.Forms.Panel pPrincipal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker txtVencimentoInicial;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnGerarParcelas;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListView listViewParcelas;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnAddTipoDespesa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker txtDataEmissao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker txtDataEntrada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtFavorecido;
        private System.Windows.Forms.ComboBox txtCategoria;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox txtTipoDocumento;
        private System.Windows.Forms.ComboBox txtSubClasseLancamento;
        private System.Windows.Forms.ComboBox txtClasseLancamento;
        private System.Windows.Forms.TextBox txtTotalParcelas;
        private System.Windows.Forms.ComboBox txtQtdeParcela;
        private System.Windows.Forms.TextBox txtValorDocumento;
        private System.Windows.Forms.TextBox txtDescricaoLancamento;
        private System.Windows.Forms.TextBox txtNumeroDoc;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAddSubClasseLancamento;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnAddClasseLancamento;

    }
}