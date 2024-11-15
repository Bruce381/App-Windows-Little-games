// ********************************************************************
// Project: First Exam
// Author: Bruce
// Date Created: 2024-11-14
// Description: A Windows Forms application to manage student data.
// License: MIT License
// ********************************************************************

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace School_APP
{
    public partial class Login : Form
    {
        string username = "bruce"; // Username
        string password = "1111";  // Password

        public Login()
        {
            InitializeComponent();
            this.DoubleBuffered = true;  // Enable double buffering to reduce flickering
        }

        private void Login_Load(object sender, EventArgs e)
        {
            show_error.Text = string.Empty; // Clear any existing error message
            // Ensure the form is redrawn every time it is loaded
            this.Invalidate(); // Request to repaint the form
        }

        // Use OnPaintBackground to draw the background
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            // Get the size of the form
            int width = this.ClientSize.Width;
            int height = this.ClientSize.Height;

            // Set fixed gradient colors
            Color color1 = Color.FromArgb(0, 128, 255); // Blue color
            Color color2 = Color.FromArgb(255, 0, 0);    // Red color

            // Create a linear gradient brush
            using (LinearGradientBrush brush = new LinearGradientBrush(
                new Rectangle(0, 0, width, height),
                color1,
                color2,
                LinearGradientMode.ForwardDiagonal)) // Gradient direction
            {
                // Fill the entire form with the gradient background
                e.Graphics.FillRectangle(brush, 0, 0, width, height);
            }
        }

        private void sine_in_Click(object sender, EventArgs e)
        {
            if (textBox_username.Text != username)
            {
                show_error.Text = "Username is incorrect"; // Show error message for incorrect username
            }
            else if (textBox_password.Text != password)
            {
                show_error.Text = "Password is incorrect"; // Show error message for incorrect password
            }
            else if (textBox_username.Text == username && textBox_password.Text == password)
            {
                Data data = new Data(username);
                data.Owner = this;
                data.Show(); // Show the data form after successful login
                this.Hide(); // Hide the login form
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            // Show a confirmation dialog when exiting
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Exit the application if "Yes" is clicked
            }
        }

        public void GetUsername()
        {
            string enteredUsername = textBox_username.Text; // Store entered username (not used currently)
        }

        private void textBox_username_Click(object sender, EventArgs e)
        {
            textBox_username.Clear(); // Clear the username text box when clicked
        }

        private void textBox_password_Click(object sender, EventArgs e)
        {
            textBox_password.Clear(); // Clear the password text box when clicked
        }

        private void textBox_username_KeyDown(object sender, KeyEventArgs e)
        {
            // 检测是否按下 Enter 键
            if (e.KeyCode == Keys.Enter)
            {
                // 将焦点设置到 password 输入框
                textBox_password.Focus();
            }
        }

        private void textBox_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 检测是否按下 Enter 键
            if (e.KeyChar == (char)Keys.Enter)
            {
                // 执行登录按钮的点击事件
                sine_in_Click(sender, e);
            }
        }
    }
}
