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
    public partial class comp : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        OleDbDataReader dr;
        public comp()
        {
            InitializeComponent();
        }

        private void com_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "PROVIDER=MSDAORA; USER ID=system; PASSWORD=arun; Unicode=true;";
            try
            {
                con.Open();
                if (Convert.ToBoolean(con.State))
                {
//                    MessageBox.Show("Connection Success");

                }
            }
            catch
            {
                MessageBox.Show("Connection Failed");
            }
        }

        private void SUBMIT_Click(object sender, EventArgs e)
        {
            if (RNO.Text != "")
            {
                com.Connection = con;
                com.CommandText = "select rno  from registration where rno='" + RNO.Text + "' ";
                Int32 temp = Convert.ToInt32(RNO.Text);
                Int32 count = Convert.ToInt32(com.ExecuteScalar());
                if (count == temp)
                {

                    com.CommandText = "insert into complaint(rno) values ('" + RNO.Text + "')";
                    com.ExecuteNonQuery();
                    com.Dispose();
                    MessageBox.Show("YOUR REGISTRATION NO IS INSERTED");
                }
                else
                {
                    MessageBox.Show("REGISTRATION NUMBER IS NOT PRESENT");
                }

            }
            else
            {
                MessageBox.Show("Plzzz INSERT VALUES ");
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
