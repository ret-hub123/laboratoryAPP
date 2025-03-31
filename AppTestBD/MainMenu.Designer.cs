namespace AppTestBD
{
    partial class MainMenu
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
            label1 = new Label();
            labelFIO = new Label();
            labelRole = new Label();
            panel1 = new Panel();
            exitControl1 = new ExitControl();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(73, 11);
            label1.Name = "label1";
            label1.Size = new Size(288, 51);
            label1.TabIndex = 3;
            label1.Text = "Главное меню";
            // 
            // labelFIO
            // 
            labelFIO.Anchor = AnchorStyles.None;
            labelFIO.AutoSize = true;
            labelFIO.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            labelFIO.Location = new Point(84, 44);
            labelFIO.Name = "labelFIO";
            labelFIO.Size = new Size(59, 30);
            labelFIO.TabIndex = 3;
            labelFIO.Text = "ФИО";
            labelFIO.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelRole
            // 
            labelRole.Anchor = AnchorStyles.None;
            labelRole.AutoSize = true;
            labelRole.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            labelRole.Location = new Point(84, 84);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(60, 30);
            labelRole.TabIndex = 4;
            labelRole.Text = "Роль";
            labelRole.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Controls.Add(labelRole);
            panel1.Controls.Add(labelFIO);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 75);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(440, 403);
            panel1.TabIndex = 4;
            // 
            // exitControl1
            // 
            exitControl1.Location = new Point(0, 1);
            exitControl1.Name = "exitControl1";
            exitControl1.Size = new Size(51, 51);
            exitControl1.TabIndex = 5;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(84, 166, 136);
            ClientSize = new Size(440, 478);
            Controls.Add(exitControl1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "MainMenu";
            Text = "MainMenu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label labelFIO;
        private Label labelRole;
        private Panel panel1;
        private AccountantControl accountantControl1;
        private AccountantControl accountantControl2;
        private ExitControl exitControl1;
    }
}