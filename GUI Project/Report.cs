using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Project
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dynamicReport.StudentModule' table. You can move, or remove it, as needed.
            this.studentModuleTableAdapter.Fill(this.dynamicReport.StudentModule);
            // TODO: This line of code loads data into the 'dynamicReport1.StudentModule' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'DynamicReport.StudentModule' table. You can move, or remove it, as needed.
            

            this.reportViewer1.RefreshReport();
            txt_id.Visible = false;
            txt_std.Visible = false;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if(rbn_batch.Checked)
            {
                string bid = txt_id.Text.ToString();
                this.studentModuleTableAdapter.FillBy(this.dynamicReport.StudentModule,bid);
                this.reportViewer1.RefreshReport();
            }
            else if(rbn_std.Checked)
            {
                string sid = txt_std.Text.ToString();
                this.studentModuleTableAdapter.setBatchId(this.dynamicReport.StudentModule, sid);
                this.reportViewer1.RefreshReport();
            }
        }

        private void rbn_batch_CheckedChanged(object sender, EventArgs e)
        {
            if(rbn_batch.Checked)
            {
                txt_id.Visible = true;
                txt_std.Visible = false;
                
            }
        }

        private void rbn_std_CheckedChanged(object sender, EventArgs e)
        {
            if (rbn_std.Checked)
            {
                txt_std.Visible = true;
                txt_id.Visible = false;
            }
        }
       private void  FillBy(string bid)
       {

       }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            NewAdminDashboard obj = new NewAdminDashboard();
            this.Close();
            obj.Show();
        }
    }
}
