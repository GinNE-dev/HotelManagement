
using HotelManagement.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            HotelDBEntities HotelDBEntities = HotelDB.GetDBEntities();
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            

            if(username.Equals(String.Empty))
            {
                MessageBox.Show("Username can't be empty!");
            }
            else if(password.Equals(String.Empty))
            {
                MessageBox.Show("Password can't be empty!");
            }
            else
            {
                string hashed = CryptographyHelper.ComputeSHA256(password);
                var account = HotelDBEntities.Accounts.Where(
                    a => a.Username.Equals(username) 
                    && a.Password.Equals(hashed)
                    ).FirstOrDefault();
                if(account != null)
                {
                    //MessageBox.Show("Login success!");
                    frmMain.GetInstance().Login(account);
                    this.Hide() ;
                }
                else
                {
                    MessageBox.Show("Incorrect username or password!");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUsername.Text = String.Empty;
            txtPassword.Text = String.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain.GetInstance().Close();
        }
    }
}
