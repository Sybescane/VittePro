using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace VittePro1
{
    internal class DB
    {
        SqlConnection connection = new SqlConnection(@"Data source=DESKTOP-L4CKJRS;Initial catalog=VittePro;Integrated Security=True;TrustServerCertificate=True;");

        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void closedConnection()
        {
            if( connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public SqlConnection getConnection()
        {
            return connection;
        }
    }
}
