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
    public partial class FormAddNewEmployee : Form
    {
        public FormAddNewEmployee()
        {
            InitializeComponent();
            cbbPosition.SelectedIndex = 0;
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (!InputValidateHelper.ValidateTextBoxLength(txtName, 1, 50))
            {
                MessageBox.Show(TextDictionary.MESSAGE_EMPLOYEE_NAME_CANNOT_EMPTY);
                txtName.Focus();
                return;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!InputValidateHelper.ValidateTextBoxLength(txtEmail, 1, 50))
            {
                MessageBox.Show(TextDictionary.MESSAGE_EMPLOYEE_EMAIL_INCORRECT_FORMAT);
                txtEmail.Focus();
                return;
            }
            else if (!InputValidateHelper.ValidateEmailFormat(txtEmail.Text))
            {
                MessageBox.Show(TextDictionary.MESSAGE_EMPLOYEE_EMAIL_INCORRECT_FORMAT);
                txtEmail.Focus();
                return;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!InputValidateHelper.ValidateTextBoxLength(txtName, 1, 50))
            {
                MessageBox.Show(TextDictionary.MESSAGE_EMPLOYEE_NAME_CANNOT_EMPTY);
                txtName.Focus();
                return;
            }

            if (!InputValidateHelper.ValidateTextBoxLength(txtEmail, 1, 50))
            {
                MessageBox.Show(TextDictionary.MESSAGE_EMPLOYEE_EMAIL_INCORRECT_FORMAT);
                txtEmail.Focus();
                return;
            }
            else if(!InputValidateHelper.ValidateEmailFormat(txtEmail.Text))
            {
                MessageBox.Show(TextDictionary.MESSAGE_EMPLOYEE_EMAIL_INCORRECT_FORMAT);
                txtEmail.Focus();
                return;
            }

            if (!InputValidateHelper.ValidateTextBoxLength(mtxtPhone, 12, 12))
            {
                MessageBox.Show(TextDictionary.MESSAGE_EMPLOYEE_PHONE_CANNOT_EMPTY);
                mtxtPhone.Focus();
                return;
            }

            Employee employee = new Employee();

            employee.ID = Guid.NewGuid().ToString();
            employee.Name = txtName.Text;
            employee.Email = txtEmail.Text;
            employee.Phone = mtxtPhone.Text;
            employee.Address = txtAddress.Text;
            employee.Salary = double.Parse(nUDSalary.Value.ToString());
            employee.Position = cbbPosition.Text.ToString();

            frmEmployeeManagement.GetInstance().AddNewEmployee(employee);
            this.Close();
        }
    }
}
