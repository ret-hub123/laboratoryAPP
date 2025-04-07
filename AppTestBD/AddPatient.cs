using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Microsoft.Identity.Client;
using System.Windows.Forms;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace AppTestBD
{
    public partial class AddPatient : Form
    {
        public AddPatient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TextID = textID.Text;
            string TextDateBirth = textDateBirth.Text;
            string TextpassSerio = textpassSerio.Text;
            string TextPassNum = textPassNum.Text;
            string TextPhone = textPhone.Text;
            string TextEmail = textEmail.Text;
            string TextPolis = textPolis.Text;
            string TexttypePolis = texttypePolis.Text;
            string TextCompany = textCompany.Text;
            

            if (string.IsNullOrEmpty(TextID) || string.IsNullOrEmpty(TextDateBirth) || string.IsNullOrEmpty(TextpassSerio) || string.IsNullOrEmpty(TextPassNum) || string.IsNullOrEmpty(TextPhone) || string.IsNullOrEmpty(TextEmail) || string.IsNullOrEmpty(TextPolis) || string.IsNullOrEmpty(TexttypePolis) || string.IsNullOrEmpty(TextCompany))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Прерываем выполнение, если поля не заполнены
            }
            DB dB = new DB();
            DataTable table = new DataTable();


            SqlCommand command_add_report = new SqlCommand("INSERT INTO[Patients](patient_id, birth_date, passport_series, passport_number, phone, email, insurance_policy_number, insurance_policy_type, insurance_company_id)" +
            "VALUES(@patient_id, @birth_date, @passport_series, @passport_number, @phone, @email, @insurance_policy_number, @insurance_policy_type, @insurance_company_id);", dB.getConnection());

            command_add_report.Parameters.Add("@patient_id", SqlDbType.VarChar).Value = TextID;
            command_add_report.Parameters.Add("@birth_date", SqlDbType.DateTime).Value = TextDateBirth;
            command_add_report.Parameters.Add("@passport_series", SqlDbType.Int).Value = TextpassSerio;
            command_add_report.Parameters.Add("@passport_number", SqlDbType.Int).Value = TextPassNum;
            command_add_report.Parameters.Add("@phone", SqlDbType.VarChar).Value = TextPhone;
            command_add_report.Parameters.Add("@email", SqlDbType.VarChar).Value = TextEmail;
            command_add_report.Parameters.Add("@insurance_policy_number", SqlDbType.VarChar).Value = TextPolis;
            command_add_report.Parameters.Add("@insurance_policy_type", SqlDbType.VarChar).Value = TexttypePolis;
            command_add_report.Parameters.Add("@insurance_company_id", SqlDbType.VarChar).Value = TextCompany;

          
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
