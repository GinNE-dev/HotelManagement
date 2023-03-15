using HotelManagement.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HotelManagement.FuntionalForms
{
    public partial class frmBillManagement : Form
    {
        public frmBillManagement()
        {
            InitializeComponent();
            //
            PrepareBillGrid();
        }

        private void PrepareBillGrid()
        {
            dgvBill.Rows.Clear();
            dgvBill.Columns.Add(TextDictionary.BILL_ID_COLUMN_NAME, TextDictionary.BILL_ID_COLUMN_TEXT);
            dgvBill.Columns[TextDictionary.BILL_ID_COLUMN_NAME].Visible = true;
            dgvBill.Columns.Add(TextDictionary.CLIENT_NAME_COLUMN_NAME, "Customer");
            dgvBill.Columns.Add(TextDictionary.EMPLOYEE_NAME_COLUMN_NAME, "Staff");
            dgvBill.Columns.Add(TextDictionary.BILL_DATE_COLUMN_NAME, TextDictionary.BILL_DATE_COLUMN_TEXT);
            dgvBill.Columns.Add(TextDictionary.BILL_TOTALCOST_COLUMN_NAME, TextDictionary.BILL_TOTALCOST_COLUMN_TEXT);

            DataGridViewButtonColumn ButtonInColumnM = new DataGridViewButtonColumn();
            ButtonInColumnM.Name = TextDictionary.CONTROL_PRINT_BILL_BUTTON_NAME;
            ButtonInColumnM.Text = TextDictionary.CONTROL_PRINT_BILL_BUTTON_TEXT;
            ButtonInColumnM.FlatStyle = FlatStyle.Flat;
            ButtonInColumnM.UseColumnTextForButtonValue = true;

            if (dgvBill.Columns[TextDictionary.CONTROL_PRINT_BILL_COLUMN_NAME] == null)
            {
                dgvBill.Columns.Insert(dgvBill.Columns.Count, ButtonInColumnM);
            }

            DataGridViewButtonColumn ButtonInColumnS = new DataGridViewButtonColumn();
            ButtonInColumnS.Name = TextDictionary.CONTROL_SEND_EMAIL_BILL_BUTTON_NAME;
            ButtonInColumnS.Text = TextDictionary.CONTROL_SEND_EMAIL_BILL_BUTTON_TEXT;
            ButtonInColumnS.FlatStyle = FlatStyle.Flat;
            ButtonInColumnS.UseColumnTextForButtonValue = true;

            if (dgvBill.Columns[TextDictionary.CONTROL_SEND_EMAIL_BILL_COLUMN_NAME] == null)
            {
                dgvBill.Columns.Insert(dgvBill.Columns.Count, ButtonInColumnS);
            }
        }

        private void UpdateBillGrid(IEnumerable<Bill> bills = null)
        {
            if(bills != null)
            {
                string filter = txtSearch.Text != null ? txtSearch.Text.ToLower() : String.Empty;
                bool pass = false;

                foreach (Bill b in bills)
                {
                    pass = false;
                    if (b.Customer == null || b.Employee == null) continue;
                    pass = pass || b.Customer.Name != null && b.Customer.Name.ToLower().Contains(filter);
                    pass = pass || b.Employee.Name != null && b.Employee.Name.ToLower().Contains(filter);

                    if (pass)
                    {
                        dgvBill.Rows.Add(b.ID, b.Customer.Name, b.Employee.Name, b.BillDate, b.TotalCost);
                    }
                }
            }
        }

        private void ReloadBillGrid(IEnumerable<Bill> bills = null)
        {
            dgvBill.ClearSelection();
            dgvBill.Rows.Clear();
            if(bills == null)
            {
                bills = HotelDB.GetDBEntities().Bills.ToList();
            }

            UpdateBillGrid(bills);
        }

        private void ShowBillVisible(Bill bill)
        {
            if(bill != null)
            {
                lblBillNumber.Text = "#"+bill.ID;
                lblCustomer.Text = bill.Customer.Name;
                lblStaff.Text = bill.Employee.Name;
                lblBillTime.Text = bill.BillDate.ToString();
                lblTotalCost.Text = bill.TotalCost.ToString(TextDictionary.CURRENCY_FORMAT);
                if(bill.Booking != null)
                {
                    lblServiceCost.Text = bill.Booking.ServiceCost.ToString(TextDictionary.CURRENCY_FORMAT);
                    lblExtraFee.Text = bill.Booking.ExtraFee.ToString(TextDictionary.CURRENCY_FORMAT);
                    lblRoomFee.Text = (bill.TotalCost - bill.Booking.ServiceCost - bill.Booking.ExtraFee).ToString(TextDictionary.CURRENCY_FORMAT);
                }
            }
        }

        private void frmBillManagement_VisibleChanged(object sender, EventArgs e)
        {
            ReloadBillGrid();
        }

        private void dgvBill_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            DataGridViewCellCollection cells = dgvBill.Rows[e.RowIndex].Cells;

            //var selectedColumnName = dgvBill.Columns[e.ColumnIndex].Name;
            string ID = cells[TextDictionary.BILL_ID_COLUMN_NAME].Value.ToString();
            Bill bill = HotelDB.GetDBEntities().Bills.FirstOrDefault(x => x.ID == ID);
            ShowBillVisible(bill);
        }

        private void dgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            DataGridViewCellCollection cells = dgvBill.Rows[e.RowIndex].Cells;

            var selectedColumnName = dgvBill.Columns[e.ColumnIndex].Name;
            switch(selectedColumnName)
            {
                case TextDictionary.CONTROL_PRINT_BILL_BUTTON_NAME:
                    DialogResult dialogResult = MessageBox.Show(TextDictionary.MESSAGE_COMFIRM_PRINTBILL,
                        TextDictionary.TITLE_COMFIRM_PRINTBILL, MessageBoxButtons.YesNo);
                    if(dialogResult == DialogResult.Yes)
                    {
                        string ID = cells[TextDictionary.BILL_ID_COLUMN_NAME].Value.ToString();
                        var bill = HotelDB.GetDBEntities().Bills.FirstOrDefault(x => x.ID.Equals(ID));
                        if(bill != null)
                        {
                            var file = DataExporter.ExportBill(bill);
                            MessageBox.Show("Success!");
                        } 
                    }
                    break;
                case TextDictionary.CONTROL_SEND_EMAIL_BILL_BUTTON_NAME:
                    DialogResult dialogSensResult = MessageBox.Show(TextDictionary.MESSAGE_COMFIRM_SEND_BILL_EMAIL,
                        TextDictionary.TITLE_COMFIRM_SEND_BILL_EMAIL, MessageBoxButtons.YesNo);
                    if (dialogSensResult == DialogResult.Yes)
                    {
                        string BID = cells[TextDictionary.BILL_ID_COLUMN_NAME].Value.ToString();
                        var bill = HotelDB.GetDBEntities().Bills.FirstOrDefault(x => x.ID.Equals(BID));
                        if (bill != null)
                        {
                            var file = DataExporter.ExportBill(bill);

                            if(bill.Customer != null && bill.Customer.Email != null)
                            {
                                if(InputValidateHelper.ValidateEmailFormat(bill.Customer.Email))
                                {
                                    if (SimpleMailPost.SendMail(bill.Customer.Email, "Hotel bill", "", file))
                                    {
                                        MessageBox.Show(TextDictionary.MESSAGE_SEND_BILL_EMAIL_SUCCESS);
                                    }
                                    else
                                    {
                                        MessageBox.Show(TextDictionary.MESSAGE_SEND_BILL_EMAIL_ERROR);
                                    }
                                }
                            }
                            
                            
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ReloadBillGrid();
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            ReloadBillGrid();
        }
    }
}
