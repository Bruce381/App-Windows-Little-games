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
            "成绩从小到大",
            "成绩从大到小"});
            this.choose_type.Location = new System.Drawing.Point(16, 103);
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
            this.show_data_name.Size = new System.Drawing.Size(260, 345);
            this.show_data_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Class";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // user_data
            // 
            this.user_data.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.user_data.BackColor = System.Drawing.Color.Transparent;
            this.user_data.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_data.Location = new System.Drawing.Point(249, 9);
            this.user_data.Name = "user_data";
            this.user_data.Size = new System.Drawing.Size(85, 30);
            this.user_data.TabIndex = 4;
            this.user_data.Text = "Result";
            this.user_data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(340, 39);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(113, 33);
            this.submit.TabIndex = 5;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_name.Location = new System.Drawing.Point(16, 42);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(82, 30);
            this.textBox_name.TabIndex = 6;
            // 
            // textBox_resalt
            // 
            this.textBox_resalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_resalt.Location = new System.Drawing.Point(253, 42);
            this.textBox_resalt.Name = "textBox_resalt";
            this.textBox_resalt.Size = new System.Drawing.Size(81, 30);
            this.textBox_resalt.TabIndex = 8;
            this.textBox_resalt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_resalt_KeyPress);
            // 
            // show_user
            // 
            this.show_user.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.show_user.BackColor = System.Drawing.Color.Transparent;
            this.show_user.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_user.Location = new System.Drawing.Point(696, 9);
            this.show_user.Name = "show_user";
            this.show_user.Size = new System.Drawing.Size(158, 31);
            this.show_user.TabIndex = 9;
            this.show_user.Text = "Hello";
            this.show_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 27);
            this.label3.TabIndex = 10;
            this.label3.Text = "Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(309, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 27);
            this.label4.TabIndex = 11;
            this.label4.Text = "Class";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(594, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 27);
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
            this.show_data_class.Location = new System.Drawing.Point(309, 181);
            this.show_data_class.Name = "show_data_class";
            this.show_data_class.Size = new System.Drawing.Size(260, 345);
            this.show_data_class.TabIndex = 13;
            // 
            // show_data_result
            // 
            this.show_data_result.Enabled = false;
            this.show_data_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_data_result.FormattingEnabled = true;
            this.show_data_result.ItemHeight = 31;
            this.show_data_result.Location = new System.Drawing.Point(594, 181);
            this.show_data_result.Name = "show_data_result";
            this.show_data_result.Size = new System.Drawing.Size(260, 345);
            this.show_data_result.TabIndex = 14;
            // 
            // set
            // 
            this.set.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.set.Location = new System.Drawing.Point(340, 102);
            this.set.Name = "set";
            this.set.Size = new System.Drawing.Size(113, 36);
            this.set.TabIndex = 15;
            this.set.Text = "Set";
            this.set.UseVisualStyleBackColor = true;
            this.set.Click += new System.EventHandler(this.set_Click);
            // 
            // statistics
            // 
            this.statistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statistics.Location = new System.Drawing.Point(481, 39);
            this.statistics.Margin = new System.Windows.Forms.Padding(0);
            this.statistics.Name = "statistics";
            this.statistics.Size = new System.Drawing.Size(113, 33);
            this.statistics.TabIndex = 16;
            this.statistics.Text = "Statistics";
            this.statistics.UseVisualStyleBackColor = true;
            this.statistics.Click += new System.EventHandler(this.statistics_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(481, 103);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(113, 36);
            this.exit.TabIndex = 17;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // comboBox_class
            // 
            this.comboBox_class.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox_class.FormattingEnabled = true;
            this.comboBox_class.Items.AddRange(new object[] {
            "Class 1",
            "Class 2",
            "Class 3",
            "Class 4",
            "Class 5"});
            this.comboBox_class.Location = new System.Drawing.Point(107, 39);
            this.comboBox_class.Name = "comboBox_class";
            this.comboBox_class.Size = new System.Drawing.Size(136, 33);
            this.comboBox_class.TabIndex = 18;
            // 
            // Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 533);
            this.Controls.Add(this.comboBox_class);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.statistics);
            this.Controls.Add(this.set);
            this.Controls.Add(this.show_data_result);
            this.Controls.Add(this.show_data_class);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.show_user);
            this.Controls.Add(this.textBox_resalt);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.user_data);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.show_data_name);
            this.Controls.Add(this.choose_type);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Data_FormClosing);
            this.Load += new System.EventHandler(this.Data_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

