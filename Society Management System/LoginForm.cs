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
            //Login Logic
            bool loginSucceed = true;

            String userName = txtUserName.Text;
            String password = txtPassword.Text;
            //loginSucceed = this.loginProcess(userName,password);

            if (loginSucceed)
            {
                this.Hide();
                AdminPanel adminPanel = new AdminPanel();
                adminPanel.Show();
            }
        }

        private Boolean loginProcess(String username, String password)
        {
            DbConnect connection = new DbConnect();
            MySqlConnection cnn = connection.DatabaseConnect();
            
            try
            {
                cnn.Open();
                //MessageBox.Show("Connection Open ! ");
                string stm = "SELECT * from users where username=\"" + username + "\" and password=\"" + password + "\"";
                MySqlCommand cmd = new MySqlCommand(stm, cnn);
                MySqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    //MessageBox.Show(rdr["username"].ToString()+ rdr["password"].ToString());
                    cnn.Close();
                    ActiveForm.Hide();
                    new MainForm().Show();
                }
                else
                {
                    lblAlert.Visible = true;
                    lblAlert.Text = "Check your Username and Password";
                }

            }
            catch (Exception ex)
            {
                //pictureBox1.Visible = false;
                lblAlert.Visible = true;
                lblAlert.Text = "Database Connection Failed";
            }
            return true;

        }
    }
}
