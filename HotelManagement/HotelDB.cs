using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement
{
    internal class HotelDB
    {
        
        private static HotelDBEntities dBEntities;
        public static HotelDBEntities GetDBEntities()
        {
            if (dBEntities == null) dBEntities = new HotelDBEntities();
            return dBEntities;
        }

        public static void SaveChanges()
        {
            GetDBEntities().SaveChanges();//Make sure ShopDBEntities not null
        }
    }
}
