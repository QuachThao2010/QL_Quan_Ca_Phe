
namespace BTLHighlandsCoffee
{
    partial class frmReportUngLuong
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
            this.DataSetUngLuong = new BTLHighlandsCoffee.DataSetUngLuong();
            this.DataTableUngLuongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTableUngLuongTableAdapter = new BTLHighlandsCoffee.DataSetUngLuongTableAdapters.DataTableUngLuongTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetUngLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableUngLuongBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTableUngLuongBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BTLHighlandsCoffee.ReportUngLuong.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1332, 716);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetUngLuong
            // 
            this.DataSetUngLuong.DataSetName = "DataSetUngLuong";
            this.DataSetUngLuong.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTableUngLuongBindingSource
            // 
            this.DataTableUngLuongBindingSource.DataMember = "DataTableUngLuong";
            this.DataTableUngLuongBindingSource.DataSource = this.DataSetUngLuong;
            // 
            // DataTableUngLuongTableAdapter
            // 
            this.DataTableUngLuongTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportUngLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 716);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportUngLuong";
            this.Text = "frmReportUngLuong";
            this.Load += new System.EventHandler(this.frmReportUngLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetUngLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableUngLuongBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTableUngLuongBindingSource;
        private DataSetUngLuong DataSetUngLuong;
        private DataSetUngLuongTableAdapters.DataTableUngLuongTableAdapter DataTableUngLuongTableAdapter;
    }
}