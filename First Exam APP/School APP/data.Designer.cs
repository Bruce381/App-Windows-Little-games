namespace School_APP
{
    partial class Data
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Data));
            this.choose_type = new System.Windows.Forms.ComboBox();
            this.show_data_name = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.user_data = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_resalt = new System.Windows.Forms.TextBox();
            this.show_user = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.show_data_class = new System.Windows.Forms.ListBox();
            this.show_data_result = new System.Windows.Forms.ListBox();
            this.set = new System.Windows.Forms.Button();
            this.statistics = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.comboBox_class = new System.Windows.Forms.ComboBox();
            this.label_show_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // choose_type
            // 
            this.choose_type.AllowDrop = true;
            this.choose_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.choose_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.choose_type.FormattingEnabled = true;
            this.choose_type.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.choose_type.Items.AddRange(new object[] {
            "from low to high",
            "from high to low"});
            this.choose_type.Location = new System.Drawing.Point(16, 115);
            this.choose_type.Name = "choose_type";
            this.choose_type.Size = new System.Drawing.Size(318, 33);
            this.choose_type.TabIndex = 0;
            // 
            // show_data_name
            // 
            this.show_data_name.Enabled = false;
            this.show_data_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_data_name.FormattingEnabled = true;
            this.show_data_name.ItemHeight = 31;
            this.show_data_name.Location = new System.Drawing.Point(12, 181);
            this.show_data_name.Name = "show_data_name";
            this.show_data_name.Size = new System.Drawing.Size(300, 345);
            this.show_data_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Class";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // user_data
            // 
            this.user_data.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.user_data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.user_data.BackColor = System.Drawing.Color.Transparent;
            this.user_data.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_data.Location = new System.Drawing.Point(255, 7);
            this.user_data.Name = "user_data";
            this.user_data.Size = new System.Drawing.Size(85, 30);
            this.user_data.TabIndex = 4;
            this.user_data.Text = "Result";
            this.user_data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // submit
            // 
            this.submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(340, 61);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(113, 32);
            this.submit.TabIndex = 5;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_name.Location = new System.Drawing.Point(23, 61);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(81, 30);
            this.textBox_name.TabIndex = 6;
            // 
            // textBox_resalt
            // 
            this.textBox_resalt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox_resalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_resalt.Location = new System.Drawing.Point(253, 61);
            this.textBox_resalt.Name = "textBox_resalt";
            this.textBox_resalt.Size = new System.Drawing.Size(81, 30);
            this.textBox_resalt.TabIndex = 8;
            this.textBox_resalt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_resalt_KeyPress);
            // 
            // show_user
            // 
            this.show_user.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.show_user.BackColor = System.Drawing.Color.Transparent;
            this.show_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.show_user.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_user.Location = new System.Drawing.Point(0, 0);
            this.show_user.Name = "show_user";
            this.show_user.Size = new System.Drawing.Size(271, 51);
            this.show_user.TabIndex = 9;
            this.show_user.Text = "Hello";
            this.show_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.show_user.Click += new System.EventHandler(this.show_user_Click);
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 27);
            this.label3.TabIndex = 10;
            this.label3.Text = "Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(318, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 27);
            this.label4.TabIndex = 11;
            this.label4.Text = "Class";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(624, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(300, 27);
            this.label5.TabIndex = 12;
            this.label5.Text = "Result";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // show_data_class
            // 
            this.show_data_class.Enabled = false;
            this.show_data_class.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_data_class.FormattingEnabled = true;
            this.show_data_class.ItemHeight = 31;
            this.show_data_class.Location = new System.Drawing.Point(318, 181);
            this.show_data_class.Name = "show_data_class";
            this.show_data_class.Size = new System.Drawing.Size(300, 345);
            this.show_data_class.TabIndex = 13;
            // 
            // show_data_result
            // 
            this.show_data_result.Enabled = false;
            this.show_data_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_data_result.FormattingEnabled = true;
            this.show_data_result.ItemHeight = 31;
            this.show_data_result.Location = new System.Drawing.Point(624, 181);
            this.show_data_result.Name = "show_data_result";
            this.show_data_result.Size = new System.Drawing.Size(300, 345);
            this.show_data_result.TabIndex = 14;
            // 
            // set
            // 
            this.set.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.set.Location = new System.Drawing.Point(340, 114);
            this.set.Name = "set";
            this.set.Size = new System.Drawing.Size(113, 36);
            this.set.TabIndex = 15;
            this.set.Text = "Set";
            this.set.UseVisualStyleBackColor = true;
            this.set.Click += new System.EventHandler(this.set_Click);
            // 
            // statistics
            // 
            this.statistics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.statistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statistics.Location = new System.Drawing.Point(461, 61);
            this.statistics.Margin = new System.Windows.Forms.Padding(0);
            this.statistics.Name = "statistics";
            this.statistics.Size = new System.Drawing.Size(113, 32);
            this.statistics.TabIndex = 16;
            this.statistics.Text = "Statistics";
            this.statistics.UseVisualStyleBackColor = true;
            this.statistics.Click += new System.EventHandler(this.statistics_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(461, 112);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(113, 36);
            this.exit.TabIndex = 17;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // comboBox_class
            // 
            this.comboBox_class.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBox_class.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox_class.FormattingEnabled = true;
            this.comboBox_class.Items.AddRange(new object[] {
            "Class 1",
            "Class 2",
            "Class 3",
            "Class 4",
            "Class 5"});
            this.comboBox_class.Location = new System.Drawing.Point(111, 58);
            this.comboBox_class.Name = "comboBox_class";
            this.comboBox_class.Size = new System.Drawing.Size(136, 33);
            this.comboBox_class.TabIndex = 18;
            // 
            // label_show_time
            // 
            this.label_show_time.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.label_show_time.BackColor = System.Drawing.Color.Transparent;
            this.label_show_time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_show_time.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_show_time.Location = new System.Drawing.Point(0, 0);
            this.label_show_time.Name = "label_show_time";
            this.label_show_time.Size = new System.Drawing.Size(271, 58);
            this.label_show_time.TabIndex = 19;
            this.label_show_time.Text = "time";
            this.label_show_time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 109);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.textBox_name);
            this.panel2.Controls.Add(this.comboBox_class);
            this.panel2.Controls.Add(this.statistics);
            this.panel2.Controls.Add(this.textBox_resalt);
            this.panel2.Controls.Add(this.submit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(940, 109);
            this.panel2.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(669, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(271, 109);
            this.panel3.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.show_user);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(271, 51);
            this.panel4.TabIndex = 20;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label_show_time);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 51);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(271, 58);
            this.panel5.TabIndex = 21;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.user_data);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(940, 45);
            this.panel6.TabIndex = 19;
            // 
            // Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 533);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.set);
            this.Controls.Add(this.show_data_result);
            this.Controls.Add(this.show_data_class);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.show_data_name);
            this.Controls.Add(this.choose_type);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Data_FormClosing);
            this.Load += new System.EventHandler(this.Data_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox choose_type;
        private System.Windows.Forms.ListBox show_data_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label user_data;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_resalt;
        private System.Windows.Forms.Label show_user;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox show_data_class;
        private System.Windows.Forms.ListBox show_data_result;
        private System.Windows.Forms.Button set;
        private System.Windows.Forms.Button statistics;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.ComboBox comboBox_class;
        private System.Windows.Forms.Label label_show_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}

