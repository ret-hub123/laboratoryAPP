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
    public partial class InsuranceInvoices : Form
    {
        public string AccountantId { get; set; }
        public InsuranceInvoices(string accountantId)
        {
            InitializeComponent();
            this.AccountantId = accountantId;

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string Textname_id = textname.Text;
            string TextSum = textSum.Text;
            string TextDescript = textDescript.Text;

            if (string.IsNullOrEmpty(Textname_id) || string.IsNullOrEmpty(TextSum) || string.IsNullOrEmpty(TextDescript))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Прерываем выполнение, если поля не заполнены
            }


            DB dB = new DB();
            DataTable table = new DataTable();
           

            SqlCommand command = new SqlCommand("INSERT INTO InsuranceInvoices (accountant_id, insurance_company_id, data, sum, description) VALUES" +
            "(@accountant_id, @insurance_company_id, CONVERT(DATETIME, @data , 120), @sum, @description) ", dB.getConnection());

            command.Parameters.Add("@description", SqlDbType.VarChar).Value = TextDescript;
            command.Parameters.Add("@sum", SqlDbType.Int).Value = TextSum;
            command.Parameters.Add("@insurance_company_id", SqlDbType.Int).Value = Textname_id;


            DateTime currentTime = DateTime.Now;
            string currentTimeString = currentTime.ToString("yyyy-MM-dd HH:mm:ss");

            command.Parameters.Add("@accountant_id", SqlDbType.VarChar).Value = AccountantId;
            command.Parameters.Add("@data", SqlDbType.VarChar).Value = currentTimeString;

            try
            {
                dB.openConnection();
                command.ExecuteNonQuery();
                MessageBox.Show("Данные успешно добавлены!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
    }
}
