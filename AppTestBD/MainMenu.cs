using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTestBD
{
    public partial class MainMenu : Form
    {
        public MainMenu(DataTable table)
        {
            InitializeComponent();
            table = table;
            foreach (DataRow row in table.Rows)
            {
                String userRole = Convert.ToString(row["user_type"]);
                LoadData(table, userRole);
            }


        }

        private void LoadData(DataTable table, string userRole)
        {
            DisplayUserInfo(table);

            Control userControl = null;
            //dataGridView1.DataSource = table;
            
            switch (userRole)
            {
                case "admin":
                userControl = new AdminControl();
                break;
                case "laborant":
                userControl = new LaborantControl();
                break;
                case "accountant":
                    userControl = new AccountantControl();
                    break;

            }
            if (userControl != null)
            {
                userControl.Dock = DockStyle.Bottom;
                panel1.Controls.Add(userControl);

                if (userControl is AccountantControl accountantControl)
                {
                    accountantControl.DisplayData(table);
                }

                if (userControl is LaborantControl laborantControl)
                {
                    laborantControl.DisplayData(table);
                }

                if (userControl is AdminControl adminntControl)
                {
                    adminntControl.DisplayData(table);
                }


            }

        }

        private void DisplayUserInfo(DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                labelFIO.Text = "Здравствуйте, " + Convert.ToString(row["full_name"]);
                labelRole.Text = "Ваша роль: " + Convert.ToString(row["user_type"]);
            }
        }







        }
}
