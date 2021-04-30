namespace Delivery
{
    partial class frmBaseReciboVenda
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
            this.ItensPedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetRelatorios = new Delivery.DataSetRelatorios();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ItensPedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetRelatorios)).BeginInit();
            this.SuspendLayout();
            // 
            // ItensPedidoBindingSource
            // 
            this.ItensPedidoBindingSource.DataMember = "ItensPedido";
            this.ItensPedidoBindingSource.DataSource = this.DataSetRelatorios;
            // 
            // DataSetRelatorios
            // 
            this.DataSetRelatorios.DataSetName = "DataSetRelatorios";
            this.DataSetRelatorios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ItensPedidoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Delivery.ReportReciboVenda.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(695, 600);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmBaseReciboVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 600);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmBaseReciboVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar recibo de venda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBaseReciboVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItensPedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetRelatorios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ItensPedidoBindingSource;
        private DataSetRelatorios DataSetRelatorios;
    }
}