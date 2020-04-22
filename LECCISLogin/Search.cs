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

namespace LECCISSearch
{

    public partial class searchForm : Form
    {
        MySqlConnection myconnection = new MySqlConnection("Server=209.106.201.103;Database=group6;uid=dbstudent9;pwd=scarybat74;");
        MySqlDataAdapter adpt;
        DataTable dt;

        public searchForm()
        {
            InitializeComponent();
            myconnection.Open();
        }
        void searchBox_keyDown(object sender, KeyEventArgs e)
        { 
            if (e.KeyCode == Keys.Enter)
            {
                searchButton_Click((object)sender, (EventArgs)e);
            }
        }
        void searchButton_Click(object sender, EventArgs e)
        {

            if (SearchNameOrPropertyCheckbox.Checked == true && SearchOwnerOnlyCheckbox.Checked == false)
            {
                if (searchPropertyNameOrOwnerTextBox.Text.Contains(")") ||
                searchPropertyNameOrOwnerTextBox.Text.Contains("(") ||
                searchPropertyNameOrOwnerTextBox.Text.Contains(";"))
                {
                    MessageBox.Show("Search field cannot contain SQL Statements.", "Invalid Input", MessageBoxButtons.OK);
                    searchPropertyNameOrOwnerTextBox.Clear();
                }
                else
                {
                    //   adpt = new MySqlDataAdapter("Select O.firstName, O.lastName, O.email, O.phoneNumber, P.streetNumber, P.city, P.state, P.zip, P.acres, P.sqft From Owner O, Property P, OwnerWithProperty OP where O.OwnerId = OP.OwnerId AND P.PropertyId = OP.PropertyId AND streetNumber like '%" + searchPropertyStreetTextBox.Text + "%'", myconnection);
                    adpt = new MySqlDataAdapter("Select firstName, lastName, phoneNumber, email, streetNumber, city, state, zip From Property Left Join OwnerWithProperty " +
                        "ON Property.propertyId = OwnerWithProperty.propertyId Left Join Owner ON Owner.ownerId = OwnerWithProperty.ownerId " +
                        "WHERE streetNumber like '%" + searchPropertyNameOrOwnerTextBox.Text + "%' " +
                        "OR firstName like '%" + searchPropertyNameOrOwnerTextBox.Text + "%' " +
                        "OR lastName like '%" + searchPropertyNameOrOwnerTextBox.Text + "%' " +
                        "OR CONCAT(firstName, ' ', lastName) like '%" + searchPropertyNameOrOwnerTextBox.Text + "%'", myconnection);
                    dt = new DataTable();
                    adpt.Fill(dt);
                    resultsDataGridView.DataSource = dt;
                    searchPropertyNameOrOwnerTextBox.Clear();
                }
            }
            else if (SearchNameOrPropertyCheckbox.Checked == false && SearchOwnerOnlyCheckbox.Checked == true)
            {
                if (searchPropertyNameOrOwnerTextBox.Text.Contains(")") ||
               searchPropertyNameOrOwnerTextBox.Text.Contains("(") ||
               searchPropertyNameOrOwnerTextBox.Text.Contains(";"))
                {
                    MessageBox.Show("Search field cannot contain SQL Statements.", "Invalid Input", MessageBoxButtons.OK);
                    searchPropertyNameOrOwnerTextBox.Clear();
                }
                else
                {
                    //   adpt = new MySqlDataAdapter("Select O.firstName, O.lastName, O.email, O.phoneNumber, P.streetNumber, P.city, P.state, P.zip, P.acres, P.sqft From Owner O, Property P, OwnerWithProperty OP where O.OwnerId = OP.OwnerId AND P.PropertyId = OP.PropertyId AND streetNumber like '%" + searchPropertyStreetTextBox.Text + "%'", myconnection);
                    adpt = new MySqlDataAdapter("SELECT * from Owner " +
                        "Where firstName like '%" + searchPropertyNameOrOwnerTextBox.Text + "%' " +
                        "OR lastName like '%" + searchPropertyNameOrOwnerTextBox.Text + "%' " +
                        "OR CONCAT(firstName, ' ', lastName) like '%" + searchPropertyNameOrOwnerTextBox.Text + "%'", myconnection);
                    dt = new DataTable();
                    adpt.Fill(dt);
                    resultsDataGridView.DataSource = dt;
                    searchPropertyNameOrOwnerTextBox.Clear();
                }
            }
            else
            {
                MessageBox.Show("Wrong way of checking", "Please Check one and only one of the checkbox to search ", MessageBoxButtons.OK);
                searchPropertyNameOrOwnerTextBox.Clear();
            }
        }

        private void searchPropertyStreetTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void resultsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchPropertyStreetLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

