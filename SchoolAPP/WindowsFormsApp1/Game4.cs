using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Game4 : Form
    {
        private List<Point> buttonPositions;

        //生命数
        int life;
        //成功次数
        int su;
        int sus;

        public Game4()
        {
            InitializeComponent();
        }
        private void Game4_Load(object sender, EventArgs e)
        {
            lifeshow.Text = string.Empty;
        }
        private void CalculateButtonPositions(int rows, int columns)//计算按钮位置
        {
            buttonPositions = new List<Point>();
            int buttonWidth = 60; // 按钮宽度
            int buttonHeight = 60; // 按钮高度
            int spacing = 10; // 按钮之间的间距

            // 计算起始坐标
            //计算按钮矩阵在box里的中心位置
            int startX = (this.Gamearea.Width - (buttonWidth * columns + spacing * (columns - 1))) / 2;
            int startY = (this.Gamearea.Height - (buttonHeight * rows + spacing * (rows - 1))) / 2;
            
            //公式
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    buttonPositions.Add(new Point(startX + col * (buttonWidth + spacing), startY + row * (buttonHeight + spacing)));
                }
            }
        }

        private void CreateMatrixButtons(int rows, int columns, int bomCount)
        {
            Random random = new Random();

            // 创建标签列表
            List<string> buttonLabels = new List<string>();

            // 添加指定数量的 "bom" 标签
            for (int i = 0; i < bomCount; i++)
            {
                buttonLabels.Add("bom");
            }

            // 添加其他标签，确保总数量为 rows * columns
            int totalButtons = rows * columns;
            int okCount = totalButtons - bomCount; // 计算 "ok" 标签的数量

            for (int i = 0; i < okCount; i++)
            {
                buttonLabels.Add("ok");
            }

            // 随机打乱按钮标签顺序
            buttonLabels = buttonLabels.OrderBy(x => random.Next()).ToList();

            // 清空 Gamearea 中的现有按钮
            Gamearea.Controls.Clear();

            CalculateButtonPositions(rows, columns); // 计算按钮位置

            for (int i = 0; i < buttonPositions.Count; i++)
            {
                Button button = new Button
                {
                    Tag = buttonLabels[i], // 使用打乱后的标签
                    Location = buttonPositions[i],
                    Size = new Size(60, 60),// 一致的按钮大小
                    ForeColor = Color.Black // 设置文本颜色
                };
                button.Click += Button_Click; // 绑定事件
                Gamearea.Controls.Add(button); // 添加按钮到 Gamearea
            }
        }


        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton.Tag == "bom")
            {
                clickedButton.Text = "❌";
                lifeshow.Text = lifeshow.Text.Substring(0, lifeshow.Text.Length - 1); // 更新 Label 的文本
                life--;
                checklife();
            }else if (clickedButton.Tag == "ok")
            {
                clickedButton.Text = "✔";
                su++;
                checkok();
            }
        }

        private void checklife()
        {
            if (life == 0)
            {
                MessageBox.Show("GG"); // 显示一个空的消息框
                reset();
            }
        }
        private void checkok()
        {
            if (su == sus)
            {
                MessageBox.Show("Ohhhhhhhh"); // 显示一个空的消息框
                reset();
            }
        }
        private void reset()
        {
            life = 2;
            su = 0;
            sus = 0;
            // 清空 Gamearea 中的现有按钮
            Gamearea.Controls.Clear();
        }
        
        private void easy_Click(object sender, EventArgs e)
        {
            Gamearea.Text = "Easy";
            life = 3;
            sus = 4;
            lifeshow.Text = "❤❤❤";
            CreateMatrixButtons(3, 3, 3); // 创建3行3列的按钮矩阵
        }

        private void hard_Click(object sender, EventArgs e)
        {
            Gamearea.Text = "Hard";
            life = 4;
            sus = 5;
            lifeshow.Text = "❤❤❤❤";
            CreateMatrixButtons(4,4,4); // 创建6行6列的按钮矩阵
        }


    }
}
