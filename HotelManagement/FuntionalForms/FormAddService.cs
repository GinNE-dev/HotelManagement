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
    public partial class FormAddService : Form
    {
        public FormAddService()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(!InputValidateHelper.ValidateTextBoxLength(txtName, 1, 100))
            {
                MessageBox.Show(TextDictionary.MESSAGE_SERVICE_NAME_CANNOT_EMPTY);
                txtName.Focus();
                return;
            }

            Service service = new Service();
            service.ID = Guid.NewGuid().ToString();
            service.Name = txtName.Text;
            service.InStock = int.Parse(nudInStock.Value.ToString());
            service.UnitCost = double.Parse(nudPrice.Value.ToString());
            service.Description = richTextBoxDecription.Text;

            HotelDB.GetDBEntities().Services.Add(service);
            HotelDB.SaveChanges();
            this.Close();
        }
    }
}
