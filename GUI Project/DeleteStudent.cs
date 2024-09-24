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
    public partial class DeleteStudent : MetroFramework.Forms.MetroForm
    {
        public DeleteStudent()
        {
            InitializeComponent();
        }
        Student obj = new Student();
        private void DeleteStudent_Load(object sender, EventArgs e)
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

        private void btn_delt_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_sid.Text.Length == 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "ID cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string query = "Delete from Student where S_id= '" + txt_sid.Text + "'";
                    int i = obj.Save_Update_Delete(query);
                    if (i == 1)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Data Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Data cannot delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please Check Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
