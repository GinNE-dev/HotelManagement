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
    public partial class frmBookingManagement : Form
    {
        public frmBookingManagement()
        {
            InitializeComponent();
            PrepareBookingGrid();
        }

        private void PrepareBookingGrid()
        {

            dgvBooking.Rows.Clear();
            dgvBooking.Columns.Add(TextDictionary.BOOKING_ID_COLUMN_NAME, TextDictionary.BOOKING_ID_COLUMN_NAME);
            dgvBooking.Columns[TextDictionary.BOOKING_ID_COLUMN_NAME].Visible = true;
            dgvBooking.Columns.Add(TextDictionary.CLIENT_NAME_COLUMN_NAME, TextDictionary.CLIENT_NAME_COLUMN_TEXT);
            dgvBooking.Columns.Add(TextDictionary.ROOM_NUMBER_COLUMN_NAME, TextDictionary.ROOM_NUMBER_COLUMN_TEXT);
            dgvBooking.Columns.Add(TextDictionary.BOOKING_STATUS_COLUMN_NAME, TextDictionary.BOOKING_STATUS_COLUMN_TEXT);

            DataGridViewButtonColumn ButtonInColumnM = new DataGridViewButtonColumn();
            ButtonInColumnM.Name = TextDictionary.CONTROL_ROOMMANAGE_BUTTON_NAME;
            ButtonInColumnM.Text = TextDictionary.CONTROL_ROOMMANAGE_BUTTON_TEXT;
            ButtonInColumnM.FlatStyle = FlatStyle.Flat;
            ButtonInColumnM.UseColumnTextForButtonValue = true;

            if (dgvBooking.Columns[TextDictionary.CONTROL_ROOMMANAGE_COLUMN_NAME] == null)
            {
                dgvBooking.Columns.Insert(dgvBooking.Columns.Count, ButtonInColumnM);
            }
        }

        private void UpdateBookingGrid(IEnumerable<Booking> bookings)
        {
            if (bookings == null) return;
            //Filtering
            string filter = txtSearch.Text != null ? txtSearch.Text.ToLower() : String.Empty;
            bool pass = false;
            foreach (Booking b in bookings)
            {
                pass = false;
                if (b.Customer == null || b.Room == null || b.Employee == null) continue;
                
                pass = pass || b.Customer.Name != null && b.Customer.Name.ToLower().Contains(filter);
                //MessageBox.Show(pass.ToString());
                pass = pass || b.Room.Number != null && b.Room.Number.ToString().Equals(filter);

                //MessageBox.Show(b.Room.Number.ToString()+":"+filter+"-"+ b.Room.Number.ToString().Equals(filter).ToString());
                if(pass)
                {
                    dgvBooking.Rows.Add(b.ID, b.Customer.Name, b.Room.Number, b.Status);
                }
            }

            foreach (DataGridViewRow row in dgvBooking.Rows)
            {
                switch (row.Cells[TextDictionary.BOOKING_STATUS_COLUMN_NAME].Value.ToString())
                {
                    case TextDictionary.BOOKING_APPROVED:
                        row.DefaultCellStyle.BackColor = Color.FromArgb(104, 232, 90);
                        break;
                    case TextDictionary.BOOKING_CLOSED:
                        row.DefaultCellStyle.BackColor = Color.FromArgb(232, 90, 90);
                        break;
                    case TextDictionary.BOOKING_PENDING:
                        row.DefaultCellStyle.BackColor = Color.FromArgb(187, 232, 90);
                        break;
                    default:
                        break;
                }

            }
        }

        public void ReloadBookingGrid(IEnumerable<Booking> bookings = null)
        {
            if (bookings == null)
            {
                bookings = HotelDB.GetDBEntities().Bookings.ToList();
            }

            dgvBooking.ClearSelection();
            dgvBooking.Rows.Clear();

            UpdateBookingGrid(bookings);
        }

        private void frmBookingManagement_VisibleChanged(object sender, EventArgs e)
        {
            ReloadBookingGrid();
        }

        private void dgvBooking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            DataGridViewCellCollection cells = dgvBooking.Rows[e.RowIndex].Cells;

            var selectedColumnName = dgvBooking.Columns[e.ColumnIndex].Name;
            switch (selectedColumnName)
            {
                case TextDictionary.CONTROL_ROOMMANAGE_BUTTON_NAME:
                    string bID = cells[TextDictionary.BOOKING_ID_COLUMN_NAME].Value.ToString();
                    Booking booking = HotelDB.GetDBEntities().Bookings.FirstOrDefault(x => x.ID.Equals(bID));
                    if (booking != null)
                    {
                        frmManageUsedRoom frmManageUsedRoom = new frmManageUsedRoom();
                        if (booking.Status.Equals(TextDictionary.BOOKING_APPROVED))
                        {
                            frmManageUsedRoom.RegisterToManage(booking);
                            frmManageUsedRoom.ShowDialog();
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ReloadBookingGrid();
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            ReloadBookingGrid();
        }
    }
}
