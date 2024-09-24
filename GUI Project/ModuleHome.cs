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
    public partial class ModuleHome : MetroFramework.Forms.MetroForm
    {
        public ModuleHome()
        {
            InitializeComponent();
        }

        private void ModuleHome_Load(object sender, EventArgs e)
        {

        }

        private void btn_view_Click(object sender, EventArgs e)
        {

        }

        private void btn_up_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            NewAdminDashboard obj = new NewAdminDashboard();
            obj.ShowDialog();
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            ModuleRegistration obj = new ModuleRegistration();
            obj.ShowDialog();
        }

        private void btn_up_Click_1(object sender, EventArgs e)
        {
            ModuleUpdate obj = new ModuleUpdate();
            obj.ShowDialog();
        }

        private void btn_view_Click_1(object sender, EventArgs e)
        {
            ModuleView obj = new ModuleView();
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
    }
}
