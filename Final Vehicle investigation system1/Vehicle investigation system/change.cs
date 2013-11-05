using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Vehicle_investigation_system
{
    public partial class change : Form
    {

        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        OleDbDataReader dr;
        public change()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            com.Connection = con;
            com.CommandText = "select RNO  from registration where RNO='" + RNO.Text + "' ";

            Int32 count = Convert.ToInt32(com.ExecuteScalar());
            if (RNO.Text == "")
            {
                MessageBox.Show("ENTER THE REGISTRATION NUMBER");  
            }
            else if (count == 0)
            {
                MessageBox.Show("Opps You Entered Wrong Vehicle No");
                RNO.Text = "";
                NAME.Text = "";
                RELATION.Text = "";
                ID.Text = "";
                MOB.Text = "";
                ADDR.Text = "";
            }
            else  if (RNO.Text != ""  & NAME.Text != "" & RELATION.Text != "" & ID.Text != "" & MOB.Text != "" & ADDR.Text != "")
            {
                com.CommandText = "update registration set NAME='" + NAME.Text + "',RELATION='" + RELATION.Text + "',ID='" + ID.Text + "',MOB='" + MOB.Text + "',ADDR='" + ADDR.Text + "' where RNO='" + RNO.Text + "' ";
                com.ExecuteNonQuery();
                MessageBox.Show("TABLE UPDATED");
                Form1 f = new Form1();
                f.Show();
                Hide();
            }
            else
                MessageBox.Show("Plz Enter All Values");
                
        }

        private void change_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider=OraOLEDB.Oracle.1;Persist Security Info=False;User ID=mca1268;PASSWORD=User164;Data Source=nitt";
            try
            {
                con.Open();
                if (Convert.ToBoolean(con.State))
                {
                      MessageBox.Show("Connection Success");
                 }
            }
            catch
            {
                MessageBox.Show("Connection Failed");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RNO.Text = "";
            NAME.Text = "";
            RELATION.Text = "";
            ID.Text = "";
            MOB.Text = "";
            ADDR.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void RNO_TextChanged(object sender, EventArgs e)
        {
            string context = this.RNO.Text;
            for (int i = 0; i < context.Length; i++)
            {

                if (char.IsNumber(context[i]))
                {

                }
                else
                {
                    MessageBox.Show("ONLY NUMBERS ARE ALLOWED");
                    RNO.Text = "";
                    // WHEELER.Enabled = true;
                }
            }
        }

        private void ID_TextChanged(object sender, EventArgs e)
        {
            string context = this.ID.Text;
            for (int i = 0; i < context.Length; i++)
            {

                if (char.IsNumber(context[i]))
                {

                }
                else
                {
                    MessageBox.Show("ONLY NUMBERS ARE ALLOWED");
                    ID.Text = "";
                    // WHEELER.Enabled = true;
                }
            }
        }

        private void MOB_TextChanged(object sender, EventArgs e)
        {
            string context = this.MOB.Text;
            for (int i = 0; i < context.Length; i++)
            {

                if (char.IsNumber(context[i]))
                {

                }
                else
                {
                    MessageBox.Show("ONLY NUMBERS ARE ALLOWED");
                    MOB.Text = "";
                    // WHEELER.Enabled = true;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
