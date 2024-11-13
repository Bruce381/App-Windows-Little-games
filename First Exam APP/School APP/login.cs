using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace School_APP
{
    public partial class login : Form
    {
        string username = "bruce";
        string password = "1111";

        public login()
        {
            InitializeComponent();
            this.DoubleBuffered = true;  // 启用双缓冲，减少闪烁
        }

        private void login_Load(object sender, EventArgs e)
        {
            empty();
            // 确保窗体每次重绘时都使用 OnPaintBackground 事件
            this.Invalidate(); // 请求重绘
        }

        private void empty()
        {
            show_error.Text = string.Empty;
        }

        private string GetUsername()
        {
            return username;
        }

        private void sine_in_Click(object sender, EventArgs e)
        {
            if (textBox_username.Text != username)
            {
                show_error.Text = "username wrong";
            }
            else if (textBox_password.Text != password)
            {
                show_error.Text = "password wrong";
            }
            else if (textBox_username.Text == username || textBox_password.Text == password)
            {
                Data data = new Data(username);
                data.Owner = this;
                data.Show();
                this.Hide();
            }
        }

        public void get_username()
        {
            string get_username = textBox_username.Text;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            // 弹出确认退出的对话框
            DialogResult result = MessageBox.Show("Are you sure to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // 使用 OnPaintBackground 绘制背景
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            // 获取窗体的大小
            int width = this.ClientSize.Width;
            int height = this.ClientSize.Height;

            // 固定渐变颜色
            Color color1 = Color.FromArgb(0, 128, 255); // 例如：蓝色
            Color color2 = Color.FromArgb(255, 0, 0);

            // 创建线性渐变画刷
            using (LinearGradientBrush brush = new LinearGradientBrush(
                new Rectangle(0, 0, width, height),
                color1,
                color2,
                LinearGradientMode.ForwardDiagonal)) // 渐变方向
            {
                // 填充整个窗体背景
                e.Graphics.FillRectangle(brush, 0, 0, width, height);
            }
        }
    }
}
