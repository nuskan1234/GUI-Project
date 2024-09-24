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
    public partial class BatchRegistration : MetroFramework.Forms.MetroForm
    {
        public BatchRegistration()
        {
            InitializeComponent();
        }
        Batch obj = new Batch();
        private void BatchRegistration_Load(object sender, EventArgs e)
        {
            txt_id.Text = GetNextBatchID();
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
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
            BatchHome obj = new BatchHome();
            obj.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
           try
           {
                // DateTime selectedDate = 
                if (string.IsNullOrEmpty(txt_bname.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Name cannot be blank ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                /* else if()
                 {

                 }*/
                
                string query = "insert into Batch(Bid, Bname, Bdate) values('" + txt_id.Text + "', '" + txt_bname.Text + "', '" + picker_batch.Value + "'')";






                int line = obj.Save_Update_Delete(query);
                if (line == 1)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Data saved successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Data cannot save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (FormatException)
           {
                MetroFramework.MetroMessageBox.Show(this, "Please enter numbers only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          /* catch(SqlException)
           {
                MetroFramework.MetroMessageBox.Show(this, "Database error ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
           catch(Exception)
           {
                MetroFramework.MetroMessageBox.Show(this, "Please check again ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string GetNextBatchID()
        {
            string nextBatchID = string.Empty;
            // Retrieve the maximum batch ID from the Batch table
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-STADLEU;Initial Catalog=StudentAttendence;Integrated Security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT MAX(Bid) FROM Batch",con);
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    string currentBatchID = result.ToString();
                    string numericPart = currentBatchID.Substring(1); // Extract the numeric part of the ID
                    int numericValue;

                    if (int.TryParse(numericPart, out numericValue))
                    {
                        // If a valid numeric part exists, increment it by 1 and concatenate with the prefix
                        nextBatchID = "B" + (numericValue + 1);
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
                    nextBatchID = "B1";
                }
            }

            return nextBatchID;
        }

        private void btn_cls_Click(object sender, EventArgs e)
        {
            txt_bname.Clear();
            GetNextBatchID();
        }
    }
}
