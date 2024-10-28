using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Game1 : Form
    {
        private int speed = 1; // 控制移动速度

        // 类字段，保存所有创建的 PictureBox
        private List<PictureBox> pictureBoxes = new List<PictureBox>();


        public Game1()
        {
            InitializeComponent(); // 初始化组件
        }

        private void homework_Load(object sender, EventArgs e)
        {
            LoadMultiplePictureBoxes(5);

            SetInitialPositions(); // 设置初始位置
        }

        private void LoadMultiplePictureBoxes(int count)
        {
            var usedLocations = new HashSet<Point>();

            // 添加已存在 PictureBox 的位置到 usedLocations
            foreach (var box in pictureBoxes)
            {
                usedLocations.Add(box.Location);
            }

            for (int i = 0; i < count; i++)
            {
                PictureBox pictureBox = CreatePictureBoxFrom(pictureBox3);
                Point randomLocation;

                do
                {
                    randomLocation = GetRandomLocation(pictureBox.Size);
                } while (!IsLocationValid(randomLocation, usedLocations, pictureBox.Size));

                usedLocations.Add(randomLocation); // 更新已使用的位置
                pictureBox.Location = randomLocation; // 设置位置
                panel6.Controls.Add(pictureBox); // 将 PictureBox 添加到面板中
                pictureBoxes.Add(pictureBox); // 保存创建的 PictureBox 到类字段的列表
            }
        }

        // 从现有 PictureBox 创建一个新的 PictureBox
        private PictureBox CreatePictureBoxFrom(PictureBox original)
        {
            PictureBox newPictureBox = new PictureBox
            {
                Size = original.Size,
                SizeMode = original.SizeMode,
                Image = (Image)original.Image.Clone() // 复制图片
            };
            return newPictureBox;
        }

        // 生成随机位置
        private Point GetRandomLocation(Size pictureBoxSize)
        {
            Random random = new Random();
            int randomX = random.Next(0, panel6.ClientSize.Width - pictureBoxSize.Width);
            int randomY = random.Next(0, panel6.ClientSize.Height - pictureBoxSize.Height);
            return new Point(randomX, randomY);
        }

        // 检查生成的位置是否有效
        private bool IsLocationValid(Point randomLocation, HashSet<Point> usedLocations, Size pictureBoxSize)
        {
            // 创建新位置的边界
            Rectangle newBounds = new Rectangle(randomLocation, pictureBoxSize);

            // 检查新位置是否与已使用的位置重叠
            foreach (var usedLocation in usedLocations)
            {
                Rectangle usedBounds = new Rectangle(usedLocation, pictureBoxSize);
                if (newBounds.IntersectsWith(usedBounds))
                {
                    return false; // 无效的位置
                }
            }

            // 检查新生成的位置是否与 pictureBox1 和 pictureBox2 重叠
            if (newBounds.IntersectsWith(pictureBox1.Bounds) || newBounds.IntersectsWith(pictureBox2.Bounds))
            {
                return false; // 无效的位置
            }

            // 检查新生成的位置与其他所有 PictureBox 之间的间隔
            foreach (var box in pictureBoxes)
            {
                Rectangle boxBounds = box.Bounds;
                // 计算间隔
                Rectangle expandedBounds = new Rectangle(boxBounds.X - 35, boxBounds.Y - 35, boxBounds.Width + 70, boxBounds.Height + 70);
                if (expandedBounds.IntersectsWith(newBounds))
                {
                    return false; // 无效的位置
                }
            }

            return true; // 有效的位置
        }

        // 设置初始位置
        private void SetInitialPositions()
        {
            SetPictureBox1InitialPosition(); // 设置 PictureBox1 的初始位置
            SetPictureBox2InitialPosition(); // 设置 PictureBox2 的初始位置
        }

        // 设置 PictureBox1 的初始位置
        private void SetPictureBox1InitialPosition()
        {
            Random random = new Random();
            int randomY = random.Next(0, panel6.ClientSize.Height - pictureBox1.Height);
            pictureBox1.Location = new Point(0, randomY); // 设置 PictureBox1 在左侧随机高度
        }

        // 设置 PictureBox2 的初始位置
        private void SetPictureBox2InitialPosition()
        {
            Random random = new Random();
            int randomY;
            do
            {
                randomY = random.Next(0, panel6.ClientSize.Height - pictureBox2.Height);
            } while (IsYOverlapping(pictureBox1, new Point(panel6.ClientSize.Width - pictureBox2.Width, randomY)));

            pictureBox2.Location = new Point(panel6.ClientSize.Width - pictureBox2.Width, randomY); // 设置 PictureBox2 在右侧随机高度
        }

        // 检查 Y 方向上是否重叠
        private bool IsYOverlapping(PictureBox pictureBox, Point newLocation)
        {
            return (newLocation.Y + pictureBox2.Height > pictureBox.Top && newLocation.Y < pictureBox.Bottom);
        }

        // 增加速度
        private void button3_Click(object sender, EventArgs e)
        {
            if (speed < 10)
            {
                speed++;
                button4.Enabled = true; // 启用减速按钮
                if (speed == 10)
                {
                    button3.Enabled = false; // 达到最大速度时禁用加速按钮
                }
            }
        }

        // 减少速度
        private void button4_Click(object sender, EventArgs e)
        {
            if (speed > 1)
            {
                speed--;
                button3.Enabled = true; // 启用加速按钮
                if (speed == 1)
                {
                    button4.Enabled = false; // 达到最小速度时禁用减速按钮
                }
            }
        }

        // 向上移动 PictureBox1
        private void button1_Click(object sender, EventArgs e)
        {
            MovePictureBox(pictureBox1, -speed);
        }

        // 向下移动 PictureBox1
        private void button2_Click(object sender, EventArgs e)
        {
            MovePictureBox(pictureBox1, speed);
        }

        // 向左移动 PictureBox1
        private void button6_Click(object sender, EventArgs e)
        {
            MovePictureBox(pictureBox1, 0, -speed); // 只在 X 轴上移动
        }

        // 向右移动 PictureBox1
        private void button5_Click(object sender, EventArgs e)
        {
            MovePictureBox(pictureBox1, 0, speed); // 只在 X 轴上移动
        }

        // 移动指定的 PictureBox
        private void MovePictureBox(PictureBox pictureBox, int deltaY, int deltaX = 0)
        {
            // 检查新的位置是否超出边界
            if (pictureBox.Top + deltaY < 0 ||
                pictureBox.Top + pictureBox.Height + deltaY > panel6.Height ||
                pictureBox.Left + deltaX < 0 ||
                pictureBox.Left + pictureBox.Width + deltaX > panel6.Width)
            {
                // 如果碰到边界，弹出失败提示
                MessageBox.Show("失败！已碰到边界。", "碰撞检测", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetGame(); // 碰撞边界后重置游戏
                return; // 终止移动
            }

            // 更新 Y 坐标
            pictureBox.Top += deltaY;
            // 更新 X 坐标
            pictureBox.Left += deltaX;

            // 检查与其他 PictureBox 的碰撞
            foreach (var box in pictureBoxes)
            {
                if (pictureBox != box && pictureBox.Bounds.IntersectsWith(box.Bounds))
                {
                    MessageBox.Show("失败！与其他对象碰撞。", "碰撞检测", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ResetGame(); // 碰撞其他对象后重置游戏
                    return; // 如果发生碰撞，终止进一步移动
                }
            }

            // 检查与 PictureBox2 的碰撞
            if (pictureBox.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                MessageBox.Show("完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information); // 弹出消息框
                ResetGame(); // 碰撞后重置游戏
            }
        }

        // 重置游戏状态
        private void ResetGame()
        {
            // 重置速度
            speed = 1;

            // 移除所有现有的 PictureBox 控件
            foreach (var pictureBox in pictureBoxes)
            {
                panel6.Controls.Remove(pictureBox);
            }
            pictureBoxes.Clear(); // 清空 pictureBoxes 列表

            // 重新生成所有 PictureBox
            LoadMultiplePictureBoxes(5); // 可以传递原先的数量

            // 重新设置 PictureBox1 和 PictureBox2 的初始位置
            SetInitialPositions();

            // 重置其他相关状态
            button3.Enabled = true; // 启用加速按钮
            button4.Enabled = false; // 禁用减速按钮
        }


        // 退出应用程序
        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // 定时器事件，更新标签显示位置和速度
        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = pictureBox1.Location.X.ToString(); // 更新 X 坐标
            label4.Text = pictureBox1.Location.Y.ToString(); // 更新 Y 坐标
            label5.Text = speed.ToString(); // 更新速度
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 获取 ASCII 码
            int asciiValue = (int)e.KeyChar;

            if (asciiValue == 113 || asciiValue == 81) // 113 是 'q'，81 是 'Q'
            {
                // 处理 "q" 键按下的逻辑
                MovePictureBox(pictureBox1, -speed);
            }
        }
    }
}
