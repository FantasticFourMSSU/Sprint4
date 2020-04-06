using System;
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
        LECCISLogin.addOwnerForm addOwner = new LECCISLogin.addOwnerForm();
        LECCISLogin.addProperty addProperty = new LECCISLogin.addProperty();
        LECCISLogin.Login login = new LECCISLogin.Login();

        public Dashboard()
        {
            InitializeComponent();
            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            
            search.ShowDialog();
        }

        private void addOwnerButton_Click(object sender, EventArgs e)
        {
            
            addOwner.ShowDialog();
        }

        private void addPropertyButton_Click(object sender, EventArgs e)
        {
            
            addProperty.ShowDialog();
        }

        private void logoutToolStripLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.ShowDialog();
            this.Close();
        }
    }
}
