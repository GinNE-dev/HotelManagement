using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Utils
{
    internal class CryptographyHelper
    {
        public static string ComputeSHA256(string s)
        {
            string hash = String.Empty;

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashValue = sha256.ComputeHash(Encoding.UTF8.GetBytes(s));

                // Expecting hashed in string format
                foreach (byte b in hashValue)
                {
                    hash += $"{b:X2}";
                }
            }

            return hash;
        }

        public static bool ValidateSHA256(string raw, string hashed)
        {
            return ComputeSHA256(raw).ToLower().Equals(hashed.ToLower());
        }
    }
}
