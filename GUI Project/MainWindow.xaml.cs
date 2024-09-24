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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MaterialDesignThemes.Wpf;
using System.Data.SqlClient;
using System.Data;

namespace GUI_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string UserName { get; private set; }
        private StudentRegistration StudentRegistration;
        public MainWindow()
        {
            InitializeComponent();
            this.StudentRegistration = StudentRegistration;
           
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-STADLEU;Initial Catalog=StudentAttendence;Integrated Security=True");
        SqlDataAdapter da;
        public bool isdarktheme { get; set; }
        private readonly PaletteHelper paletteHelper = new PaletteHelper();

        private void toggleTheme(object sender, RoutedEventArgs e)
        {
            ITheme theme = paletteHelper.GetTheme();

           if (isdarktheme = theme.GetBaseTheme() == BaseTheme.Dark)
            {
                isdarktheme = false;
                theme.SetBaseTheme(Theme.Light);
            }
            else
            {
                isdarktheme = true;
                theme.SetBaseTheme(Theme.Dark);
            }
            paletteHelper.SetTheme(theme);
        }

        private void exitapp(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }

        private void btn_admin_Click(object sender, RoutedEventArgs e)
        {

            adminlogin obj = new adminlogin();
            this.Hide();
            obj.Show();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            


            
        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            /*  var studentDashboardForm= new GUI_Project.StudentDashboard();
             studentDashboardForm.ShowDialog();*/

            /*  StudentRegistration obj = new StudentRegistration();
              obj.ShowDialog();*/

            /*  QrScan obj = new QrScan();
              obj.ShowDialog();*/
           try
           {
                if (txt_username.Text.Length == 0 || txt_password.Password.Length == 0)
                {
                    MessageBox.Show("Username or Password cannot be blank", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }

                string query = "SELECT * from Student where S_id= '" + txt_username.Text.ToString() + "' AND Password = '" + txt_password.Password + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);

                DataTable dtable = new DataTable();
                da.Fill((dtable));

                if(dtable.Rows.Count >0)
                {
                    UserName = txt_username.Text;

                    StudentDashboard obj = new StudentDashboard();
                    this.Hide();
                    obj.ShowDialog();
                    
                }
                else
                {
                    System.Console.WriteLine("Test1");
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    txt_username.Clear();
                    txt_password.Clear();
                }
            }
            catch(Exception ex)
           {
                MessageBox.Show(ex.Message.ToString());
                MessageBox.Show("Please check again", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
           }

            
           

        }
    }
}
