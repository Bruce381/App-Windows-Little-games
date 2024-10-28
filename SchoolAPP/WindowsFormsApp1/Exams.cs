using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Exams : Form
    {
        Random random = new Random();

        private int Life = 10;
        private int test = 10;
        private int countdownTime =300; // 倒计时的总时间（秒）


        public Exams()
        {
            InitializeComponent();
        }
        private void new_number()
        {
            // 生成新的随机数字并设置到 label1 和 label3
            label1.Text = random.Next(0, 100).ToString();  // label1 设置随机数
            label3.Text = random.Next(0, 100).ToString();  // label3 设置随机数
            calculate();  // 计算逻辑
        }

        private void calculate()
        {
            int a = int.Parse(label1.Text);
            int b = int.Parse(label3.Text);

            // 检查加法
            if (a + b > 100)
            {
                new_number();  // 如果和大于100，重新生成数字
            }
            // 检查减法
            else if (a - b < 0)
            {
                new_number();  // 如果结果小于0，重新生成数字
            }
            // 检查乘法
            else if (a * b > 100)
            {
                new_number();  // 如果乘积大于100，重新生成数字
            }
            // 检查除法
            else if (b == 0)
            {
                new_number();  // 如果除数为零，重新生成数字
            }
            else if (a % b != 0)
            {
                new_number();  // 如果不能整除，重新生成数字
            }
        }


        private void empty()
        {
            // 清空标签和文本框内容，并将焦点设置到文本框
            label1.Text = string.Empty;
            label2.Text = string.Empty;
            label3.Text = string.Empty;
            label5.Text = string.Empty;
            label6.Text = string.Empty;
            label7.Text = "Time";
            textBox1.Text = string.Empty;
        }
        public void SetRandomOperator()
        {
            char[] operators = { '+', '-', '*', '/' };
            char randomOperator = operators[random.Next(operators.Length)];
            label2.Text = randomOperator.ToString();  // 假设 Label 名称为 label2
        }
        private void button1_Click(object sender, EventArgs e)
        {
            empty();
            textBox1.Focus();
            textBox1.SelectionStart = 0;
            timer2.Start(); // 启动倒计时

            // 生成新数字和运算符
            new_number();
            SetRandomOperator();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 检查输入框是否为空
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                label5.Text = "❌";
                label6.Text = "请输入结果！";
                HandleIncorrectAnswer();
                return;
            }

            // 尝试解析 label1、label3 和 textBox1 中的文本为整数
            if (int.TryParse(label1.Text, out int a) &&
                int.TryParse(label3.Text, out int b) &&
                int.TryParse(textBox1.Text, out int c))
            {
                // 获取当前运算符
                char operatorChar = label2.Text[0];
                int expectedResult = 0;
                bool isCorrect = false;

                switch (operatorChar)
                {
                    case '+':
                        expectedResult = a + b;
                        isCorrect = (expectedResult == c);
                        break;
                    case '-':
                        expectedResult = a - b;
                        isCorrect = (expectedResult == c);
                        break;
                    case '*':
                        expectedResult = a * b;
                        isCorrect = (expectedResult == c);
                        break;
                    case '/':
                        expectedResult = a / b;
                        isCorrect = (expectedResult == c);
                        break;
                    default:
                        label6.Text = "未知运算符！";
                        return;
                }

                if (isCorrect)
                {
                    label5.Text = "✔";
                    test--;
                    new_number();
                }
                else
                {
                    label5.Text = "❌";
                    label6.Text = $"正确答案是 {expectedResult}";
                    test--;
                    HandleIncorrectAnswer();
                }
            }
            else
            {
                label6.Text = "请确保所有输入都是有效的数字！";
                HandleIncorrectAnswer();
            }

            // 更新 test 值到界面上，以便监控变化
            label9.Text = test.ToString();
            CheckSuccessCondition();
        }

        private void HandleIncorrectAnswer()
        {
            Life--; // 减少一次生命值

            // 更新 life 标签
            if (Life >= 0)
            {
                // 每次减少一个心形字符
                life.Text = life.Text.Remove(life.Text.Length - 2, 2);
            }

            // 检查是否没有生命了
            if (Life == 0)
            {
                MessageBox.Show("游戏结束！");
                timer2.Stop(); // 停止倒计时
                resetGame();
            }
            else
            {
                new_number(); // 生成新题目
                SetRandomOperator(); // 设置新的运算符
            }
        }





        private void timer2_Tick(object sender, EventArgs e)
        {
            if (countdownTime > 0)
            {
                countdownTime--; // 每秒减少1秒
                label7.Text = countdownTime.ToString(); // 更新label7显示剩余时间
            }
            else
            {
                timer2.Stop(); // 停止计时器
                label7.Text = "时间到！"; // 显示时间到的消息

                // 弹出提示框
                DialogResult result = MessageBox.Show("时间到！点击确定后清空所有内容。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    // 清空所有标签和文本框内容
                    resetGame();
                    countdownTime = 300; // 重置倒计时
                    label7.Text = countdownTime.ToString(); // 更新倒计时显示
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 更新 label8 为当前时间
            label8.Text = DateTime.Now.ToString("HH:mm:ss"); // 使用24小时格式
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calculater cal = new calculater();
            cal.Show();
        }
        private void CheckSuccessCondition()
        {
            if (test == 0 && Life > 0)
            {
                MessageBox.Show("恭喜你，成功通关！");
                timer2.Stop(); // 停止倒计时
                resetGame();
            }
            else
            {
                textBox1.Text = string.Empty;
                textBox1.Focus();
            }
        }

        private void resetGame()
        {
            // 重置生命值和显示
            Life = 10;
            life.Text = "❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️";

            // 重置倒计时时间
            countdownTime = 300;
            label7.Text = countdownTime.ToString();

            // 重置 test 变量
            test = 10;

            // 清空所有标签和文本框内容
            label1.Text = string.Empty;
            label2.Text = string.Empty;
            label3.Text = string.Empty;
            label5.Text = string.Empty;
            label6.Text = string.Empty;
            textBox1.Text = string.Empty;

            // 停止计时器
            timer2.Stop();

            // 设置焦点到 textBox1 以便用户重新开始
            textBox1.Focus();
        }

        private void Exams_Load(object sender, EventArgs e)
        {
            resetGame();
        }
    }
}

