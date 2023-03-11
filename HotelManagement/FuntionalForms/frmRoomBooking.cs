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
    public partial class frmRoomBooking : Form
    {
        public frmRoomBooking()
        {
            InitializeComponent();
            PrepareRoomGrid();
        }

        private void PrepareRoomGrid()
        {

            dataGridViewRoom.Rows.Clear();
            dataGridViewRoom.Columns.Add(TextDictionary.ROOM_ID_COLUMN_NAME, TextDictionary.ROOM_ID_COLUMN_TEXT);
            dataGridViewRoom.Columns[TextDictionary.ROOM_ID_COLUMN_NAME].Visible = false;
            dataGridViewRoom.Columns.Add(TextDictionary.ROOM_NUMBER_COLUMN_NAME, TextDictionary.ROOM_NUMBER_COLUMN_TEXT);
            dataGridViewRoom.Columns.Add(TextDictionary.ROOM_TYPE_COLUMN_NAME, TextDictionary.ROOM_TYPE_COLUMN_TEXT);
            dataGridViewRoom.Columns.Add(TextDictionary.ROOM_HOURCOST_COLUMN_NAME, TextDictionary.ROOM_HOURCOST_COLUMN_TEXT);
            dataGridViewRoom.Columns.Add(TextDictionary.ROOM_STATUS_COLUMN_NAME, TextDictionary.ROOM_STATUS_COLUMN_TEXT);
            dataGridViewRoom.Columns.Add(TextDictionary.ROOM_VIP_COLUMN_NAME, TextDictionary.ROOM_VIP_COLUMN_TEXT);
            dataGridViewRoom.Columns.Add(TextDictionary.ROOM_DESCRIPTION_COLUMN_NAME, TextDictionary.ROOM_DESCRIPTION_COLUMN_TEXT);
            dataGridViewRoom.Columns[TextDictionary.ROOM_DESCRIPTION_COLUMN_NAME].Visible = false;


            DataGridViewButtonColumn ButtonInColumn = new DataGridViewButtonColumn();
            ButtonInColumn.Name = TextDictionary.CONTROL_BOOK_BUTTON_NAME;
            ButtonInColumn.Text = TextDictionary.CONTROL_BOOK_BUTTON_TEXT;
            ButtonInColumn.FlatStyle = FlatStyle.Flat;
            ButtonInColumn.UseColumnTextForButtonValue = true;

            if (dataGridViewRoom.Columns[TextDictionary.CONTROL_BOOK_COLUMN_NAME] == null)
            {
                dataGridViewRoom.Columns.Insert(dataGridViewRoom.Columns.Count, ButtonInColumn);
            }

            /*
            DataGridViewButtonColumn ButtonInColumnM = new DataGridViewButtonColumn();
            ButtonInColumnM.Name = TextDictionary.CONTROL_ROOMMANAGE_BUTTON_NAME;
            ButtonInColumnM.Text = TextDictionary.CONTROL_ROOMMANAGE_BUTTON_TEXT;
            ButtonInColumnM.FlatStyle = FlatStyle.Flat;
            ButtonInColumnM.UseColumnTextForButtonValue = true;

            if (dataGridViewRoom.Columns[TextDictionary.CONTROL_ROOMMANAGE_COLUMN_NAME] == null)
            {
                dataGridViewRoom.Columns.Insert(dataGridViewRoom.Columns.Count, ButtonInColumnM);
            }
            */
        }

        private void UpdateRoomGrid(IEnumerable<Room> rooms)
        {
            if (rooms == null) return;
            //Filtering
            string key = txtSearch.Text.ToLower();
            bool pass = true;
            foreach (Room r in rooms)
            {
                /*
                pass = false;
                pass = pass || room.Number.ToString().ToLower().Equals(key);
                pass = pass || room.RoomType.ToLower().Equals(key);
                pass = pass || room.Status.ToLower().Equals(key);
                
                if (checkBoxVIP.Checked)
                {
                    pass &= room.VIP;
                }
                */
                /*
                if(dataGridViewRoom.Rows.Count>0)
                {
                    row = (DataGridViewRow)dataGridViewRoom.Rows[0].Clone();
                }
                else
                {
                    
                }
                */
                dataGridViewRoom.Rows.Add(r.ID, r.Number, r.RoomType, r.HourCost, r.Status, r.VIP, r.Description);
            }

            foreach (DataGridViewRow row in dataGridViewRoom.Rows)
            {
                switch (row.Cells[TextDictionary.ROOM_STATUS_COLUMN_NAME].Value.ToString())
                {
                    case TextDictionary.ROOM_READY:
                        row.DefaultCellStyle.BackColor = Color.FromArgb(104, 232, 90);
                        break;
                    case TextDictionary.ROOM_BUSSY:
                        row.DefaultCellStyle.BackColor = Color.FromArgb(232, 90, 90);
                        break;
                    case TextDictionary.ROOM_CLEANING:
                        row.DefaultCellStyle.BackColor = Color.FromArgb(187, 232, 90);
                        break;
                    case TextDictionary.ROOM_FIXING:
                        row.DefaultCellStyle.BackColor = Color.FromArgb(235, 137, 73);
                        break;
                    default:
                        break;
                }

            }
        }

        private void ReloadRoomGrid(IEnumerable<Room> rooms = null)
        {
           if(rooms == null)
            {
                rooms = HotelDB.GetDBEntities().Rooms.ToList();
            }

            dataGridViewRoom.ClearSelection();
            dataGridViewRoom.Rows.Clear();

            UpdateRoomGrid(rooms);
        }

        private void frmRoomBooking_VisibleChanged(object sender, EventArgs e)
        {
            ReloadRoomGrid();
        }

        private void dataGridViewRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            DataGridViewCellCollection cells = dataGridViewRoom.Rows[e.RowIndex].Cells;

            var selectedColumnName = dataGridViewRoom.Columns[e.ColumnIndex].Name;
            switch(selectedColumnName)
            {
                case TextDictionary.CONTROL_BOOK_BUTTON_NAME:
                    DialogResult dialogResult = MessageBox.Show(TextDictionary.MESSAGE_COMFIRM_BOOKROOM,
                        TextDictionary.TITLE_COMFIRM_BOOKROOM, MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string ID = cells[TextDictionary.ROOM_ID_COLUMN_NAME].Value.ToString();
                        Room room = HotelDB.GetDBEntities().Rooms.FirstOrDefault(x=>x.ID.Equals(ID));
                        Employee employee = frmMain.GetInstance()._currentUser;

                        if(employee != null && room != null)
                        {
                            switch(room.Status)
                            {
                                case TextDictionary.ROOM_BUSSY:
                                    MessageBox.Show(TextDictionary.MESSAGE_ROOM_BUSSY);
                                    break;
                                case TextDictionary.ROOM_FIXING:
                                    MessageBox.Show(TextDictionary.MESSAGE_ROOM_FIXING);
                                    break;
                                case TextDictionary.ROOM_CLEANING:
                                    MessageBox.Show(TextDictionary.MESSAGE_ROOM_CLEANING);
                                    break;
                                default:
                                    frmPlaceBooking placeBooking = new frmPlaceBooking();
                                    placeBooking.RegisterToBooking(employee, room);
                                    placeBooking.ShowDialog();
                                    
                                    break;
                            }
                        }
                    }
                    break;
                case TextDictionary.CONTROL_ROOMMANAGE_BUTTON_NAME:
                    
                    
                    break;
                default:
                    break;
            }
        }

        private void ShowRowRoomCellsData(DataGridViewCellCollection cells)
        {
            if (cells == null) return;
            lblROOMNUMBER2.Text = cells[TextDictionary.ROOM_NUMBER_COLUMN_NAME].Value.ToString();
            lblRoomType2.Text = cells[TextDictionary.ROOM_TYPE_COLUMN_NAME].Value.ToString();
            lblHourCost2.Text = double.Parse(cells[TextDictionary.ROOM_HOURCOST_COLUMN_NAME].
                Value.ToString()).ToString(TextDictionary.CURRENCY_FORMAT);
            lblStatus2.Text = cells[TextDictionary.ROOM_STATUS_COLUMN_NAME].Value.ToString();
            lblVIP2.Text = bool.Parse(cells[TextDictionary.ROOM_VIP_COLUMN_NAME].Value.ToString()) ? "✔" : "✖";
            richTextBoxDecription.Text = cells[TextDictionary.ROOM_DESCRIPTION_COLUMN_NAME].Value.ToString();
        }

        private void dataGridViewRoom_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            DataGridViewCellCollection cells = dataGridViewRoom.Rows[e.RowIndex].Cells;
            ShowRowRoomCellsData(cells);
        }
    }
}
