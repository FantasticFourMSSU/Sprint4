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

        public int ownerId;

        public string fullname;

        string FN = "";
        string LN = "";
        string PH = "";
        string EM = "";

       
       
        string SN = "";
        string CT = "";
        string ST = "";
        string ZP = "";
        
        

        public modify()
        {
            InitializeComponent();

            fullname = (FN + " " + LN);

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

        public void FindOwnerID()
        {
            string query = "SELECT ownerId from Owner where CONCAT(firstName, ' ', lastName) = '" + fullname + "';";
            MySqlCommand cmdDatabase = new MySqlCommand(query, myconnection);
            using (MySqlDataReader myReader = cmdDatabase.ExecuteReader())
            {
                while (myReader.Read())
                {
                    int OID = Convert.ToInt32(myReader.GetString("ownerId"));

                    ownerId = OID;
                }
            }
        }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            string street = SN;
            string city = CT;
            string state = ST;
            string zip = ZP;
            string Combo = (FN + LN);

            LECCISLogin.EditProperty editProp = new EditProperty(street,city,state,zip,Combo);
            editProp.ShowDialog();


        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            adpt = new MySqlDataAdapter("DELETE FROM OwnerWithProperty WHERE ownerId =  " + ownerId + "", myconnection);
           adpt = new MySqlDataAdapter("DELETE FROM Owner WHERE ownerId = " + ownerId + "", myconnection);
            dt = new DataTable();
            adpt.Fill(dt);
            deletedataGridView.DataSource = dt;
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

            FN = selectedRow.Cells[0].Value.ToString();
            LN = selectedRow.Cells[1].Value.ToString();
            PH = selectedRow.Cells[2].Value.ToString();
            EM = selectedRow.Cells[3].Value.ToString();
            SN = selectedRow.Cells[4].Value.ToString();
            CT = selectedRow.Cells[5].Value.ToString();
            ST = selectedRow.Cells[6].Value.ToString();
            ZP = selectedRow.Cells[7].Value.ToString();

        }

        private void SearchOwnerOrPropertyTextbox_TextChanged(object sender, EventArgs e)
        {

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
