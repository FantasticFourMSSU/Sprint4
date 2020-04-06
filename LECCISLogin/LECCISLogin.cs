using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LECCISLogin
{
  public partial class Login : Form

    {
        MySqlConnection myconnection = new MySqlConnection("Server=209.106.201.103;Database=group6;uid=dbstudent14;pwd=spicymonster10;");
        MySqlCommand cmd;
        MySqlDataReader dr;



        public Login()
        {
            InitializeComponent();
            myconnection.Open();
        }
       
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string user = username.Text;
            string pass = password.Text;
            cmd = new MySqlCommand();
            cmd.Connection = myconnection;
            cmd.CommandText = "SELECT * FROM Users where Username='" + username.Text + "' AND Password = '" + password.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Login sucessful", "Login Status");
                
            }
            else
            {
                MessageBox.Show("Invalid username or password","Invalid Login", MessageBoxButtons.RetryCancel);
            }
            myconnection.Close();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
