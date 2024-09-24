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
using System.ComponentModel;
using System.Threading;
using System.Windows.Threading;
using System.Windows.Forms;


namespace GUI_Project
{
    /// <summary>
    /// Interaction logic for splashscreen.xaml
    /// </summary>
    public partial class splashscreen : Window
    {
        readonly DispatcherTimer dispatcherTimer = new DispatcherTimer();

        public splashscreen()
        {
            InitializeComponent();
            dispatcherTimer.Tick += new EventHandler(MySplash);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 5);
            dispatcherTimer.Start();
            
        }
        private void MySplash(object sender, EventArgs e)
        {
             MainWindow main = new MainWindow();
              main.Show();
            

            dispatcherTimer.Stop();
            this.Close();
           // var adminDashboardForm = new GUI_Project.AdminDashboard();
           // adminDashboardForm.ShowDialog();
        }
       /* private void Window_ContentRendered(object sender, EventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += worker_DoWork;
            worker.ProgressChanged += worker_ProgressChanged;
            worker.RunWorkerAsync();
        }
        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                (sender as BackgroundWorker).ReportProgress(i);
                Thread.Sleep(80);
            }
        }
        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            if (progressBar.Value == 100)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.ShowDialog();
                this.Close();
               
            }
        }*/

    }
}
