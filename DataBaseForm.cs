using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace P2G_Crawler
{
    public partial class DataBaseForm : Form
    {
        public DataBaseForm()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string connString = txtConnectionString.Text;
            if(connString=="") return;

            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = conn;
                com.CommandText = "SELECT RegNum,Website FROM CharityProfile WHERE Website <>''";
                SqlDataReader results = com.ExecuteReader();

                Settings.InputData = new Dictionary<string, string>();
                while (results.Read())
                {
                    string RegNum = results.GetString(0);
                    string Website = results.GetString(1);
                    Settings.InputData.Add(RegNum, Website);

                }

                MessageBox.Show("Data of "+Settings.InputData.Count+" records were Loaded");
            }


            catch { return; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
