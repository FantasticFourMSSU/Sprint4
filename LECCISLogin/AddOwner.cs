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
  public partial class addOwnerForm : Form
  {
        MySqlConnection myconnection = new MySqlConnection("Server=209.106.201.103;Database=group6;uid=dbstudent14;pwd=spicymonster10;");


        public addOwnerForm()
        {
             InitializeComponent();
             myconnection.Open();
        }


        private void button_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.SystemColors.Control;
        }


        private void button_Click(object sender, EventArgs e)
        {
            var FN = firstName.Text;
            var LN = lastName.Text;
            var PN = phoneNumber.Text;
            var EM = email.Text;

            if (FN == "" || LN == "" || PN == "" || EM == "")
            {
                MessageBox.Show("Field can not be blank.", "Insert values");
            }
            if (firstName.Text.Contains(")") || firstName.Text.Contains("(") || firstName.Text.Contains(";") ||
                lastName.Text.Contains(")") || lastName.Text.Contains("(") || lastName.Text.Contains(";") ||
                phoneNumber.Text.Contains(";") ||
                email.Text.Contains(")") || email.Text.Contains("(") || email.Text.Contains(";"))
            {
                MessageBox.Show("Field cannot contain SQL Statements.", "Invalid Input", MessageBoxButtons.OK);
                firstName.Clear();
                lastName.Clear();
                phoneNumber.Clear();
                email.Clear(); 
            }
            else
            {
                string sql = "INSERT INTO Owner(firstName, lastName, phoneNumber, email) VALUES ('" + this.firstName.Text + "','" + this.lastName.Text + " ', '" + this.phoneNumber.Text + " ',' " + this.email.Text + " ' )";
                using (MySqlCommand cmd = new MySqlCommand(sql, myconnection))
                {
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            MessageBox.Show(string.Format("{0} {1} {2}", rdr.GetInt32(0), rdr.GetString(1),
                                    rdr.GetString(2)));

                        }

                    }
                }
                myconnection.Close();
            }

        }

    }
}
