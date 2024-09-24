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
    public partial class BatchHome : MetroFramework.Forms.MetroForm
    {
        public BatchHome()
        {
            InitializeComponent();
        }

        private void BatchHome_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            BatchView obj = new BatchView();
            obj.ShowDialog();
        }

        private void btn_max_Click(object sender, EventArgs e)
        {

        }

        private void btn_min_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            NewAdminDashboard obj = new NewAdminDashboard();
            obj.ShowDialog();
        }

        private void btn_close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_max_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btn_min_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            BatchRegistration obj = new BatchRegistration();
            obj.ShowDialog();
        }
    }
}
