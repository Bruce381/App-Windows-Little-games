namespace School_APP
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.sine_in = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.show_error = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_username
            // 
            this.textBox_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_username.Location = new System.Drawing.Point(193, 139);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(315, 38);
            this.textBox_username.TabIndex = 0;
            this.textBox_username.Text = "User name";
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(193, 201);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(315, 38);
            this.textBox_password.TabIndex = 1;
            this.textBox_password.Text = "Password";
            // 
            // sine_in
            // 
            this.sine_in.BackColor = System.Drawing.Color.Transparent;
            this.sine_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sine_in.Location = new System.Drawing.Point(281, 278);
            this.sine_in.Name = "sine_in";
            this.sine_in.Size = new System.Drawing.Size(138, 46);
            this.sine_in.TabIndex = 2;
            this.sine_in.Text = "Log in";
            this.sine_in.UseVisualStyleBackColor = false;
            this.sine_in.Click += new System.EventHandler(this.sine_in_Click);
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(193, 75);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(315, 52);
            this.label.TabIndex = 3;
            this.label.Text = "Login CCC";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // show_error
            // 
            this.show_error.BackColor = System.Drawing.Color.Transparent;
            this.show_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_error.Location = new System.Drawing.Point(193, 242);
            this.show_error.Name = "show_error";
            this.show_error.Size = new System.Drawing.Size(315, 24);
            this.show_error.TabIndex = 4;
            this.show_error.Text = "error";
            this.show_error.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(538, 392);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(138, 46);
            this.exit.TabIndex = 5;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 450);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.show_error);
            this.Controls.Add(this.label);
            this.Controls.Add(this.sine_in);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button sine_in;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label show_error;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
    }
}