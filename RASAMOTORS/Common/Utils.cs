using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASAMOTORS.Common
{
    class Utils
    {
        private static string connectionString = "Data Source=DESKTOP-HEN8CVM;Initial Catalog=ServiceCenterManagementDB;Integrated Security=True";

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
