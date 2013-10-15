namespace Vehicle_investigation_system
{
    partial class retrive
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
            this.rgno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rgno
            // 
            this.rgno.Location = new System.Drawing.Point(126, 113);
            this.rgno.Name = "rgno";
            this.rgno.Size = new System.Drawing.Size(75, 23);
            this.rgno.TabIndex = 0;
            this.rgno.Text = "registration no is";
            this.rgno.UseVisualStyleBackColor = true;
            this.rgno.Click += new System.EventHandler(this.rgno_Click);
            // 
            // retrive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 456);
            this.Controls.Add(this.rgno);
            this.Name = "retrive";
            this.Text = "retrive";
            this.Load += new System.EventHandler(this.retrive_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rgno;
    }
}