
namespace GUI_Project
{
    partial class ModuleDuration
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
            this.btn_max = new FontAwesome.Sharp.IconButton();
            this.btn_min = new FontAwesome.Sharp.IconButton();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_close = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cls = new MetroFramework.Controls.MetroButton();
            this.btn_add = new MetroFramework.Controls.MetroButton();
            this.txt_Mid = new MetroFramework.Controls.MetroTextBox();
            this.txt_id = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.SdateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.EdateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.btn_max.Location = new System.Drawing.Point(884, 4);
            this.btn_max.Name = "btn_max";
            this.btn_max.Rotation = 0D;
            this.btn_max.Size = new System.Drawing.Size(45, 25);
            this.btn_max.TabIndex = 24;
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
            this.btn_min.Location = new System.Drawing.Point(843, 4);
            this.btn_min.Name = "btn_min";
            this.btn_min.Rotation = 0D;
            this.btn_min.Size = new System.Drawing.Size(45, 25);
            this.btn_min.TabIndex = 23;
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_back
            // 
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.DimGray;
            this.btn_back.Location = new System.Drawing.Point(887, 35);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 33);
            this.btn_back.TabIndex = 21;
            this.btn_back.Text = "<<back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
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
            this.btn_close.Location = new System.Drawing.Point(926, 4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Rotation = 0D;
            this.btn_close.Size = new System.Drawing.Size(45, 25);
            this.btn_close.TabIndex = 22;
            this.btn_close.Text = " X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.EdateTimePicker2);
            this.panel1.Controls.Add(this.SdateTimePicker1);
            this.panel1.Controls.Add(this.metroLabel4);
            this.panel1.Controls.Add(this.btn_cls);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.txt_Mid);
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Location = new System.Drawing.Point(43, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 514);
            this.panel1.TabIndex = 20;
            // 
            // btn_cls
            // 
            this.btn_cls.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_cls.Location = new System.Drawing.Point(437, 450);
            this.btn_cls.Name = "btn_cls";
            this.btn_cls.Size = new System.Drawing.Size(75, 37);
            this.btn_cls.TabIndex = 15;
            this.btn_cls.Text = "Clear";
            this.btn_cls.UseSelectable = true;
            // 
            // btn_add
            // 
            this.btn_add.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_add.Location = new System.Drawing.Point(250, 450);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 37);
            this.btn_add.TabIndex = 14;
            this.btn_add.Text = "ADD";
            this.btn_add.UseSelectable = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_Mid
            // 
            // 
            // 
            // 
            this.txt_Mid.CustomButton.Image = null;
            this.txt_Mid.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txt_Mid.CustomButton.Name = "";
            this.txt_Mid.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Mid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Mid.CustomButton.TabIndex = 1;
            this.txt_Mid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Mid.CustomButton.UseSelectable = true;
            this.txt_Mid.CustomButton.Visible = false;
            this.txt_Mid.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_Mid.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txt_Mid.Lines = new string[0];
            this.txt_Mid.Location = new System.Drawing.Point(364, 158);
            this.txt_Mid.MaxLength = 32767;
            this.txt_Mid.Name = "txt_Mid";
            this.txt_Mid.PasswordChar = '\0';
            this.txt_Mid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Mid.SelectedText = "";
            this.txt_Mid.SelectionLength = 0;
            this.txt_Mid.SelectionStart = 0;
            this.txt_Mid.ShortcutsEnabled = true;
            this.txt_Mid.Size = new System.Drawing.Size(200, 23);
            this.txt_Mid.TabIndex = 12;
            this.txt_Mid.UseSelectable = true;
            this.txt_Mid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Mid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_id
            // 
            // 
            // 
            // 
            this.txt_id.CustomButton.Image = null;
            this.txt_id.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txt_id.CustomButton.Name = "";
            this.txt_id.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_id.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_id.CustomButton.TabIndex = 1;
            this.txt_id.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_id.CustomButton.UseSelectable = true;
            this.txt_id.CustomButton.Visible = false;
            this.txt_id.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_id.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txt_id.Lines = new string[0];
            this.txt_id.Location = new System.Drawing.Point(364, 69);
            this.txt_id.MaxLength = 32767;
            this.txt_id.Name = "txt_id";
            this.txt_id.PasswordChar = '\0';
            this.txt_id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_id.SelectedText = "";
            this.txt_id.SelectionLength = 0;
            this.txt_id.SelectionStart = 0;
            this.txt_id.ShortcutsEnabled = true;
            this.txt_id.Size = new System.Drawing.Size(200, 23);
            this.txt_id.TabIndex = 11;
            this.txt_id.UseSelectable = true;
            this.txt_id.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_id.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(93, 240);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(102, 25);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Start Date";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(93, 158);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(106, 25);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Module ID";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(96, 67);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(86, 25);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Batch ID";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(96, 337);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(92, 25);
            this.metroLabel4.TabIndex = 17;
            this.metroLabel4.Text = "End Date";
            // 
            // SdateTimePicker1
            // 
            this.SdateTimePicker1.Location = new System.Drawing.Point(364, 243);
            this.SdateTimePicker1.Name = "SdateTimePicker1";
            this.SdateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.SdateTimePicker1.TabIndex = 18;
            // 
            // EdateTimePicker2
            // 
            this.EdateTimePicker2.Location = new System.Drawing.Point(364, 337);
            this.EdateTimePicker2.Name = "EdateTimePicker2";
            this.EdateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.EdateTimePicker2.TabIndex = 19;
            // 
            // ModuleDuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 666);
            this.Controls.Add(this.btn_max);
            this.Controls.Add(this.btn_min);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.panel1);
            this.Name = "ModuleDuration";
            this.Text = "Module Duration";
            this.Load += new System.EventHandler(this.ModuleDuration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btn_max;
        private FontAwesome.Sharp.IconButton btn_min;
        private System.Windows.Forms.Button btn_back;
        private FontAwesome.Sharp.IconButton btn_close;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton btn_cls;
        private MetroFramework.Controls.MetroButton btn_add;
        private MetroFramework.Controls.MetroTextBox txt_Mid;
        private MetroFramework.Controls.MetroTextBox txt_id;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DateTimePicker EdateTimePicker2;
        private System.Windows.Forms.DateTimePicker SdateTimePicker1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}