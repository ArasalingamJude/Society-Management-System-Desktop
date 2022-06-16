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
using Society_Management_System.Models;

namespace Society_Management_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String userName = txtUserName.Text;
            String password = txtPassword.Text;

            //Login process
            User user = this.loginProcess(userName, password);

            if (!user.isConnected)
            {
                lblAlert.Visible = true;
                lblAlert.Text = "Database Connection Failed";
                return;
            }
            //if the login process succeed...
            if (user.loginSucceed)
            {
                ActiveForm.Hide();
                //Checking the user role
                if (user.Role == "admin"){
                    //AdminPanel adminPanel = new AdminPanel();
                    //adminPanel.Show();
                   
                }
                if (user.Role == "standard")
                {
                    //UserPanel userPanel = new UserPanel();
                    //userPanel.Show();
                    AllocateHouse alHouse = new AllocateHouse();
                    alHouse.Show();
                }
            }
            //if the login process failed...
            else
            {
                lblAlert.Visible = true;
                lblAlert.Text = "Check your Username and Password";
            }
        }

        private User loginProcess(String username, String password)
        {
            DbConnect connection = new DbConnect();
            MySqlConnection cnn = connection.DatabaseConnect();

            User user = new User();
            try
            {
                cnn.Open();

                string stm = "SELECT * from users where username=\"" + username + "\" and password=\"" + password + "\"";
                MySqlCommand cmd = new MySqlCommand(stm, cnn);
                MySqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                
                if (rdr.Read())
                {
                    user = new User(rdr.GetString("id"), rdr.GetString("username"), rdr.GetString("role"));
                    cnn.Close();
                    return user;
                }
                else
                {
                    cnn.Close();
                    return user;
                }

            }
            catch (Exception ex)
            {
                return user;
            }
        }
    }
}
