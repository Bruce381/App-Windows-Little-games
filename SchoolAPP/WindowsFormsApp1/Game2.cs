using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Game2 : Form
    {
        Random random = new Random();
        private int point;
        private int countdownTime = 10; // 倒计时的总秒数

        public Game2()
        {
            InitializeComponent();
        }

        private void Game2_Load(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            point_show();
            if (point == 5)
            {
                end();
            }
        }

        private void end()
        {
            timer1.Stop();
            MessageBox.Show("成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void point_show()
        {
            label2.Text = point.ToString();
        }

        private void Change_button()
        {
            int a = random.Next(0, 100 + 1);
            // 获取 button1 和 button2 的当前位置信息
            Point button1Location = button1.Location;
            Point button2Location = button2.Location;

            if (a > 50)
            {
                // 交换位置
                button1.Location = button2Location;
                button2.Location = button1Location;
            }

            // 启动计时器
            timer2.Start();
        }

        private void Game_Start()
        {
            countdownTime = 5; // 设置倒计时的起始时间为5秒
            label1.Text = countdownTime.ToString(); // 更新显示
            Change_button();
            timer2.Start(); // 启动定时器
        }
        private void start_Click(object sender, EventArgs e)
        {
            Game_Start();
        }

        private void Game_Stop()
        {
            timer2.Stop(); // 停止定时器
            Game_Start(); // 重新开始游戏
        }

        private void button1_Click(object sender, EventArgs e)
        {
            point++;
            ResetCountdown(); // 重置倒计时
            Game_Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            point--;
            ResetCountdown(); // 重置倒计时
            Game_Stop();
        }

        private void ResetCountdown()
        {
            timer2.Stop(); // 停止计时器
            countdownTime = 10; // 重置倒计时
            label1.Text = countdownTime.ToString(); // 更新显示
            timer2.Start(); // 重新启动计时器
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // 每次计时器触发时减少倒计时
            countdownTime--;

            // 更新 label1 显示剩余时间
            label1.Text = countdownTime.ToString();

            // 检查倒计时是否结束
            if (countdownTime <= 0)
            {
                timer2.Stop(); // 停止定时器
                MessageBox.Show("时间到！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Game_Stop(); // 结束游戏
            }
        }

        
    }
}
