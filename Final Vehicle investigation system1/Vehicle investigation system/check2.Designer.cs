namespace Vehicle_investigation_system
{
    partial class check2
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
            this.data = new System.Windows.Forms.DataGridView();
            this.HOME = new System.Windows.Forms.Button();
            this.BACK = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(44, 272);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(735, 111);
            this.data.TabIndex = 0;
            this.data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellContentClick);
            // 
            // HOME
            // 
            this.HOME.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.HOME.Location = new System.Drawing.Point(12, 26);
            this.HOME.Name = "HOME";
            this.HOME.Size = new System.Drawing.Size(75, 23);
            this.HOME.TabIndex = 1;
            this.HOME.Text = "HOME";
            this.HOME.UseVisualStyleBackColor = true;
            this.HOME.Click += new System.EventHandler(this.HOME_Click);
            // 
            // BACK
            // 
            this.BACK.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BACK.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BACK.Location = new System.Drawing.Point(12, 70);
            this.BACK.Name = "BACK";
            this.BACK.Size = new System.Drawing.Size(75, 23);
            this.BACK.TabIndex = 2;
            this.BACK.Text = "BACK";
            this.BACK.UseVisualStyleBackColor = true;
            this.BACK.Click += new System.EventHandler(this.BACK_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button3.Location = new System.Drawing.Point(12, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "EXIT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // check2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 535);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BACK);
            this.Controls.Add(this.HOME);
            this.Controls.Add(this.data);
            this.Name = "check2";
            this.Text = "check2";
            this.Load += new System.EventHandler(this.check2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Button HOME;
        private System.Windows.Forms.Button BACK;
        private System.Windows.Forms.Button button3;
    }
}