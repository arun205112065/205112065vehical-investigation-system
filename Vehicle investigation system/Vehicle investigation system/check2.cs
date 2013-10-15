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

        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        OleDbDataReader dr;
        public check2()
        {
            InitializeComponent();
        }

        private void check2_Load(object sender, EventArgs e)
        {


        }
    }
}
