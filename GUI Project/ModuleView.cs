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
    public partial class ModuleView : MetroFramework.Forms.MetroForm
    {
        public ModuleView()
        {
            InitializeComponent();
        }
        Module obj = new Module();
        private void ModuleView_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            ModuleHome obj = new ModuleHome();
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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (rbn_id.Checked == true)
            {
                dataGridView1.DataSource = obj.Display("Select * from Module where Mid = '" + txt_search.Text + "'");
            }
            else if (rbn_name.Checked == true)
            {
                dataGridView1.DataSource = obj.Display("Select * from Module where Mname LIKE '" + txt_search.Text + "%'");
            }
            if (txt_search.Text.Length == 0)
            {
                dataGridView1.DataSource = obj.Display("Select * from Module");
            }
        }
    }
}
