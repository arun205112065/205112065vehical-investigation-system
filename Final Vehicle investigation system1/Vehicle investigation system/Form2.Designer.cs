namespace Vehicle_investigation_system
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.VEHICLE = new System.Windows.Forms.TextBox();
            this.WHEELER = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TEXTBOX = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TEXTBOX22 = new System.Windows.Forms.Label();
            this.CHECHIS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TEXTBOX6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TECCC = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.HOME = new System.Windows.Forms.Button();
            this.RESET = new System.Windows.Forms.Button();
            this.SUBMIT = new System.Windows.Forms.Button();
            this.ADDR = new System.Windows.Forms.TextBox();
            this.MOB = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.NAME = new System.Windows.Forms.TextBox();
            this.TYPE = new System.Windows.Forms.ComboBox();
            this.RELATION = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(228, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRATION FORM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // VEHICLE
            // 
            this.VEHICLE.Location = new System.Drawing.Point(332, 205);
            this.VEHICLE.MaxLength = 15;
            this.VEHICLE.Name = "VEHICLE";
            this.VEHICLE.Size = new System.Drawing.Size(194, 20);
            this.VEHICLE.TabIndex = 1;
            this.VEHICLE.TextChanged += new System.EventHandler(this.VEHICLE_TextChanged);
            // 
            // WHEELER
            // 
            this.WHEELER.Location = new System.Drawing.Point(332, 248);
            this.WHEELER.MaxLength = 2;
            this.WHEELER.Name = "WHEELER";
            this.WHEELER.Size = new System.Drawing.Size(194, 20);
            this.WHEELER.TabIndex = 2;
            this.WHEELER.TextChanged += new System.EventHandler(this.WHEELER_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(37, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "ENTER VEHICLE DETAILS";
            // 
            // TEXTBOX
            // 
            this.TEXTBOX.AutoSize = true;
            this.TEXTBOX.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TEXTBOX.Location = new System.Drawing.Point(191, 212);
            this.TEXTBOX.Name = "TEXTBOX";
            this.TEXTBOX.Size = new System.Drawing.Size(71, 13);
            this.TEXTBOX.TabIndex = 5;
            this.TEXTBOX.Text = "VEHICLE NO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(191, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "NO OF WHEEL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(191, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "VEHICLE TYPE";
            // 
            // TEXTBOX22
            // 
            this.TEXTBOX22.AutoSize = true;
            this.TEXTBOX22.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TEXTBOX22.Location = new System.Drawing.Point(191, 340);
            this.TEXTBOX22.Name = "TEXTBOX22";
            this.TEXTBOX22.Size = new System.Drawing.Size(73, 13);
            this.TEXTBOX22.TabIndex = 8;
            this.TEXTBOX22.Text = "CHECHIS NO";
            this.TEXTBOX22.Click += new System.EventHandler(this.label3_Click);
            // 
            // CHECHIS
            // 
            this.CHECHIS.Location = new System.Drawing.Point(332, 333);
            this.CHECHIS.MaxLength = 10;
            this.CHECHIS.Name = "CHECHIS";
            this.CHECHIS.Size = new System.Drawing.Size(194, 20);
            this.CHECHIS.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(37, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "ENTER PERSONAL DETAILS";
            // 
            // TEXTBOX6
            // 
            this.TEXTBOX6.AutoSize = true;
            this.TEXTBOX6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TEXTBOX6.Location = new System.Drawing.Point(191, 434);
            this.TEXTBOX6.Name = "TEXTBOX6";
            this.TEXTBOX6.Size = new System.Drawing.Size(38, 13);
            this.TEXTBOX6.TabIndex = 11;
            this.TEXTBOX6.Text = "NAME";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(191, 543);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "MOBILE NO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(191, 472);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "RELATION TO NITT";
            // 
            // TECCC
            // 
            this.TECCC.AutoSize = true;
            this.TECCC.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TECCC.Location = new System.Drawing.Point(191, 508);
            this.TECCC.Name = "TECCC";
            this.TECCC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TECCC.Size = new System.Drawing.Size(65, 13);
            this.TECCC.TabIndex = 13;
            this.TECCC.Text = "NITT ID NO";
            this.TECCC.Click += new System.EventHandler(this.label9_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(191, 586);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "ADDRESS";
            // 
            // HOME
            // 
            this.HOME.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.HOME.Location = new System.Drawing.Point(16, 12);
            this.HOME.Name = "HOME";
            this.HOME.Size = new System.Drawing.Size(75, 23);
            this.HOME.TabIndex = 22;
            this.HOME.Text = "HOME";
            this.HOME.UseVisualStyleBackColor = true;
            this.HOME.Click += new System.EventHandler(this.HOME_Click);
            // 
            // RESET
            // 
            this.RESET.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RESET.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.RESET.Location = new System.Drawing.Point(451, 666);
            this.RESET.Name = "RESET";
            this.RESET.Size = new System.Drawing.Size(75, 23);
            this.RESET.TabIndex = 21;
            this.RESET.Text = "RESET";
            this.RESET.UseVisualStyleBackColor = true;
            this.RESET.Click += new System.EventHandler(this.RESET_Click);
            // 
            // SUBMIT
            // 
            this.SUBMIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUBMIT.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SUBMIT.Location = new System.Drawing.Point(332, 666);
            this.SUBMIT.Name = "SUBMIT";
            this.SUBMIT.Size = new System.Drawing.Size(75, 23);
            this.SUBMIT.TabIndex = 20;
            this.SUBMIT.Text = "SUBMIT";
            this.SUBMIT.UseVisualStyleBackColor = true;
            this.SUBMIT.Click += new System.EventHandler(this.SUBMIT_Click);
            // 
            // ADDR
            // 
            this.ADDR.Location = new System.Drawing.Point(332, 579);
            this.ADDR.MaxLength = 30;
            this.ADDR.Name = "ADDR";
            this.ADDR.Size = new System.Drawing.Size(194, 20);
            this.ADDR.TabIndex = 15;
            // 
            // MOB
            // 
            this.MOB.Location = new System.Drawing.Point(332, 536);
            this.MOB.MaxLength = 10;
            this.MOB.Name = "MOB";
            this.MOB.Size = new System.Drawing.Size(194, 20);
            this.MOB.TabIndex = 16;
            this.MOB.TextChanged += new System.EventHandler(this.MOB_TextChanged);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(332, 501);
            this.ID.MaxLength = 10;
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(194, 20);
            this.ID.TabIndex = 17;
            this.ID.TextChanged += new System.EventHandler(this.ID_TextChanged);
            // 
            // NAME
            // 
            this.NAME.Location = new System.Drawing.Point(332, 427);
            this.NAME.MaxLength = 20;
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(194, 20);
            this.NAME.TabIndex = 19;
            // 
            // TYPE
            // 
            this.TYPE.FormattingEnabled = true;
            this.TYPE.Items.AddRange(new object[] {
            "cycle",
            "bike",
            "car",
            "bus"});
            this.TYPE.Location = new System.Drawing.Point(332, 289);
            this.TYPE.MaxLength = 10;
            this.TYPE.Name = "TYPE";
            this.TYPE.Size = new System.Drawing.Size(194, 21);
            this.TYPE.TabIndex = 23;
            // 
            // RELATION
            // 
            this.RELATION.FormattingEnabled = true;
            this.RELATION.Items.AddRange(new object[] {
            "student",
            "employee",
            "worker"});
            this.RELATION.Location = new System.Drawing.Point(332, 464);
            this.RELATION.MaxLength = 10;
            this.RELATION.Name = "RELATION";
            this.RELATION.Size = new System.Drawing.Size(194, 21);
            this.RELATION.TabIndex = 24;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button3.Location = new System.Drawing.Point(564, 666);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "EXIT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(646, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(111, 95);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(781, 750);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.RELATION);
            this.Controls.Add(this.TYPE);
            this.Controls.Add(this.HOME);
            this.Controls.Add(this.RESET);
            this.Controls.Add(this.SUBMIT);
            this.Controls.Add(this.NAME);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.MOB);
            this.Controls.Add(this.ADDR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TECCC);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TEXTBOX6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CHECHIS);
            this.Controls.Add(this.TEXTBOX22);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TEXTBOX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WHEELER);
            this.Controls.Add(this.VEHICLE);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "form2";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox VEHICLE;
        private System.Windows.Forms.TextBox WHEELER;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TEXTBOX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TEXTBOX22;
        private System.Windows.Forms.TextBox CHECHIS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TEXTBOX6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label TECCC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button HOME;
        private System.Windows.Forms.Button RESET;
        private System.Windows.Forms.Button SUBMIT;
        private System.Windows.Forms.TextBox ADDR;
        private System.Windows.Forms.TextBox MOB;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox NAME;
        private System.Windows.Forms.ComboBox TYPE;
        private System.Windows.Forms.ComboBox RELATION;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}