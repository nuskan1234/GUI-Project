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
    public partial class StudentUpdate : MetroFramework.Forms.MetroForm
    {
        public StudentUpdate()
        {
            InitializeComponent();
        }
        Student obj = new Student();

        private void StudentUpdate_Load(object sender, EventArgs e)
        {

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

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Sname.Text.Length == 0 || txt_add.Text.Length == 0 || txt_tp.Text.Length == 0 || txt_pw.Text.Length == 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Fields cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    string query = "update Student set Sname= '" + txt_Sname.Text + "', Saddress= '" + txt_add.Text + "', Tp= '" + txt_tp.Text + "', DOB= '" + picker_DateTime.Value + "', Password= '" + txt_pw.Text + "' where S_id= '" + txt_id.Text + "' and Bid= '" + txt_bid.Text + "'";
                    int i = obj.Save_Update_Delete(query);
                    if (i == 1)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Data updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Data cannot update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }  
            catch(SqlException)
            {
                MetroFramework.MetroMessageBox.Show(this, "Database error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
