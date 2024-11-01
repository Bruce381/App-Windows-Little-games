namespace WindowsFormsApp1
{
    partial class root
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Label();
            this.loginbutten = new System.Windows.Forms.Label();
            this.About = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.userdata = new System.Windows.Forms.Label();
            this.game4 = new System.Windows.Forms.Button();
            this.game3 = new System.Windows.Forms.Button();
            this.game2 = new System.Windows.Forms.Button();
            this.game1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ControlText;
            this.title.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.title.Location = new System.Drawing.Point(102, 1);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(204, 50);
            this.title.TabIndex = 0;
            this.title.Text = "Sakura Anywhere";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 50);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.exit);
            this.panel3.Controls.Add(this.loginbutten);
            this.panel3.Controls.Add(this.About);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(898, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(254, 50);
            this.panel3.TabIndex = 3;
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(178, 1);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(80, 48);
            this.exit.TabIndex = 5;
            this.exit.Text = "Exit";
            this.exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // loginbutten
            // 
            this.loginbutten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutten.Location = new System.Drawing.Point(92, 1);
            this.loginbutten.Name = "loginbutten";
            this.loginbutten.Size = new System.Drawing.Size(80, 48);
            this.loginbutten.TabIndex = 4;
            this.loginbutten.Text = "Login";
            this.loginbutten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginbutten.Click += new System.EventHandler(this.loginbutten_Click);
            // 
            // About
            // 
            this.About.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About.Location = new System.Drawing.Point(6, 1);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(80, 48);
            this.About.TabIndex = 3;
            this.About.Text = "About";
            this.About.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.title);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(898, 50);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.icon;
            this.pictureBox1.InitialImage = global::WindowsFormsApp1.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(46, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.userdata);
            this.panel4.Controls.Add(this.game4);
            this.panel4.Controls.Add(this.game3);
            this.panel4.Controls.Add(this.game2);
            this.panel4.Controls.Add(this.game1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel4.Location = new System.Drawing.Point(0, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1152, 598);
            this.panel4.TabIndex = 3;
            // 
            // userdata
            // 
            this.userdata.BackColor = System.Drawing.Color.Transparent;
            this.userdata.Location = new System.Drawing.Point(830, 315);
            this.userdata.Name = "userdata";
            this.userdata.Size = new System.Drawing.Size(310, 274);
            this.userdata.TabIndex = 7;
            // 
            // game4
            // 
            this.game4.BackColor = System.Drawing.Color.Transparent;
            this.game4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game4.Location = new System.Drawing.Point(213, 97);
            this.game4.Name = "game4";
            this.game4.Size = new System.Drawing.Size(161, 46);
            this.game4.TabIndex = 6;
            this.game4.Text = "Game 4";
            this.game4.UseVisualStyleBackColor = false;
            this.game4.Click += new System.EventHandler(this.game4_Click);
            // 
            // game3
            // 
            this.game3.BackColor = System.Drawing.Color.Transparent;
            this.game3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game3.Location = new System.Drawing.Point(46, 97);
            this.game3.Name = "game3";
            this.game3.Size = new System.Drawing.Size(161, 46);
            this.game3.TabIndex = 5;
            this.game3.Text = "Game 3";
            this.game3.UseVisualStyleBackColor = false;
            this.game3.Click += new System.EventHandler(this.game3_Click);
            // 
            // game2
            // 
            this.game2.BackColor = System.Drawing.Color.Transparent;
            this.game2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game2.Location = new System.Drawing.Point(213, 45);
            this.game2.Name = "game2";
            this.game2.Size = new System.Drawing.Size(161, 46);
            this.game2.TabIndex = 4;
            this.game2.Text = "Game 2";
            this.game2.UseVisualStyleBackColor = false;
            this.game2.Click += new System.EventHandler(this.game2_Click);
            // 
            // game1
            // 
            this.game1.BackColor = System.Drawing.Color.Transparent;
            this.game1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game1.Location = new System.Drawing.Point(46, 45);
            this.game1.Name = "game1";
            this.game1.Size = new System.Drawing.Size(161, 46);
            this.game1.TabIndex = 3;
            this.game1.Text = "Game 1";
            this.game1.UseVisualStyleBackColor = false;
            this.game1.Click += new System.EventHandler(this.game1_Click);
            // 
            // root
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.miku_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1152, 648);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "root";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "root";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button game4;
        private System.Windows.Forms.Button game3;
        private System.Windows.Forms.Button game2;
        private System.Windows.Forms.Button game1;
        private System.Windows.Forms.Label loginbutten;
        private System.Windows.Forms.Label About;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label userdata;
    }
}