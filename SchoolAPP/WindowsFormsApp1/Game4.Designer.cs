namespace WindowsFormsApp1
{
    partial class Game4
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
            this.hard = new System.Windows.Forms.Button();
            this.easy = new System.Windows.Forms.Button();
            this.Gamearea = new System.Windows.Forms.GroupBox();
            this.lifeshow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hard
            // 
            this.hard.BackColor = System.Drawing.Color.Transparent;
            this.hard.Location = new System.Drawing.Point(204, 12);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(75, 37);
            this.hard.TabIndex = 0;
            this.hard.Text = "Hard";
            this.hard.UseVisualStyleBackColor = false;
            this.hard.Click += new System.EventHandler(this.hard_Click);
            // 
            // easy
            // 
            this.easy.BackColor = System.Drawing.Color.Transparent;
            this.easy.Location = new System.Drawing.Point(123, 12);
            this.easy.Name = "easy";
            this.easy.Size = new System.Drawing.Size(75, 37);
            this.easy.TabIndex = 1;
            this.easy.Text = "Easy";
            this.easy.UseVisualStyleBackColor = false;
            this.easy.Click += new System.EventHandler(this.easy_Click);
            // 
            // Gamearea
            // 
            this.Gamearea.BackColor = System.Drawing.Color.Transparent;
            this.Gamearea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Gamearea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gamearea.ForeColor = System.Drawing.Color.White;
            this.Gamearea.Location = new System.Drawing.Point(0, 55);
            this.Gamearea.Name = "Gamearea";
            this.Gamearea.Size = new System.Drawing.Size(408, 395);
            this.Gamearea.TabIndex = 2;
            this.Gamearea.TabStop = false;
            this.Gamearea.Text = "Game";
            // 
            // lifeshow
            // 
            this.lifeshow.BackColor = System.Drawing.Color.Transparent;
            this.lifeshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lifeshow.ForeColor = System.Drawing.Color.White;
            this.lifeshow.Location = new System.Drawing.Point(17, 12);
            this.lifeshow.Name = "lifeshow";
            this.lifeshow.Size = new System.Drawing.Size(100, 37);
            this.lifeshow.TabIndex = 3;
            this.lifeshow.Text = "life";
            this.lifeshow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Game4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.GbJUfOcWcAAbi_g;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(408, 450);
            this.Controls.Add(this.lifeshow);
            this.Controls.Add(this.Gamearea);
            this.Controls.Add(this.easy);
            this.Controls.Add(this.hard);
            this.Name = "Game4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game4";
            this.Load += new System.EventHandler(this.Game4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button hard;
        private System.Windows.Forms.Button easy;
        private System.Windows.Forms.GroupBox Gamearea;
        private System.Windows.Forms.Label lifeshow;
    }
}