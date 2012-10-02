using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AccessDBDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAccess_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=127.0.0.1; Initial Source=Shop; User ID=sa; Pwd=njjizyj0826";
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();
            MessageBox.Show("Open Successfully!");
            connection.Close();
            MessageBox.Show("Close Successfully!");
        }
    }
}
