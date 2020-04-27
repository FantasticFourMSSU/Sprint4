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
    public partial class addProperty : Form
    {
        MySqlConnection myconnection = new MySqlConnection("Server=209.106.201.103;Database=group6;uid=dbstudent9;pwd=scarybat74;");

        public int ownerID;
        public int propId;
        public string SN;
        public string CT;
        public string ST;
        public string ZP;
       

        public addProperty()
        {
            InitializeComponent();
            Fillcombo();
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
                MessageBox.Show("Error fetching data","Data Retrieval Error",MessageBoxButtons.RetryCancel);
            }
            myconnection.Close();
        }

        public void FindProperty()
        {
            myconnection.Open();

            string query = "select propertyId From Property where streetNumber = '" + SN + "' AND city = '" + CT + "' AND state = '" + ST + "' AND zip = '" + ZP + "';";
            MySqlCommand cmdDatabase = new MySqlCommand(query, myconnection);
            using (MySqlDataReader myReader = cmdDatabase.ExecuteReader())
            {
                while (myReader.Read())
                {
                    int PID = Convert.ToInt32(myReader.GetString("propertyId"));

                    propId = PID;
                }
            }
            myconnection.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            SN = streetNumber.Text;
            CT = city.Text;
            ST = state.Text;
            ZP = zip.Text;

            if (SN == "" || CT == "" || ST == "" || ZP == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Please insert values for each field", "Invalid Input", MessageBoxButtons.OK);
            }
            if (streetNumber.Text.Contains(")") || streetNumber.Text.Contains("(") || streetNumber.Text.Contains(";") ||
                city.Text.Contains(")") || city.Text.Contains("(") || city.Text.Contains(";") ||
                zip.Text.Contains(")") || zip.Text.Contains("(") || zip.Text.Contains(";"))
            {
                MessageBox.Show("Field cannot contain SQL Statements.", "Invalid Input", MessageBoxButtons.OK);
                streetNumber.Clear();
                city.Clear();
                zip.Clear();
            }
            else
            {
                FindProperty();

                if (propId != 0)
                {
                    MessageBox.Show("A duplicate exists in the database and cannot be added.", "Database Duplication", MessageBoxButtons.OK);
                }
                else
                {

                    string sql = "INSERT INTO Property( streetNumber, city, state, zip) VALUES ('" + this.streetNumber.Text + "','" + this.city.Text + "','" + this.state.Text + "','" + this.zip.Text + "')";
                    string sql3 = "INSERT INTO OwnerWithProperty  VALUES( " + ownerID + "," + "LAST_INSERT_ID()" + ")";


                    myconnection.Open();
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

                    myconnection.Open();
                    using (MySqlCommand cmd2 = new MySqlCommand(sql3, myconnection))
                    {
                        using (MySqlDataReader rdr2 = cmd2.ExecuteReader())
                        {
                            while (rdr2.Read())
                            {

                            }
                            MessageBox.Show("Property Added Sucessfully", "Sucsess Message", MessageBoxButtons.OK);
                            myconnection.Close();
                        }
                    }
                    myconnection.Close();
                }

            }
            this.Close();
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

    }
}