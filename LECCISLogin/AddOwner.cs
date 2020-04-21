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
        MySqlConnection myconnection = new MySqlConnection("Server=209.106.201.103;Database=group6;uid=dbstudent9;pwd=scarybat74;");


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
            var PN1 = phoneNumber1.Text;
            var PN2 = phoneNumber2.Text;
            var PN3 = phoneNumber3.Text;
            var PN = PN1 + PN2 + PN3;
            var EM = email.Text;

            if (FN == "" || LN == "" || PN == "" || EM == "")
            {
                MessageBox.Show("Field can not be blank.", "Insert values");
            }
            if (firstName.Text.Contains(")") || firstName.Text.Contains("(") || firstName.Text.Contains(";") ||
                lastName.Text.Contains(")") || lastName.Text.Contains("(") || lastName.Text.Contains(";") ||
                phoneNumber1.Text.Contains(";") ||
                email.Text.Contains(")") || email.Text.Contains("(") || email.Text.Contains(";"))
            {
                MessageBox.Show("Field cannot contain SQL Statements.", "Invalid Input", MessageBoxButtons.OK);
                firstName.Clear();
                lastName.Clear();
                phoneNumber1.Clear();
                email.Clear();
            }
            else
            {
                string sql = "INSERT INTO Owner(firstName, lastName, phoneNumber, email) VALUES ('" + this.firstName.Text + "','" + this.lastName.Text + " ', '" + PN + " ',' " + this.email.Text + " ' )";
                MySqlCommand cmd = new MySqlCommand(sql, myconnection);
                MySqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                try
                {
                    while (rdr.Read())
                    {
                    }
                    MessageBox.Show("Owner Added Sucessfully", "Success Message", MessageBoxButtons.OK);
                    myconnection.Close();
                    this.Close();  
                }
                catch
                {
   
                    MessageBox.Show("Values could not be addded", "System Error", MessageBoxButtons.AbortRetryIgnore);
                }
            }
            //        using (MySqlDataReader rdr = cmd.ExecuteReader())
            //        {
            //            while (rdr.Read())
            //            {
            //                MessageBox.Show(string.Format("{0} {1} {2}", rdr.GetInt32(0), rdr.GetString(1),
            //                        rdr.GetString(2)));

            //            }

            //        }
            //    }
            //    myconnection.Close();
            //}
            //MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            //MySqlDataReader MyReader2;
            //MyConn2.Open();
            //MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
            //MessageBox.Show("Save Data");
            //while (MyReader2.Read())
            //{
            //}
            //MyConn2.Close();

        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
