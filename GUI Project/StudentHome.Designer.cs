
namespace GUI_Project
{
    partial class StudentHome
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_del = new MetroFramework.Controls.MetroTile();
            this.btn_view = new MetroFramework.Controls.MetroTile();
            this.btn_up = new MetroFramework.Controls.MetroTile();
            this.btn_reg = new MetroFramework.Controls.MetroTile();
            this.btn_max = new FontAwesome.Sharp.IconButton();
            this.btn_min = new FontAwesome.Sharp.IconButton();
            this.btn_close = new FontAwesome.Sharp.IconButton();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.btn_del);
            this.panel1.Controls.Add(this.btn_view);
            this.panel1.Controls.Add(this.btn_up);
            this.panel1.Controls.Add(this.btn_reg);
            this.panel1.Location = new System.Drawing.Point(25, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 576);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_del
            // 
            this.btn_del.ActiveControl = null;
            this.btn_del.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_del.Location = new System.Drawing.Point(532, 216);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(340, 120);
            this.btn_del.TabIndex = 3;
            this.btn_del.Text = "Delete Student";
            this.btn_del.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_del.UseCustomBackColor = true;
            this.btn_del.UseCustomForeColor = true;
            this.btn_del.UseSelectable = true;
            this.btn_del.UseStyleColors = true;
            this.btn_del.UseTileImage = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_view
            // 
            this.btn_view.ActiveControl = null;
            this.btn_view.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_view.Location = new System.Drawing.Point(532, 368);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(340, 120);
            this.btn_view.TabIndex = 2;
            this.btn_view.Text = "Student Information";
            this.btn_view.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_view.UseCustomBackColor = true;
            this.btn_view.UseCustomForeColor = true;
            this.btn_view.UseSelectable = true;
            this.btn_view.UseStyleColors = true;
            this.btn_view.UseTileImage = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // btn_up
            // 
            this.btn_up.ActiveControl = null;
            this.btn_up.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_up.Location = new System.Drawing.Point(532, 60);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(340, 120);
            this.btn_up.TabIndex = 1;
            this.btn_up.Text = "Update Student";
            this.btn_up.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_up.UseCustomBackColor = true;
            this.btn_up.UseCustomForeColor = true;
            this.btn_up.UseSelectable = true;
            this.btn_up.UseStyleColors = true;
            this.btn_up.UseTileImage = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_reg
            // 
            this.btn_reg.ActiveControl = null;
            this.btn_reg.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_reg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_reg.Location = new System.Drawing.Point(137, 60);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(345, 428);
            this.btn_reg.TabIndex = 0;
            this.btn_reg.Text = "Registration";
            this.btn_reg.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_reg.UseCustomBackColor = true;
            this.btn_reg.UseCustomForeColor = true;
            this.btn_reg.UseSelectable = true;
            this.btn_reg.UseStyleColors = true;
            this.btn_reg.UseTileImage = true;
            this.btn_reg.Click += new System.EventHandler(this.btn_reg_Click);
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
            this.btn_max.Location = new System.Drawing.Point(1071, 4);
            this.btn_max.Name = "btn_max";
            this.btn_max.Rotation = 0D;
            this.btn_max.Size = new System.Drawing.Size(45, 25);
            this.btn_max.TabIndex = 27;
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
            this.btn_min.Location = new System.Drawing.Point(1030, 4);
            this.btn_min.Name = "btn_min";
            this.btn_min.Rotation = 0D;
            this.btn_min.Size = new System.Drawing.Size(45, 25);
            this.btn_min.TabIndex = 26;
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
            this.btn_close.Location = new System.Drawing.Point(1113, 4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Rotation = 0D;
            this.btn_close.Size = new System.Drawing.Size(45, 25);
            this.btn_close.TabIndex = 25;
            this.btn_close.Text = " X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_back
            // 
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.DimGray;
            this.btn_back.Location = new System.Drawing.Point(1057, 46);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 33);
            this.btn_back.TabIndex = 28;
            this.btn_back.Text = "<<back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // StudentHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 684);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_max);
            this.Controls.Add(this.btn_min);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StudentHome";
            this.Padding = new System.Windows.Forms.Padding(22, 60, 22, 20);
            this.Text = "Student ";
            this.Load += new System.EventHandler(this.StudentHome_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTile btn_del;
        private MetroFramework.Controls.MetroTile btn_view;
        private MetroFramework.Controls.MetroTile btn_up;
        private MetroFramework.Controls.MetroTile btn_reg;
        private FontAwesome.Sharp.IconButton btn_max;
        private FontAwesome.Sharp.IconButton btn_min;
        private FontAwesome.Sharp.IconButton btn_close;
        private System.Windows.Forms.Button btn_back;
    }
}