using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.world
{
    class DatabaseConnection
    {
        private static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["Data_connection"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
