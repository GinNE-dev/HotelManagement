﻿using HotelManagement.Utils;
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
    public partial class frmPlaceBooking : Form
    {
        private static frmPlaceBooking Instance;
        private Booking _booking;
        //private Room _room;
        public frmPlaceBooking()
        {
            InitializeComponent();
            //
            PrepareServiceGrid();
            ReloadServiceGrid();
            PrepareOrderedServiceGrid();
            PrepareCustomerGrid();

            Instance = this;
        }

        public static frmPlaceBooking GetInstance()
        {
            if( Instance == null ) Instance = new frmPlaceBooking();
            return Instance;
        }

        public bool IsInBooking()
        {
            return _booking != null;
        }

        private bool StopBooking()
        {
            _booking = null;
            return true;
        }

        public bool RegisterToBooking(Employee employee, Room room)
        {
            if(employee == null || room == null) return false;
            if(_booking != null)
            {
                //CancelBooking();
            }
            InnitialBooking();
            room.Status = TextDictionary.ROOM_BUSSY;
            _booking.Employee = employee;
            _booking.EmployeeID = employee.ID;
            _booking.Room = room;
            _booking.RoomID = room.ID;
            return true;
        }

        public bool AddStayInRoomCustomer(Customer customer)
        {
            
            if(customer == null) return false;
            if(_booking == null || _booking.Room == null) return false;

            StayInRoom stayInRoom = new StayInRoom();
            stayInRoom.ID = Guid.NewGuid().ToString();
            stayInRoom.CustomerID = customer.ID;
            stayInRoom.RoomID = _booking.Room.ID;
            stayInRoom.Customer = customer;
            stayInRoom.Room = _booking.Room;
            stayInRoom.IsStayIn = true;
            _booking.Room.StayInRooms.Add(stayInRoom);
            
            if(_booking.Customer == null) _booking.Customer = customer;
            ReloadCustomerGrid();

            return true;
        }

        private void InnitialBooking()
        {
            _booking = new Booking();
            _booking.ID = Guid.NewGuid().ToString();
            _booking.BookDate = DateTime.Now;
            _booking.Status = TextDictionary.BOOKING_APPROVED;
            _booking.CheckinDate = DateTime.Now;
        }
        private void PrepareOrderedServiceGrid()
        {
            dataGridViewOrderedServices.Columns.Add(TextDictionary.SERVICE_ID_COLUMN_NAME, TextDictionary.SERVICE_ID_COLUMN_TEXT);
            dataGridViewOrderedServices.Columns.Add(TextDictionary.SERVICE_NAME_COLUMN_NAME, TextDictionary.SERVICE_NAME_COLUMN_TEXT);
            dataGridViewOrderedServices.Columns.Add(TextDictionary.ORDSERVICE_QUANTITY_COLUMN_NAME, TextDictionary.ORDSERVICE_QUANTITY_COLUMN_TEXT);
            dataGridViewOrderedServices.Columns.Add(TextDictionary.ORDSERVICE_TOTALCOST_COLUMN_NAME, TextDictionary.ORDSERVICE_TOTALCOST_COLUMN_TEXT);

            DataGridViewButtonColumn ButtonInColumn = new DataGridViewButtonColumn();
            ButtonInColumn.Name = TextDictionary.CONTROL_CANCEL_COLUMN_NAME;
            ButtonInColumn.Text = TextDictionary.CONTROL_CANCEL_BUTTON_TEXT;
            ButtonInColumn.FlatStyle = FlatStyle.Flat;
            ButtonInColumn.UseColumnTextForButtonValue = true;

            if (dataGridViewOrderedServices.Columns[TextDictionary.CONTROL_CANCEL_COLUMN_NAME] == null)
            {
                dataGridViewOrderedServices.Columns.Insert(dataGridViewOrderedServices.Columns.Count, ButtonInColumn);
            }
        }

        private void UpdateOrderedServiceGrid(IEnumerable<ServiceDetail> serviceDetails)
        {
            if (serviceDetails == null) return;
            foreach (ServiceDetail sd in serviceDetails)
            {
                dataGridViewOrderedServices.Rows.Add(sd.Service.ID, sd.Service.Name, sd.Quantity, sd.Quantity * sd.Service.UnitCost);
            }
        }

        private void ReloadOrderedServiceGrid(IEnumerable<ServiceDetail> sds = null)
        {
            dataGridViewOrderedServices.ClearSelection();
            dataGridViewOrderedServices.Rows.Clear();
            if (sds == null)
            {
                if(_booking!=null)
                {
                    sds = _booking.ServiceDetails;
                }
            }

            UpdateOrderedServiceGrid(sds);
        }

        private void PrepareServiceGrid()
        {
            dataGridViewServices.Columns.Add(TextDictionary.SERVICE_ID_COLUMN_NAME, TextDictionary.SERVICE_ID_COLUMN_TEXT);
            dataGridViewServices.Columns.Add(TextDictionary.SERVICE_NAME_COLUMN_NAME, TextDictionary.SERVICE_NAME_COLUMN_TEXT);
            dataGridViewServices.Columns.Add(TextDictionary.SERVICE_INSTOCK_COLUMN_NAME, TextDictionary.SERVICE_INSTOCK_COLUMN_TEXT);
            dataGridViewServices.Columns.Add(TextDictionary.SERVICE_PRICE_COLUMN_NAME, TextDictionary.SERVICE_PRICE_COLUMN_TEXT);
            dataGridViewServices.Columns.Add(TextDictionary.SERVICE_DESCRIPTION_COLUMN_NAME, TextDictionary.SERVICE_DESCRIPTION_COLUMN_TEXT);

            DataGridViewButtonColumn ButtonInColumn = new DataGridViewButtonColumn();
            ButtonInColumn.Name = TextDictionary.CONTROL_ORDER_BUTTON_NAME;
            ButtonInColumn.Text = TextDictionary.CONTROL_ORDER_BUTTON_TEXT;
            ButtonInColumn.FlatStyle = FlatStyle.Flat;
            ButtonInColumn.UseColumnTextForButtonValue = true;

            if (dataGridViewServices.Columns[TextDictionary.CONTROL_ORDER_COLUMN_NAME] == null)
            {
                dataGridViewServices.Columns.Insert(dataGridViewServices.Columns.Count, ButtonInColumn);
            }
            /*
            foreach (DataGridViewColumn col in dataGridViewServices.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            */
        }

        private void UpdateServiceGrid(IEnumerable<Service> services)
        {
            if (services == null) return;
            //Filtering
            string key = "";// txtSearch.Text.ToLower();
            bool pass = true;
            foreach (Service sc in services)
            {
                pass = false;
                pass = pass || sc.ID.ToString().ToLower().Contains(key);
                pass = pass || sc.Name.ToLower().Contains(key);

                if (pass)
                {
                    dataGridViewServices.Rows.Add(sc.ID, sc.Name, sc.InStock, sc.UnitCost, sc.Description);
                }
            }
        }

        private void ReloadServiceGrid(IEnumerable<Service> services = null)
        {
            dataGridViewServices.ClearSelection();
            dataGridViewServices.Rows.Clear();
            if (services == null)
            {
                services = HotelDB.GetDBEntities().Services.ToList();
            }

            UpdateServiceGrid(services);
        }

        private void PrepareCustomerGrid()
        {
            dataGridViewStayInRoom.Columns.Add(TextDictionary.CLIENT_ID_COLUMN_NAME, TextDictionary.CLIENT_ID_COLUMN_TEXT);
            dataGridViewStayInRoom.Columns.Add(TextDictionary.CLIENT_NAME_COLUMN_NAME, TextDictionary.CLIENT_NAME_COLUMN_TEXT);
            dataGridViewStayInRoom.Columns.Add(TextDictionary.CLIENT_AGE_COLUMN_NAME, TextDictionary.CLIENT_AGE_COLUMN_TEXT);
            dataGridViewStayInRoom.Columns.Add(TextDictionary.CLIENT_GENDER_COLUMN_NAME, TextDictionary.CLIENT_GENDER_COLUMN_TEXT);
            dataGridViewStayInRoom.Columns.Add(TextDictionary.CLIENT_PHONE_COLUMN_NAME, TextDictionary.CLIENT_PHONE_COLUMN_TEXT);
            dataGridViewStayInRoom.Columns.Add(TextDictionary.CLIENT_EMAIL_COLUMN_NAME, TextDictionary.CLIENT_EMAIL_COLUMN_TEXT);
            dataGridViewStayInRoom.Columns.Add(TextDictionary.CLIENT_CITIZENID_COLUMN_NAME, TextDictionary.CLIENT_CITIZENID_COLUMN_TEXT);

            DataGridViewButtonColumn ButtonInColumn = new DataGridViewButtonColumn();
            ButtonInColumn.Name = TextDictionary.CONTROL_DELETE_BUTTON_NAME;
            ButtonInColumn.Text = TextDictionary.CONTROL_DELETE_BUTTON_TEXT;
            ButtonInColumn.FlatStyle = FlatStyle.Flat;
            ButtonInColumn.UseColumnTextForButtonValue = true;

            if (dataGridViewStayInRoom.Columns[TextDictionary.CONTROL_DELETE_COLUMN_NAME] == null)
            {
                dataGridViewStayInRoom.Columns.Insert(dataGridViewStayInRoom.Columns.Count, ButtonInColumn);
            }

        }

        private void UpdateCustomerGrid(IEnumerable<StayInRoom> customers)
        {
            if (customers == null) return;

            foreach(StayInRoom stay in customers)
            {
                var c = stay.Customer;
                if (c == null) continue;
                dataGridViewStayInRoom.Rows.Add(c.ID, c.Name, c.Age, c.Gender, c.Phone, c.Email, c.CitizenID);
            }
        }

        private void ReloadCustomerGrid(IEnumerable<StayInRoom> customers = null)
        {
            if(customers == null)
            {
                //if (_booking == null) MessageBox.Show("Hehe");
                if (_booking == null || _booking.Room == null) return;
                customers = _booking.Room.StayInRooms;
            }

            dataGridViewStayInRoom.ClearSelection();
            dataGridViewStayInRoom.Rows.Clear();

            UpdateCustomerGrid(customers);
        }

        public void CancelBooking()
        {
            if (_booking != null)
            {
                foreach (ServiceDetail sd in _booking.ServiceDetails)
                {
                    sd.Service.InStock += sd.Quantity;
                }
                _booking.Room.Status = TextDictionary.ROOM_READY;
                StopBooking();
                HotelDB.GetDBEntities().SaveChanges();
            }
        }

        private void ConfirmBooking()
        {
            if (_booking == null) return;
            if (_booking.Room == null) return;

            if (_booking.Room.StayInRooms.Count < 1)
            {
                MessageBox.Show("Please add at least one customer!");
                return;
            }


            HotelDB.GetDBEntities().Bookings.Add(_booking);
            
            StopBooking();
            HotelDB.SaveChanges();
        }

        private DialogResult NumericInputDialog(string title, string message, ref int inputValue)
        {

            Form dialog = new Form();
            Label label = new Label();
            NumericUpDown numInput = new NumericUpDown();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            dialog.Text = title;
            label.Text = message;
            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(10, 40, 90, 16);
            numInput.SetBounds(10, 59, 123, 22);
            numInput.Minimum = 1;
            numInput.Maximum = 1000;
            buttonOk.SetBounds(10, 117, 75, 23);
            buttonCancel.SetBounds(127, 117, 75, 23);

            label.AutoSize = true;
            dialog.ClientSize = new Size(208, 150);
            dialog.FormBorderStyle = FormBorderStyle.FixedDialog;
            dialog.StartPosition = FormStartPosition.Manual;
            dialog.Location = DrawingMathHelper.FindSmallPointCenter(this.Location, this.Size, dialog.Size);
            dialog.MinimizeBox = false;
            dialog.MaximizeBox = false;

            dialog.Controls.AddRange(new Control[] { label, numInput, buttonOk, buttonCancel });
            dialog.AcceptButton = buttonOk;
            dialog.CancelButton = buttonCancel;

            DialogResult dialogResult = dialog.ShowDialog();
            inputValue = int.Parse(numInput.Value.ToString());

            return dialogResult;
        }

        private void dataGridViewServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            DataGridViewCellCollection cells = dataGridViewServices.Rows[e.RowIndex].Cells;

            var selectedColumnName = dataGridViewServices.Columns[e.ColumnIndex].Name;

            switch(selectedColumnName)
            {
                case TextDictionary.CONTROL_ORDER_COLUMN_NAME:
                    string sID = cells[TextDictionary.SERVICE_ID_COLUMN_NAME].Value.ToString();
                    Service service = HotelDB.GetDBEntities().Services.FirstOrDefault(s => s.ID.Equals(sID));

                    int quantity = 1;
                    if (NumericInputDialog(TextDictionary.TITLE_ORDER_QUANTITY_DIALOG,
                        TextDictionary.MESSAGE_ORDER_QUANTITY_DIALOG, ref quantity) == DialogResult.OK)
                    {
                        if (service != null)
                        {
                            if(service.InStock >= quantity)
                            {
                                service.InStock -= quantity;
                                ServiceDetail serviceDetail;
                                serviceDetail = _booking.ServiceDetails.FirstOrDefault(x=>x.ServiceID.Equals(sID));

                                if (serviceDetail == null)
                                {
                                    serviceDetail = new ServiceDetail();
                                    serviceDetail.ID = Guid.NewGuid().ToString();
                                    serviceDetail.Service = service;
                                    serviceDetail.Booking = _booking;
                                    serviceDetail.ServiceID = service.ID;
                                    serviceDetail.BookingID = _booking.ID;
                                    serviceDetail.Quantity = quantity;
                                }
                                else
                                {
                                    serviceDetail.Quantity += quantity;
                                }

                                _booking.ServiceCost += service.UnitCost * quantity;

                                _booking.ServiceDetails.Add(serviceDetail);
                                HotelDB.SaveChanges();
                                ReloadServiceGrid();
                                ReloadOrderedServiceGrid(_booking.ServiceDetails);
                            }
                            else
                            {
                                MessageBox.Show(TextDictionary.MESSAGE_NOT_ENOUGH_QUANTITY_INSTOCK);
                            }
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private void dataGridViewOrderedServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            DataGridViewCellCollection cells = dataGridViewOrderedServices.Rows[e.RowIndex].Cells;

            var selectedColumnName = dataGridViewOrderedServices.Columns[e.ColumnIndex].Name;
            switch (selectedColumnName)
            {
                case TextDictionary.CONTROL_CANCEL_COLUMN_NAME:
                    DialogResult dialogResult = MessageBox.Show(TextDictionary.MESSAGE_CONFIRM_CANCEL_SERVICE,
                        TextDictionary.TITLE_CONFIRM_CANCEL_SERVICE, MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string ID = cells[TextDictionary.SERVICE_ID_COLUMN_NAME].Value.ToString();
                        ServiceDetail serviceDetail = _booking.ServiceDetails.FirstOrDefault(x => x.ServiceID.Equals(ID));

                        if(serviceDetail != null)
                        {
                            if(serviceDetail.Service != null)
                            {
                                serviceDetail.Service.InStock += serviceDetail.Quantity;
                                _booking.ServiceCost -= serviceDetail.Quantity * serviceDetail.Service.UnitCost;
                            }
                            _booking.ServiceDetails.Remove(serviceDetail);
                        }
                        

                        HotelDB.SaveChanges();

                        ReloadServiceGrid();
                        ReloadOrderedServiceGrid();
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ConfirmBooking();
            frmMain.GetInstance().OpenMainChild();
            //this.Hide();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Form root = this.MdiParent != null ? this.MdiParent : this;
            Form formAddNew = new frmNewCustomer();

            formAddNew.StartPosition = FormStartPosition.Manual;
            formAddNew.Location = DrawingMathHelper.FindSmallPointCenter(root.Location, root.Size, formAddNew.Size);

            formAddNew.ShowDialog();
            ReloadCustomerGrid();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelBooking();
            frmMain.GetInstance().OpenMainChild();
            //this.Hide();
        }

        private void frmPlaceBooking_VisibleChanged(object sender, EventArgs e)
        {
            ReloadCustomerGrid();
            ReloadOrderedServiceGrid();
            ReloadServiceGrid();
            if(_booking!=null && _booking.Room != null)
            {
                lblRoomNumber.Text = _booking.Room.Number.ToString();
            }
        }

        private void dataGridViewStayInRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            DataGridViewCellCollection cells = dataGridViewStayInRoom.Rows[e.RowIndex].Cells;

            var selectedColumnName = dataGridViewStayInRoom.Columns[e.ColumnIndex].Name;
            switch (selectedColumnName)
            {
                case TextDictionary.CONTROL_DELETE_COLUMN_NAME:
                    string ID = cells[TextDictionary.CLIENT_ID_COLUMN_NAME].Value.ToString();
                    if (_booking != null && _booking.Room != null)
                    {
                        StayInRoom stayInRoom = _booking.Room.StayInRooms.FirstOrDefault(x => x.CustomerID.Equals(ID));
                        if (stayInRoom != null)
                        {
                            if (_booking.Customer != null) _booking.Customer = null;
                            _booking.Room.StayInRooms.Remove(stayInRoom);
                            ReloadCustomerGrid();
                        }
                        //dataGridViewStayInRoom.Rows.RemoveAt(e.RowIndex);   
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
