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
    public partial class AddReports : Form
    {
        public string laborantId { get; set; }
        public AddReports(string laborantId)
        {
            InitializeComponent();
            this.laborantId = laborantId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TextService = textService.Text;
            string TextDescript = textDescript.Text;
            string TextType = textType.Text;

            if ( string.IsNullOrEmpty(TextType) || string.IsNullOrEmpty(TextDescript))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Прерываем выполнение, если поля не заполнены
            }

            DB dB = new DB();
            DataTable table = new DataTable();


            SqlCommand command_add_report = new SqlCommand("INSERT INTO Reports (report_type, creationDate, laborant_id, performed_services_id, report_Data)" +
            "VALUES(@report_type, CONVERT(DATETIME, @creationDate , 120), @laborant_id, @performed_services_id, @report_Data);", dB.getConnection());

            command_add_report.Parameters.Add("@report_Data", SqlDbType.VarChar).Value = TextDescript;
            command_add_report.Parameters.Add("@report_type", SqlDbType.VarChar).Value = TextType;
            command_add_report.Parameters.Add("@performed_services_id", SqlDbType.Int).Value = TextService;

            DateTime currentTime = DateTime.Now;
            string currentTimeString = currentTime.ToString("yyyy-MM-dd HH:mm:ss");

            command_add_report.Parameters.Add("@laborant_id", SqlDbType.VarChar).Value = laborantId;
            command_add_report.Parameters.Add("@creationDate", SqlDbType.VarChar).Value = currentTimeString;

            try
            {
                dB.openConnection();
                command_add_report.ExecuteNonQuery();
                MessageBox.Show("Данные успешно добавлены!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}
