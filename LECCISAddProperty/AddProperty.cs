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
        MySqlConnection myconnection = new MySqlConnection("Server=209.106.201.103;Database=group6;uid=dbstudent14;pwd=spicymonster10;");

        public int ownerID;
       

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

        private void button1_Click(object sender, EventArgs e)
        {
            myconnection.Open();

            var SN = streetNumber.Text;
            var CT = city.Text;
            var ST = state.Text;
            var ZP = zip.Text;

            if (SN == "" || CT == "" || ST == "" || ZP == "")
                MessageBox.Show("Please insert values for each field","Invalid Input",MessageBoxButtons.OK);
            else
            {

                //string sql2 = "SELECT MAX(propertyId) AS LastID from Property;";
                //MessageBox.Show(sql2);


                string sql = "INSERT INTO Property( streetNumber, city, state, zip) VALUES (' " + this.streetNumber.Text + " ','" + this.city.Text + " ', '" + this.state.Text + " ',' " + this.zip.Text + "')";



                string sql3 = "INSERT INTO OwnerWithProperty  VALUES( " + ownerID + "," + "LAST_INSERT_ID()" + ")";
                MessageBox.Show(sql3);

                

                

                

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
                //myconnection.Open();
                //MySqlCommand cmdDatabase = new MySqlCommand(sql2, myconnection);
                //MySqlDataReader myReader;
                //try
                //{
                //    myReader = cmdDatabase.ExecuteReader();

                //    while (myReader.Read())
                //    {
                //        int PID = Convert.ToInt32(myReader.GetString("LastID"));

                //        propID = PID;
                //    }
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Error fetching data", "Data Retrieval Error", MessageBoxButtons.RetryCancel);
                //}
               // myconnection.Close();
                myconnection.Open();
                using (MySqlCommand cmd2 = new MySqlCommand(sql3, myconnection))
                {
                    using (MySqlDataReader rdr2 = cmd2.ExecuteReader())
                    {
                        while (rdr2.Read())
                        {
                            MessageBox.Show(string.Format("{0} {1} {2}", rdr2.GetInt32(0), rdr2.GetString(1),
                                    rdr2.GetString(2)));

                        }
                    }
                }
            }
            myconnection.Close();
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

        private void streetNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}