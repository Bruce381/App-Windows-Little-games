using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{


    public partial class Login : Form
    {
        string ur = "tom";
        string pw = "123";
        
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            user.Text = string.Empty;
            password.Text = string.Empty;
            lableshow.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (user.Text == "" || password.Text == "")
            {
                lableshow.Text = "Can't empty";
            }
            else 
            {
                if (user.Text == ur && password.Text == pw)
                {
                    lableshow.Text = "Success"; // 显示成功消息
                    lableshow.ForeColor = System.Drawing.Color.Blue;
                }
                else if (user.Text != ur && password.Text == pw)
                {
                    lableshow.Text = "User wrong";
                    lableshow.ForeColor = System.Drawing.Color.Red;
                }
                else if (user.Text == ur && password.Text != pw)
                {
                    lableshow.Text = "Password wrong";
                    lableshow.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    lableshow.Text = "User or Password wrong"; // 显示错误消息
                    lableshow.ForeColor = System.Drawing.Color.Red;
                }
            }
            
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

            
        }

        private void submit_Load(object sender, EventArgs e)
        {
            user.Select();
            lableshow.Text = null;
        }
    }
}
