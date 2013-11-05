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
    public partial class view_all_registered : Form
    {

        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        public view_all_registered()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Hide();
        }

        private void view_all_registered_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider=OraOLEDB.Oracle.1;Persist Security Info=False;User ID=mca1268;PASSWORD=User164;Data Source=nitt";
            try
            {
                con.Open();
                if (Convert.ToBoolean(con.State))
                {
                      // MessageBox.Show("Connection Success");

                }
            }
            catch
            {
                MessageBox.Show("Connection Failed");
            }

            dataR.DataSource = null;
            try
            {

                //System.Data.OleDb.OleDbConnection MyCnn;

                System.Data.DataSet DSet;

                System.Data.OleDb.OleDbDataAdapter MyCmd;


                MyCmd = new System.Data.OleDb.OleDbDataAdapter("select * from registration ", con);

                MyCmd.TableMappings.Add("Table", "registration");

                DSet = new System.Data.DataSet();

                MyCmd.Fill(DSet);

                dataR.DataSource = DSet.Tables[0];

                //                con.Close();
                MyCmd.Dispose();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }


        }

        private void dataR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
