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


            textBox1.Text = Convert.ToString(_placeholderText);
            textBox1.ForeColor = System.Drawing.Color.Gray;

            // Подписываемся на события
            textBox1.GotFocus += textBox1_GotFocus;
            textBox1.LostFocus += textBox1_LostFocus;
            textBox1.KeyDown += textBox1_KeyDown;

            _currentOrderId = CreateOrder();
        }



        private void textBox1_GotFocus(object sender, EventArgs e)
        {
            if (_placeholderShown)
            {
                textBox1.Text = "";
                textBox1.ForeColor = System.Drawing.Color.Black;
                _placeholderShown = false;
            }
        }

        private void textBox1_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = Convert.ToString(_placeholderText);
                textBox1.ForeColor = System.Drawing.Color.Gray;
                _placeholderShown = true;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevent beep

           

                textBox1.Text = Convert.ToString(_placeholderText);
                textBox1.ForeColor = System.Drawing.Color.Black;
                _placeholderShown = false; // mark placeholder as no longer shown
                textBox1.SelectionStart = textBox1.Text.Length; // Move caret to end



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

        }
    }
}
