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
    public partial class frmServiceManagement : Form
    {
        public frmServiceManagement()
        {
            InitializeComponent();
            //
            PrepareServiceGrid();
        }

        private void PrepareServiceGrid()
        {
            dgvService.Columns.Add(TextDictionary.SERVICE_ID_COLUMN_NAME, TextDictionary.SERVICE_ID_COLUMN_TEXT);
            dgvService.Columns.Add(TextDictionary.SERVICE_NAME_COLUMN_NAME, TextDictionary.SERVICE_NAME_COLUMN_TEXT);
            dgvService.Columns.Add(TextDictionary.SERVICE_INSTOCK_COLUMN_NAME, TextDictionary.SERVICE_INSTOCK_COLUMN_TEXT);
            dgvService.Columns.Add(TextDictionary.SERVICE_PRICE_COLUMN_NAME, TextDictionary.SERVICE_PRICE_COLUMN_TEXT);
            dgvService.Columns.Add(TextDictionary.SERVICE_DESCRIPTION_COLUMN_NAME, TextDictionary.SERVICE_DESCRIPTION_COLUMN_TEXT);

            DataGridViewButtonColumn ButtonInColumn = new DataGridViewButtonColumn();
            ButtonInColumn.Name = TextDictionary.CONTROL_DELETE_BUTTON_NAME;
            ButtonInColumn.Text = TextDictionary.CONTROL_DELETE_BUTTON_TEXT;
            ButtonInColumn.FlatStyle = FlatStyle.Flat;
            ButtonInColumn.UseColumnTextForButtonValue = true;

            
            if (dgvService.Columns[TextDictionary.CONTROL_DELETE_COLUMN_NAME] == null)
            {
                dgvService.Columns.Insert(dgvService.Columns.Count, ButtonInColumn);
            }
            
        }

        private void UpdateServiceGrid(IEnumerable<Service> services)
        {
            if (services == null) return;
            //Filtering
            string filter = txtSearch.Text != null ? txtSearch.Text.ToLower() : string.Empty;
            bool pass = false;
            foreach (Service sc in services)
            {
                pass = false;
                pass = pass || sc.ID.ToString().ToLower().Contains(filter);
                pass = pass || sc.Name != null && sc.Name.ToLower().Contains(filter);

                if (pass)
                {
                    dgvService.Rows.Add(sc.ID, sc.Name, sc.InStock, sc.UnitCost, sc.Description);
                }
            }
        }

        private void ReloadServiceGrid(IEnumerable<Service> services = null)
        {
            dgvService.ClearSelection();
            dgvService.Rows.Clear();
            if (services == null)
            {
                services = HotelDB.GetDBEntities().Services.ToList();
            }

            UpdateServiceGrid(services);
        }

        private void ShowServiceData(Service service)
        {
            if(service != null)
            {
                lblID.Text = service.ID;
                txtName.Text = service.Name;
                nudInStock.Value = decimal.Parse(service.InStock.ToString());
                nudPrice.Value = decimal.Parse(service.UnitCost.ToString());
                richTextBoxDecription.Text = service.Description;
            }
        }

        private void frmServiceManagement_VisibleChanged(object sender, EventArgs e)
        {
            ReloadServiceGrid();
        }

        private void dgvService_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            DataGridViewCellCollection cells = dgvService.Rows[e.RowIndex].Cells;
            string ID = cells[TextDictionary.SERVICE_ID_COLUMN_NAME].Value.ToString();
            Service service = HotelDB.GetDBEntities().Services.FirstOrDefault(x => x.ID.Equals(ID));

            ShowServiceData(service);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!InputValidateHelper.ValidateTextBoxLength(txtName, 1, 200))
            {
                MessageBox.Show(TextDictionary.MESSAGE_SERVICE_NAME_CANNOT_EMPTY);
                txtName.Focus();
                return;
            }

            DialogResult dialogResult = MessageBox.Show(TextDictionary.MESSAGE_COMFIRM_UPDATE_SERVICE,
                        TextDictionary.TITLE_COMFIRM_UPDATE_SERVICE, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string ID = lblID.Text;
                var service = HotelDB.GetDBEntities().Services.FirstOrDefault(x => x.ID.Equals(ID));
                if (service != null)
                {
                    service.Name = txtName.Text;
                    service.InStock = int.Parse(nudInStock.Value.ToString());
                    service.UnitCost = double.Parse(nudPrice.Value.ToString());
                    service.Description = richTextBoxDecription.Text;

                    HotelDB.SaveChanges();
                    ReloadServiceGrid();
                }
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if(!InputValidateHelper.ValidateTextBoxLength(txtName, 1, 200))
            {
                txtName.Focus();
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            var root = this.MdiParent != null ? this.MdiParent : this;
            var formAddNew = new FormAddService();

            formAddNew.StartPosition = FormStartPosition.Manual;
            formAddNew.Location = DrawingMathHelper.FindSmallPointCenter(root.Location, root.Size, formAddNew.Size);

            formAddNew.ShowDialog();
            ReloadServiceGrid();
        }

        private void dgvService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            DataGridViewCellCollection cells = dgvService.Rows[e.RowIndex].Cells;

            var selectedColumnName = dgvService.Columns[e.ColumnIndex].Name;
            switch (selectedColumnName)
            {
                case TextDictionary.CONTROL_DELETE_BUTTON_NAME:
                    DialogResult dialogResult = MessageBox.Show(TextDictionary.MESSAGE_CONFIRM_DELETE,
                        TextDictionary.TITLE_CONFIRM_DELETE, MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string ID = lblID.Text;
                        Service service = HotelDB.GetDBEntities().Services.FirstOrDefault(x => x.ID.Equals(ID));
                        if(service != null)
                        {
                            if(service.ServiceDetails.Count>0)
                            {
                                MessageBox.Show(TextDictionary.MESSAGE_CANNOT_DELETE_SERVICE_BE_ORDERED);
                            }
                            else
                            {
                                HotelDB.GetDBEntities().Services.Remove(service);
                                HotelDB.SaveChanges();
                                ReloadServiceGrid();
                            }
                        }
                    }
                        break;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ReloadServiceGrid();
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            ReloadServiceGrid();
        }
    }
}
