
namespace SchoolManagementSystem
{
    partial class rEPORT
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
            this.NewDataSet1 = new SchoolManagementSystem.NewDataSet1();
            this.NewRegBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NewRegTableAdapter = new SchoolManagementSystem.NewDataSet1TableAdapters.NewRegTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.NewDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewRegBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "RegDetails";
            reportDataSource1.Value = this.NewRegBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SchoolManagementSystem.RegistrationForm.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 426);
            this.reportViewer1.TabIndex = 0;
            // 
            // NewDataSet1
            // 
            this.NewDataSet1.DataSetName = "NewDataSet1";
            this.NewDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NewRegBindingSource
            // 
            this.NewRegBindingSource.DataMember = "NewReg";
            this.NewRegBindingSource.DataSource = this.NewDataSet1;
            // 
            // NewRegTableAdapter
            // 
            this.NewRegTableAdapter.ClearBeforeFill = true;
            // 
            // rEPORT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rEPORT";
            this.Text = "rEPORT";
            this.Load += new System.EventHandler(this.rEPORT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NewDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewRegBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource NewRegBindingSource;
        private NewDataSet1 NewDataSet1;
        private NewDataSet1TableAdapters.NewRegTableAdapter NewRegTableAdapter;
    }
}