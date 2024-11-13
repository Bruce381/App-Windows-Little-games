using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace School_APP
{
    public partial class Data : Form
    {
        // 创建三个列表
        List<string> names = new List<string>();       // 存储名字
        List<string> classes = new List<string>();     // 存储班级信息
        List<string> result = new List<string>();      // 存储成绩

        public Data(string username)
        {
            InitializeComponent();
            show_user.Text = $"Hello {char.ToUpper(username[0]) + username.Substring(1)}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 检查文本框是否为空
            if (string.IsNullOrWhiteSpace(textBox_name.Text) ||
                string.IsNullOrWhiteSpace(comboBox_class.Text) ||
                string.IsNullOrWhiteSpace(textBox_resalt.Text))
            {
                // 显示错误提示
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // 如果有空字段，则不继续执行
            }

            // 检查成绩是否是合法的数字，且不超过100
            if (double.TryParse(textBox_resalt.Text, out double score))
            {
                if (score < 0 || score > 100)
                {
                    MessageBox.Show("Please enter a valid score between 0 and 100.", "Invalid Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number for the score.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 添加新的数据
            names.Add(textBox_name.Text);
            classes.Add(comboBox_class.Text);
            result.Add(textBox_resalt.Text);

            // 刷新列表显示
            fresh_list();

            // 清空输入框
            textBox_name.Text = string.Empty;
            //textBox_class.Text = string.Empty;
            textBox_resalt.Text = string.Empty;

            // 聚焦到姓名输入框
            textBox_name.Focus();
        }

        private void fresh_list()
        {
            // 清空现有的 ListBox 项
            show_data_name.Items.Clear();
            show_data_class.Items.Clear();
            show_data_result.Items.Clear();

            // 将数据添加到对应的 ListBox 控件中
            foreach (var name in names)
            {
                show_data_name.Items.Add(name);
            }

            foreach (var classNumber in classes)
            {
                show_data_class.Items.Add(classNumber.ToString());
            }

            foreach (var resultValue in result)
            {
                show_data_result.Items.Add(resultValue);
            }
        }

        private void Data_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void set_Click(object sender, EventArgs e)
        {
            // 获取 ComboBox 当前选中的项
            var selectedItem = choose_type.SelectedItem.ToString();

            // 使用 if 语句判断选择的项
            if (selectedItem == "成绩从小到大")
            {
                // 将三个列表合并为一个元组列表
                var combinedList = names
                    .Select((name, index) => (name: name, classNumber: classes[index], result: result[index]))
                    .ToList();

                // 按照成绩从小到大排序
                var sortedListAsc = combinedList
                    .OrderBy(item => double.Parse(item.result))  // 将成绩从字符串转换为数字并升序排列
                    .ToList();

                // 更新 ListBox
                UpdateListBox(sortedListAsc);
            }
            else if (selectedItem == "成绩从大到小")
            {
                // 将三个列表合并为一个元组列表
                var combinedList = names
                    .Select((name, index) => (name: name, classNumber: classes[index], result: result[index]))
                    .ToList();

                // 按照成绩从大到小排序
                var sortedListDesc = combinedList
                    .OrderByDescending(item => double.Parse(item.result))  // 降序排列
                    .ToList();

                // 更新 ListBox
                UpdateListBox(sortedListDesc);
            }
        }

        private void UpdateListBox(List<(string name, string classes, string result)> sortedList)
        {
            // 清空现有的 ListBox 项
            show_data_name.Items.Clear();
            show_data_class.Items.Clear();
            show_data_result.Items.Clear();

            // 更新排序后的数据到 ListBox 中
            foreach (var item in sortedList)
            {
                show_data_name.Items.Add(item.name);
                show_data_class.Items.Add(item.classes);
                show_data_result.Items.Add(item.result);
            }
        }

        private void statistics_Click(object sender, EventArgs e)
        {
            // 将成绩列表从字符串转换为整数
            List<double> scores = result.Select(double.Parse).ToList();

            // 计算统计信息
            double maxScore = scores.Max();
            double minScore = scores.Min();
            double averageScore = scores.Average();
            double sumScore = scores.Sum();
            double aboveAveragePercentage = (double)scores.Count(score => score > averageScore) / scores.Count * 100;
            double belowAveragePercentage = (double)scores.Count(score => score < averageScore) / scores.Count * 100;

            // 构建消息内容
            string message = $"1) 统计的最大成绩: {maxScore:F2}\n" +
                             $"2) 统计的最小成绩: {minScore:F2}\n" +
                             $"3) 统计的平均成绩: {averageScore:F2}\n" +
                             $"4) 统计成绩之和: {sumScore}\n" +
                             $"5) 大于平均成绩的学生所占百分比: {aboveAveragePercentage:F2}%\n" +
                             $"6) 小于平均成绩的学生所占百分比: {belowAveragePercentage:F2}%";

            // 显示消息框
            MessageBox.Show(message, "统计信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox_resalt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 检查输入字符是否是数字、控制键或小数点
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // 阻止非数字或小数点的输入
            }

            // 如果输入框中的文本已包含小数点，阻止再次输入
            if (e.KeyChar == '.' && textBox_resalt.Text.Contains("."))
            {
                e.Handled = true; // 阻止输入第二个小数点
            }

            // 如果输入框中的文本长度已经是5个字符（最多三位整数和两位小数），禁止继续输入
            if (textBox_resalt.Text.Length >= 5 && !char.IsControl(e.KeyChar)) // 允许两位小数和一个小数点
            {
                e.Handled = true;  // 禁止输入
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            // 弹出确认退出的对话框
            DialogResult result = MessageBox.Show("Are you sure to exit?", "yes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // 如果用户选择了 "Yes"，则退出应用程序
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
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
                LinearGradientMode.Vertical)) // 渐变方向
            {
                // 填充整个窗体背景
                e.Graphics.FillRectangle(brush, 0, 0, width, height);
            }
        }

        private void Data_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;  // 启用双缓冲，减少闪烁
        }
    }
}
