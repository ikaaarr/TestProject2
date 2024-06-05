using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DemoEkzamenPrakrika
{
    internal class DBConnect
    {
        SqlConnection connStr = new SqlConnection(Properties.Settings.Default.connection);
        
            public void OpenOrClose()
            {
                if (connStr.State == System.Data.ConnectionState.Closed) connStr.Open();
                else if (connStr.State == System.Data.ConnectionState.Open) connStr.Close();
            }
            public SqlConnection getCon()
            {
                return connStr;
            }
        
    }
}
