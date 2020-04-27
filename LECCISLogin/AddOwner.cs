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
       
        public int ownerId = 0;
        public string FN;
        public string LN;
        public string PN1;
        public string PN2;
        public string PN3;
        public string PN;
        public string EM;


        public addOwnerForm()
        {
             InitializeComponent();

        }

        public void FindOwnerID()
        {
            myconnection.Open();
            string query = "SELECT ownerId from Owner where firstName = '" + FN + "' AND lastName = '" + LN + "' AND phoneNumber = '" + PN + "' AND email = '" + EM + "';";
            // string query = "SELECT ownerId from Owner where CONCAT(firstName, ' ', lastName) = '" + fullname + "';";
            MySqlCommand cmdDatabase = new MySqlCommand(query, myconnection);
            using (MySqlDataReader myReader = cmdDatabase.ExecuteReader())
            {
                while (myReader.Read())
                {
                    int OID = Convert.ToInt32(myReader.GetString("ownerId"));

                    ownerId = OID;
                }
            }
            myconnection.Close();
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
            FN = firstName.Text;
            LN = lastName.Text;
            PN1 = phoneNumber1.Text;
            PN2 = phoneNumber2.Text;
            PN3 = phoneNumber3.Text;
            PN = PN1 + "-" + PN2 + "-" + PN3;
            EM = email.Text;

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
                FindOwnerID();

                if(ownerId != 0)
                {
                    MessageBox.Show("A duplicate exists in the database and cannot be added.", "Database Duplication", MessageBoxButtons.OK);

                }
                else
                {

                    myconnection.Open();
                    string sql = "INSERT INTO Owner(firstName, lastName, phoneNumber, email) VALUES ('" + this.firstName.Text + "','" + this.lastName.Text + "', '" + PN + "','" + this.email.Text + "' )";
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
                    myconnection.Close();
                }

            }
            this.Close();

        }

    }
}
