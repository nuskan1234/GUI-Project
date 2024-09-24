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
    public partial class ModuleUpdate : MetroFramework.Forms.MetroForm
    {
        public ModuleUpdate()
        {
            InitializeComponent();
        }
        Module obj = new Module();
        private void ModuleUpdate_Load(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            txt_name.Clear();
            txt_name.Clear();
        }

        private void btn_min_Click(object sender, EventArgs e)
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

        private void btn_min_Click_1(object sender, EventArgs e)
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
                if (txt_mid.Text.Length == 0 || txt_name.Text.Length == 0 || txt_no_lecs.Text.Length == 0 )
                {
                    MetroFramework.MetroMessageBox.Show(this, "Fields cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    string query = "update Module set Mname= '" + txt_name.Text + "', No_of_lecs= '" + txt_no_lecs.Text + "' where Mid= '" + txt_mid.Text + "' ";
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
            catch (SqlException)
            {
                MetroFramework.MetroMessageBox.Show(this, "Database error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /* try
         {
             if (txt_mid.Text.Length == 0)
             {
                 MetroFramework.MetroMessageBox.Show(this, "Module ID cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
             }

             // Fetch the Module details from the database based on Module ID
             string moduleID = txt_mid.Text;
             DataTable moduleData = obj.GetModuleDetails(moduleID);

             if (moduleData.Rows.Count > 0)
             {
                 // Display the Module details in the textboxes
                 txt_name.Text = moduleData.Rows[0]["ModuleName"].ToString();
                 txt_no_lecs.Text = moduleData.Rows[0]["NumLectures"].ToString();
             }
             else
             {
                 MetroFramework.MetroMessageBox.Show(this, "Module not found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }

             if (txt_mid.Text.Length == 0 || txt_name.Text.Length == 0 || txt_no_lecs.Text.Length == 0)
             {
                 MetroFramework.MetroMessageBox.Show(this, "Fields cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
             }

             // Get the modified Module details from the textboxes
           //  string moduleID = txt_mid.Text;
             string moduleName = txt_name.Text;
             int numLectures = int.Parse(txt_no_lecs.Text);

             // Update the Module details in the database
             int rowsAffected = obj.UpdateModuleDetails(moduleID, moduleName, numLectures);

             if (rowsAffected > 0)
             {
                 MetroFramework.MetroMessageBox.Show(this, "Data updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             else
             {
                 MetroFramework.MetroMessageBox.Show(this, "Data cannot be updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }
         catch (Exception ex)
         {
             MetroFramework.MetroMessageBox.Show(this, "Error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }*/

    }

    }


    

