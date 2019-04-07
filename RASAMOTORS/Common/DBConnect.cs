using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RASAMOTORS.Common
{
    class DBConnect
    {
        public SqlConnection con;

        public void connection()
        {
            con = new SqlConnection("Data Source=DESKTOP-T0HOCLV;Initial Catalog=ServiceCenterManagementDB;Integrated Security=True");
        }
    }
}
