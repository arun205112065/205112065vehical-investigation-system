namespace Vehicle_investigation_system
{
    partial class comp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(comp));
            this.label1 = new System.Windows.Forms.Label();
            this.RNO = new System.Windows.Forms.TextBox();
            this.SUBMIT = new System.Windows.Forms.Button();
            this.HOME = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DATE = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(217, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO COMPLAINT FORM";
            // 
            // RNO
            // 
            this.RNO.Location = new System.Drawing.Point(378, 366);
            this.RNO.Name = "RNO";
            this.RNO.Size = new System.Drawing.Size(200, 20);
            this.RNO.TabIndex = 1;
            this.RNO.TextChanged += new System.EventHandler(this.RNO_TextChanged);
            // 
            // SUBMIT
            // 
            this.SUBMIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUBMIT.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SUBMIT.Location = new System.Drawing.Point(378, 483);
            this.SUBMIT.Name = "SUBMIT";
            this.SUBMIT.Size = new System.Drawing.Size(75, 23);
            this.SUBMIT.TabIndex = 2;
            this.SUBMIT.Text = "GO";
            this.SUBMIT.UseVisualStyleBackColor = true;
            this.SUBMIT.Click += new System.EventHandler(this.SUBMIT_Click);
            // 
            // HOME
            // 
            this.HOME.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.HOME.Location = new System.Drawing.Point(22, 23);
            this.HOME.Name = "HOME";
            this.HOME.Size = new System.Drawing.Size(72, 30);
            this.HOME.TabIndex = 3;
            this.HOME.Text = "HOME";
            this.HOME.UseVisualStyleBackColor = true;
            this.HOME.Click += new System.EventHandler(this.HOME_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(163, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ENTER REGISTRATION NO";
            // 
            // DATE
            // 
            this.DATE.CalendarMonthBackground = System.Drawing.SystemColors.ControlLight;
            this.DATE.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.DATE.CalendarTitleForeColor = System.Drawing.SystemColors.ControlText;
            this.DATE.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlText;
            this.DATE.Location = new System.Drawing.Point(378, 414);
            this.DATE.Name = "DATE";
            this.DATE.Size = new System.Drawing.Size(200, 20);
            this.DATE.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(163, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ENTER DATE OF STOLEN";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button3.Location = new System.Drawing.Point(478, 483);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "EXIT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(357, 184);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 114);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(685, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(111, 95);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // comp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 590);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DATE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HOME);
            this.Controls.Add(this.SUBMIT);
            this.Controls.Add(this.RNO);
            this.Controls.Add(this.label1);
            this.Name = "comp";
            this.Text = "com";
            this.Load += new System.EventHandler(this.com_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RNO;
        private System.Windows.Forms.Button SUBMIT;
        private System.Windows.Forms.Button HOME;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DATE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}