using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class calculater : Form
    {

        private Random random = new Random();

        public calculater()
        {
            InitializeComponent();
        }

        private void class3_Load(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += "1"; // 添加数字 1
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text += "2"; // 添加数字 2
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text += "3"; // 添加数字 3
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text += "4"; // 添加数字 4
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text += "5"; // 添加数字 5
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text += "6"; // 添加数字 6
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text += "7"; // 添加数字 7
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text += "8"; // 添加数字 8
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text += "9"; // 添加数字 9
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text += "0"; // 添加数字 0（可选）
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text += "+";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text += "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text += "*";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1.Text += "/";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            calculate();
        }

        private void calculate()
        {
            string expression = label1.Text;

            if (calculate_symbols(expression))
            {
                try
                {
                    // 使用 DataTable 计算表达式的值
                    var result = new DataTable().Compute(expression, null);
                    label1.Text = result.ToString();
                }
                catch (Exception ex)
                {
                    label1.Text= "计算错误: " + ex.Message + "错误";
                }
            }
            else
            {
                label1.Text = "无效的数学表达式！" + "检测结果";
            }
        }

        private bool calculate_symbols(string expression)
        {
            // 正则表达式匹配只包含数字和基本的运算符
            string pattern = @"^[0-9\s+\-*/()]+$"; // 允许数字、空格、加减乘除和括号

            // 检查表达式的格式
            if (!Regex.IsMatch(expression, pattern))
            {
                return false; // 如果不匹配，则返回 false
            }

            // 检查是否至少有一个运算符
            return expression.Contains('+') ||
                   expression.Contains('-') ||
                   expression.Contains('*') ||
                   expression.Contains('/');
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
        }
    }
}
