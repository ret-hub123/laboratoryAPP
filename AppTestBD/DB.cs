using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace AppTestBD
{
    
    class DB
    {
        

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-KSH314B\MSSQLSERVER1;Initial Catalog=""laboratory data"";Integrated Security=True;Encrypt=False");
           
        public void openConnection()
        {
              if(connection.State == System.Data.ConnectionState.Closed) 
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public SqlConnection getConnection() { return connection; }

    }
}