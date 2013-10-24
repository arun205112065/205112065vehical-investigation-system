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
         
    public partial class check2 : Form
    {

        OleDbConnection con;
        string regno;

        public check2()
        {
            InitializeComponent();
        }

        public void passvalue(OleDbConnection conn, string str)
        {
            con = conn;
            regno = str;
        }

        private void check2_Load(object sender, EventArgs e)
        {
            data.DataSource = null;
            try
            {

                //System.Data.OleDb.OleDbConnection MyCnn;

                System.Data.DataSet DSet;

                System.Data.OleDb.OleDbDataAdapter MyCmd;


                MyCmd = new System.Data.OleDb.OleDbDataAdapter("select * from registration where rno='" + (regno) + "'", con);

                MyCmd.TableMappings.Add("Table", "registration");

                DSet = new System.Data.DataSet();

                MyCmd.Fill(DSet);

                data.DataSource = DSet.Tables[0];

                //                con.Close();
                MyCmd.Dispose();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }


        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HOME_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Hide();
        }

        private void BACK_Click(object sender, EventArgs e)
        {
            check f = new check();
            f.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
