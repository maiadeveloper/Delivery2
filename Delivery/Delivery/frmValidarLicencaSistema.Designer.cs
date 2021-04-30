namespace Delivery
{
    partial class frmValidarLicencaSistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmValidarLicencaSistema));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbImageOk = new System.Windows.Forms.PictureBox();
            this.txtChaveAcesso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnValidarLicenca = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbImageOk);
            this.groupBox1.Controls.Add(this.txtChaveAcesso);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnValidarLicenca);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informe a chave de acesso";
            // 
            // pbImageOk
            // 
            this.pbImageOk.Image = ((System.Drawing.Image)(resources.GetObject("pbImageOk.Image")));
            this.pbImageOk.Location = new System.Drawing.Point(446, 71);
            this.pbImageOk.Name = "pbImageOk";
            this.pbImageOk.Size = new System.Drawing.Size(31, 27);
            this.pbImageOk.TabIndex = 3;
            this.pbImageOk.TabStop = false;
            this.pbImageOk.Visible = false;
            // 
            // txtChaveAcesso
            // 
            this.txtChaveAcesso.Location = new System.Drawing.Point(10, 72);
            this.txtChaveAcesso.Name = "txtChaveAcesso";
            this.txtChaveAcesso.Size = new System.Drawing.Size(431, 26);
            this.txtChaveAcesso.TabIndex = 1;
            this.txtChaveAcesso.Leave += new System.EventHandler(this.txtChaveAcesso_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chave de acesso:";
            // 
            // btnValidarLicenca
            // 
            this.btnValidarLicenca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidarLicenca.Location = new System.Drawing.Point(141, 116);
            this.btnValidarLicenca.Name = "btnValidarLicenca";
            this.btnValidarLicenca.Size = new System.Drawing.Size(181, 37);
            this.btnValidarLicenca.TabIndex = 2;
            this.btnValidarLicenca.Text = "Validar licença mensal";
            this.btnValidarLicenca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnValidarLicenca.UseVisualStyleBackColor = true;
            this.btnValidarLicenca.Click += new System.EventHandler(this.btnValidarLicenca_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBox2.Location = new System.Drawing.Point(12, 254);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(477, 130);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "Suporte Técnico!\r\n\r\nContato: Luis Antonio Oliveira Maia\r\nTelefone: (69) 99271-845" +
    "4\r\nE-Mail: luisantoniopvh@hotmail.com";
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(398, 25);
            this.label2.TabIndex = 40;
            this.label2.Text = "Suporte técnico - Validar licença do sistema";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(479, 31);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // frmValidarLicencaSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(501, 396);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmValidarLicencaSistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validar licença do sistema";
            this.Load += new System.EventHandler(this.frmValidarLicencaSistema_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtChaveAcesso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnValidarLicenca;
        private System.Windows.Forms.PictureBox pbImageOk;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}