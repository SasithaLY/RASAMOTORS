using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASAMOTORS.Common
{
    class Utils
    {

        

       // private static string connectionString = "Data Source=DESKTOP-T0HOCLV;Initial Catalog=ServiceCenterManagementDB;Integrated Security=True";
        private static string connectionString = @"Data Source=DESKTOP-A6OVS3L\SQLEXPRESS;Initial Catalog=NetProfit;Integrated Security=True";


        public static string ConnectionString
        {
            get
            {
                return connectionString;
            }
            set
            {
                connectionString = value;
            }
        }
    }
}
