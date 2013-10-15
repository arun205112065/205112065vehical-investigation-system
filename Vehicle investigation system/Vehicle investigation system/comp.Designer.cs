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
            this.label1 = new System.Windows.Forms.Label();
            this.RNO = new System.Windows.Forms.TextBox();
            this.SUBMIT = new System.Windows.Forms.Button();
            this.HOME = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(203, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENTER YOUR REGISTRATION NO";
            // 
            // RNO
            // 
            this.RNO.Location = new System.Drawing.Point(357, 231);
            this.RNO.Name = "RNO";
            this.RNO.Size = new System.Drawing.Size(156, 20);
            this.RNO.TabIndex = 1;
            // 
            // SUBMIT
            // 
            this.SUBMIT.Location = new System.Drawing.Point(404, 289);
            this.SUBMIT.Name = "SUBMIT";
            this.SUBMIT.Size = new System.Drawing.Size(75, 23);
            this.SUBMIT.TabIndex = 2;
            this.SUBMIT.Text = "GO";
            this.SUBMIT.UseVisualStyleBackColor = true;
            this.SUBMIT.Click += new System.EventHandler(this.SUBMIT_Click);
            // 
            // HOME
            // 
            this.HOME.Location = new System.Drawing.Point(22, 23);
            this.HOME.Name = "HOME";
            this.HOME.Size = new System.Drawing.Size(72, 23);
            this.HOME.TabIndex = 3;
            this.HOME.Text = "HOME";
            this.HOME.UseVisualStyleBackColor = true;
            this.HOME.Click += new System.EventHandler(this.HOME_Click);
            // 
            // comp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 590);
            this.Controls.Add(this.HOME);
            this.Controls.Add(this.SUBMIT);
            this.Controls.Add(this.RNO);
            this.Controls.Add(this.label1);
            this.Name = "comp";
            this.Text = "com";
            this.Load += new System.EventHandler(this.com_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RNO;
        private System.Windows.Forms.Button SUBMIT;
        private System.Windows.Forms.Button HOME;
    }
}