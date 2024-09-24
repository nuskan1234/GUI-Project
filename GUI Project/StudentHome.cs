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
    public partial class StudentHome : MetroFramework.Forms.MetroForm
    {
        public StudentHome()
        {
            InitializeComponent();
        }

        private void StudentHome_Load(object sender, EventArgs e)
        {

        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            SelectBatch sel = new SelectBatch();
            sel.ShowDialog();
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            StudentUpdate obj = new StudentUpdate();
            obj.ShowDialog();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            DeleteStudent obj = new DeleteStudent();
            obj.ShowDialog();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            ViewStudent obj = new ViewStudent();
            obj.ShowDialog();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
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
