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
    public partial class frmNewCustomer : Form
    {
        public frmNewCustomer()
        {
            InitializeComponent();
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if(!InputValidateHelper.ValidateTextBoxLength(txtName, 1, 50))
            {
                MessageBox.Show("Please enter name!");
                txtName.Focus();
            }
        }

        private void comboBoxGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!InputValidateHelper.ValidateEmailFormat(txtEmail.Text))
            {

                MessageBox.Show("Invalid email format!");
                txtEmail.Focus();
            }
        }

        private void mtxtPhone_Leave(object sender, EventArgs e)
        {
            if(!InputValidateHelper.ValidateTextBoxLength(mtxtPhone, 12, 12))
            {
                MessageBox.Show("Please enters the correct format of phone!");
                mtxtPhone.Focus();
            }

        }

        private void mtxtCitizenID_Leave(object sender, EventArgs e)
        {
            if(!InputValidateHelper.ValidateTextBoxLength(mtxtCitizenID, 12, 12))
            {
                MessageBox.Show("Please enters the correct format citizen ID!");
                mtxtCitizenID.Focus();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(!InputValidateHelper.ValidateTextBoxLength(mtxtCitizenID, 12, 12))
            {
                MessageBox.Show("Please enters the correct format of phone!");
                mtxtPhone.Focus();
            }

            if(!InputValidateHelper.ValidateTextBoxLength(mtxtCitizenID, 12, 12))
            {
                MessageBox.Show("Please enters the correct format citizen ID!");
                mtxtCitizenID.Focus();
            }

            Customer customer = new Customer();
            customer.ID = Guid.NewGuid().ToString();
            customer.Name = txtName.Text;
            customer.Age = byte.Parse(nUDAge.Value.ToString());
            customer.Gender = comboBoxGender.Text.ToLower();
            customer.Email = txtEmail.Text;
            customer.Phone = mtxtPhone.Text;
            customer.CitizenID = mtxtCitizenID.Text;

            frmPlaceBooking.GetInstance().AddStayInRoomCustomer(customer);

            this.Close();
        }
    }
}
