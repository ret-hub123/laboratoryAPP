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
        
        static void Connect()
        {

            string connectionString = @"Source = DESKTOP - KSH314B\MSSQLSERVER1; Initial Catalog = laboratory data; Integrated Security = True; Encrypt = False";
       

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
             
                MessageBox.Show("SELECT * FROM Patients");
            }
            Console.WriteLine("Подключение закрыто...");

            Console.Read();
        }
    }
}