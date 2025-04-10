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
using System.Transactions;
using static System.Net.Mime.MediaTypeNames;
using System.Data.Common;

namespace AppTestBD
{
    public partial class AddBiomaterial : Form
    {
        public string laborantId { get; set; }

        private int _placeholderText; 
        private bool _placeholderShown = true;
        private DB _db = new DB();
        private int _currentOrderId = -1;

        public AddBiomaterial(string laborantId)
        {
            InitializeComponent();
            this.laborantId = laborantId;

            DB dB = new DB();
            DataTable table = new DataTable();

            SqlCommand command_get_last_order_id = new SqlCommand("SELECT MAX(order_id) FROM [Order]", dB.getConnection());
            int last_order_id;

            dB.openConnection();
            last_order_id = Convert.ToInt32(command_get_last_order_id.ExecuteScalar());

            _placeholderText = last_order_id + 1;


            textBiomaterial.Text = Convert.ToString(_placeholderText);
            textBiomaterial.ForeColor = System.Drawing.Color.Gray;

            // Подписываемся на события
            textBiomaterial.GotFocus += textBox1_GotFocus;
            textBiomaterial.LostFocus += textBox1_LostFocus;
            textBiomaterial.KeyDown += textBox1_KeyDown;

            _currentOrderId = CreateOrder();
        }



        private void textBox1_GotFocus(object sender, EventArgs e)
        {
            if (_placeholderShown)
            {
                textBiomaterial.Text = "";
                textBiomaterial.ForeColor = System.Drawing.Color.Black;
                _placeholderShown = false;
            }
        }

        private void textBox1_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBiomaterial.Text))
            {
                textBiomaterial.Text = Convert.ToString(_placeholderText);
                textBiomaterial.ForeColor = System.Drawing.Color.Gray;
                _placeholderShown = true;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevent beep

           

                textBiomaterial.Text = Convert.ToString(_placeholderText);
                textBiomaterial.ForeColor = System.Drawing.Color.Black;
                _placeholderShown = false; // mark placeholder as no longer shown
                textBiomaterial.SelectionStart = textBiomaterial.Text.Length; // Move caret to end



            }
        }



        private int CreateOrder()
        {


            int newOrderId = -1;

            SqlConnection connection = _db.getConnection();


            _db.openConnection();

            SqlTransaction transaction = connection.BeginTransaction();



            try
            {
                string insertOrderQuery = "INSERT INTO [Order] (creation_date, order_status)  VALUES (@creation_date, @order_status); SELECT SCOPE_IDENTITY();";
                using (SqlCommand insertOrderCommand = new SqlCommand(insertOrderQuery, connection, transaction))
                {
                    insertOrderCommand.Parameters.Add("@creation_date", SqlDbType.DateTime).Value = DateTime.Now;
                    insertOrderCommand.Parameters.Add("@order_status", SqlDbType.VarChar).Value = "В обработке";
                    newOrderId = Convert.ToInt32(insertOrderCommand.ExecuteScalar());
                }

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Ошибка при создании заказа: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                newOrderId = -1;
            }



            return newOrderId;

        }




        private void button3_Click(object sender, EventArgs e)
        {
           
            AddService addserv = new AddService(_currentOrderId, this);

            this.Hide();
            addserv.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TextPatient = textPatient.Text;
            string TextBiomaterial = textBiomaterial.Text;
            string patint;

            if (string.IsNullOrEmpty(TextPatient) || string.IsNullOrEmpty(TextBiomaterial))
            {
                MessageBox.Show("Добавьте ID пользователя и услуги к заказу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            SqlConnection connection = _db.getConnection();
            SqlCommand command_find_patint = new SqlCommand("SELECT patient_id FROM [Patients] WHERE patient_id = @patient_id", _db.getConnection());

            command_find_patint.Parameters.Add("@patient_id", SqlDbType.VarChar).Value = TextPatient;

            _db.openConnection();

            patint = Convert.ToString(command_find_patint.ExecuteScalar());
            

            if ( string.IsNullOrEmpty(patint))
            {

                MessageBox.Show("Такого пользователя не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                AddPatient addpat = new AddPatient();
                this.Hide();
                addpat.Show();


            }
            else 
            {

                SqlCommand command_generate_order = new SqlCommand("UPDATE [Order] SET patient_id = @patient_id, biomaterials_id = @biomaterials_id   WHERE @currentOrder = order_id;", _db.getConnection());

                command_generate_order.Parameters.Add("@patient_id", SqlDbType.VarChar).Value = patint;
                command_generate_order.Parameters.Add("@biomaterials_id", SqlDbType.VarChar).Value = TextBiomaterial;
                command_generate_order.Parameters.Add("@currentOrder", SqlDbType.Int).Value = _currentOrderId;

                try
                {
                    _db.openConnection();
                    command_generate_order.ExecuteNonQuery();
                    MessageBox.Show("Заказ сформирован", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при добавлении данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }

        }
    }
}
