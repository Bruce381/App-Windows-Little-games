using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Game3 : Form
    {
        Random random = new Random();
        private int life = 10;
        private int cont = 0;
        private int D;

        public Game3()
        {
            InitializeComponent();
        }

        private void Exam_Load(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
            label3.Text = string.Empty;
            label5.Text = string.Empty;
            label6.Text = string.Empty;

            D = random.Next(0, 11);
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

            // 如果和大于100，重新生成数字
            if (a + b > 100)
            {
                new_number();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                return; // 不执行后续代码
            }

            if (int.TryParse(label1.Text, out int a) &&
                int.TryParse(label3.Text, out int b) &&
                int.TryParse(textBox1.Text, out int c))
            {
                label5.Text = a + b == c ? "✔" : "❌";
            }
            else
            {
                MessageBox.Show("请确保所有输入都是有效的数字！", "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            cont++;
            int d = int.Parse(textBox2.Text);
            if (d > D && cont < 3)
            {
                label8.Text = "big";
            }
            else if (d < D && cont < 3)
            {
                label8.Text = "small";
            }
            else if (d == D && cont < 3)
            {
                label8.Text = "success";
            }
            else
            {
                label8.Text = "time out";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            calculater cal = new calculater();
            cal.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            int second = DateTime.Now.Second;

            label9.Text = $"{hour:D2}:{minute:D2}:{second:D2}";
        }

        public void SetRandomOperator()
        {
            char[] operators = { '+', '-', '*', '/' };
            char randomOperator = operators[random.Next(operators.Length)];
            label2.Text = randomOperator.ToString();  // 假设 Label 名称为 label2
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // 清空标签和文本框内容，并将焦点设置到文本框
            label1.Text = string.Empty;
            label3.Text = string.Empty;
            label5.Text = string.Empty;
            textBox1.Text = string.Empty;
            textBox1.Focus();
            textBox1.SelectionStart = 0;

            // 生成新数字和运算符
            new_number();
            SetRandomOperator();
        }
    }
}
