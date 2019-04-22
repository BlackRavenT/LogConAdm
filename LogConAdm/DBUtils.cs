using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConnectSQLServer
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"LENOVO-PC\BRAVEN";
            string database = "My_1";
            string username = "User-001";
            string password = "111";
                      
            return DBSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }

        public static SqlConnection GetDBConnection(string username, string password)
        {
            string datasource = @"LENOVO-PC\BRAVEN";
            string database = "My_1";

            return DBSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }
    }

}
