using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace test_DataBase
{
    internal class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-6B2PDIN; Initial Catalog=test; Integrated Security=True");

        public void openConnection() 
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) // если коннект закрыт -> открыть
            {
                sqlConnection.Open();
            }
        }
        public void closeConnection() 
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open) 
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection getSqlConnection()
        {
            return sqlConnection;
        }
    }
}
