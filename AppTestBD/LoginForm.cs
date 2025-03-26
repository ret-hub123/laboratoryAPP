using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace AppTestBD
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string loginUser = textLogin.Text;
            string PasswordUser = textPassword.Text;
          

            DB dB = new DB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE user_id = @login AND password = @password", dB.getConnection());
    
            command.Parameters.Add("@login", SqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = PasswordUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                MainMenu mainForm = new MainMenu(table);
                mainForm.Show();
            }
            else
                MessageBox.Show("Полшьзователь не найден");

        }

        
    }
}