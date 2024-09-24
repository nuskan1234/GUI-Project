using System;
using QRCoder;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing.Imaging;
using System.Data.SqlClient;
using System.IO;
namespace GUI_Project
{
    public partial class StudentRegistration : MetroFramework.Forms.MetroForm
    {
       public string batch { get; set; }
       public string ComboBoxValue { get; set; }

        public string StudentID { get; private set; }
    public string Password { get; private set; }


        public StudentRegistration(string selectedBatch)
        {
            InitializeComponent();
            //public StudentRegistration(string selectedBatch)
            //this.ComboBoxValue = ComboBoxValue;
            //this.batch = batch;
            batch = selectedBatch;

        }

        public StudentRegistration()
        {
        }

        Student obj = new Student();
        SqlConnection con;
        SqlCommand cmd;

        private void StudentRegistration_Load(object sender, EventArgs e)
        {
           autoincri();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {









        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm())
                {
                    SaveDataToDatabase();
                    ShowSuccessMessageBox();
                }
            }
            catch (FormatException)
            {
                ShowErrorMessageBox("Please enter valid data.");
            }
            catch (SqlException a)
            {
                //ShowErrorMessageBox("Database error occurred.");
                MessageBox.Show(a.Message);
            }
           catch (Exception)
            {
                ShowErrorMessageBox("An error occurred. Please try again.");
                
            }
            autoincri();
        }

        private bool ValidateForm()
        {
            bool isValid = true;
            DateTime selectedDate = picker_DateTime.Value;
            DateTime currentDate = DateTime.Now;
            int minAge = 18;
            int maxAge = 50;
            DateTime minBirthDate = currentDate.AddYears(-maxAge);
            DateTime maxBirthDate = currentDate.AddYears(-minAge);

            if (string.IsNullOrEmpty(txt_Sname.Text) || txt_Sname.Text.Any(char.IsDigit))
            {
                ShowErrorMessageBox("Name cannot be blank or contain digits.");
                isValid = false;
            }
            else if (string.IsNullOrEmpty(txt_add.Text))
            {
                ShowErrorMessageBox("Address cannot be blank.");
                isValid = false;
            }
            else if (!Regex.IsMatch(txt_tp.Text, @"^(?:\+94|0)?(?:7[0125678]|9[0-9])[0-9]{7}$"))
            {
                ShowErrorMessageBox("Invalid telephone number.");
                isValid = false;
            }
            else if (!(selectedDate >= minBirthDate && selectedDate <= maxBirthDate))
            {
                ShowErrorMessageBox("Invalid date of birth.");
                isValid = false;
            }
            else if (txt_pw.Text.Length == 0)
            {
                ShowErrorMessageBox("Password cannot be blank.");
                isValid = false;
            }
            else if (txt_pw.Text.Length < 8)
            {
                ShowErrorMessageBox("Password must contain at least 8 characters.");
                isValid = false;
            }
            else
            {
                bool hasUppercase = false;
                bool hasLowercase = false;
                bool hasSpecialChar = false;
                bool hasDigit = false;

                foreach (char c in txt_pw.Text)
                {
                    if (char.IsUpper(c)) hasUppercase = true;
                    else if (char.IsLower(c)) hasLowercase = true;
                    else if (char.IsDigit(c)) hasDigit = true;
                    else hasSpecialChar = true;
                }

                if (!hasUppercase)
                {
                    ShowErrorMessageBox("Password must contain at least one uppercase letter.");
                    isValid = false;
                }
                else if (!hasLowercase)
                {
                    ShowErrorMessageBox("Password must contain at least one lowercase letter.");
                    isValid = false;
                }
                else if (!hasSpecialChar)
                {
                    ShowErrorMessageBox("Password must contain at least one special character.");
                    isValid = false;
                }
                else if (!hasDigit)
                {
                    ShowErrorMessageBox("Password must contain at least one digit.");
                    isValid = false;
                }
                else if (txt_pw.Text != txt_pwCon.Text)
                {
                    ShowErrorMessageBox("Confirmed password doesn't match the entered password.");
                    isValid = false;
                }
            }

            return isValid;
        }

        private void SaveDataToDatabase()
        {
            

            // Insert your data saving logic here.
            // Replace "query" with your actual SQL query for saving data to the database
           string query = "insert into Student(S_Id,Bid,Sname,Saddress,Tp,DOB,Password) values('" + txt_id.Text + "','" + txt_bid.Text + "','" + txt_Sname.Text + "','" + txt_add.Text + "','" + txt_tp.Text + "','" + picker_DateTime.Value + "','" + txt_pw.Text + "' )";
               int i = obj.Save_Update_Delete(query);
               if (i == 1)
               {
                   ShowInfoMessageBox("Data saved successfully.");
               }
               else
               {
                   ShowErrorMessageBox("Data cannot be saved.");
               } 


        }

        private void ShowSuccessMessageBox()
        {
            ShowInfoMessageBox("Registration successful.");
        }

