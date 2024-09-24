using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;
using System.Data.SqlClient;
using AForge.Video;


namespace GUI_Project
{
    public partial class QrScan : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection();
        FilterInfoCollection CaptureDevice;
        VideoCaptureDevice FinalFrame;
        
        public QrScan()
        {
            InitializeComponent();
            con.ConnectionString = "Data Source=DESKTOP-STADLEU;Initial Catalog=StudentAttendence;Integrated Security=True";
        }

        
        private void QrScan_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
                CMB_Device.Items.Add(Device.Name);
            CMB_Device.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();
        }

        private void btn_scan_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {

        }  
        private void QrScan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame.IsRunning == true)
                FinalFrame.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BarcodeReader reader = new BarcodeReader();
            Result result = reader.Decode((Bitmap)camPicturebox.Image);
            try
            {
                string decode = result.ToString().Trim();
                txt_id.Text = decode;
                if (decode != null)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "Select * from Student where S_id LIKE '% " + txt_id.Text + "";
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        txt_bid.Text = dr["Bid"].ToString();
                        txt_Sname.Text = dr["Sname"].ToString();
                        txt_add.Text = dr["Saddress"].ToString();
                        txt_tp.Text = dr["Tp"].ToString();
                        picker_DateTime.Text = dr["DOB"].ToString();


                    }
                    con.Close();
                }
            }
            catch(Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please Check Again ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            NewAdminDashboard obj = new NewAdminDashboard();
            this.Close();
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
            //open camera
            FinalFrame = new VideoCaptureDevice(CaptureDevice[CMB_Device.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            camPicturebox.Image = (Bitmap)eventArgs.Frame.Clone();
        }
    }
}