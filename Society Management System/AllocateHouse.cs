using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Society_Management_System.Models;
using MySql.Data.MySqlClient;

namespace Society_Management_System
{
    public partial class AllocateHouse : Form
    {
        public AllocateHouse()
        {
            InitializeComponent();
        }

        private void AllocateHouse_Load(object sender, EventArgs e)
        {

        }

        private void btnAddSociety_Click(object sender, EventArgs e)
        {

        }

        private void btnAllocateHouse_Click(object sender, EventArgs e)
        {

        }

        private void btnComplain_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHouseNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMobileNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalMembers_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSocietyName1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHouseNo1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPwd1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //User Creation
            String username = txtUserName1.Text;
            String password = txtPwd1.Text;

            long userId = onCreateNewUser(username, password);

            //House Creation
            String firstName = txtFirstName.Text;
            String lastName = txtHouseNo.Text;
            String mobile = txtMobileNo.Text;
            String totalMembers = txtTotalMembers.Text;
            String societyName = txtSocietyName1.Text;
            String houseNumber = txtHouseNo.Text;

            //HouseSociety hSociety = new HouseSociety(totalMembers, societyName, houseNumber);

            long result = onCreateHouseAndAssignUser(totalMembers, societyName, houseNumber);

            if(result == null || result == 0)
            {
                MessageBox.Show("House failed to create");
            }
            else
            {
                MessageBox.Show("House successfully created");
            }
        }

        private long onCreateNewUser(String username,String password)
        {
            String query = "INSERT INTO users (username, password) VALUES (@userName,@password )";
            
            
            DbConnect connection = new DbConnect();
            MySqlConnection cnn = connection.DatabaseConnect();
            try
            {
                cnn.Open();
                MySqlCommand cmd = new MySqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@userName", username);
                cmd.Parameters.AddWithValue("@password", password);

                MySqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();

                long userId = cmd.LastInsertedId;
               
                cnn.Close();
                return userId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("User failed to insert");
                return 0;
            }
        }

        private long onCreateHouseAndAssignUser(String totalMembers, String societyName, String houseNumber)
        {
            String query = "INSERT INTO house (total_members, society_id, house_number) VALUES (@totalMem,@societyId,@houseNum)";


            DbConnect connection = new DbConnect();
            MySqlConnection cnn = connection.DatabaseConnect();
            try
            {
                cnn.Open();
                MySqlCommand cmd = new MySqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@totalMem", totalMembers);
                cmd.Parameters.AddWithValue("@societyId", societyName);
                cmd.Parameters.AddWithValue("@houseNum", houseNumber);

                MySqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();

                long houseId = cmd.LastInsertedId;

                cnn.Close();
                return houseId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("House failed to insert");
                return 0;
            }
        }
    }
}
