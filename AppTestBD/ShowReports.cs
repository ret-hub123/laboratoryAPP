using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Identity.Client;

namespace AppTestBD
{
    public partial class ShowReports : Form
    {
        public string AccountantId { get; set; }
        public ShowReports(string accountantId)
        {
            InitializeComponent();
            this.AccountantId = accountantId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TextSearch = textSearch.Text;

            DB dB = new DB();
            DataTable table = new DataTable();
            SqlCommand command;


            if (int.TryParse(TextSearch, out int reportId))
            {
                // Поиск по report_id (число)
                command = new SqlCommand("SELECT * FROM Reports WHERE report_id = @report_id;", dB.getConnection());
                command.Parameters.Add("@report_id", SqlDbType.Int).Value = reportId;
            }
            // 2. Если преобразование не удалось, ищем по laborant_id (строка)
            else
            {
                // Поиск по laborant_id (строка, case-insensitive)
                command = new SqlCommand("SELECT * FROM Reports WHERE UPPER(TRIM(laborant_id)) LIKE UPPER(TRIM(@laborant_id));", dB.getConnection());
                command.Parameters.Add("@laborant_id", SqlDbType.VarChar).Value = "%" + TextSearch + "%";
            }

            try
            {
                dB.openConnection();
                SqlDataReader reader = command.ExecuteReader(); // Используем ExecuteReader для получения набора данных

                if (reader.HasRows)  // Проверяем, есть ли результаты
                {
                    table.Load(reader); // Загружаем данные из reader в DataTable
                    dataGridView1.DataSource = table;  // Привязываем DataTable к DataGridView
                }
                else
                {
                    MessageBox.Show("Отчет не найден.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                reader.Close(); // Закрываем reader после использования
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выполнении запроса: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
