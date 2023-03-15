using HotelManagement.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.FuntionalForms
{
    public partial class FormNewAccount : Form
    {
        private Employee _employee;
        public FormNewAccount()
        {
            InitializeComponent();
        }

        public bool RegiserCreateAccount(Employee employee)
        {
            if(employee != null)
            {
                _employee = employee;
            }

            return true;
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if(txtUsername.Text.Length<8)
            {
                MessageBox.Show("Username has at least 8 characters!");
                txtUsername.Focus();
            }
            else if(txtUsername.Text.Length>32)
            {
                MessageBox.Show("Username has 32 characters in maximum!");
                txtUsername.Text = String.Empty;
                txtUsername.Focus();
            }
            
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length < 8)
            {
                MessageBox.Show("Password has at least 8 characters!");
                txtPassword.Focus();
            }
            else if (txtPassword.Text.Length > 32)
            {
                MessageBox.Show("Password has 32 characters in maximum!");
                txtPassword.Text = String.Empty;
                txtPassword.Focus();
            }
        }

        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            if(!txtConfirmPassword.Text.Equals(txtPassword.Text))
            {
                MessageBox.Show("Not match with entered password!");
                txtConfirmPassword.Focus();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length < 8)
            {
                MessageBox.Show("Username has at least 8 characters!");
                txtUsername.Focus();
            }
            else if (txtUsername.Text.Length > 32)
            {
                MessageBox.Show("Username has 32 characters in maximum!");
                txtUsername.Text = String.Empty;
                txtUsername.Focus();
            }


            if (txtPassword.Text.Length < 8)
            {
                MessageBox.Show("Password has at least 8 characters!");
                txtPassword.Focus();
            }
            else if (txtPassword.Text.Length > 32)
            {
                MessageBox.Show("Password has 32 characters in maximum!");
                txtPassword.Text = String.Empty;
                txtPassword.Focus();
            }

            if (!txtConfirmPassword.Text.Equals(txtPassword.Text))
            {
                MessageBox.Show("Not match with entered password!");
                txtConfirmPassword.Focus();
            }

            Account account = new Account();
            account.ID = Guid.NewGuid().ToString();
            account.Username = txtUsername.Text;
            account.Password = CryptographyHelper.ComputeSHA256(txtPassword.Text);

            if(_employee != null)
            {
                account.EmployeeID = _employee.ID;
                account.Employee = _employee;
                if(_employee.Accounts.Count == 0)
                {
                    HotelDB.GetDBEntities().Accounts.Add(account);
                    _employee.Accounts.Add(account);
                    HotelDB.SaveChanges();
                    MessageBox.Show("Success!");
                }
            }

            this.Close();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtConfirmPassword.PasswordChar = '*';
            }
        }
    }
}
