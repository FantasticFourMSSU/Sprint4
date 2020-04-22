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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            adpt = new MySqlDataAdapter("Select firstName, lastName, phoneNumber, email, streetNumber, city, state, zip From Property Left Join OwnerWithProperty ON property.propertyId = OwnerWithProperty.propertyId Left Join Owners ON Owner.ownerId = OwnerWithProperty.ownerId;", myconnection); 
                dt = new DataTable();
            adpt.Fill(dt);
            deletedataGridView.DataSource = dt; 


        }
    }
}
