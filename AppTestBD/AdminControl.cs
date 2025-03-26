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
    public partial class AdminControl : UserControl
    {
        public AdminControl()
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

       
        }
    
}
