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
    public partial class AddBiomaterial : Form
    {
        public string laborantId { get; set; }
        public AddBiomaterial(string laborantId)
        {
            InitializeComponent();
            this.laborantId = laborantId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TextPatient = textPatient.Text;
            string TextType = textType.Text;
            string TextDescript = textDescript.Text;

            if (string.IsNullOrEmpty(TextPatient) || string.IsNullOrEmpty(TextType) || string.IsNullOrEmpty(TextDescript))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Прерываем выполнение, если поля не заполнены
            }

            DB dB = new DB();
            DataTable table = new DataTable();


            SqlCommand command_add_biot = new SqlCommand("INSERT INTO Biomaterials (sampletype, сollection_Date, notes, laborant_id, patient_id) VALUES" +
            "(@sampletype, CONVERT(DATETIME, @сollection_Date , 120), @notes, @laborant_id, @patient_id); SELECT  SCOPE_IDENTITY()", dB.getConnection());

            command_add_biot.Parameters.Add("@notes", SqlDbType.VarChar).Value = TextDescript;
            command_add_biot.Parameters.Add("@sampletype", SqlDbType.VarChar).Value = TextType;
            command_add_biot.Parameters.Add("@patient_id", SqlDbType.VarChar).Value = TextPatient;


            DateTime currentTime = DateTime.Now;
            string currentTimeString = currentTime.ToString("yyyy-MM-dd HH:mm:ss");

            command_add_biot.Parameters.Add("@laborant_id", SqlDbType.VarChar).Value = laborantId;
            command_add_biot.Parameters.Add("@сollection_Date", SqlDbType.VarChar).Value = currentTimeString;

            int id_biomaterials_now = -1;
            try
            {
                dB.openConnection();
                id_biomaterials_now = Convert.ToInt32(command_add_biot.ExecuteScalar());
                MessageBox.Show("Данные успешно добавлены!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (id_biomaterials_now > 0)
            {
                SqlCommand command_add_order = new SqlCommand("INSERT INTO [Order] (biomaterials_id, creation_date, order_status) VALUES" +
                "(@biomaterials_id, CONVERT(DATETIME, @creation_date , 120), @order_status) ", dB.getConnection());

                command_add_order.Parameters.Add("@biomaterials_id", SqlDbType.Int).Value = id_biomaterials_now;
                command_add_order.Parameters.Add("@creation_date", SqlDbType.VarChar).Value = currentTimeString;
                command_add_order.Parameters.Add("@order_status", SqlDbType.VarChar).Value = "В обработке";


                try
                {
                    dB.openConnection();
                    command_add_order.ExecuteNonQuery();
                    MessageBox.Show("Заказ создан", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при добавлении данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                Console.WriteLine("Невозможно добавить запись в Order, так как не удалось создать запись в Biomaterials.");
            }



        }
    }
}
