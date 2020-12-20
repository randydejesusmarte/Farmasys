
namespace WindowsFormsApp1.Reportes.Forms
{
    partial class RUsuarios
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.farmaciaDataSet2 = new WindowsFormsApp1.farmaciaDataSet2();
            this.farmaciaDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new WindowsFormsApp1.farmaciaDataSet2TableAdapters.usuariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.farmaciaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmaciaDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "usuarios";
            reportDataSource1.Value = this.usuariosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Reportes.RDLCs.RUsuarios.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowExportButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.ShowZoomControl = false;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // farmaciaDataSet2
            // 
            this.farmaciaDataSet2.DataSetName = "farmaciaDataSet2";
            this.farmaciaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // farmaciaDataSet2BindingSource
            // 
            this.farmaciaDataSet2BindingSource.DataSource = this.farmaciaDataSet2;
            this.farmaciaDataSet2BindingSource.Position = 0;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.farmaciaDataSet2BindingSource;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // RUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RUsuarios";
            this.Text = "Rusuarios";
            this.Load += new System.EventHandler(this.Rusuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.farmaciaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmaciaDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private farmaciaDataSet2 farmaciaDataSet2;
        private System.Windows.Forms.BindingSource farmaciaDataSet2BindingSource;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private farmaciaDataSet2TableAdapters.usuariosTableAdapter usuariosTableAdapter;
    }
}