using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_OOP_1184018
{
    class Connection
    {
        public SqlConnection GetConn()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = "Data Source = NAOMI-CHT\\SQLEXPRESS; Initial Catalog = DB_CONTOH; Integrated Security = true";
            return Conn;
        }
    }
}
