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
    public partial class EditOwner : Form
    {

        MySqlConnection myconnection = new MySqlConnection("Server=209.106.201.103;Database=group6;uid=dbstudent9;pwd=scarybat74;");

        public int ownerID;
        public string firstName;
        public string lastName;
        public string phoneNumber;
        public string email;

        public string PN;
        public int validationKey;

        public EditOwner(string fn, string ln, string pn, string e, int oid)
        {
            InitializeComponent();

            firstName = fn;
            lastName = ln;
            phoneNumber = pn;
            email = e;
            ownerID = oid;


            textBoxFN.Text = firstName;
            textBoxLN.Text = lastName;
            textBoxPN.Text = phoneNumber;
            textBoxE.Text = email;
          
        }

        public void ValidateInput()
        {
            validationKey = 0;

            if (textBoxFN.Text == "" || textBoxLN.Text == "" || textBoxPN.Text == "" || textBoxE.Text == "")
            {
                MessageBox.Show("Field can not be blank.", "Insert values", MessageBoxButtons.OK);

            }
            else
            {
                validationKey = validationKey + 1;
            }
            if (textBoxFN.Text.Contains(")") || textBoxFN.Text.Contains("(") || textBoxFN.Text.Contains(";") ||
                textBoxLN.Text.Contains(")") || textBoxLN.Text.Contains("(") || textBoxLN.Text.Contains(";") ||
                textBoxPN.Text.Contains(";") ||
                textBoxE.Text.Contains(")") || textBoxE.Text.Contains("(") || textBoxE.Text.Contains(";"))
            {
                MessageBox.Show("Field cannot contain SQL Statements.", "Invalid Input", MessageBoxButtons.OK);
                textBoxFN.Clear();
                textBoxLN.Clear();
                textBoxPN.Clear();
                textBoxE.Clear();
            }
            else
            {
                validationKey = validationKey + 1;
            }
            if (PN.Length != 10)
            {
                MessageBox.Show("Incorrect Format. Phone number should be entered in the format 999 999 9999.", "Format Error", MessageBoxButtons.OK);
            }
            else
            {
                validationKey = validationKey + 1;
            }
            if (!textBoxE.Text.Contains("@"))
            {
                MessageBox.Show("Incorrect Format. Email should follow the format name@domain.org", "Format Error", MessageBoxButtons.OK);
            }
            else
            {
                validationKey = validationKey + 1;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            myconnection.Open();
            PN = textBoxPN.Text;

            ValidateInput();


            if (validationKey != 4)
            {
                MessageBox.Show("Owner information could not be updated. Check your input and try again.", "Update Failure", MessageBoxButtons.RetryCancel);
                textBoxFN.Focus();
            }
            else
            {                 
                string sql = "Update Owner SET firstName = '" + this.textBoxFN.Text + "', " +
                             "lastName = '" + this.textBoxLN.Text + "', phoneNumber = '" + this.textBoxPN.Text + "', " +
                             "email = '" + this.textBoxE.Text + "' WHERE ownerId = " + ownerID +"";
                MySqlCommand cmd = new MySqlCommand(sql, myconnection);
                MySqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                try
                {
                    while (rdr.Read())
                    {
                    }
                    MessageBox.Show("Owner Updated Sucessfully", "Success Message", MessageBoxButtons.OK);
                    myconnection.Close();
                    this.Close();
                }
                catch
                {

                    MessageBox.Show("Values could not be edited", "System Error", MessageBoxButtons.AbortRetryIgnore);
                }
            }
            myconnection.Close();
        }


    }
}

