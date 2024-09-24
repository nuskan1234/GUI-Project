
namespace GUI_Project
{
    partial class StudentDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDashboard));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.lbl_batch = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_max = new FontAwesome.Sharp.IconButton();
            this.btn_min = new FontAwesome.Sharp.IconButton();
            this.btn_close = new FontAwesome.Sharp.IconButton();
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
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lbl_tot = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.panel_att.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pane_lec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel_tot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.menuPanel.Controls.Add(this.lbl_batch);
            this.menuPanel.Controls.Add(this.lbl_name);
            this.menuPanel.Controls.Add(this.label3);
            this.menuPanel.Controls.Add(this.label2);
            this.menuPanel.Controls.Add(this.pictureBox2);
            this.menuPanel.Controls.Add(this.pictureBox1);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(314, 820);
            this.menuPanel.TabIndex = 0;
            // 
            // lbl_batch
            // 
            this.lbl_batch.AutoSize = true;
            this.lbl_batch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_batch.ForeColor = System.Drawing.Color.White;
            this.lbl_batch.Location = new System.Drawing.Point(114, 459);
            this.lbl_batch.Name = "lbl_batch";
            this.lbl_batch.Size = new System.Drawing.Size(78, 29);
            this.lbl_batch.TabIndex = 7;
            this.lbl_batch.Text = "Name";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(114, 363);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(78, 29);
            this.lbl_name.TabIndex = 6;
            this.lbl_name.Text = "Name";
            this.lbl_name.Click += new System.EventHandler(this.lbl_name_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Batch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(35, 137);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(227, 172);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
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
            this.panelTitleBar.Location = new System.Drawing.Point(314, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1084, 76);
            this.panelTitleBar.TabIndex = 4;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Student Dashboard";
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
            this.btn_max.Location = new System.Drawing.Point(993, 0);
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
            this.btn_min.Location = new System.Drawing.Point(952, 0);
            this.btn_min.Name = "btn_min";
            this.btn_min.Rotation = 0D;
            this.btn_min.Size = new System.Drawing.Size(45, 25);
            this.btn_min.TabIndex = 2;
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
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
            this.btn_close.Location = new System.Drawing.Point(1035, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Rotation = 0D;
            this.btn_close.Size = new System.Drawing.Size(45, 25);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = " X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            this.btn_close.Resize += new System.EventHandler(this.btn_close_Resize);
            // 
            // panel_att
            // 
            this.panel_att.BackColor = System.Drawing.Color.Pink;
            this.panel_att.Controls.Add(this.lbl_attendance);
            this.panel_att.Controls.Add(this.pictureBox4);
            this.panel_att.Controls.Add(this.lbl_att);
            this.panel_att.Location = new System.Drawing.Point(880, 499);
            this.panel_att.Name = "panel_att";
            this.panel_att.Size = new System.Drawing.Size(453, 267);
            this.panel_att.TabIndex = 7;
            // 
            // lbl_attendance
            // 
            this.lbl_attendance.AutoSize = true;
            this.lbl_attendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_attendance.Location = new System.Drawing.Point(150, 63);
            this.lbl_attendance.Name = "lbl_attendance";
            this.lbl_attendance.Size = new System.Drawing.Size(85, 29);
            this.lbl_attendance.TabIndex = 3;
            this.lbl_attendance.Text = "label4";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(18, 48);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 60);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            this.lbl_att.Size = new System.Drawing.Size(171, 29);
            this.lbl_att.TabIndex = 1;
            this.lbl_att.Text = "Lectures Held";
            // 
            // pane_lec
            // 
            this.pane_lec.BackColor = System.Drawing.Color.LightGreen;
            this.pane_lec.Controls.Add(this.lbl_lec_no);
            this.pane_lec.Controls.Add(this.pictureBox3);
            this.pane_lec.Controls.Add(this.lbl_lec);
            this.pane_lec.Location = new System.Drawing.Point(880, 125);
            this.pane_lec.Name = "pane_lec";
            this.pane_lec.Size = new System.Drawing.Size(453, 267);
            this.pane_lec.TabIndex = 6;
            // 
            // lbl_lec_no
            // 
            this.lbl_lec_no.AutoSize = true;
            this.lbl_lec_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lec_no.Location = new System.Drawing.Point(164, 65);
            this.lbl_lec_no.Name = "lbl_lec_no";
            this.lbl_lec_no.Size = new System.Drawing.Size(85, 29);
            this.lbl_lec_no.TabIndex = 3;
            this.lbl_lec_no.Text = "label3";
            this.lbl_lec_no.Click += new System.EventHandler(this.lbl_lec_no_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(19, 50);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            this.lbl_lec.Size = new System.Drawing.Size(112, 29);
            this.lbl_lec.TabIndex = 1;
            this.lbl_lec.Text = "Lectures";
            // 
            // panel_tot
            // 
            this.panel_tot.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel_tot.Controls.Add(this.lbl_std_tot);
            this.panel_tot.Controls.Add(this.pictureBox5);
            this.panel_tot.Controls.Add(this.lbl_tot);
            this.panel_tot.Location = new System.Drawing.Point(371, 125);
            this.panel_tot.Name = "panel_tot";
            this.panel_tot.Size = new System.Drawing.Size(453, 267);
            this.panel_tot.TabIndex = 5;
            this.panel_tot.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_tot_Paint);
            // 
            // lbl_std_tot
            // 
            this.lbl_std_tot.AutoSize = true;
            this.lbl_std_tot.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_std_tot.Location = new System.Drawing.Point(158, 63);
            this.lbl_std_tot.Name = "lbl_std_tot";
            this.lbl_std_tot.Size = new System.Drawing.Size(85, 29);
            this.lbl_std_tot.TabIndex = 2;
            this.lbl_std_tot.Text = "label2";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(10, 48);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(60, 60);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // lbl_tot
            // 
            this.lbl_tot.AutoSize = true;
            this.lbl_tot.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tot.ForeColor = System.Drawing.Color.White;
            this.lbl_tot.Location = new System.Drawing.Point(3, 16);
            this.lbl_tot.Name = "lbl_tot";
            this.lbl_tot.Size = new System.Drawing.Size(99, 29);
            this.lbl_tot.TabIndex = 0;
            this.lbl_tot.Text = "Module";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(371, 499);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 267);
            this.panel1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(158, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "label2";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(19, 48);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(60, 60);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Attended";
            // 
            // StudentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 820);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_att);
            this.Controls.Add(this.pane_lec);
            this.Controls.Add(this.panel_tot);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.menuPanel);
            this.Name = "StudentDashboard";
            this.Text = "StudentDashboard";
            this.Load += new System.EventHandler(this.StudentDashboard_Load);
            this.Resize += new System.EventHandler(this.StudentDashboard_Resize);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panel_att.ResumeLayout(false);
            this.panel_att.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pane_lec.ResumeLayout(false);
            this.pane_lec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel_tot.ResumeLayout(false);
            this.panel_tot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btn_max;
        private FontAwesome.Sharp.IconButton btn_min;
        private FontAwesome.Sharp.IconButton btn_close;
        private System.Windows.Forms.Panel panel_att;
        private System.Windows.Forms.Label lbl_attendance;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lbl_att;
        private System.Windows.Forms.Panel pane_lec;
        private System.Windows.Forms.Label lbl_lec_no;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbl_lec;
        private System.Windows.Forms.Panel panel_tot;
        private System.Windows.Forms.Label lbl_std_tot;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lbl_tot;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_batch;
        private System.Windows.Forms.Label lbl_name;
    }
}