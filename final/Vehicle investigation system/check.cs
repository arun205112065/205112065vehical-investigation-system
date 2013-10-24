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
    public partial class check : Form
    {

         OleDbConnection con = new OleDbConnection();
         OleDbCommand com = new OleDbCommand();
         OleDbDataReader dr;

           private void check_Load(object sender, EventArgs e)
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

        public check()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {        }

        private void SUBMIT_Click(object sender, EventArgs e)
        {
             com.Connection = con;
             com.CommandText = "select rno  from registration where rno='"+ regno.Text+"' ";
              if(regno.Text!="")
             {
                 Int32 reg = Convert.ToInt32(regno.Text);
                 Int32 count = Convert.ToInt32(com.ExecuteScalar());
            
                 if (count == reg)
                 {
                     string str = regno.Text;
                     check2 ob = new check2();
                     ob.passvalue(con, str);
                     ob.Show();
                     Hide();
                 }
                 else
                 {
                     MessageBox.Show("Opps...Wrong Registration NO ");
                     regno.Text = "";
                 }

                     
             }
            else
                 MessageBox.Show("FILL THE REGISTRATIN NO");
        }

             /* com.Connection = con;
                com.CommandText = "select rno  from registration where rno='"+ regno.Text+"' ";
                Int32 reg=Convert.ToInt32(regno.Text);
                Int32 count = Convert.ToInt32(com.ExecuteScalar());
                if (count == reg)
                {
                    com.CommandText = "select *  from registration where rno='" + regno.Text + "' ";
                    //  
                    dr = com.ExecuteReader();
                    while (dr.Read())
                    {

                        label1.Enabled = false;
                        label1.Text = "";

                        regno.Enabled = false;
                        regno.Text = "";

                        SUBMIT.Enabled = false;
                        SUBMIT.Text = "";

                        l1.Enabled = false;
                        l1.Text = "";


                        l2.Enabled = false;
                        l2.Text = "";


                        l3.Enabled = false;
                        l3.Text = "";

                        l4.Enabled = false;
                        l4.Text = "";

                    }
                    /*
                      /*  string count3 = Convert.ToString(dr.GetString(0));
                        MessageBox.Show(count3);
                        */
                    //    Int32 count5 = Convert.ToInt32(dr.GetInt32(0));
                    //  MessageBox.Show(count5);

                    //     MessageBox.Show(count4);
                    //   int count3 = dr.GetString(0);
                    // MessageBox.Show(count3);

                    //    int count0 = dr.GetInt32(0);
                    /*             Int64  count7 = Convert.ToInt32(dr[7].ToString());
                                 ID.Text = "ID OF STUDENT : " + count7;

                                 Int64 count8 = Convert.ToInt64(dr[8].ToString());
                                 MOB.Text = "MOBILE NO IS : " + count8;
                    
                                 //MessageBox.Show("a :" + count0);
                                 string count1 = Convert.ToString(dr.GetString(1));
                                 VEHICLE.Text = "VEHICLE NO IS : "+count1;
                    
                                 string count3 = Convert.ToString(dr.GetString(3));
                                 TYPE.Text = "TYPE OF VEHICLE IS : "+count3;
                                 string count5 = Convert.ToString(dr.GetString(5));
                                 NAME.Text = "NAME OF OWNER : "+count5;
                                 string count6 = Convert.ToString(dr.GetString(6));
                                 RELATION.Text = "RELATION TO NIT-T : " + count6;
                                 string count9 = Convert.ToString(dr.GetString(9));

                                 ADDR.Text = "ADDRESS IS : " + count9;
                             /*    Int64 count8 =(Int64)(dr.GetInt64(8));
                                 MOB.Text = "MOBILE NO IS : " + count8;
                    
                                //     Int64 count7 = Convert.ToInt64(dr.GetString(7));
                                  //   ID.Text = Convert.ToString(count7);
                                 //    string count7 = Convert.ToString(dr.GetString(7));
                               //  RELATION.Text = count7;
                                    string count8 = Convert.ToString(dr.GetString(8));
                                    MOB.Text = count8;
                                    string count7 = Convert.ToString(dr.GetString(7));
                                    .Text = count7;
                                  * /
                     
                         } 
                         /* string count5 = Convert.ToString(dr.GetString(2));
                         MessageBox.Show(count5);
                           */
                    // check2 c = new check2();
                    //c.Show();
                    //Hide();

                    //  label1.Enabled = false;
                    //label1.Text = " ";

                    /*             }
                             }
                             else
                             {
                                 MessageBox.Show("YOU ENTERED WRONG REGISTRATION NO");
                                 check c = new check();
                                 c.Show();
                                 Hide();
                             }
                       //      count = Convert.ToInt32(com.ExecuteScalar());

                      */
                
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forget f = new forget();
            f.Show();
            Hide();
        }

        private void HOME_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
