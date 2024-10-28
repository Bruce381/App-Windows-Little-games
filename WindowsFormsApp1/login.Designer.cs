namespace WindowsFormsApp1
{
    partial class submit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(submit));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lableshow = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sub = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(285, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 54);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bruce\'s App";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "User";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(257, 115);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(224, 46);
            this.user.TabIndex = 7;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(257, 195);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(224, 46);
            this.password.TabIndex = 8;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(280, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 50);
            this.button2.TabIndex = 10;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // lableshow
            // 
            this.lableshow.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableshow.ForeColor = System.Drawing.Color.IndianRed;
            this.lableshow.Location = new System.Drawing.Point(131, 251);
            this.lableshow.Name = "lableshow";
            this.lableshow.Size = new System.Drawing.Size(458, 34);
            this.lableshow.TabIndex = 11;
            this.lableshow.Text = "error";
            this.lableshow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lableshow.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(226, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sub);
            this.groupBox1.Controls.Add(this.exit);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(12, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 96);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(154, 40);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(120, 50);
            this.sub.TabIndex = 2;
            this.sub.Text = "submit";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.button1_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(406, 40);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(120, 50);
            this.exit.TabIndex = 9;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // submit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 429);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lableshow);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "submit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APPPPPP";
            this.Load += new System.EventHandler(this.submit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lableshow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button exit;
    }
}

