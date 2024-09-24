
namespace GUI_Project
{
    partial class SelectBatch
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
            this.comboBox_select_batch = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_head = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_select_batch
            // 
            this.comboBox_select_batch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBox_select_batch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_select_batch.FormattingEnabled = true;
            this.comboBox_select_batch.Items.AddRange(new object[] {
            "DSE",
            "DNE"});
            this.comboBox_select_batch.Location = new System.Drawing.Point(284, 159);
            this.comboBox_select_batch.Name = "comboBox_select_batch";
            this.comboBox_select_batch.Size = new System.Drawing.Size(209, 37);
            this.comboBox_select_batch.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.label_head);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 56);
            this.panel1.TabIndex = 1;
            // 
            // label_head
            // 
            this.label_head.AutoSize = true;
            this.label_head.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_head.Location = new System.Drawing.Point(215, 9);
            this.label_head.Name = "label_head";
            this.label_head.Size = new System.Drawing.Size(347, 35);
            this.label_head.TabIndex = 0;
            this.label_head.Text = "Select the batch first ";
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.Location = new System.Drawing.Point(316, 262);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(148, 37);
            this.btn_next.TabIndex = 2;
            this.btn_next.Text = "Next   >";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Controls.Add(this.btn_back);
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 403);
            this.panel2.TabIndex = 3;
            // 
            // btn_back
            // 
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.DimGray;
            this.btn_back.Location = new System.Drawing.Point(713, 30);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 33);
            this.btn_back.TabIndex = 11;
            this.btn_back.Text = "<<back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // SelectBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox_select_batch);
            this.Controls.Add(this.panel2);
            this.Name = "SelectBatch";
            this.Text = "SelectBatch";
            this.Load += new System.EventHandler(this.SelectBatch_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_select_batch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_head;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_back;
    }
}