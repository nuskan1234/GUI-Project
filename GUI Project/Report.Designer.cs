
namespace GUI_Project
{
    partial class Report
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
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_std = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.rbn_batch = new System.Windows.Forms.RadioButton();
            this.rbn_std = new System.Windows.Forms.RadioButton();
            this.studentModuleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dynamicReport = new GUI_Project.DynamicReport();
            this.studentModuleTableAdapter = new GUI_Project.DynamicReportTableAdapters.StudentModuleTableAdapter();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentModuleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dynamicReport)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.PaleTurquoise;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.studentModuleBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI_Project.Dynamic_report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(48, 124);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1049, 589);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // btn_search
            // 
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Location = new System.Drawing.Point(800, 41);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_std
            // 
            this.txt_std.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_std.Location = new System.Drawing.Point(481, 41);
            this.txt_std.Name = "txt_std";
            this.txt_std.Size = new System.Drawing.Size(151, 30);
            this.txt_std.TabIndex = 4;
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(133, 41);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(146, 30);
            this.txt_id.TabIndex = 3;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // rbn_batch
            // 
            this.rbn_batch.AutoSize = true;
            this.rbn_batch.Location = new System.Drawing.Point(17, 45);
            this.rbn_batch.Name = "rbn_batch";
            this.rbn_batch.Size = new System.Drawing.Size(82, 21);
            this.rbn_batch.TabIndex = 6;
            this.rbn_batch.TabStop = true;
            this.rbn_batch.Text = "Batch ID";
            this.rbn_batch.UseVisualStyleBackColor = true;
            this.rbn_batch.CheckedChanged += new System.EventHandler(this.rbn_batch_CheckedChanged);
            // 
            // rbn_std
            // 
            this.rbn_std.AutoSize = true;
            this.rbn_std.Location = new System.Drawing.Point(365, 45);
            this.rbn_std.Name = "rbn_std";
            this.rbn_std.Size = new System.Drawing.Size(95, 21);
            this.rbn_std.TabIndex = 7;
            this.rbn_std.TabStop = true;
            this.rbn_std.Text = "Student ID";
            this.rbn_std.UseVisualStyleBackColor = true;
            this.rbn_std.CheckedChanged += new System.EventHandler(this.rbn_std_CheckedChanged);
            // 
            // studentModuleBindingSource
            // 
            this.studentModuleBindingSource.DataMember = "StudentModule";
            this.studentModuleBindingSource.DataSource = this.dynamicReport;
            // 
            // dynamicReport
            // 
            this.dynamicReport.DataSetName = "DynamicReport";
            this.dynamicReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentModuleTableAdapter
            // 
            this.studentModuleTableAdapter.ClearBeforeFill = true;
            // 
            // btn_back
            // 
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.DimGray;
            this.btn_back.Location = new System.Drawing.Point(1056, 31);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 33);
            this.btn_back.TabIndex = 22;
            this.btn_back.Text = "<<back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1172, 748);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.rbn_std);
            this.Controls.Add(this.rbn_batch);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_std);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentModuleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dynamicReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_std;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.RadioButton rbn_batch;
        private System.Windows.Forms.RadioButton rbn_std;
        private DynamicReport dynamicReport;
        private System.Windows.Forms.BindingSource studentModuleBindingSource;
        private DynamicReportTableAdapters.StudentModuleTableAdapter studentModuleTableAdapter;
        private System.Windows.Forms.Button btn_back;
    }
}