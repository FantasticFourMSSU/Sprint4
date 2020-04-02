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


                string sql = "INSERT INTO Property(streetNumber, city, state, zip, acres, sqft) VALUES (' " + this.streetNumber.Text + " ','" + this.city.Text + " ', '" + this.state.Text + " ',' " + this.zip.Text + " ',' " + this.Sqft.Text + " ',' " + this.Acres.Text + " ')";
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