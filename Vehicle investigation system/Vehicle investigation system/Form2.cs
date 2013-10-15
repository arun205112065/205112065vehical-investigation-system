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
    public partial class Form2 : Form
    {

        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        OleDbDataReader dr;
        Int32 count;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            con.ConnectionString = "PROVIDER=MSDAORA; USER ID=system; PASSWORD=arun; Unicode=true;";
            try
            { 
                con.Open();
                if (Convert.ToBoolean(con.State))
                {
                   //   MessageBox.Show("Connection Success");
                      com.Connection = con;
                      com.CommandText = "select max(rno)  from registration ";
                      count = Convert.ToInt32(com.ExecuteScalar());
                }
            }
            catch
            {
                MessageBox.Show("Connection Failed");
            }
            
        }

        private void SUBMIT_Click(object sender, EventArgs e)
        {

            if (VEHICLE.Text != "" & WHEELER.Text != "" & TYPE.Text != "" & CHECHIS.Text != "" & NAME.Text != "" & RELATION.Text != "" & ID.Text != "" & MOB.Text != "" & ADDR.Text != "")
            {
                
                     count = count + 1;
                   
                     com.Connection = con;
                     com.CommandText = "insert into registration(rno,vehicle,wheeler,type,chechis,name,relation,id,mob,addr) values ('" +count + "','" + VEHICLE.Text + "','" + WHEELER.Text + "','" + TYPE.Text + "','" + CHECHIS.Text + "','" + NAME.Text + "','" + RELATION.Text + "','" + ID.Text + "','" + MOB.Text + "','" + ADDR.Text + "')";
                     com.ExecuteNonQuery();
                     com.Dispose();
                     MessageBox.Show("record inserted");

                     MessageBox.Show("your registration no is : " + (count));

                     VEHICLE.Text = "";
                     WHEELER.Text = "";
                     TYPE.Text = "";
                     CHECHIS.Text = "";
                     NAME.Text = "";
                     RELATION.Text = "";
                     ID.Text = "";
                     MOB.Text = "";
                     ADDR.Text = "";

            }
            else
            {
                MessageBox.Show("Plzzz insert all entries ");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VEHICLE_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void RESET_Click(object sender, EventArgs e)
        {

            VEHICLE.Text = "";
            WHEELER.Text = "" ;
            TYPE.Text = "" ;
            CHECHIS.Text = "" ;
            NAME.Text = "" ;
            RELATION.Text = "" ;
            ID.Text = "" ;
            MOB.Text = "" ;
            ADDR.Text = "";
        }

        private void ID_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void HOME_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Hide();
        }

        private void ADDR_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
