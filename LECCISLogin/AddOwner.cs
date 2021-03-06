﻿using System;
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

        public bool p;
        public int validationKey;


        public addOwnerForm()
        {
             InitializeComponent();

        }

        public bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return p = false;
            }
            return p = true;
        }

        public void ValidateInput()
        {
            validationKey = 0;

            IsDigitsOnly(PN);

            if (firstName.Text == "" || lastName.Text == "" || phoneNumber1.Text == "" || email.Text == "")
            {
                MessageBox.Show("Field can not be blank.", "Insert values", MessageBoxButtons.OK);
                firstName.Focus();
            }
            else
            {
                validationKey = validationKey + 1;
            }
            if (firstName.Text.Contains(")") || firstName.Text.Contains("(") || firstName.Text.Contains(";") ||
                lastName.Text.Contains(")") || lastName.Text.Contains("(") || lastName.Text.Contains(";") ||
                email.Text.Contains(")") || email.Text.Contains("(") || email.Text.Contains(";"))
            {
                MessageBox.Show("Field cannot contain SQL Statements.", "Invalid Input", MessageBoxButtons.OK);
                firstName.Clear();
                lastName.Clear();
                email.Clear();
                firstName.Focus();

            }
            else
            {
                validationKey = validationKey + 1;
            }
            if (PN.Length != 10)
            {
                MessageBox.Show("Incorrect Format. Phone number should be entered in the format 9999999999.", "Format Error", MessageBoxButtons.OK);
                phoneNumber1.Focus();
            }
            else
            {
                validationKey = validationKey + 1;
            }
            if (p == false)
            {
                MessageBox.Show("Phone number cannot contain letters.", "Invalid Input", MessageBoxButtons.OK);
                phoneNumber1.Focus();
            }
            else
            {
                validationKey = validationKey + 1;
            }
            if (!email.Text.Contains("@"))
            {
                MessageBox.Show("Incorrect Format. Email should follow the format name@domain.org", "Format Error", MessageBoxButtons.OK);
                email.Focus();
            }
            else
            {
                validationKey = validationKey + 1;
            }
            if (!email.Text.Contains("."))
            {
                MessageBox.Show("Incorrect Format. Email should follow the format name@domain.org", "Format Error", MessageBoxButtons.OK);
                email.Focus();
            }
            else
            {
                validationKey = validationKey + 1;
            }
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
            PN = phoneNumber1.Text;
            EM = email.Text;

            ValidateInput();


            if (validationKey != 6)
            {
                MessageBox.Show("Owner information could not be updated. Check your input and try again.", "Update Failure", MessageBoxButtons.RetryCancel);
            }
            else
            {
                FindOwnerID();

                if(ownerId != 0)
                {
                    MessageBox.Show("A duplicate exists in the database and cannot be added.", "Database Duplication", MessageBoxButtons.OK);
                    this.DialogResult = DialogResult.OK;
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
        }
    }
}
