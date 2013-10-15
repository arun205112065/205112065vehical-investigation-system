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
    public partial class retrive : Form
    {

        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        OleDbDataReader dr;

        public retrive()
        {
            InitializeComponent();
        }

        private void rgno_Click(object sender, EventArgs e)
        {


        }

        private void retrive_Load(object sender, EventArgs e)
        {

              con.ConnectionString = "PROVIDER=MSDAORA; USER ID=system; PASSWORD=arun; Unicode=true;";
            try
            { 
                con.Open();
                if (Convert.ToBoolean(con.State)) 
                {
                      MessageBox.Show("Connection Success");
                      com.Connection = con;
                      com.CommandText = "select max(mob)  from registration ";
                      //dr =
                      int i=   Convert.ToInt32(com.ExecuteScalar());
                      MessageBox.Show("a "+i.ToString());  
                    if (dr.Read())
                      {
                          MessageBox.Show("correct");
                          
                       //   MessageBox.Show(dr[0]);

                          dr.Close();
                          
              /*          string myField = (string)dr["max"];
                          MessageBox.Show(myField);
                */
                      }
                      else
                      {
                          MessageBox.Show("Oops");
                      }

                }
            }
            catch
            {
                MessageBox.Show("Connection Failed");
            }
            
        } 

     }
   }
