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
using System.Text.RegularExpressions;


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

        public bool z;
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

        public bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return z = false;
            }
            return z = true;
        }

        public void ValidateInput()
        {
            validationKey = 0;

            string SN = textBoxSN.Text;
            string CT = textBoxCY.Text;
            string ST = stateComboBox.Text;
            string ZP = textBoxZP.Text;


            IsDigitsOnly(ZP);
  

            
            if (SN == "" || CT == "" || ST == "" || ZP == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Please insert values for each field", "Invalid Input", MessageBoxButtons.OK);
                textBoxSN.Focus();
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
                textBoxSN.Focus();
            }
            else
            {
                validationKey = validationKey + 1;
            }
            if (ZP.Length != 5)
            {
                MessageBox.Show("Zip code must be 5 digits.", "Invalid Input", MessageBoxButtons.OK);
                textBoxZP.Focus();
            }
            else
            {
                validationKey = validationKey + 1;
            }
            if (z == false)
            {
                MessageBox.Show("Zip code cannot contain letters.", "Invalid Input", MessageBoxButtons.OK);
                textBoxZP.Focus();
            }
            else
            {
                validationKey = validationKey + 1;
            }
            // Testing Code //
            if (!stateComboBox.Items.Contains(stateComboBox.Text))
            {
                MessageBox.Show("State selected is not valid.", "Invalid State", MessageBoxButtons.OK);
                comboBox1.Focus();
            }
            else
            {
                validationKey = validationKey + 1;
            }
            if (!comboBox1.Items.Contains(comboBox1.Text))
            {
                MessageBox.Show("Properties must be associated to a listed Owner. Select the owner from the list or close this form and add an owner first.", "Invalid Owner", MessageBoxButtons.OK);
                comboBox1.Focus();
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

            if (validationKey != 6)
            {
                MessageBox.Show("Property information could not be updated. Check your input and try again.", "Update Failure", MessageBoxButtons.RetryCancel);
                
            }
            else
            {
                string sql = "UPDATE Property SET streetNumber = '" + this.textBoxSN.Text + "', city = '" + this.textBoxCY.Text + "', state = '" + this.stateComboBox.Text + "', zip = '" + this.textBoxZP.Text + "' WHERE propertyId = " + propID + "";
                string sql2 = "DELETE FROM OwnerWithProperty WHERE propertyId =  " + propID + "";
                string sql3 = "INSERT INTO OwnerWithProperty  VALUES(" + ownerID + "," + propID + ")";
                try
                {
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
                            }
                        }
                        using (MySqlCommand cmd3 = new MySqlCommand(sql3, myconnection))
                        {
                            using (MySqlDataReader rdr3 = cmd3.ExecuteReader())
                            {
                                while (rdr3.Read())
                                {
                                }
                            }
                        }
                        MessageBox.Show("Property Added Sucessfully", "Sucsess Message", MessageBoxButtons.OK);
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
