using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTestBD
{
    public partial class AccountantControl : UserControl
    {
        public AccountantControl()
        {
            InitializeComponent();
        }

        public void DisplayData(DataTable table)
        {
            // Проверка на null и наличие данных
            if (table != null && table.Rows.Count > 0)
            {
                // Привязка данных к DataGridView
                dataGridView1.DataSource = table;

            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string accountantId = Convert.ToString(dataGridView1.Rows[0].Cells[0].Value);
            this.FindForm().Hide();

            ShowReports showreports = new ShowReports(accountantId);
            showreports.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                    string accountantId = Convert.ToString(dataGridView1.Rows[0].Cells[0].Value);
                    this.FindForm().Hide();

                    InsuranceInvoices insuranceInvoices = new InsuranceInvoices(accountantId);               
                    insuranceInvoices.Show();
                }

            }
        }
    }

