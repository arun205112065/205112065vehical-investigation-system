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
    public partial class forget : Form
    {


        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        OleDbDataReader dr;

        public forget()
        {
            InitializeComponent();
        }

        private void SUBMIT_Click(object sender, EventArgs e)
        {
            com.Connection = con;
            com.CommandText = "select RNO  from registration where VEHICLE='" + VEHICLE.Text + "' ";
            string count = Convert.ToString(com.ExecuteScalar());
            MessageBox.Show("YOUR REGISTRATION NO IS : " + count);
        
        }

        private void forget_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "PROVIDER=MSDAORA; USER ID=system; PASSWORD=arun; Unicode=true;";
            try
            {
                con.Open();
                if (Convert.ToBoolean(con.State))
                {
                 //   MessageBox.Show("Connection Success");

                }
            }
            catch
            {
                MessageBox.Show("Connection Failed");
            }
        }

        private void HOME_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Hide();
        }
    }
}
