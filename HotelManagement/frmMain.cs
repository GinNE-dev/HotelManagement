using HotelManagement.FuntionalForms;
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

namespace HotelManagement
{
    public partial class frmMain : Form
    {
        bool sideBarExpand;
        bool managerContainerShowed;
        public Employee _currentUser { get; private set; }
        private Form _currentChildForm;
        private frmRoomBooking RoomManagerForm = new frmRoomBooking();
        private frmBookingManagement BookingManagerForm = new frmBookingManagement();
        private frmBillManagement BillManagementForm = new frmBillManagement();
        private frmPlaceBooking PlaceBookingForm = new frmPlaceBooking();
        private frmEmployeeManagement EmployeeManagementForm = new frmEmployeeManagement();
        private frmServiceManagement ServiceManagementForm = new frmServiceManagement();
        private frmStatistic StatisticForm = new frmStatistic();

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

        public void OpenMainChild()
        {
            OpenChildForm(RoomManagerForm);
        }

        public void OpenChildByFogein(Form form)
        {
            //
            OpenChildForm(form);
        }

        public void OpenPlaceBooking(Room room)
        {
            if(PlaceBookingForm.IsInBooking())
            {
                DialogResult dialogResult = MessageBox.Show(TextDictionary.MESSAGE_COMFIRM_CONTINUE_LATEST_BOOKING,
                        TextDictionary.TITLE_COMFIRM_CONTINUE_LATEST_BOOKING, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    OpenChildForm(PlaceBookingForm);
                }
            }
            else
            {
                PlaceBookingForm.RegisterToBooking(_currentUser, room);
            }
            OpenChildForm(PlaceBookingForm);
        }

        public void ReloadBookingFormVisible()
        {
            BookingManagerForm.ReloadBookingGrid();
        }

        public bool Login(Account account)
        {
            if(account != null)
            {
                if(account.Employee != null)
                {
                    _currentUser = account.Employee;
                    if(_currentUser.Position.ToLower().Equals(TextDictionary.POSITION_MANAGER.ToLower()))
                    {
                        panelManagerContainer.Visible = true;
                    }
                    OpenMainChild();
                    this.Show();
                    return true;
                }
                
            }

            return false;
        }

        private void sideBarTimer_Tick(object sender, EventArgs e)
        {
            if(sideBarExpand)
            {
                fpanelManageMenuContainer.Width -= 10;
                if(fpanelManageMenuContainer.Width == fpanelManageMenuContainer.MinimumSize.Width)
                {
                    sideBarExpand = false;
                    sideBarTimer.Stop();
                }
            }
            else
            {
                fpanelManageMenuContainer.Width += 10;
                if(fpanelManageMenuContainer.Width == fpanelManageMenuContainer.MaximumSize.Width)
                {
                    sideBarExpand = true;
                    sideBarTimer.Stop();
                }
            }
        }

        private void menuButtton_Click(object sender, EventArgs e)
        {
            if(sideBarExpand)
            {
                if(managerContainerShowed)
                {
                    timerManagerMenu.Start();
                }
            }
            sideBarTimer.Start();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            OpenChildForm(RoomManagerForm);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(TextDictionary.MESSAGE_COMFIRM_EXIT_APP,
                        TextDictionary.TITLE_COMFIRM_EXIT_APP, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            RoomManagerForm = new frmRoomBooking();
            _currentUser = HotelDB.GetDBEntities().Employees.FirstOrDefault();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
            this.Hide();
        }

        private void btnBookingManagement_Click(object sender, EventArgs e)
        {
            //BookingManagerForm = new frmBookingManagement();
            OpenChildForm(BookingManagerForm);
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            OpenChildForm(BillManagementForm);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            PlaceBookingForm.CancelBooking();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
           
        }

        private void timerManagerMenu_Tick(object sender, EventArgs e)
        {
            if(managerContainerShowed)
            {
                //MessageBox.Show("Closing");
                panelManagerContainer.Height -= 10;
                if(panelManagerContainer.Height <= panelManagerContainer.MinimumSize.Height)
                {
                    managerContainerShowed = false;
                    timerManagerMenu.Stop();
                }
            }
            else
            {
                //MessageBox.Show("COpening");
                panelManagerContainer.Height += 10;
                if (panelManagerContainer.Height >= panelManagerContainer.MaximumSize.Height)
                {
                    managerContainerShowed = true;
                    timerManagerMenu.Stop();
                }
            }
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            timerManagerMenu.Start();
        }

        private void btnEmployeeManage_Click(object sender, EventArgs e)
        {
            OpenChildForm(EmployeeManagementForm);
        }

        private void btnServiceManage_Click(object sender, EventArgs e)
        {
            OpenChildForm(ServiceManagementForm);
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            OpenChildForm(StatisticForm);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(TextDictionary.MESSAGE_COMFIRM_LOGOUT,
                        TextDictionary.TITLE_COMFIRM_LOGOUT, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                PlaceBookingForm.CancelBooking();
                this.Hide();
                frmLogin login = new frmLogin();
                login.ShowDialog();
            }
           
        }
    }
}
