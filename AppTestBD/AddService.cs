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

namespace AppTestBD
{
    public partial class AddService : Form
    {
        private int _currentOrderId;
        private AddBiomaterial _lastForm;

        public AddService(int order_id, AddBiomaterial lastForm)
        {
            InitializeComponent();
            _currentOrderId = order_id;
            _lastForm = lastForm;


            label3.Text = _currentOrderId.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TextID = textID.Text;
            string TextStatus = textStatus.Text;
            


            if (string.IsNullOrEmpty(TextID) || string.IsNullOrEmpty(TextStatus))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Прерываем выполнение, если поля не заполнены
            }
            DB dB = new DB();
            DataTable table = new DataTable();


            SqlCommand command_add_servis = new SqlCommand("INSERT INTO OrderInServices (order_status, laboratory_services_id, order_id) " +
                "VALUES (@order_status, @laboratory_services_id, @order_id)", dB.getConnection());

            command_add_servis.Parameters.Add("@order_status", SqlDbType.VarChar).Value = TextStatus;
            command_add_servis.Parameters.Add("@laboratory_services_id", SqlDbType.Int).Value = TextID;
            command_add_servis.Parameters.Add("@order_id", SqlDbType.Int).Value = _currentOrderId;
           
            

            try
            {
                dB.openConnection();
                command_add_servis.ExecuteNonQuery();
                MessageBox.Show("Данные успешно добавлены!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (_lastForm != null)
                {
                    _lastForm.Show();
                    this.Hide(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
