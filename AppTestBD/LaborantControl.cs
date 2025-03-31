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
    public partial class LaborantControl : UserControl
    {
        public LaborantControl()
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
            if (dataGridView1.Rows.Count > 0)
            {
                string laborantId = Convert.ToString(dataGridView1.Rows[0].Cells[0].Value);
                this.FindForm().Hide();

                AddBiomaterial addboimat = new AddBiomaterial(laborantId);
                addboimat.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string laborantId = Convert.ToString(dataGridView1.Rows[0].Cells[0].Value);
            this.FindForm().Hide();

            AddReports addboreports = new AddReports(laborantId);
            addboreports.Show();

        }
    }
}
