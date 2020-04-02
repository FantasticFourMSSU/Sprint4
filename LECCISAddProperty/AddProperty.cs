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

namespace LECCISAddProperty
{
    public partial class addProperty : Form
    {

        public addProperty()
        {
            InitializeComponent();
            Fillcombo();
        }

        void Fillcombo()
        {
            string constring = "Server= 209.106.201.103; Database=group6; uid=dbstudent14;pwd=spicymonster10";
            string query = "SELECT * FROM Owner;";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(query, conDatabase);
            MySqlDataReader myReader;
            try
            {
                conDatabase.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    string fName = myReader.GetString("firstName" );
                    string lName = myReader.GetString("lastName");

                    
                     
                
                    comboBox1.Items.Add(fName + lName);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            
    }
        //private void Address_Enter(object sender, EventArgs e)
        //{
        //  Address.ForeColor = Color.Gray;
        //}

        //private void Address_Leave(object sender, EventArgs e)
        //{
        //  Address.ForeColor = Color.Black;
        //}

        private void Address_TextChanged(object sender, EventArgs e)
        {

        }

        private void StreetNumber_TextChanged(object sender, EventArgs e)
        {

        }
        private MySqlConnection ConnectToDatabase()
        {
            string myconnection = "Server= 209.106.201.103; Database=group6; uid=dbstudent14;pwd=spicymonster10";
            MySqlConnection conn = new MySqlConnection(myconnection);
            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open)
            {
                MessageBox.Show("connection opened");

            }
            return conn;

        
    }

        //private void addRecord_Click(object sender, EventArgs e)
        //{


        //    }

        private void button1_Click(object sender, EventArgs e)
        {
            var SN = streetNumber.Text;
            var CT = city.Text;
            var ST = state.Text;
            var ZP = zip.Text;
            var SF = Sqft.Text;
            var AC = Acres.Text;

            if (CT == "" || ST == "" || ZP == "")
                MessageBox.Show("insert values");
            else
            {

                MySqlConnection conn = ConnectToDatabase();


               
              // string sql =  "SELECT * FROM Owner LEFT JOIN OwnerWithProperty ON Owner.ownerId = OwnerWithProperty.ownerId LEFT JOIN Property ON Property.propertyId = OwnerWithProperty.propertyId;";
               string sql = "INSERT INTO Property(streetNumber, city, state, zip, acres, sqft) VALUES (' " + this.streetNumber.Text + " ','" + this.city.Text + " ', '" + this.state.Text + " ',' " + this.zip.Text + " ',' " + this.Sqft.Text + " ',' " + this.Acres.Text + " ')";
              //  sql = "INSERT INTO OwnerWithProperty(ownerId) VALUES (ownerId, LAST_INSERT_ID);";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            MessageBox.Show(string.Format("{0} {1} {2}", rdr.GetInt32(0), rdr.GetString(1),
                                    rdr.GetString(2)));

                        }
                        comboBox1.DisplayMember = "firstName";

                    }
                }

                conn.Close();
            }
        }
        private void Acres_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = ConnectToDatabase();

            //string sql = "SELECT * FROM Owner LEFT JOIN OwnerWithProperty ON Owner.ownerId = OwnerWithProperty.ownerId LEFT JOIN Property ON Property.propertyId = OwnerWithProperty.propertyId;";

            
            
            
           string sql = "SELECT firstName, lastName FROM Owner;";

            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
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
        }

    }
}