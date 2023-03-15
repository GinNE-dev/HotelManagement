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
    public partial class frmEmployeeManagement : Form
    {
        private static frmEmployeeManagement Instance;

        public frmEmployeeManagement()
        {
            InitializeComponent();
            //
            Instance = this;
            PrepareEmployeeGrid();
        }

        public static frmEmployeeManagement GetInstance()
        {
            if(Instance == null)
            {
                Instance = new frmEmployeeManagement();
            }

            return Instance;
        }

        public void AddNewEmployee(Employee employee)
        {
            if(employee != null)
            {
                HotelDB.GetDBEntities().Employees.Add(employee);
                HotelDB.SaveChanges();

                UpdateEmployeeGrid(new List<Employee>() {employee});
            }
        }

        private void PrepareEmployeeGrid()
        {
            dgvEmployee.Columns.Add(TextDictionary.EMPLOYEE_ID_COLUMN_NAME, TextDictionary.EMPLOYEE_ID_COLUMN_TEXT);
            dgvEmployee.Columns[TextDictionary.EMPLOYEE_ID_COLUMN_NAME].Visible = false;
            dgvEmployee.Columns.Add(TextDictionary.EMPLOYEE_NAME_COLUMN_NAME, TextDictionary.EMPLOYEE_NAME_COLUMN_TEXT);
            dgvEmployee.Columns.Add(TextDictionary.EMPLOYEE_EMAIL_COLUMN_NAME, TextDictionary.EMPLOYEE_EMAIL_COLUMN_TEXT);
            dgvEmployee.Columns.Add(TextDictionary.EMPLOYEE_PHONE_COLUMN_NAME, TextDictionary.EMPLOYEE_PHONE_COLUMN_TEXT);
            dgvEmployee.Columns.Add(TextDictionary.EMPLOYEE_ADDRESS_COLUMN_NAME, TextDictionary.EMPLOYEE_ADDRESS_COLUMN_TEXT);
            dgvEmployee.Columns.Add(TextDictionary.EMPLOYEE_SALARY_COLUMN_NAME, TextDictionary.EMPLOYEE_SALARY_COLUMN_TEXT);
            dgvEmployee.Columns.Add(TextDictionary.EMPLOYEE_POSITION_COLUMN_NAME, TextDictionary.EMPLOYEE_POSITION_COLUMN_TEXT);

            
            DataGridViewButtonColumn ButtonInColumnM = new DataGridViewButtonColumn();
            ButtonInColumnM.Name = TextDictionary.CONTROL_DELETE_BUTTON_NAME;
            ButtonInColumnM.Text = TextDictionary.CONTROL_DELETE_BUTTON_TEXT;
            ButtonInColumnM.FlatStyle = FlatStyle.Flat;
            ButtonInColumnM.UseColumnTextForButtonValue = true;

            if (dgvEmployee.Columns[TextDictionary.CONTROL_DELETE_COLUMN_NAME] == null)
            {
                dgvEmployee.Columns.Insert(dgvEmployee.Columns.Count, ButtonInColumnM);
            }
        }

        private void UpdateEmployeeGrid(IEnumerable<Employee> employees)
        {
            if(employees != null)
            {
                string filter = txtSearch.Text != null ? txtSearch.Text.ToLower() : string.Empty;
                bool pass = false;
                foreach(Employee e in employees)
                {
                    pass = pass || e.ID.ToLower().Contains(filter);
                    pass = pass || e.Name != null && e.Name.ToLower().Contains(filter);
                    pass = pass || e.Email != null && e.Email.ToLower().Contains(filter);
                    pass = pass || e.Phone != null && e.Phone.ToLower().Replace('-', '\0').Contains(filter);
                    
                    if (pass) dgvEmployee.Rows.Add(e.ID, e.Name, e.Email, e.Phone, e.Address, e.Salary, e.Position);
                }
            }
        }

        private void ReloadEmployeeGrid(IEnumerable<Employee> employees = null)
        {
            if(employees == null)
            {
                employees = HotelDB.GetDBEntities().Employees;
            }

            dgvEmployee.ClearSelection();
            dgvEmployee.Rows.Clear();
            UpdateEmployeeGrid(employees);
        }

        private void ShowEmployeeData(Employee employee)
        {
            if(employee != null)
            {
                lblID.Text = employee.ID;
                txtName.Text = employee.Name;
                txtEmail.Text = employee.Email;
                mtxtPhone.Text = employee.Phone;
                txtAddress.Text = employee.Address;
                nUDSalary.Value = decimal.Parse(employee.Salary.ToString());
                cbbPosition.Text = employee.Position;
            }
        }

        private void frmEmployeeManagement_VisibleChanged(object sender, EventArgs e)
        {
            ReloadEmployeeGrid();
        }

        private void dgvEmployee_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            DataGridViewCellCollection cells = dgvEmployee.Rows[e.RowIndex].Cells;
            string ID = cells[TextDictionary.EMPLOYEE_ID_COLUMN_NAME].Value.ToString();
            Employee emp = HotelDB.GetDBEntities().Employees.FirstOrDefault(x=>x.ID.Equals(ID));

            ShowEmployeeData(emp);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!InputValidateHelper.ValidateTextBoxLength(txtName, 1, 50))
            {
                MessageBox.Show(TextDictionary.MESSAGE_EMPLOYEE_NAME_CANNOT_EMPTY);
                txtName.Focus();
                return;
            }

            if (!InputValidateHelper.ValidateTextBoxLength(mtxtPhone, 12, 12))
            {
                MessageBox.Show(TextDictionary.MESSAGE_EMPLOYEE_PHONE_CANNOT_EMPTY);
                mtxtPhone.Focus();
                return;
            }

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

            DialogResult dialogResult = MessageBox.Show(TextDictionary.MESSAGE_COMFIRM_UPDATE_EMPLOYEE,
                        TextDictionary.TITLE_COMFIRM_UPDATE_EMPLOYEE, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string ID = lblID.Text;
                var emp = HotelDB.GetDBEntities().Employees.FirstOrDefault(x=>x.ID.Equals(ID));
                if(emp != null)
                {
                    emp.Name = txtName.Text;
                    emp.Email = txtEmail.Text;
                    emp.Phone = mtxtPhone.Text;
                    emp.Address = txtAddress.Text;
                    emp.Salary = double.Parse(nUDSalary.Value.ToString());
                    emp.Position = cbbPosition.Text;

                    HotelDB.SaveChanges();
                    ReloadEmployeeGrid();
                }
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            Form root = this.MdiParent != null ? this.MdiParent : this;
            Form formAddNew = new FormAddNewEmployee();

            formAddNew.StartPosition = FormStartPosition.Manual;
            formAddNew.Location = DrawingMathHelper.FindSmallPointCenter(root.Location, root.Size, formAddNew.Size);

            formAddNew.ShowDialog();
            //ReloadCustomerGrid();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string ID = lblID.Text;
            Employee employee = HotelDB.GetDBEntities().Employees.FirstOrDefault(x => x.ID.Equals(ID));
            if(employee != null)
            {
                if(employee.Accounts.Count > 0)
                {
                    MessageBox.Show("This employee alredy has an account!");
                }
                else
                {
                    FormNewAccount fna = new FormNewAccount();
                    fna.RegiserCreateAccount(employee);
                    fna.ShowDialog();
                }
            }
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            DataGridViewCellCollection cells = dgvEmployee.Rows[e.RowIndex].Cells;

            var selectedColumnName = dgvEmployee.Columns[e.ColumnIndex].Name;
            switch (selectedColumnName)
            {
                case TextDictionary.CONTROL_DELETE_BUTTON_NAME:
                   // MessageBox.Show("hh1");
                    string ID = lblID.Text;
                    Employee employee = HotelDB.GetDBEntities().Employees.FirstOrDefault(x => x.ID.Equals(ID));
                    
                    if(employee != null)
                    {
                        DialogResult dialogResult = MessageBox.Show(TextDictionary.MESSAGE_CONFIRM_DELETE,
                        TextDictionary.TITLE_CONFIRM_DELETE, MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            if (employee.Bookings.Count > 0)
                            {
                                MessageBox.Show(TextDictionary.TITLE_CANNOT_DELETE_HAS_BOOKING);
                            }
                            else if (employee.Bills.Count > 0)
                            {
                                MessageBox.Show(TextDictionary.TITLE_CANNOT_DELETE_HAS_BILLED);
                            }
                            else
                            {
                                if (frmMain.GetInstance()._currentUser != null)
                                {
                                    if (frmMain.GetInstance()._currentUser.ID.Equals(employee.ID))
                                    {
                                        MessageBox.Show(TextDictionary.TITLE_CANNOT_DELETE_YOURSELF);
                                    }
                                    else
                                    {
                                        var account = employee.Accounts.FirstOrDefault();
                                        if(account != null) HotelDB.GetDBEntities().Accounts.Remove(account);

                                        HotelDB.GetDBEntities().Employees.Remove(employee);
                                        HotelDB.SaveChanges();
                                        ReloadEmployeeGrid();
                                    }
                                }
                            }
                        }
                    }
                    break;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ReloadEmployeeGrid();
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = String.Empty;
            ReloadEmployeeGrid();
        }
    }
}
