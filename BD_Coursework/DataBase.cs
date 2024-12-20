using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BD_Coursework
{
    public class DataBase
    {
        SqlConnection _conn = new SqlConnection(@"Data Source=DESKTOP-4N1MDK1;Initial Catalog=Peredachi;Integrated Security=True");

        public void OpenConnection()
        {
            if(_conn.State == System.Data.ConnectionState.Closed)
                _conn.Open();
        }

        public void CloseConnection()
        {
            if (_conn.State == System.Data.ConnectionState.Open)
                _conn.Close();
        }

        public SqlConnection GetConnection()
        {
            return _conn;
        }
    }
}
