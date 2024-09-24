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
    public partial class SelectBatch : MetroFramework.Forms.MetroForm
    {
       public string ComboBoxValueFromSelectBatch { get; private set; }
       
        public SelectBatch()
        {
            InitializeComponent();
            FillCombo();
        }
        private void FillCombo()
        {
            string constring = "Data Source=DESKTOP-STADLEU;Initial Catalog=StudentAttendence;Integrated Security=True";
            string query = "SELECT Bname FROM Batch";

            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader myReader;

            try
            {
                con.Open();
                myReader = cmd.ExecuteReader();

                // Clear the existing items in the ComboBox
                comboBox_select_batch.Items.Clear();

                while (myReader.Read())
                {
                    // Add each value from the database to the ComboBox
                    comboBox_select_batch.Items.Add(myReader["Bname"].ToString());
                }

                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        private void SelectBatch_Load(object sender, EventArgs e)
        {
           comboBox_select_batch.Text = ComboBoxValueFromSelectBatch;

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            string selectedBatch = comboBox_select_batch.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedBatch))
            {
                // Show an error message or handle the case where no batch is selected.
                // For example, you can display a MessageBox or return from the method.
                MessageBox.Show("Please select a batch before proceeding.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            else
            {

               
                StudentRegistration studentRegistrationForm = new StudentRegistration(selectedBatch);
                studentRegistrationForm.ComboBoxValue = selectedBatch; // Set the ComboBox value
                studentRegistrationForm.ShowDialog();

            }






            /*StudentRegistration A = new StudentRegistration(comboBox_select_batch.SelectedItem?.ToString());
            A.ComboBoxValue = comboBox_select_batch.Text;
            A.ShowDialog();*/

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            StudentHome obj = new StudentHome();
            this.Close();
            obj.ShowDialog();
        }
    }
}
