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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            Hide();
        }

        private void CHECK_Click(object sender, EventArgs e)
        {
            check c = new check();
            c.Show();
            Hide();
        }

        private void NEW_Load(object sender, EventArgs e)
        {

        }

        private void FORGER_Click(object sender, EventArgs e)
        {
            forget f = new forget();
            f.Show();
            Hide();
        }

        private void REGISTER_Click(object sender, EventArgs e)
        {
            comp c = new comp();
            c.Show();
            Hide();
        }

        private void CHANGE_Click(object sender, EventArgs e)
        {
            change c = new change();
            c.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            view_all_complaint c = new view_all_complaint();
            c.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            view_all_registered c = new view_all_registered();
            c.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
