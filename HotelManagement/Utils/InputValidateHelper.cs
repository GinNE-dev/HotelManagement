using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.Utils
{
    internal class InputValidateHelper
    {
        public static bool ValidateTextBoxLength(Control control,int minLengh, int maxLengh)
        {
            if (control.Text.Length < minLengh)
            {
                return false;
            }
            else if (control.Text.Length > maxLengh)
            {
                control.Text = control.Text.Substring(0, maxLengh);
            }

            return true;
        }

        public static bool ValidateEmailFormat(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
                return true;
            return false;
        }
    }
}
