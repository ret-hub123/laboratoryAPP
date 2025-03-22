using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace AppTestBD
{
    public partial class Form1 : Form
    {
        //Строка подключения. Убедитесь, что она правильно настроена
        private string connectionString = @"Data Source=DESKTOP-KSH314B\MSSQLSERVER1;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

             using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand get_patient = new SqlCommand("SELECT * FROM Patients", connection);  //  SELECT * FROM Patients
                    SqlDataReader reader = get_patient.ExecuteReader();

                    // Создаем DataTable для хранения данных
                    DataTable dt = new DataTable();
                    Console.WriteLine(reader);

            }
            
            
        }
    }
}