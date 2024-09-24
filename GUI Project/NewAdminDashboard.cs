using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace GUI_Project
{
    public partial class NewAdminDashboard : Form
    {
        private int borderSize = 2;
        public NewAdminDashboard()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);
           // this.BackColor = Color.FromArgb(103, 58, 183);

        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-STADLEU;Initial Catalog=StudentAttendence;Integrated Security=True");

        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wPara, int lParam);



        private void iconButton_Scan_qr_Click(object sender, EventArgs e)
        {

        }

        private void titlepanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        protected override void WndProc(ref Message m)
        {


            const int WM_NCCALASIZE = 0x0083;

            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;

            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right

           

            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          

                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion

            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }



            base.WndProc(ref m);
        }

        private void NewAdminDashboard_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }

        private void barIcon_Click(object sender, EventArgs e)
        {
            CollapseMenu();

        }

        private void CollapseMenu()
        {
            if (this.panel1.Width > 200)
            {
                panel1.Width = 100;
                pictureBox1.Visible = false;
                barIcon.Dock = DockStyle.Top;
                foreach (Button menuButton in panel1.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            {
                panel1.Width = 230;
                pictureBox1.Visible = true;
                barIcon.Dock = DockStyle.None;
                foreach (Button menuButton in panel1.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            
            /* var mainform = new GUI_Project.MainWindow();
             mainform.ShowDialog();*/
              MainWindow loginform = new MainWindow();
            this.Close();
            loginform.ShowDialog();
           /* StudentRegistration regis = new StudentRegistration();
            regis.ShowDialog();*/

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnscan_Click(object sender, EventArgs e)
        {
            QrScan obj = new QrScan();
            this.Hide();
            obj.ShowDialog();
        }

        private void btnST_Click(object sender, EventArgs e)
        {
            StudentHome obj = new StudentHome();
            this.Hide();
            obj.ShowDialog();
        }

        private void btnBatch_Click(object sender, EventArgs e)
        {
            BatchHome obj = new BatchHome();
            obj.ShowDialog();
        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            ModuleHome obj = new ModuleHome();
            this.Hide();
            obj.ShowDialog();
        }

        private void btnrep_Click(object sender, EventArgs e)
        {
            Report obj = new Report();
            this.Hide();
            obj.ShowDialog();
        }

        private void btn_dura_Click(object sender, EventArgs e)
        {
            ModuleDuration obj = new ModuleDuration();
            this.Hide();
            obj.ShowDialog();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {

        }

        private void NewAdminDashboard_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("select count(*) from Student", con);
            DataTable dt = new DataTable();
            sda1.Fill(dt);
            lbl_std_tot.Text = dt.Rows[0][0].ToString();
           SqlDataAdapter sda2 = new SqlDataAdapter("SELECT SUM(Module.No_of_lecs) AS TotalLecture FROM Module JOIN BatchModule ON Module.Mid = BatchModule.Mid WHERE GETDATE() BETWEEN BatchModule.s_date AND BatchModule.e_date ",con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            lbl_lec_no.Text = dt2.Rows[0][0].ToString();
            con.Close();
        }
    }
}
