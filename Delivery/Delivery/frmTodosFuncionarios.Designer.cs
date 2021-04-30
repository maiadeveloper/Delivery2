namespace Delivery
{
    partial class frmTodosFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTodosFuncionarios));
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.btnNovoCliente = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtQtdeItem = new System.Windows.Forms.TextBox();
            this.btnMensagem = new System.Windows.Forms.Button();
            this.txtParametroBusca = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lwFuncionarios = new System.Windows.Forms.ListView();
            this.colunaId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaSituacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaFuncao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaCPF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaCelular = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaFoneRes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colunaFoneCome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.pPrincipal.Controls.Add(this.btnNovoCliente);
            this.pPrincipal.Controls.Add(this.btnCancelar);
            this.pPrincipal.Controls.Add(this.panel1);
            this.pPrincipal.Controls.Add(this.label1);
            this.pPrincipal.Controls.Add(this.pictureBox1);
            this.pPrincipal.Location = new System.Drawing.Point(-7, 0);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(1058, 511);
            this.pPrincipal.TabIndex = 1;
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNovoCliente.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoCliente.Image")));
            this.btnNovoCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovoCliente.Location = new System.Drawing.Point(742, 437);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Size = new System.Drawing.Size(150, 60);
            this.btnNovoCliente.TabIndex = 35;
            this.btnNovoCliente.Text = "Adicionar novo cliente";
            this.btnNovoCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovoCliente.UseVisualStyleBackColor = true;
            this.btnNovoCliente.Click += new System.EventHandler(this.btnNovoCliente_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(898, 436);
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
            this.panel1.Controls.Add(this.txtQtdeItem);
            this.panel1.Controls.Add(this.btnMensagem);
            this.panel1.Controls.Add(this.txtParametroBusca);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lwFuncionarios);
            this.panel1.Location = new System.Drawing.Point(11, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 385);
            this.panel1.TabIndex = 33;
            // 
            // txtQtdeItem
            // 
            this.txtQtdeItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtQtdeItem.BackColor = System.Drawing.Color.White;
            this.txtQtdeItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdeItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQtdeItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdeItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQtdeItem.Location = new System.Drawing.Point(16, 351);
            this.txtQtdeItem.Name = "txtQtdeItem";
            this.txtQtdeItem.ReadOnly = true;
            this.txtQtdeItem.Size = new System.Drawing.Size(64, 29);
            this.txtQtdeItem.TabIndex = 56;
            this.txtQtdeItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMensagem
            // 
            this.btnMensagem.BackColor = System.Drawing.Color.Transparent;
            this.btnMensagem.Enabled = false;
            this.btnMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMensagem.Image = ((System.Drawing.Image)(resources.GetObject("btnMensagem.Image")));
            this.btnMensagem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMensagem.Location = new System.Drawing.Point(263, 218);
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
            this.txtParametroBusca.Size = new System.Drawing.Size(954, 29);
            this.txtParametroBusca.TabIndex = 36;
            this.txtParametroBusca.TextChanged += new System.EventHandler(this.txtParametroBusca_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
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
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(15, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1004, 42);
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // lwFuncionarios
            // 
            this.lwFuncionarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwFuncionarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lwFuncionarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colunaId,
            this.colunaSituacao,
            this.colunaNome,
            this.colunaFuncao,
            this.colunaCPF,
            this.colunaCelular,
            this.colunaFoneRes,
            this.colunaFoneCome});
            this.lwFuncionarios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwFuncionarios.FullRowSelect = true;
            this.lwFuncionarios.GridLines = true;
            this.lwFuncionarios.HideSelection = false;
            this.lwFuncionarios.Location = new System.Drawing.Point(15, 67);
            this.lwFuncionarios.Name = "lwFuncionarios";
            this.lwFuncionarios.Size = new System.Drawing.Size(1004, 280);
            this.lwFuncionarios.TabIndex = 33;
            this.lwFuncionarios.UseCompatibleStateImageBehavior = false;
            this.lwFuncionarios.View = System.Windows.Forms.View.Details;
            this.lwFuncionarios.DoubleClick += new System.EventHandler(this.lwFuncionarios_DoubleClick);
            // 
            // colunaId
            // 
            this.colunaId.Text = "Cód.";
            this.colunaId.Width = 55;
            // 
            // colunaSituacao
            // 
            this.colunaSituacao.Text = "Situação";
            this.colunaSituacao.Width = 100;
            // 
            // colunaNome
            // 
            this.colunaNome.Text = "Nome funcionário";
            this.colunaNome.Width = 350;
            // 
            // colunaFuncao
            // 
            this.colunaFuncao.Text = "Função";
            this.colunaFuncao.Width = 120;
            // 
            // colunaCPF
            // 
            this.colunaCPF.Text = "Documento";
            this.colunaCPF.Width = 130;
            // 
            // colunaCelular
            // 
            this.colunaCelular.Text = "Celular";
            this.colunaCelular.Width = 130;
            // 
            // colunaFoneRes
            // 
            this.colunaFoneRes.Text = "Tel.Residencial";
            this.colunaFoneRes.Width = 130;
            // 
            // colunaFoneCome
            // 
            this.colunaFoneCome.Text = "Tel.Comercial";
            this.colunaFoneCome.Width = 130;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Listagem de funcionários cadastrados";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox1.Location = new System.Drawing.Point(11, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1035, 31);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // frmTodosFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1053, 513);
            this.Controls.Add(this.pPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmTodosFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Funcionarios";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTodosFuncionarios_KeyDown);
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
        private System.Windows.Forms.Button btnNovoCliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMensagem;
        private System.Windows.Forms.TextBox txtParametroBusca;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListView lwFuncionarios;
        private System.Windows.Forms.ColumnHeader colunaId;
        private System.Windows.Forms.ColumnHeader colunaSituacao;
        private System.Windows.Forms.ColumnHeader colunaNome;
        private System.Windows.Forms.ColumnHeader colunaFuncao;
        private System.Windows.Forms.ColumnHeader colunaCPF;
        private System.Windows.Forms.ColumnHeader colunaCelular;
        private System.Windows.Forms.ColumnHeader colunaFoneRes;
        private System.Windows.Forms.ColumnHeader colunaFoneCome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtQtdeItem;
    }
}