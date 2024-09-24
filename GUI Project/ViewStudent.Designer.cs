
namespace GUI_Project
{
    partial class ViewStudent
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
            this.components = new System.ComponentModel.Container();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btn_max = new FontAwesome.Sharp.IconButton();
            this.btn_min = new FontAwesome.Sharp.IconButton();
            this.btn_close = new FontAwesome.Sharp.IconButton();
            this.btn_back = new System.Windows.Forms.Button();
            this.rbn_id = new System.Windows.Forms.RadioButton();
            this.rbn_name = new System.Windows.Forms.RadioButton();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.StdDGV = new System.Windows.Forms.DataGridView();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentAttendenceDataSet = new GUI_Project.StudentAttendenceDataSet();
            this.studentRegistrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.studentTableAdapter = new GUI_Project.StudentAttendenceDataSetTableAdapters.StudentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.StdDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAttendenceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentRegistrationBindingSource)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.Location = new System.Drawing.Point(636, 104);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "View";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
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
            this.btn_max.Location = new System.Drawing.Point(1093, 4);
            this.btn_max.Name = "btn_max";
            this.btn_max.Rotation = 0D;
            this.btn_max.Size = new System.Drawing.Size(45, 25);
            this.btn_max.TabIndex = 9;
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
            this.btn_min.Location = new System.Drawing.Point(1052, 4);
            this.btn_min.Name = "btn_min";
            this.btn_min.Rotation = 0D;
            this.btn_min.Size = new System.Drawing.Size(45, 25);
            this.btn_min.TabIndex = 8;
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
            this.btn_close.Location = new System.Drawing.Point(1135, 4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Rotation = 0D;
            this.btn_close.Size = new System.Drawing.Size(45, 25);
            this.btn_close.TabIndex = 7;
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
            this.btn_back.Location = new System.Drawing.Point(1093, 35);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 33);
            this.btn_back.TabIndex = 10;
            this.btn_back.Text = "<<back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // rbn_id
            // 
            this.rbn_id.AutoSize = true;
            this.rbn_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbn_id.Location = new System.Drawing.Point(92, 77);
            this.rbn_id.Name = "rbn_id";
            this.rbn_id.Size = new System.Drawing.Size(107, 22);
            this.rbn_id.TabIndex = 11;
            this.rbn_id.TabStop = true;
            this.rbn_id.Text = "Student ID";
            this.rbn_id.UseVisualStyleBackColor = true;
            // 
            // rbn_name
            // 
            this.rbn_name.AutoSize = true;
            this.rbn_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbn_name.Location = new System.Drawing.Point(92, 127);
            this.rbn_name.Name = "rbn_name";
            this.rbn_name.Size = new System.Drawing.Size(135, 22);
            this.rbn_name.TabIndex = 12;
            this.rbn_name.TabStop = true;
            this.rbn_name.Text = "Student Name";
            this.rbn_name.UseVisualStyleBackColor = true;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(310, 104);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(167, 22);
            this.txt_search.TabIndex = 13;
            // 
            // StdDGV
            // 
            this.StdDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StdDGV.Location = new System.Drawing.Point(24, 20);
            this.StdDGV.Name = "StdDGV";
            this.StdDGV.RowHeadersWidth = 51;
            this.StdDGV.RowTemplate.Height = 24;
            this.StdDGV.Size = new System.Drawing.Size(918, 517);
            this.StdDGV.TabIndex = 2;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.studentAttendenceDataSet;
            // 
            // studentAttendenceDataSet
            // 
            this.studentAttendenceDataSet.DataSetName = "StudentAttendenceDataSet";
            this.studentAttendenceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentRegistrationBindingSource
            // 
            this.studentRegistrationBindingSource.DataSource = typeof(GUI_Project.StudentRegistration);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.SkyBlue;
            this.metroPanel1.Controls.Add(this.StdDGV);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(33, 182);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(971, 570);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // ViewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 791);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.rbn_name);
            this.Controls.Add(this.rbn_id);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_max);
            this.Controls.Add(this.btn_min);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroPanel1);
            this.Name = "ViewStudent";
            this.Text = "Student Details";
            this.Load += new System.EventHandler(this.ViewStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StdDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAttendenceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentRegistrationBindingSource)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButton1;
        private FontAwesome.Sharp.IconButton btn_max;
        private FontAwesome.Sharp.IconButton btn_min;
        private FontAwesome.Sharp.IconButton btn_close;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.RadioButton rbn_id;
        private System.Windows.Forms.RadioButton rbn_name;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.DataGridView StdDGV;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.BindingSource studentRegistrationBindingSource;
        private StudentAttendenceDataSet studentAttendenceDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private StudentAttendenceDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
    }
}