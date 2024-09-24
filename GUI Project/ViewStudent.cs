using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GUI_Project
{
    public partial class ViewStudent : MetroFramework.Forms.MetroForm
    {
        public ViewStudent()
        {
            InitializeComponent();
        }
        Student obj = new Student();
        private void ViewStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentAttendenceDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.studentAttendenceDataSet.Student);

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
            StudentHome obj = new StudentHome();
            obj.Show();
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                /* if (rbn_id.Checked == true)
                 {
                    string query = "Select * from Student where S_id = '" + txt_search.Text + "'";
                     DataTable i = obj.Display(query);


                 }
                 else if (rbn_name.Checked == true)
                 {
                     string query = "Select * from Student where Sname LIKE '" + txt_search.Text + "%'";
                 }
                 if (txt_search.Text.Length == 0)
                 {
                     string query = "Select * from Student";
                 }*/
                if (rbn_id.Checked == true)
                {
                    StdDGV.DataSource = obj.Display("Select * from Student where S_id = '" +  txt_search.Text + "'");
                }
                else if (rbn_name.Checked == true)
                {
                    StdDGV.DataSource = obj.Display("Select * from Student where Sname LIKE '" + txt_search.Text + "%'"); 
                }
                if (txt_search.Text.Length == 0)
                {
                    StdDGV.DataSource = obj.Display("Select * from Student");
                }

            }
            catch (SqlException)
            {

            }
        }
    }
}
