using HotelManagement.FuntionalForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class frmMain : Form
    {
        public Employee _currentUser;
        bool sideBarExpand;
        private Form _currentChildForm;
        private frmRoomBooking RoomManagerForm = new frmRoomBooking();
        private frmBookingManagement BookingManagerForm = new frmBookingManagement();

        private static frmMain Instance;
        public frmMain()
        {
            InitializeComponent();
            Instance = this;
        }

        public static frmMain GetInstance()
        {
            if(Instance == null)
            {
                Instance = new frmMain();
            }
            return Instance;
        }

        private void OpenChildForm(Form child)
        {
            if (_currentChildForm != null)
            {
                _currentChildForm.Hide();
            }
            _currentChildForm = child;
            child.MdiParent = this;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            child.Show();
        }

        private void sideBarTimer_Tick(object sender, EventArgs e)
        {
            if(sideBarExpand)
            {
                panelMain.Width -= 10;
                if(panelMain.Width == panelMain.MinimumSize.Width)
                {
                    sideBarExpand = false;
                    sideBarTimer.Stop();
                }
            }
            else
            {
                panelMain.Width += 10;
                if(panelMain.Width ==  panelMain.MaximumSize.Width)
                {
                    sideBarExpand = true;
                    sideBarTimer.Stop();
                }
            }
        }

        private void menuButtton_Click(object sender, EventArgs e)
        {
            sideBarTimer.Start();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            OpenChildForm(RoomManagerForm);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            RoomManagerForm = new frmRoomBooking();
            _currentUser = HotelDB.GetDBEntities().Employees.FirstOrDefault();
        }

        private void btnBookingManagement_Click(object sender, EventArgs e)
        {
            //BookingManagerForm = new frmBookingManagement();
            OpenChildForm(BookingManagerForm);
        }
    }
}
