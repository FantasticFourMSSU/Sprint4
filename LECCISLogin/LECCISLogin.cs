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
       // MySqlCommand cmd;
       // MySqlDataReader dr;



        public Login()
        {
            InitializeComponent();
            myconnection.Open();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string user = username.Text;
            string pass = password.Text;
            if (user == "" || pass == "")
            {
                MessageBox.Show("Please enter a username and password.", "Invalid Input", MessageBoxButtons.OK);
            }
            
            else
            {
                string query = "SELECT * FROM Users where Username='" + username.Text + "' AND Password = '" + password.Text + "'";
                // dr = cmd.ExecuteReader();
                MySqlDataAdapter sda = new MySqlDataAdapter(query, myconnection);
                DataTable dtb1 = new DataTable();
                sda.Fill(dtb1);
                if (dtb1.Rows.Count == 1)
                {

                    Dashboard main = new Dashboard();
                    this.Hide();
                    main.ShowDialog();
                    this.Close();


                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Invalid Login", MessageBoxButtons.RetryCancel);
                }
                myconnection.Close();

            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
