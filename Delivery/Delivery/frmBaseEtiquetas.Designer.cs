namespace Delivery
{
    partial class frmBaseEtiquetas
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
            this.EtiquetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetRelatorios = new Delivery.DataSetRelatorios();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.EtiquetaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetRelatorios)).BeginInit();
            this.SuspendLayout();
            // 
            // EtiquetaBindingSource
            // 
            this.EtiquetaBindingSource.DataMember = "Etiqueta";
            this.EtiquetaBindingSource.DataSource = this.DataSetRelatorios;
            // 
            // DataSetRelatorios
            // 
            this.DataSetRelatorios.DataSetName = "DataSetRelatorios";
            this.DataSetRelatorios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource1.Name = "DataSetRelatorios";
            reportDataSource1.Value = this.EtiquetaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Delivery.ReportEtiqueta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1150, 515);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomPercent = 150;
            // 
            // frmBaseEtiquetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 515);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmBaseEtiquetas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar etiquetas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBaseEtiquetas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBaseEtiquetas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.EtiquetaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetRelatorios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EtiquetaBindingSource;
        private DataSetRelatorios DataSetRelatorios;
    }
}