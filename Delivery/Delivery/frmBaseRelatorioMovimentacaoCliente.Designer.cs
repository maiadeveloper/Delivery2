namespace Delivery
{
    partial class frmBaseRelatorioMovimentacaoCliente
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaseRelatorioMovimentacaoCliente));
            this.MovimentacaoClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetRelatorios = new Delivery.DataSetRelatorios();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnMensagem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MovimentacaoClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetRelatorios)).BeginInit();
            this.SuspendLayout();
            // 
            // MovimentacaoClienteBindingSource
            // 
            this.MovimentacaoClienteBindingSource.DataMember = "MovimentacaoCliente";
            this.MovimentacaoClienteBindingSource.DataSource = this.DataSetRelatorios;
            // 
            // DataSetRelatorios
            // 
            this.DataSetRelatorios.DataSetName = "DataSetRelatorios";
            this.DataSetRelatorios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetClienteMovSaldo";
            reportDataSource1.Value = this.MovimentacaoClienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Delivery.ReportMovimentacaoSaldoCliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1114, 470);
            this.reportViewer1.TabIndex = 1;
            // 
            // btnMensagem
            // 
            this.btnMensagem.BackColor = System.Drawing.Color.Transparent;
            this.btnMensagem.Enabled = false;
            this.btnMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMensagem.Image = ((System.Drawing.Image)(resources.GetObject("btnMensagem.Image")));
            this.btnMensagem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMensagem.Location = new System.Drawing.Point(359, 352);
            this.btnMensagem.Name = "btnMensagem";
            this.btnMensagem.Size = new System.Drawing.Size(537, 45);
            this.btnMensagem.TabIndex = 38;
            this.btnMensagem.Text = "    Desculpe !  Não foi encontrado clientes com saldo!";
            this.btnMensagem.UseVisualStyleBackColor = false;
            // 
            // frmBaseRelatorioMovimentacaoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 470);
            this.Controls.Add(this.btnMensagem);
            this.Controls.Add(this.reportViewer1);
            this.KeyPreview = true;
            this.Name = "frmBaseRelatorioMovimentacaoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar relatório";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBaseRelatorioMovimentacaoCliente_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBaseRelatorioMovimentacaoCliente_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.MovimentacaoClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetRelatorios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MovimentacaoClienteBindingSource;
        private DataSetRelatorios DataSetRelatorios;
        private System.Windows.Forms.Button btnMensagem;
    }
}