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
        public int propId;

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
            dataGridViewRefresh();
        }

        // Load and Refresh Data Grid View //
        public void dataGridViewRefresh()
        {
            myconnection.Open();
            adpt = new MySqlDataAdapter("Select firstName, lastName, phoneNumber, email, streetNumber, city, " +
                "state, zip From Property Left Join OwnerWithProperty ON Property.propertyId = OwnerWithProperty.propertyId " +
                "Left Join Owner On Owner.ownerId = OwnerWithProperty.ownerId", myconnection);
            dt = new DataTable();
            adpt.Fill(dt);
            deletedataGridView.DataSource = dt;
            myconnection.Close();
        }


    //  Look up the Owner ID of the selected record //
        public void FindOwnerID()
        {
            myconnection.Open();
            string query = "SELECT ownerId from Owner where firstName = '"+ FN + "' AND lastName = '"+ LN +"' AND phoneNumber = '"+ PH +"' AND email = '"+ EM +"';";
         // string query = "SELECT ownerId from Owner where CONCAT(firstName, ' ', lastName) = '" + fullname + "';";
            MySqlCommand cmdDatabase = new MySqlCommand(query, myconnection);
            using (MySqlDataReader myReader = cmdDatabase.ExecuteReader())
            {
                while (myReader.Read())
                {
                    int OID = Convert.ToInt32(myReader.GetString("ownerId"));

                    ownerId = OID;
                }
            }
            myconnection.Close();
        }

   
        public void FindProperty()
        {
            myconnection.Open();

            string query = "select propertyId From Property where streetNumber = '"+SN+"' AND city = '"+CT+"' AND state = '"+ST+"' AND zip = '"+ZP+"';";
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


        private void editButton_Click(object sender, EventArgs e)
        {
            string street = SN;
            string city = CT;
            string state = ST;
            string zip = ZP;
            string Combo = fullname;

            LECCISLogin.EditProperty editProp = new EditProperty(street,city,state,zip,Combo,ownerId,propId);
            editProp.ShowDialog();
            dataGridViewRefresh();

        }
        private void editOwnerButton_Click(object sender, EventArgs e)
        {
            string firstname = FN;
            string lastname = LN;
            string phone = PH;
            string email = EM;
            string Combo = fullname;

            LECCISLogin.EditOwner editOwner = new EditOwner(firstname, lastname, phone, email, ownerId);
            editOwner.ShowDialog();
            dataGridViewRefresh();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this record? This will delete" +
                " " + FN + " " + LN + "'s contact information along with the associated property: " +
                "" + SN + " " + CT + "," + ST + " " + ZP + ".", "Confirm Action", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                myconnection.Open();
                string sql1 = "DELETE FROM OwnerWithProperty WHERE ownerId =  " + ownerId + "";
                string sql2 = "DELETE FROM Owner WHERE ownerId = " + ownerId + "";
                string sql3 = "DELETE FROM Property WHERE propertyId = " + propId + "";

                using (MySqlCommand cmd = new MySqlCommand(sql1, myconnection))
                {
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {

                        }
                    }
                }
                using (MySqlCommand cmd = new MySqlCommand(sql2, myconnection))
                {
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {

                        }
                    }
                }
                using (MySqlCommand cmd = new MySqlCommand(sql3, myconnection))
                {
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {

                        }
                    }
                }
                myconnection.Close();
                dataGridViewRefresh();
            }
            else
            {
                dataGridViewRefresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myconnection.Open();
            adpt = new MySqlDataAdapter("Select firstName, lastName, phoneNumber, email, streetNumber, city, state, zip From Property Left Join OwnerWithProperty " +
                        "ON Property.propertyId = OwnerWithProperty.propertyId Left Join Owner ON Owner.ownerId = OwnerWithProperty.ownerId " +
                        "WHERE streetNumber like '%" + SearchOwnerOrPropertyTextbox.Text + "%' " +
                        "OR firstName like '%" + SearchOwnerOrPropertyTextbox.Text + "%' " +
                        "OR lastName like '%" + SearchOwnerOrPropertyTextbox.Text + "%' " +
                        "OR CONCAT(firstName, ' ', lastName) like '%" + SearchOwnerOrPropertyTextbox.Text+ "%'", myconnection);
            dt = new DataTable();
            adpt.Fill(dt);
            deletedataGridView.DataSource = dt;
            myconnection.Close();

        }
        private void showAllButton_Click(object sender, EventArgs e)
        {
            dataGridViewRefresh();
            SearchOwnerOrPropertyTextbox.Text = "";
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

            //  Places Current Value Into Full Name  //
            fullname = (FN + " " + LN);

            //  Look Up the OwnerID and PropertyID of the selected row //
            FindOwnerID();
            FindProperty();
        }

    }
}
