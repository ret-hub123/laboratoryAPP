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
    public partial class DecideReport : Form
    {
        public string laborantId { get; set; }
        public DecideReport(string laborantId)
        {
            InitializeComponent();
            laborantId = laborantId;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.FindForm().Hide();

            AddReports addboreports = new AddReports(laborantId);
            addboreports.Show();
        }
    }
}
