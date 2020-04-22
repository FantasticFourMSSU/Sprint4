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

            if (searchPropertyStreetTextBox.Text.Contains(")") || 
                searchPropertyStreetTextBox.Text.Contains("(") ||
                searchPropertyStreetTextBox.Text.Contains(";"))
            {
                MessageBox.Show("Search field cannot contain SQL Statements.", "Invalid Input", MessageBoxButtons.OK);
                searchPropertyStreetTextBox.Clear();
            }
            else
            {
             //   adpt = new MySqlDataAdapter("Select O.firstName, O.lastName, O.email, O.phoneNumber, P.streetNumber, P.city, P.state, P.zip, P.acres, P.sqft From Owner O, Property P, OwnerWithProperty OP where O.OwnerId = OP.OwnerId AND P.PropertyId = OP.PropertyId AND streetNumber like '%" + searchPropertyStreetTextBox.Text + "%'", myconnection);
                adpt = new MySqlDataAdapter("Select firstName, lastName, phoneNumber, email, streetNumber, city, state, zip From Property Left Join OwnerWithProperty " +
                    "ON Property.propertyId = OwnerWithProperty.propertyId Left Join Owner ON Owner.ownerId = OwnerWithProperty.ownerId " +
                    "WHERE streetNumber like '%" + searchPropertyStreetTextBox.Text + "%' " +
                    "OR firstName like '%" + searchPropertyStreetTextBox.Text + "%' " +
                    "OR lastName like '%" + searchPropertyStreetTextBox.Text + "%' " +
                    "OR CONCAT(firstName, ' ', lastName) like '%" + searchPropertyStreetTextBox.Text + "%'", myconnection);
                dt = new DataTable();
                adpt.Fill(dt);
                resultsDataGridView.DataSource = dt;
                searchPropertyStreetTextBox.Clear();
            }
        }

        private void searchPropertyStreetTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void searchButton2_Click(object sender, EventArgs e)
        {
            if (searchOwner.Text.Contains(")") ||
                   searchOwner.Text.Contains("(") ||
                   searchOwner.Text.Contains(";"))
            {
                MessageBox.Show("Search field cannot contain SQL Statements.", "Invalid Input", MessageBoxButtons.OK);
                searchOwner.Clear();
            }
            else
            {
                //   adpt = new MySqlDataAdapter("Select O.firstName, O.lastName, O.email, O.phoneNumber, P.streetNumber, P.city, P.state, P.zip, P.acres, P.sqft From Owner O, Property P, OwnerWithProperty OP where O.OwnerId = OP.OwnerId AND P.PropertyId = OP.PropertyId AND streetNumber like '%" + searchPropertyStreetTextBox.Text + "%'", myconnection);
                adpt = new MySqlDataAdapter("Select firstName, lastName, phoneNumber, email, streetNumber, city, state, zip From Property Left Join OwnerWithProperty " +
                    "ON Property.propertyId = OwnerWithProperty.propertyId Left Join Owner ON Owner.ownerId = OwnerWithProperty.ownerId " +
                    "WHERE streetNumber like '%" + searchOwner.Text + "%' " +
                    "OR firstName like '%" + searchOwner.Text + "%' " +
                    "OR lastName like '%" + searchOwner.Text + "%' " +
                    "OR CONCAT(firstName, ' ', lastName) like '%" + searchOwner.Text + "%'", myconnection);
                dt = new DataTable();
                adpt.Fill(dt);
                resultsDataGridView.DataSource = dt;
                searchOwner.Clear();
            }
        }

        private void resultsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

