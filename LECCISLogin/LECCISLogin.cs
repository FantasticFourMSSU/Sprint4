using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LECCISLogin
{
  public partial class Login : Form
  {
    public Login()
    {
      InitializeComponent();
    }
        private MySqlConnection ConnectToDatabase()
        {
            string myconnection = "Server= 209.106.201.103; Database=group6; uid=dbstudent14;pwd=spicymonster10";
            MySqlConnection conn = new MySqlConnection(myconnection);
            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open)
            {
                MessageBox.Show("connection opened");
            }
            return conn;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var UN = username.Text;
            var PW = password.Text;
            //if (PN == "" || EM == "")
            //    MessageBox.Show("insert values");
            //else
            //{
            MySqlConnection conn = ConnectToDatabase();


            string sql = "INSERT INTO Property(username, password) VALUES (' " + this.username.Text + " ','" + this.password.Text + " ')";
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                using (MySqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        MessageBox.Show(string.Format("{0} {1} ", rdr.GetInt32(0), rdr.GetString(1)));
                    }
                }
            }
            conn.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
