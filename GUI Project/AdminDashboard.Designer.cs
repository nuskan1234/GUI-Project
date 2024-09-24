
namespace GUI_Project
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_rep = new FontAwesome.Sharp.IconButton();
            this.btn_mod = new FontAwesome.Sharp.IconButton();
            this.btn_batch = new FontAwesome.Sharp.IconButton();
            this.btn_logout = new FontAwesome.Sharp.IconButton();
            this.btn_std = new FontAwesome.Sharp.IconButton();
            this.btn_scan = new FontAwesome.Sharp.IconButton();
            this.btn_qr = new FontAwesome.Sharp.IconButton();
            this.btn_home = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_bar = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_max = new FontAwesome.Sharp.IconButton();
            this.btn_min = new FontAwesome.Sharp.IconButton();
            this.btn_close = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel_att = new System.Windows.Forms.Panel();
            this.lbl_attendance = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lbl_att = new System.Windows.Forms.Label();
            this.pane_lec = new System.Windows.Forms.Panel();
            this.lbl_lec_no = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_lec = new System.Windows.Forms.Label();
            this.panel_tot = new System.Windows.Forms.Panel();
            this.lbl_std_tot = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_tot = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel_att.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pane_lec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel_tot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMenu.Controls.Add(this.btn_rep);
            this.panelMenu.Controls.Add(this.btn_mod);
            this.panelMenu.Controls.Add(this.btn_batch);
            this.panelMenu.Controls.Add(this.btn_logout);
            this.panelMenu.Controls.Add(this.btn_std);
            this.panelMenu.Controls.Add(this.btn_scan);
            this.panelMenu.Controls.Add(this.btn_qr);
            this.panelMenu.Controls.Add(this.btn_home);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(239, 709);
            this.panelMenu.TabIndex = 0;
            // 
            // btn_rep
            // 
            this.btn_rep.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_rep.FlatAppearance.BorderSize = 0;
            this.btn_rep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rep.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_rep.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rep.ForeColor = System.Drawing.Color.White;
            this.btn_rep.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.btn_rep.IconColor = System.Drawing.Color.White;
            this.btn_rep.IconSize = 30;
            this.btn_rep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_rep.Location = new System.Drawing.Point(0, 390);
            this.btn_rep.Name = "btn_rep";
            this.btn_rep.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_rep.Rotation = 0D;
            this.btn_rep.Size = new System.Drawing.Size(235, 46);
            this.btn_rep.TabIndex = 9;
            this.btn_rep.Tag = "Student";
            this.btn_rep.Text = "    Report";
            this.btn_rep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_rep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_rep.UseVisualStyleBackColor = true;
            // 
            // btn_mod
            // 
            this.btn_mod.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_mod.FlatAppearance.BorderSize = 0;
            this.btn_mod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mod.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_mod.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mod.ForeColor = System.Drawing.Color.White;
            this.btn_mod.IconChar = FontAwesome.Sharp.IconChar.File;
            this.btn_mod.IconColor = System.Drawing.Color.White;
            this.btn_mod.IconSize = 30;
            this.btn_mod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mod.Location = new System.Drawing.Point(0, 344);
            this.btn_mod.Name = "btn_mod";
            this.btn_mod.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_mod.Rotation = 0D;
            this.btn_mod.Size = new System.Drawing.Size(235, 46);
            this.btn_mod.TabIndex = 8;
            this.btn_mod.Tag = "Student";
            this.btn_mod.Text = "    Module";
            this.btn_mod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_mod.UseVisualStyleBackColor = true;
            // 
            // btn_batch
            // 
            this.btn_batch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_batch.FlatAppearance.BorderSize = 0;
            this.btn_batch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_batch.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_batch.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_batch.ForeColor = System.Drawing.Color.White;
            this.btn_batch.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            this.btn_batch.IconColor = System.Drawing.Color.White;
            this.btn_batch.IconSize = 30;
            this.btn_batch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_batch.Location = new System.Drawing.Point(0, 298);
            this.btn_batch.Name = "btn_batch";
            this.btn_batch.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_batch.Rotation = 0D;
            this.btn_batch.Size = new System.Drawing.Size(235, 46);
            this.btn_batch.TabIndex = 7;
            this.btn_batch.Tag = "Student";
            this.btn_batch.Text = "    Batch";
            this.btn_batch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_batch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_batch.UseVisualStyleBackColor = true;
            // 
            // btn_logout
            // 
            this.btn_logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_logout.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btn_logout.IconColor = System.Drawing.Color.White;
            this.btn_logout.IconSize = 30;
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Location = new System.Drawing.Point(0, 659);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_logout.Rotation = 0D;
            this.btn_logout.Size = new System.Drawing.Size(235, 46);
            this.btn_logout.TabIndex = 6;
            this.btn_logout.Tag = "LogOut";
            this.btn_logout.Text = "    LogOut";
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_std
            // 
            this.btn_std.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_std.FlatAppearance.BorderSize = 0;
            this.btn_std.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_std.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_std.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_std.ForeColor = System.Drawing.Color.White;
            this.btn_std.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            this.btn_std.IconColor = System.Drawing.Color.White;
            this.btn_std.IconSize = 30;
            this.btn_std.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_std.Location = new System.Drawing.Point(0, 252);
            this.btn_std.Name = "btn_std";
            this.btn_std.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_std.Rotation = 0D;
            this.btn_std.Size = new System.Drawing.Size(235, 46);
            this.btn_std.TabIndex = 3;
            this.btn_std.Tag = "Student";
            this.btn_std.Text = "    Student";
            this.btn_std.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_std.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_std.UseVisualStyleBackColor = true;
            // 
            // btn_scan
            // 
            this.btn_scan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_scan.FlatAppearance.BorderSize = 0;
            this.btn_scan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_scan.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_scan.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_scan.ForeColor = System.Drawing.Color.White;
            this.btn_scan.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btn_scan.IconColor = System.Drawing.Color.White;
            this.btn_scan.IconSize = 30;
            this.btn_scan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_scan.Location = new System.Drawing.Point(0, 206);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_scan.Rotation = 0D;
            this.btn_scan.Size = new System.Drawing.Size(235, 46);
            this.btn_scan.TabIndex = 2;
            this.btn_scan.Tag = "Scan";
            this.btn_scan.Text = "    Scan";
            this.btn_scan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_scan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_scan.UseVisualStyleBackColor = true;
            // 
            // btn_qr
            // 
            this.btn_qr.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_qr.FlatAppearance.BorderSize = 0;
            this.btn_qr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_qr.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_qr.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_qr.ForeColor = System.Drawing.Color.White;
            this.btn_qr.IconChar = FontAwesome.Sharp.IconChar.Qrcode;
            this.btn_qr.IconColor = System.Drawing.Color.White;
            this.btn_qr.IconSize = 30;
            this.btn_qr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_qr.Location = new System.Drawing.Point(0, 160);
            this.btn_qr.Name = "btn_qr";
            this.btn_qr.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_qr.Rotation = 0D;
            this.btn_qr.Size = new System.Drawing.Size(235, 46);
            this.btn_qr.TabIndex = 1;
            this.btn_qr.Tag = "Qr code";
            this.btn_qr.Text = "    QR Code";
            this.btn_qr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_qr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_qr.UseVisualStyleBackColor = true;
            // 
            // btn_home
            // 
            this.btn_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_home.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btn_home.IconColor = System.Drawing.Color.White;
            this.btn_home.IconSize = 30;
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(0, 114);
            this.btn_home.Name = "btn_home";
            this.btn_home.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_home.Rotation = 0D;
            this.btn_home.Size = new System.Drawing.Size(235, 46);
            this.btn_home.TabIndex = 0;
            this.btn_home.Tag = "Home";
            this.btn_home.Text = "    Home";
            this.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_home.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_bar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 114);
            this.panel1.TabIndex = 0;
            // 
            // btn_bar
            // 
            this.btn_bar.FlatAppearance.BorderSize = 0;
            this.btn_bar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_bar.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.btn_bar.IconColor = System.Drawing.Color.White;
            this.btn_bar.IconSize = 30;
            this.btn_bar.Location = new System.Drawing.Point(173, 3);
            this.btn_bar.Name = "btn_bar";
            this.btn_bar.Rotation = 0D;
            this.btn_bar.Size = new System.Drawing.Size(60, 60);
            this.btn_bar.TabIndex = 0;
            this.btn_bar.UseVisualStyleBackColor = true;
            this.btn_bar.Click += new System.EventHandler(this.btn_bar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.Thistle;
            this.panelTitleBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTitleBar.Controls.Add(this.label1);
            this.panelTitleBar.Controls.Add(this.btn_max);
            this.panelTitleBar.Controls.Add(this.btn_min);
            this.panelTitleBar.Controls.Add(this.btn_close);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(239, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1105, 76);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            this.panelTitleBar.Resize += new System.EventHandler(this.panelTitleBar_Resize);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Admin Dashboard";
            // 
            // btn_max
            // 
            this.btn_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_max.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_max.FlatAppearance.BorderSize = 0;
            this.btn_max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_max.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_max.ForeColor = System.Drawing.Color.White;
            this.btn_max.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btn_max.IconColor = System.Drawing.Color.White;
            this.btn_max.IconSize = 20;
            this.btn_max.Location = new System.Drawing.Point(1014, 0);
            this.btn_max.Name = "btn_max";
            this.btn_max.Rotation = 0D;
            this.btn_max.Size = new System.Drawing.Size(45, 25);
            this.btn_max.TabIndex = 3;
            this.btn_max.Text = " ";
            this.btn_max.UseVisualStyleBackColor = false;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // btn_min
            // 
            this.btn_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_min.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_min.FlatAppearance.BorderSize = 0;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_min.ForeColor = System.Drawing.Color.White;
            this.btn_min.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btn_min.IconColor = System.Drawing.Color.White;
            this.btn_min.IconSize = 20;
            this.btn_min.Location = new System.Drawing.Point(973, 0);
            this.btn_min.Name = "btn_min";
            this.btn_min.Rotation = 0D;
            this.btn_min.Size = new System.Drawing.Size(45, 25);
            this.btn_min.TabIndex = 2;
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            this.btn_min.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_min_MouseDown);
            this.btn_min.Resize += new System.EventHandler(this.btn_min_Resize);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.DeepPink;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_close.IconColor = System.Drawing.Color.White;
            this.btn_close.IconSize = 20;
            this.btn_close.Location = new System.Drawing.Point(1056, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Rotation = 0D;
            this.btn_close.Size = new System.Drawing.Size(45, 25);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = " X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.Lavender;
            this.panelDesktop.Controls.Add(this.chart1);
            this.panelDesktop.Controls.Add(this.panel_att);
            this.panelDesktop.Controls.Add(this.pane_lec);
            this.panelDesktop.Controls.Add(this.panel_tot);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(239, 76);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panelDesktop.Size = new System.Drawing.Size(1105, 633);
            this.panelDesktop.TabIndex = 2;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(79, 236);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(742, 327);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title1.Name = "Title1";
            title1.Text = "Attendance";
            this.chart1.Titles.Add(title1);
            // 
            // panel_att
            // 
            this.panel_att.BackColor = System.Drawing.Color.HotPink;
            this.panel_att.Controls.Add(this.lbl_attendance);
            this.panel_att.Controls.Add(this.pictureBox4);
            this.panel_att.Controls.Add(this.lbl_att);
            this.panel_att.Location = new System.Drawing.Point(769, 48);
            this.panel_att.Name = "panel_att";
            this.panel_att.Size = new System.Drawing.Size(294, 159);
            this.panel_att.TabIndex = 2;
            // 
            // lbl_attendance
            // 
            this.lbl_attendance.AutoSize = true;
            this.lbl_attendance.Location = new System.Drawing.Point(150, 63);
            this.lbl_attendance.Name = "lbl_attendance";
            this.lbl_attendance.Size = new System.Drawing.Size(46, 17);
            this.lbl_attendance.TabIndex = 3;
            this.lbl_attendance.Text = "label4";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(8, 50);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // lbl_att
            // 
            this.lbl_att.AutoSize = true;
            this.lbl_att.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_att.ForeColor = System.Drawing.Color.White;
            this.lbl_att.Location = new System.Drawing.Point(3, 16);
            this.lbl_att.Name = "lbl_att";
            this.lbl_att.Size = new System.Drawing.Size(143, 29);
            this.lbl_att.TabIndex = 1;
            this.lbl_att.Text = "Attendance";
            // 
            // pane_lec
            // 
            this.pane_lec.BackColor = System.Drawing.Color.SpringGreen;
            this.pane_lec.Controls.Add(this.lbl_lec_no);
            this.pane_lec.Controls.Add(this.pictureBox3);
            this.pane_lec.Controls.Add(this.lbl_lec);
            this.pane_lec.Location = new System.Drawing.Point(406, 48);
            this.pane_lec.Name = "pane_lec";
            this.pane_lec.Size = new System.Drawing.Size(294, 159);
            this.pane_lec.TabIndex = 1;
            // 
            // lbl_lec_no
            // 
            this.lbl_lec_no.AutoSize = true;
            this.lbl_lec_no.Location = new System.Drawing.Point(164, 65);
            this.lbl_lec_no.Name = "lbl_lec_no";
            this.lbl_lec_no.Size = new System.Drawing.Size(46, 17);
            this.lbl_lec_no.TabIndex = 3;
            this.lbl_lec_no.Text = "label3";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(19, 50);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // lbl_lec
            // 
            this.lbl_lec.AutoSize = true;
            this.lbl_lec.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lec.ForeColor = System.Drawing.Color.White;
            this.lbl_lec.Location = new System.Drawing.Point(3, 16);
            this.lbl_lec.Name = "lbl_lec";
            this.lbl_lec.Size = new System.Drawing.Size(207, 29);
            this.lbl_lec.TabIndex = 1;
            this.lbl_lec.Text = "Today\'s Lectures";
            this.lbl_lec.Click += new System.EventHandler(this.lbl_lec_Click);
            // 
            // panel_tot
            // 
            this.panel_tot.BackColor = System.Drawing.Color.MediumPurple;
            this.panel_tot.Controls.Add(this.lbl_std_tot);
            this.panel_tot.Controls.Add(this.pictureBox2);
            this.panel_tot.Controls.Add(this.lbl_tot);
            this.panel_tot.Location = new System.Drawing.Point(29, 48);
            this.panel_tot.Name = "panel_tot";
            this.panel_tot.Size = new System.Drawing.Size(294, 159);
            this.panel_tot.TabIndex = 0;
            // 
            // lbl_std_tot
            // 
            this.lbl_std_tot.AutoSize = true;
            this.lbl_std_tot.Location = new System.Drawing.Point(158, 63);
            this.lbl_std_tot.Name = "lbl_std_tot";
            this.lbl_std_tot.Size = new System.Drawing.Size(46, 17);
            this.lbl_std_tot.TabIndex = 2;
            this.lbl_std_tot.Text = "label2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_tot
            // 
            this.lbl_tot.AutoSize = true;
            this.lbl_tot.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tot.ForeColor = System.Drawing.Color.White;
            this.lbl_tot.Location = new System.Drawing.Point(3, 16);
            this.lbl_tot.Name = "lbl_tot";
            this.lbl_tot.Size = new System.Drawing.Size(179, 29);
            this.lbl_tot.TabIndex = 0;
            this.lbl_tot.Text = "Total Students";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 709);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.Resize += new System.EventHandler(this.AdminDashboard_Resize);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel_att.ResumeLayout(false);
            this.panel_att.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pane_lec.ResumeLayout(false);
            this.pane_lec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel_tot.ResumeLayout(false);
            this.panel_tot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btn_bar;
        private FontAwesome.Sharp.IconButton btn_home;
        private FontAwesome.Sharp.IconButton btn_logout;
        private FontAwesome.Sharp.IconButton btn_std;
        private FontAwesome.Sharp.IconButton btn_scan;
        private FontAwesome.Sharp.IconButton btn_qr;
        private FontAwesome.Sharp.IconButton btn_close;
        private FontAwesome.Sharp.IconButton btn_max;
        private FontAwesome.Sharp.IconButton btn_min;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_tot;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel_att;
        private System.Windows.Forms.Panel pane_lec;
        private System.Windows.Forms.Label lbl_tot;
        private FontAwesome.Sharp.IconButton btn_rep;
        private FontAwesome.Sharp.IconButton btn_mod;
        private FontAwesome.Sharp.IconButton btn_batch;
        private System.Windows.Forms.Label lbl_att;
        private System.Windows.Forms.Label lbl_lec;
        private System.Windows.Forms.Label lbl_attendance;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lbl_lec_no;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbl_std_tot;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}