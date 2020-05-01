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
    public partial class EditProperty : Form
    {
        MySqlConnection myconnection = new MySqlConnection("Server=209.106.201.103;Database=group6;uid=dbstudent9;pwd=scarybat74;");
       
        public int ownerID;
        public int ownerId;
        public int propID;
        public string combo;
        public string street;
        public string city;
        public string state;
        public string zip;

        public int validationKey;

        public EditProperty(string str, string ct, string st, string zp, string cb, int OID, int PID)
        {
            street = str;
            city = ct;
            state = st;
            zip = zp;
            combo = cb;
            ownerId = OID;
            ownerID = OID;
            propID = PID;

            InitializeComponent();
            Fillcombo();

            textBoxSN.Text = street;
            textBoxCY.Text = city;
            stateComboBox.SelectedItem = state;
            textBoxZP.Text = zip;
            comboBox1.Text = combo;

        }

        public void Fillcombo()
        {
            myconnection.Open();

            string query = "SELECT * FROM Owner;";
            MySqlCommand cmdDatabase = new MySqlCommand(query, myconnection);
            MySqlDataReader myReader;
            try
            {
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    string fName = myReader.GetString("firstName");
                    string lName = myReader.GetString("lastName");


                    comboBox1.Items.Add(fName + " " + lName);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data", "Data Retrieval Error", MessageBoxButtons.RetryCancel);
            }
            myconnection.Close();
        }

        public void ValidateInput()
        {
            validationKey = 0;

            var SN = textBoxSN.Text;
            var CT = textBoxCY.Text;
            var ST = stateComboBox.Text;
            var ZP = textBoxZP.Text;
            
            if (SN == "" || CT == "" || ST == "" || ZP == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Please insert values for each field", "Invalid Input", MessageBoxButtons.OK);
            }
            else
            {
                validationKey = validationKey + 1;

            }
            if (textBoxSN.Text.Contains(")") || textBoxSN.Text.Contains("(") || textBoxSN.Text.Contains(";") ||
                textBoxCY.Text.Contains(")") || textBoxCY.Text.Contains("(") || textBoxCY.Text.Contains(";") ||
                textBoxZP.Text.Contains(")") || textBoxZP.Text.Contains("(") || textBoxZP.Text.Contains(";"))
            {
                MessageBox.Show("Field cannot contain SQL Statements.", "Invalid Input", MessageBoxButtons.OK);
                textBoxSN.Clear();
                textBoxCY.Clear();
                textBoxZP.Clear();
            }
            else
            {
                validationKey = validationKey + 1;
            }
            if (ZP.Length != 5)
            {
                MessageBox.Show("Zip code must be 5 digits.", "Invalid Input", MessageBoxButtons.OK);
            }
            else
            {
                validationKey = validationKey + 1;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            myconnection.Open();

            string query = "SELECT ownerId from Owner where CONCAT(firstName, ' ', lastName) = '" + comboBox1.Text + "';";
            MySqlCommand cmdDatabase = new MySqlCommand(query, myconnection);
            using (MySqlDataReader myReader = cmdDatabase.ExecuteReader())
            {
                while (myReader.Read())
                {
                    int OID = Convert.ToInt32(myReader.GetString("ownerId"));

                    ownerID = OID;
                }
            }
            myconnection.Close();

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            myconnection.Open();

            ValidateInput();

            if (validationKey !=3)
            {
                MessageBox.Show("Property information could not be updated. Check your input and try again.", "Update Failure", MessageBoxButtons.RetryCancel);
                textBoxSN.Focus();
            }
            else
            {
                string sql = "UPDATE Property SET streetNumber = '" + this.textBoxSN.Text + "', city = '" + this.textBoxCY.Text + "', state = '" + this.stateComboBox.Text + "', zip = '" + this.textBoxZP.Text + "' WHERE propertyId = " + propID + "";
                string sql2 = "UPDATE OwnerWithProperty SET ownerId = " + ownerID + " Where propertyId = " + propID + "";
                try {
                    using (MySqlCommand cmd = new MySqlCommand(sql, myconnection))
                    {
                        using (MySqlDataReader rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {

                            }
                        }
                    }
                    myconnection.Close();

                    if (ownerId != ownerID)
                    {
                        myconnection.Open();
                        using (MySqlCommand cmd2 = new MySqlCommand(sql2, myconnection))
                        {
                            using (MySqlDataReader rdr2 = cmd2.ExecuteReader())
                            {
                                while (rdr2.Read())
                                {
                                }
                                MessageBox.Show("Property Added Sucessfully", "Sucsess Message", MessageBoxButtons.OK);

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Property updated successfully.", "Success", MessageBoxButtons.OK);
                    }
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
