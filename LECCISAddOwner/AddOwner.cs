
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

namespace LECCISAddOwner
{
  public partial class addOwnerForm : Form
  {

    //private TextBox firstNameDisplay;
    //private TextBox lastNameDisplay;
    //private TextBox phoneNumberDisplay;
    //private TextBox emailDisplay;


    public addOwnerForm()
    {
      InitializeComponent();
    }



        private void button_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).BackColor = System.Drawing.SystemColors.Control;
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

        private void button_Click(object sender, EventArgs e)
        {
            var FN = firstName.Text;
            var LN = lastName.Text;
            var PN = phoneNumber.Text;
            var EM = email.Text;

            if (PN == "" || EM == "")
                MessageBox.Show("insert values");
            else
            {

                MySqlConnection conn = ConnectToDatabase();


                string sql = "INSERT INTO Owner(firstName, lastName, phoneNumber, email) VALUES ('" + this.firstName.Text + "','" + this.lastName.Text + " ', '" + this.phoneNumber.Text + " ',' " + this.email.Text + " ' )";
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

            //string str = "datasource = ; username = ; password =  ";
            string query = "Select O.firstName, O.lastName, O.email, O.phoneNumber, P.streetNumnber,P.city, P.state, P.zip, P.acres, P.sqft From Owner O, Property P, OwnerWithProperty OP where O.OwnerId = OP.OwnerId AND P.PropertyId = OP.PropertyId AND streetNumnber like" + "'%'searchPropertySATextBox.Text'%'";
            //SqlConnection con = new SqlConnection(str);
            //SqlCommand cmd = new SqlCommand(query, con);

            //try
            //{
            //    con.open();
            //    DataSet ds = new DataSet();
            //    MessageBox.Show("Saved");
            //    con.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
