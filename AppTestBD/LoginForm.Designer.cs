namespace AppTestBD
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            textPassword = new TextBox();
            pictureBox1 = new PictureBox();
            textLogin = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(84, 166, 136);
            button1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(78, 225);
            button1.Name = "button1";
            button1.Size = new Size(174, 44);
            button1.TabIndex = 0;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 36F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            label1.Location = new Point(6, 8);
            label1.Name = "label1";
            label1.Size = new Size(329, 67);
            label1.TabIndex = 1;
            label1.Text = "Авторизация";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(textPassword);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textLogin);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-3, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 288);
            panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.free_icon_lock_8472244;
            pictureBox2.Location = new Point(11, 130);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(67, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // textPassword
            // 
            textPassword.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            textPassword.Location = new Point(103, 139);
            textPassword.Multiline = true;
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(225, 41);
            textPassword.TabIndex = 3;
            textPassword.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.free_icon_user_1077114;
            pictureBox1.Location = new Point(11, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // textLogin
            // 
            textLogin.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            textLogin.Location = new Point(103, 51);
            textLogin.Multiline = true;
            textLogin.Name = "textLogin";
            textLogin.Size = new Size(225, 41);
            textLogin.TabIndex = 1;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(84, 166, 136);
            ClientSize = new Size(343, 378);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox textLogin;
        private PictureBox pictureBox2;
        private TextBox textPassword;
    }
}