        private void ShowInfoMessageBox(string message)
        {
            MetroFramework.MetroMessageBox.Show(this, message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowErrorMessageBox(string message)
        {
            MetroFramework.MetroMessageBox.Show(this, message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

       /* private void btn_reg_Click(object sender, EventArgs e)
        {

            try
            {
                bool isValid = true;
                StudentID = txt_id.Text;
                Password = txt_pw.Text;
                DateTime selectedDate = picker_DateTime.Value;
                DateTime currentDate = DateTime.Now;

                int minAge = 18;
                int maxAge = 50;

                DateTime minBirthDate = currentDate.AddYears(-maxAge);
                DateTime maxBirthDate = currentDate.AddYears(-minAge);
                if (string.IsNullOrEmpty(txt_Sname.Text) || txt_Sname.Text.Any(char.IsDigit))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Name cannot be blank or cannot contain digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(txt_add.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Address cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(!Regex.IsMatch(txt_tp.Text, @"^(?:\+94|0)?(?:7[0125678]|9[0-9])[0-9]{7}$"))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Invalid telephone numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                

                else if(!(selectedDate>= minBirthDate && selectedDate <= maxBirthDate))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Invalid date of birth", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                else if(txt_pw.Text.Length==0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Password cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (txt_pw.Text.Length < 8)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Password must contain at least 8 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isValid = false;
                }

                bool hasUppercase = false;
                bool hasLowercase = false;
                bool hasSpecialChar = false;
                bool hasDigit = false;

                foreach (char c in txt_pw.Text)
                {
                    if (char.IsUpper(c))
                    {
                        hasUppercase = true;
                    }
                    else if (char.IsLower(c))
                    {
                        hasLowercase = true;
                    }
                    else if (char.IsDigit(c))
                    {
                        hasDigit = true;
                    }
                    else
                    {
                        hasSpecialChar = true;
                    }
                }

              if (!hasUppercase)
              {
                    MetroFramework.MetroMessageBox.Show(this, "Password must contaion at least one uppercase letter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isValid = false;
              }

              else if (!hasLowercase)
              {
                 MetroFramework.MetroMessageBox.Show(this, "Password must contaion at least one lowercase letter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 isValid = false;
              }

               else if (!hasSpecialChar)
               {
                    MetroFramework.MetroMessageBox.Show(this, "Password must contaion at least one special character", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isValid = false;
               }

              else  if (!hasDigit)
              {
                    MetroFramework.MetroMessageBox.Show(this, "Password must contaion at least one digit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isValid = false;
              }
                else if(txt_pw.Text != txt_pwCon.Text)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Confirmed password doesn't match with the entered password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (isValid)
                {
                    // Proceed with further actions
                    ShowSuccessMessageBox();
                }

                else
                {
                    string query = "insert into Student values('" + txt_id.Text + "','" + txt_bid.Text + "','" + txt_Sname.Text + "','" + txt_add.Text + "','" + txt_tp.Text + "','" + picker_DateTime.Value + "','" + txt_pw.Text + "')";
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

            }
            catch (FormatException)
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

        private void ShowSuccessMessageBox()
        {
            MetroFramework.MetroMessageBox.Show(this, "Registration successful", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }*/

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

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
             Close();
              StudentHome obj = new StudentHome();
              obj.ShowDialog();
        }

        private void txt_bid_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
           /* // Generate QR code with student details
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(Guid.NewGuid().ToString(), QRCodeGenerator.ECCLevel.Q); // Generate a unique string for each QR code
            QRCode code = new QRCode(data);
            pictureBox1.Image = code.GetGraphic(5);

            // Convert the QR code image to a byte array
            byte[] qrCodeBytes;
            using (MemoryStream ms = new MemoryStream())
            {
                pictureBox1.Image.Save(ms, ImageFormat.Png);
                qrCodeBytes = ms.ToArray();
            }*/

            // Use qrCodeBytes or panelQ (whichever contains the appropriate QR code data)
           // qrCodeBytes = qrCodeBytes;


           /* QRCodeGenerator qr = new QRCodeGenerator();
              QRCodeData data = qr.CreateQrCode(Guid.NewGuid().ToString(), QRCodeGenerator.ECCLevel.Q); // Generate a unique string for each QR code
              QRCode code = new QRCode(data);
              pictureBox1.Image = code.GetGraphic(5);*/


            // Generate QR code with student details
             QRCodeGenerator qr = new QRCodeGenerator();
               QRCodeData data = qr.CreateQrCode(Guid.NewGuid().ToString(), QRCodeGenerator.ECCLevel.Q); // Generate a unique string for each QR code
               QRCode code = new QRCode(data);
               pictureBox1.Image = code.GetGraphic(5);

               // Convert the QR code image to a byte array
               byte[] qrCodeBytes;
               using (MemoryStream ms = new MemoryStream())
               {
                   pictureBox1.Image.Save(ms, ImageFormat.Png);
                   qrCodeBytes = ms.ToArray();
               }
               try
               {
                   string query = "INSERT INTO Student(S_id, Bid, Sname, Saddress,Tp,DOB,Username,  Password, Qr) VALUES (@StdID, @BatchID,@name, @Saddress,@TP,@DOB,, @Pass, @QRCode)";
                   SqlCommand cmd = new SqlCommand(query, con);
                   cmd.Parameters.AddWithValue("@StdID", txt_id.Text);
                   cmd.Parameters.AddWithValue("@BatchID,", txt_bid.Text);
                   cmd.Parameters.AddWithValue("@name,", txt_Sname.Text);
                   cmd.Parameters.AddWithValue("@Saddress", txt_add.Text);
                   cmd.Parameters.AddWithValue("@TP", txt_tp.Text);
                   cmd.Parameters.AddWithValue("@DOB",picker_DateTime.Value);
                  cmd.Parameters.AddWithValue("@Pass", txt_pw.Text);
                   cmd.Parameters.AddWithValue("@QRCode", qrCodeBytes);

                   int i = obj.Save_Update_Delete(query);
                   if (i == 1)
                   {
                       MetroFramework.MetroMessageBox.Show(this, "QR code generated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   }
                   else
                   {
                       MetroFramework.MetroMessageBox.Show(this, "Cannot generate QR code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   }
               }
               catch(Exception)
               {

               } 


        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PNG Image|*.png";
                saveFileDialog.Title = "Save QR Code";
                saveFileDialog.ShowDialog();
                if (saveFileDialog.FileName != "")
                {
                    pictureBox1.Image.Save(saveFileDialog.FileName, ImageFormat.Png);
                }
            }
        }

        private void btn_cls_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_bid.Clear();
            txt_Sname.Clear();
            txt_tp.Clear();
            txt_add.Clear();
            txt_pw.Clear();
            txt_pwCon.Clear();
            autoincri();
        }

        private void btn_closeEye_Click(object sender, EventArgs e)
        {
            if (txt_pw.PasswordChar == '\0')
            {
                btn_openEye.BringToFront();
                txt_pw.PasswordChar = '*';
            }
        }

        private void btn_openEye_Click(object sender, EventArgs e)
        {
            if(txt_pw.PasswordChar == '*')
            {
                btn_closeEye.BringToFront();
                txt_pw.PasswordChar ='\0';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_pwCon.PasswordChar == '*')
            {
                button1.BringToFront();
                txt_pwCon.PasswordChar = '\0';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_pwCon.PasswordChar == '\0')
            {
                button2.BringToFront();
                txt_pwCon.PasswordChar = '*';
            }
        }
        // private void autoincri()
        // {
        /* Student student = new Student();

         string query = "SELECT MAX(CAST(SUBSTRING(s_id, LEN(@ComboBoxValue) + 1, LEN(s_id)) AS INT)) FROM student WHERE s_id LIKE @ComboBoxValue + '%'";
         SqlCommand cmd = new SqlCommand(query, con);
         cmd.Parameters.AddWithValue("@ComboBoxValue", batch);
         //object result = cmd.ExecuteScalar();
         //con.Open();
         object result = cmd.ExecuteScalar();
         //con.Close();
         int maxId = (result == DBNull.Value) ? 0 : Convert.ToInt32(result);


         int newId = maxId + 1;
         txt_id.Text = batch + newId.ToString();*/

        // string batch = .Text; // Assuming comboBox_select_batch contains the selected batch

        // Create a new instance of the Student class to access the Save_Update_Delete method
        /* Student student = new Student();

         // Use the Save_Update_Delete method to execute the query and retrieve the result
         string query = "SELECT MAX(CAST(SUBSTRING(s_id, LEN(@ComboBoxValue) + 1, LEN(s_id)) AS INT)) FROM student WHERE s_id LIKE @ComboBoxValue + '%'";
         SqlCommand cmd = new SqlCommand(query,  con);
         cmd.Parameters.AddWithValue("@ComboBoxValue", batch);
         object result = cmd.ExecuteScalar();

         int maxId = (result == DBNull.Value || result == null) ? 0 : Convert.ToInt32(result);
         int newId = maxId + 1;
         txt_id.Text = batch + newId.ToString();*/
        private void autoincri()
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-STADLEU;Initial Catalog=StudentAttendence;Integrated Security=True"))
            {
                con.Open();

                string query = "SELECT MAX(CAST(SUBSTRING(s_id, LEN(@ComboBoxValue) + 1, LEN(s_id)) AS INT)) FROM student WHERE s_id LIKE @ComboBoxValue + '%'";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ComboBoxValue", batch);
                    object result = cmd.ExecuteScalar();
                    int maxId = (result == DBNull.Value || result == null) ? 0 : Convert.ToInt32(result);

                    int newId = maxId + 1;
                    txt_id.Text = batch + newId.ToString();
                }
            }
        }
    }
}
