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
    public partial class modify : Form
    {
        MySqlConnection myconnection = new MySqlConnection("Server=209.106.201.103;Database=group6;uid=dbstudent9;pwd=scarybat74;");
        MySqlDataAdapter adpt;
        DataTable dt;

        public modify()
        {
            InitializeComponent();
            myconnection.Open();
            dataGridViewRefresh();
        }

        public void dataGridViewRefresh()
        {
            adpt = new MySqlDataAdapter("Select firstName, lastName, phoneNumber, email, streetNumber, city, " +
                "state, zip From Property Left Join OwnerWithProperty ON Property.propertyId = OwnerWithProperty.propertyId " +
                "Left Join Owner On Owner.ownerId = OwnerWithProperty.ownerId", myconnection);
            dt = new DataTable();
            adpt.Fill(dt);
            deletedataGridView.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            string SN = textBoxSN.Text;
            string CY = textBoxCY.Text;
            string ST = textBoxST.Text;
            string ZP = textBoxZP.Text;

            MessageBox.Show(SN + ", " + CY + ", " + ST + ", " + ZP, "Testing", MessageBoxButtons.OK);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adpt = new MySqlDataAdapter("Select firstName, lastName, phoneNumber, email, streetNumber, city, state, zip From Property Left Join OwnerWithProperty " +
                        "ON Property.propertyId = OwnerWithProperty.propertyId Left Join Owner ON Owner.ownerId = OwnerWithProperty.ownerId " +
                        "WHERE streetNumber like '%" + SearchOwnerOrPropertyTextbox.Text + "%' " +
                        "OR firstName like '%" + SearchOwnerOrPropertyTextbox.Text + "%' " +
                        "OR lastName like '%" + SearchOwnerOrPropertyTextbox.Text + "%' " +
                        "OR CONCAT(firstName, ' ', lastName) like '%" + SearchOwnerOrPropertyTextbox.Text+ "%'", myconnection);
            dt = new DataTable();
            adpt.Fill(dt);
            deletedataGridView.DataSource = dt;
       
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            dataGridViewRefresh();
        }

        private void deletedataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = deletedataGridView.Rows[index];

            textBoxFN.Text = selectedRow.Cells[0].Value.ToString();
            textBoxLN.Text = selectedRow.Cells[1].Value.ToString();
            textBoxPN.Text = selectedRow.Cells[2].Value.ToString();
            textBoxE.Text = selectedRow.Cells[3].Value.ToString();
            textBoxSN.Text = selectedRow.Cells[4].Value.ToString();
            textBoxCY.Text = selectedRow.Cells[5].Value.ToString();
            textBoxST.Text = selectedRow.Cells[6].Value.ToString();
            textBoxZP.Text = selectedRow.Cells[7].Value.ToString();

        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    adpt = new MySqlDataAdapter("Select firstName, lastName, phoneNumber, email, streetNumber, city, state, zip From Property Left Join OwnerWithProperty ON property.propertyId = OwnerWithProperty.propertyId Left Join Owners ON Owner.ownerId = OwnerWithProperty.ownerId;", myconnection); 
        //        dt = new DataTable();
        //    adpt.Fill(dt);
        //    deletedataGridView.DataSource = dt; 


        //}


    }
}
