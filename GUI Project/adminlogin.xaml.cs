using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GUI_Project
{
    /// <summary>
    /// Interaction logic for adminlogin.xaml
    /// </summary>
    public partial class adminlogin : Window
    {
        public adminlogin()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            /* var newadminDashboardForm = new GUI_Project.NewAdminDashboard();
             newadminDashboardForm.ShowDialog();*/
            /*  NewAdminDashboard Admin = new NewAdminDashboard();
               Admin.ShowDialog();
               this.Close();*/

             if(txt_username.Text != "Admin")
             {
                 MessageBox.Show("Incorrect Password", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
             }
             else if(txt_password.Password != "Admin@123")
             {
                 MessageBox.Show("Incorrect Username", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
             }
             else
             {
               //  MessageBox.Show("Login Successful", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                

                 NewAdminDashboard admin = new NewAdminDashboard();
                this.Hide();
               admin.ShowDialog();
             }
            
            /* QrScan qr = new QrScan();
              qr.ShowDialog();*/
            //StudentRegistration std = new StudentRegistration();
            //std.ShowDialog();
            /*Report r = new Report();
            r.ShowDialog();*/
            /* SelectBatch s = new SelectBatch();
             s.ShowDialog();*/

        }


        private void btn_back(object sender, RoutedEventArgs e)
        {
            Close();
            MainWindow obj = new MainWindow();
            obj.Show();
        }
    }
}
