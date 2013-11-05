using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vehicle_investigation_system
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UNAME.Text != "" & PASS.Text != "")
            {
                if (UNAME.Text == "65" & PASS.Text == "65")
                {

                    MessageBox.Show("LOGIN SUCCESSFUL");
                    Form1 f = new Form1();
                    f.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("LOGIN FAILED");
                    UNAME.Text = "";
                    PASS.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Insert All Values");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UNAME.Text = "";
            PASS.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }
    }
}
