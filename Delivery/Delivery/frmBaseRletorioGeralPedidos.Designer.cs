namespace Delivery
{
    partial class frmBaseRletorioGeralPedidos
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
            this.PedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetRelatorios = new Delivery.DataSetRelatorios();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.PedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetRelatorios)).BeginInit();
            this.SuspendLayout();
            // 
            // PedidoBindingSource
            // 
            this.PedidoBindingSource.DataMember = "Pedido";
            this.PedidoBindingSource.DataSource = this.DataSetRelatorios;
            // 
            // DataSetRelatorios
            // 
            this.DataSetRelatorios.DataSetName = "DataSetRelatorios";
            this.DataSetRelatorios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetRelatorios";
            reportDataSource1.Value = this.PedidoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Delivery.ReportPedidosGeral.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1084, 488);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmBaseRletorioGeralPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 488);
            this.Controls.Add(this.reportViewer1);
            this.KeyPreview = true;
            this.Name = "frmBaseRletorioGeralPedidos";
            this.Text = "Visualizar relatório";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBaseReportPedidoEntrega_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBaseRletorioGeralPedidos_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.PedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetRelatorios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource PedidoBindingSource;
        private DataSetRelatorios DataSetRelatorios;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}