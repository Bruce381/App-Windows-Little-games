using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class root : Form
    {
        public root()
        {
            InitializeComponent();
        }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("       ／＞　 フ\r\n       | 　_　_| \r\n    ／` ミ＿xノ \r\n   /　　　　 |\r\n  /　 ヽ　　ノ\r\n  │　　|　|\r\n／￣|　　|　|\r\n(￣ヽ＿_ヽ_)__)\r\n＼二)\r\n");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void game1_Click(object sender, EventArgs e)
        {
            Game1 cal = new Game1();
            cal.Show();
        }

        private void game2_Click(object sender, EventArgs e)
        {
            Game2 cal = new Game2();
            cal.Show();
        }

        private void game3_Click(object sender, EventArgs e)
        {
            Game3 cal = new Game3();
            cal.Show();
        }

        private void game4_Click(object sender, EventArgs e)
        {
            Game4 cal = new Game4();
            cal.Show();
        }

        private void loginbutten_Click(object sender, EventArgs e)
        {
            Login cal = new Login();
            cal.Show();
        }
    }
}
