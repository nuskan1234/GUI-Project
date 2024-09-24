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
    public partial class ModuleDuration : MetroFramework.Forms.MetroForm
    {
        public ModuleDuration()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-STADLEU;Initial Catalog=StudentAttendence;Integrated Security=True");
        SqlCommand cmd;

        private void ModuleDuration_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            NewAdminDashboard dash = new NewAdminDashboard();
            dash.ShowDialog();
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {


                con.Open();
                cmd = new SqlCommand("Insert into BatchModule values('" + txt_id.Text + "', '" + txt_Mid.Text + "', '" + SdateTimePicker1.Value + "', '" + EdateTimePicker2.Value + "')", con);
                int i =cmd.ExecuteNonQuery();
                if(i==1)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Data saved successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Data cannot save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
                DateTime startDate = SdateTimePicker1.Value;
                DateTime endDate = EdateTimePicker2.Value;
                if (txt_id.Text.Length ==0 || txt_Mid.Text.Length ==0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "ID cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

                // Check if the end date is earlier than the start date
               else if (endDate < startDate)
               {
                    MessageBox.Show("End date cannot be earlier than the start date.", "Date Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Reset the end date to the start date to avoid an invalid selection
                    EdateTimePicker2.Value = startDate;
               }
                else
                {
                    MessageBox.Show("Successful", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }
            catch(SqlException)
            {
                MessageBox.Show("Database Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception)
            {
                MessageBox.Show("Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
