using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Utils
{
    internal struct TextDictionary
    {

        public const string TOOMTYPE_ALL = "All";
        public const string POSITION_MANAGER = "Manager";
        public const string BOOKING_APPROVED = "Approved";
        public const string BOOKING_CLOSED = "Closed";
        public const string BOOKING_PENDING = "Pending";
        public const string ROOM_SINGLE = "Single";
        public const string ROOM_DOUBLE = "Double";
        public const string ROOM_KING = "King";
        public const string ROOM_QUEEN = "Queen";
        public const string ROOM_READY = "Ready";
        public const string ROOM_BUSSY = "Bussy";
        public const string ROOM_CLEANING = "Cleaning";
        public const string ROOM_FIXING = "Fixing";
        public const string CURRENCY_FORMAT = "$#,##0.00";
        //NAME
        public const string BILL_ID_COLUMN_NAME = "BillID";
        public const string BILL_DATE_COLUMN_NAME = "BilDate";
        public const string BILL_TOTALCOST_COLUMN_NAME = "BillTotalCost";

        public const string EMPLOYEE_ID_COLUMN_NAME = "EID";
        public const string EMPLOYEE_NAME_COLUMN_NAME = "EName";
        public const string EMPLOYEE_EMAIL_COLUMN_NAME = "EEmail";
        public const string EMPLOYEE_PHONE_COLUMN_NAME = "EPhone";
        public const string EMPLOYEE_ADDRESS_COLUMN_NAME = "EAddress";
        public const string EMPLOYEE_SALARY_COLUMN_NAME = "ESalary";
        public const string EMPLOYEE_POSITION_COLUMN_NAME = "EPosition";

        public const string CLIENT_ID_COLUMN_NAME = "ClientID";
        public const string CLIENT_NAME_COLUMN_NAME = "ClientName";
        public const string CLIENT_AGE_COLUMN_NAME = "client-age";
        public const string CLIENT_GENDER_COLUMN_NAME = "ClientGender";
        public const string CLIENT_STAYIN_COLUMN_NAME = "isstayin";
        public const string CLIENT_EMAIL_COLUMN_NAME = "ClientEmail";
        public const string CLIENT_PHONE_COLUMN_NAME = "ClientPhone";
        public const string CLIENT_CITIZENID_COLUMN_NAME = "clien_citizenid";

        public const string BOOKING_ID_COLUMN_NAME = "BookingID";
        public const string BOOKING_DATE_COLUMN_NAME = "BookingDate";
        public const string BOOKING_STATUS_COLUMN_NAME = "BookingStatus";
        public const string BOOKING_STAYHOUR_COLUMN_NAME = "BookingStay";
        ///public const string BOOKING_ID_COLUMN_NAME = "BookingID";

        public const string ROOM_ID_COLUMN_NAME = "room_id";
        public const string ROOM_NUMBER_COLUMN_NAME = "room_number";
        public const string ROOM_TYPE_COLUMN_NAME = "room_type";
        public const string ROOM_HOURCOST_COLUMN_NAME = "room_hourcost";
        public const string ROOM_STATUS_COLUMN_NAME = "room_status";
        public const string ROOM_DESCRIPTION_COLUMN_NAME = "room_decription";
        public const string ROOM_VIP_COLUMN_NAME = "room_vip";


        public const string SERVICE_ID_COLUMN_NAME = "service_id";
        public const string SERVICE_NAME_COLUMN_NAME = "service_name";
        public const string SERVICE_INSTOCK_COLUMN_NAME = "service_instock";
        public const string SERVICE_PRICE_COLUMN_NAME = "service_price";
        public const string SERVICE_DESCRIPTION_COLUMN_NAME = "service_description";

        public const string ORDSERVICE_QUANTITY_COLUMN_NAME = "ord_quantity";
        public const string ORDSERVICE_TOTALCOST_COLUMN_NAME = "ord_subtotal";

        public const string CONTROL_SELECT_BUTTON_NAME = "Select";
        public const string CONTROL_SELECT_COLUMN_NAME = "select";

        public const string CONTROL_ORDER_BUTTON_NAME = "order";
        public const string CONTROL_ORDER_COLUMN_NAME = "order";
        public const string CONTROL_CANCEL_BUTTON_NAME = "Cancel";
        public const string CONTROL_CANCEL_COLUMN_NAME = "Cancel";
        public const string CONTROL_DELETE_BUTTON_NAME = "Delete";
        public const string CONTROL_DELETE_COLUMN_NAME = "Delete";
        public const string CONTROL_BOOK_BUTTON_NAME = "Book";
        public const string CONTROL_BOOK_COLUMN_NAME = "Book";
        public const string CONTROL_ROOMMANAGE_BUTTON_NAME = "Manage";
        public const string CONTROL_ROOMMANAGE_COLUMN_NAME = "rmanage";
        public const string CONTROL_GO_OUT_BUTTON_NAME = "Go-Out";
        public const string CONTROL_GO_OUT_COLUMN_NAME = "gout";
        public const string CONTROL_COME_IN_BUTTON_NAME = "Come-In";
        public const string CONTROL_COM_IN_COLUMN_NAME = "comein";
        public const string CONTROL_PRINT_BILL_BUTTON_NAME = "Print";
        public const string CONTROL_PRINT_BILL_COLUMN_NAME = "Print-Bill";
        public const string CONTROL_SEND_EMAIL_BILL_BUTTON_NAME = "SendEmail";
        public const string CONTROL_SEND_EMAIL_BILL_COLUMN_NAME = "SendEmail";

        //TEXT
        public const string BILL_ID_COLUMN_TEXT = "ID";
        public const string BILL_DATE_COLUMN_TEXT = "Bil Date";
        public const string BILL_TOTALCOST_COLUMN_TEXT = "Total Cost";

        public const string EMPLOYEE_ID_COLUMN_TEXT = "ID";
        public const string EMPLOYEE_NAME_COLUMN_TEXT = "Name";
        public const string EMPLOYEE_EMAIL_COLUMN_TEXT = "Email";
        public const string EMPLOYEE_PHONE_COLUMN_TEXT = "Phone";
        public const string EMPLOYEE_ADDRESS_COLUMN_TEXT = "Address";
        public const string EMPLOYEE_SALARY_COLUMN_TEXT = "Salary";
        public const string EMPLOYEE_POSITION_COLUMN_TEXT = "Position";

        public const string CLIENT_ID_COLUMN_TEXT = "ID";
        public const string CLIENT_NAME_COLUMN_TEXT = "Customer Name";
        public const string CLIENT_AGE_COLUMN_TEXT = "Age";
        public const string CLIENT_GENDER_COLUMN_TEXT = "Gender";
        public const string CLIENT_STAYIN_COLUMN_TEXT = "In room";
        public const string CLIENT_EMAIL_COLUMN_TEXT = "Email";
        public const string CLIENT_PHONE_COLUMN_TEXT = "Phone";
        public const string CLIENT_CITIZENID_COLUMN_TEXT = "CitizenID";

        public const string BOOKING_ID_COLUMN_TEXT = "ID";
        public const string BOOKING_DATE_COLUMN_TEXT = "Booking Date";
        public const string BOOKING_STATUS_COLUMN_TEXT = "Status";
        public const string BOOKING_STAYHOUR_COLUMN_TEXT = "Rent Hour";

        public const string ROOM_ID_COLUMN_TEXT = "Room ID";
        public const string ROOM_NUMBER_COLUMN_TEXT = "Room Code";
        public const string ROOM_TYPE_COLUMN_TEXT = "Type";
        public const string ROOM_HOURCOST_COLUMN_TEXT = "Hour Cost";
        public const string ROOM_STATUS_COLUMN_TEXT = "Status";
        public const string ROOM_DESCRIPTION_COLUMN_TEXT = "Decription";
        public const string ROOM_VIP_COLUMN_TEXT = "VIP";

        public const string SERVICE_ID_COLUMN_TEXT = "ID";
        public const string SERVICE_NAME_COLUMN_TEXT = "Name";
        public const string SERVICE_INSTOCK_COLUMN_TEXT = "In Stock";
        public const string SERVICE_PRICE_COLUMN_TEXT = "Price";
        public const string SERVICE_DESCRIPTION_COLUMN_TEXT = "Description";

        public const string ORDSERVICE_QUANTITY_COLUMN_TEXT = "Quantity";
        public const string ORDSERVICE_TOTALCOST_COLUMN_TEXT = "Cost";

        public const string CONTROL_SELECT_BUTTON_TEXT = "Select";
        public const string CONTROL_ORDER_BUTTON_TEXT = "Order/Add";
        public const string CONTROL_CANCEL_BUTTON_TEXT = "Cancel";
        public const string CONTROL_DELETE_BUTTON_TEXT = "Delete";
        public const string CONTROL_BOOK_BUTTON_TEXT= "Book";
        public const string CONTROL_ROOMMANAGE_BUTTON_TEXT = "Manage";
        public const string CONTROL_GO_OUT_BUTTON_TEXT = "Go-Out";
        public const string CONTROL_COME_IN_BUTTON_TEXT = "Come-In";
        public const string CONTROL_PRINT_BILL_BUTTON_TEXT = "Print";
        public const string CONTROL_SEND_EMAIL_BILL_BUTTON_TEXT = "Send Email";


        //MESSAGE
        public const string TITLE_ORDER_QUANTITY_DIALOG = "Quantity"; 
        public const string MESSAGE_ORDER_QUANTITY_DIALOG = "Quantity";
        public const string MESSAGE_SERVICE_OUT_OF_STOCK = "Out of stock";
        public const string MESSAGE_NOT_ENOUGH_QUANTITY_INSTOCK = "Instock is not enough!";
        public const string MESSAGE_CONFIRM_CANCEL_SERVICE = "Cancel?";
        public const string TITLE_CONFIRM_CANCEL_SERVICE = "Confirm cancel";
        public const string MESSAGE_CONFIRM_DELETE= "Delete?";
        public const string TITLE_CONFIRM_DELETE = "Confirm delete";
        public const string MESSAGE_TEXT_LENGH_LIMITED = "Text lengh limited!";
        public const string MESSAGE_FIELD_CANNOT_EMPTY = "Field can not be empty!";
        public const string MESSAGE_COMFIRM_BOOKROOM = "Confirm books this room";
        public const string TITLE_COMFIRM_BOOKROOM = "Confirm";
        public const string MESSAGE_ROOM_BUSSY = "This room being used!";
        public const string MESSAGE_ROOM_CLEANING = "This room being cleaned!";
        public const string MESSAGE_SERVICE_NAME_CANNOT_EMPTY = "Service name can't be empty!";
        public const string MESSAGE_EMPLOYEE_NAME_CANNOT_EMPTY = "Name can't be empty!";
        public const string MESSAGE_EMPLOYEE_PHONE_CANNOT_EMPTY = "Phone empty or incorect format!";
        public const string MESSAGE_EMPLOYEE_EMAIL_INCORRECT_FORMAT = "Email is incorrect format!";
        public const string MESSAGE_EMPLOYEE_ADDRESS_CANNOT_EMPTY = "Address can't be empty!";
        public const string MESSAGE_ROOM_FIXING = "This room not available!";
        public const string MESSAGE_COMFIRM_CLOSEBOOKING = "Confirm close this booking";
        public const string TITLE_COMFIRM_CLOSEBOOKING = "Confirm";
        public const string MESSAGE_CANNOT_CLOSEBOOKING_BILL_NOT_CREATED = "This booking does not has any bill, can not close!";
        public const string MESSAGE_COMFIRM_CREATEBILL = "Confirm to create bill";
        public const string TITLE_COMFIRM_CREATEBILL = "Confirm";
        public const string MESSAGE_COMFIRM_PRINTBILL = "Confirm to print bill";
        public const string TITLE_COMFIRM_PRINTBILL = "Confirm";
        public const string MESSAGE_COMFIRM_CONTINUE_LATEST_BOOKING = "You are in another booking, continue?";
        public const string TITLE_COMFIRM_CONTINUE_LATEST_BOOKING = "Continue uncomplete booking";
        public const string MESSAGE_COMFIRM_UPDATE_EMPLOYEE = "Realy want to update?";
        public const string TITLE_COMFIRM_UPDATE_EMPLOYEE = "Confirm update info";
        public const string MESSAGE_COMFIRM_CREATE_ACCOUNT = "Realy want to create an account?";
        public const string TITLE__COMFIRM_CREATE_ACCOUNT = "Confirm create account";
        public const string TITLE_CANNOT_DELETE_HAS_BILLED = "Can not delete because it related to a bill!";
        public const string MESSAGE_CANNOT_DELETE_SERVICE_BE_ORDERED = "Can not delete because it was ordered!";
        public const string TITLE_CANNOT_DELETE_HAS_BOOKING = "Can not delete because it related to a booking!";
        public const string TITLE_CANNOT_DELETE_YOURSELF = "Can not delete yourself!";
        public const string MESSAGE_COMFIRM_UPDATE_SERVICE = "Realy want to update?";
        public const string TITLE_COMFIRM_UPDATE_SERVICE = "Confirm update info";
        public const string MESSAGE_COMFIRM_SEND_BILL_EMAIL = "Would you like to send the bill to customer mail?";
        public const string TITLE_COMFIRM_SEND_BILL_EMAIL = "Confirm send bill";
        public const string MESSAGE_SEND_BILL_EMAIL_SUCCESS = "The bill was sent to customer!";
        public const string MESSAGE_SEND_BILL_EMAIL_ERROR = "Something went wrong please try again later or contact to dev!";
        public const string TITLE_COMFIRM_LOGOUT = "Confirm logout";
        public const string MESSAGE_COMFIRM_LOGOUT = "Logout?";
        public const string TITLE_COMFIRM_EXIT_APP = "Confirm Exit";
        public const string MESSAGE_COMFIRM_EXIT_APP = "Exit?";
    }
}
