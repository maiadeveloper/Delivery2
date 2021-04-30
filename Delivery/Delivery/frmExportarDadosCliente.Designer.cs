namespace Delivery
{
    partial class frmExportarDadosCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExportarDadosCliente));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbEmail = new System.Windows.Forms.CheckBox();
            this.ckbCelular = new System.Windows.Forms.CheckBox();
            this.ckbNome = new System.Windows.Forms.CheckBox();
            this.btnExportar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbEmail);
            this.groupBox1.Controls.Add(this.ckbCelular);
            this.groupBox1.Controls.Add(this.ckbNome);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informa os campos para exportação";
            // 
            // ckbEmail
            // 
            this.ckbEmail.AutoSize = true;
            this.ckbEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbEmail.Location = new System.Drawing.Point(258, 48);
            this.ckbEmail.Name = "ckbEmail";
            this.ckbEmail.Size = new System.Drawing.Size(77, 29);
            this.ckbEmail.TabIndex = 2;
            this.ckbEmail.Text = "Email";
            this.ckbEmail.UseVisualStyleBackColor = true;
            // 
            // ckbCelular
            // 
            this.ckbCelular.AutoSize = true;
            this.ckbCelular.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCelular.Location = new System.Drawing.Point(139, 48);
            this.ckbCelular.Name = "ckbCelular";
            this.ckbCelular.Size = new System.Drawing.Size(91, 29);
            this.ckbCelular.TabIndex = 1;
            this.ckbCelular.Text = "Celular";
            this.ckbCelular.UseVisualStyleBackColor = true;
            // 
            // ckbNome
            // 
            this.ckbNome.AutoSize = true;
            this.ckbNome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbNome.Location = new System.Drawing.Point(25, 48);
            this.ckbNome.Name = "ckbNome";
            this.ckbNome.Size = new System.Drawing.Size(82, 29);
            this.ckbNome.TabIndex = 0;
            this.ckbNome.Text = "Nome";
            this.ckbNome.UseVisualStyleBackColor = true;
            // 
            // btnExportar
            // 
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.Location = new System.Drawing.Point(99, 141);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(184, 41);
            this.btnExportar.TabIndex = 0;
            this.btnExportar.Text = "Exportar dados";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // frmExportarDadosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 202);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmExportarDadosCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exportar dados de cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.CheckBox ckbEmail;
        private System.Windows.Forms.CheckBox ckbCelular;
        private System.Windows.Forms.CheckBox ckbNome;
    }
}