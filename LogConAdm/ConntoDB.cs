using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectSQLServer;
using System.Data.SqlClient;

namespace ConnectSQLServer
{
    public class Connection
    {
        public static int ConnToDB(string username, string password, out string str)
        {
            Console.WriteLine("Getting Connection ...");
            SqlConnection conn = DBUtils.GetDBConnection(username, password);

            try
            {
                Console.WriteLine("Openning Connection ...");

                conn.Open();

                Console.WriteLine("Connection successful!");
                str = "stat";
                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                str = e.Message;
                return 1;
            }

            Console.Read();
        }
    }

}

