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
    public partial class ExitControl : UserControl
    {
        public ExitControl()
        {
            InitializeComponent();
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
