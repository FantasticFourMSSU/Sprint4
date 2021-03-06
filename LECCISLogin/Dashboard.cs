﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace LECCISLogin
{
    public partial class Dashboard : Form
    {
        LECCISSearch.searchForm search = new LECCISSearch.searchForm();
        
        LECCISLogin.Login login = new LECCISLogin.Login();
        LECCISLogin.modify modify = new LECCISLogin.modify();
        

        public Dashboard(string usr)
        {
            InitializeComponent();
            usernameLabel.Text = usr;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            
            search.ShowDialog();
        }

        private void addOwnerButton_Click(object sender, EventArgs e)
        {
            LECCISLogin.addOwnerForm addOwner = new LECCISLogin.addOwnerForm();
            addOwner.ShowDialog();
        }
        private void editRecordButton_Click(object sender, EventArgs e)
        {
            modify.ShowDialog();
        }

        private void addPropertyButton_Click(object sender, EventArgs e)
        {
            LECCISLogin.addProperty addProperty = new LECCISLogin.addProperty();
            addProperty.ShowDialog();
        }

        private void logoutToolStripLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void addRecordButton_Click(object sender, EventArgs e)
        {
            addRecordPanel.Visible = true;
            addOwnerButton.Visible = true;
            addPropertyButton.Visible = true;
            returnButton.Visible = true;

        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            addRecordPanel.Visible = false;
            addOwnerButton.Visible = false;
            addPropertyButton.Visible = false;
            returnButton.Visible = false;
        }

        private void addRecordPanel_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
