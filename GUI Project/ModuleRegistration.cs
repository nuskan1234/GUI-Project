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
    public partial class ModuleRegistration : MetroFramework.Forms.MetroForm
    {
        public ModuleRegistration()
        {
            InitializeComponent();
        }
        Module obj = new Module();

        private void ModuleRegistration_Load(object sender, EventArgs e)
        {
            txt_id.Text = GetNextBatchID();
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
           ModuleHome obj = new ModuleHome();
           obj.Show();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_Mname.Text) || txt_Mname.Text.Any(char.IsDigit))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Name cannot be blank or cannot contain digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(txt_no_lecs.Text.Length == 0 ||txt_no_lecs.Text.Any(char.IsLetter))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Number of lectures cannot be blank or contain letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                string query = "insert into Module (Mid,Mname,No_of_lecs) values('" + txt_id.Text + "','" + txt_Mname.Text + "','" + txt_no_lecs.Text + "')";
                int i = obj.Save_Update_Delete(query);
                if (i == 1)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Data saved successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Data cannot save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(FormatException)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter numbers only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(SqlException)
            {
                  MetroFramework.MetroMessageBox.Show(this, "Database error ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }







        private void btn_cls_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_Mname.Clear();
            txt_no_lecs.Clear();
            GetNextBatchID();
        }

        private string GetNextBatchID()
        {
            string nextModuleID = string.Empty;
            // Retrieve the maximum batch ID from the Batch table
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-STADLEU;Initial Catalog=StudentAttendence;Integrated Security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT MAX(Mid) FROM Module", con);
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    string currentBatchID = result.ToString();
                    string numericPart = currentBatchID.Substring(1); // Extract the numeric part of the ID
                    int numericValue;

                    if (int.TryParse(numericPart, out numericValue))
                    {
                        // If a valid numeric part exists, increment it by 1 and concatenate with the prefix
                        nextModuleID = "M" + (numericValue + 1);
                    }
                    else
                    {
                        // Handle the case when the numeric part cannot be parsed
                        throw new InvalidOperationException("Invalid batch ID format in the database.");
                    }
                }
                else
                {
                    // If no batch ID exists, start from B1
                    nextModuleID = "M1";
                }
            }

            return nextModuleID;
        }
    }
}


