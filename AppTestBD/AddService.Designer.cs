namespace AppTestBD
{
    partial class AddService
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
            exitControl1 = new ExitControl();
            panel1 = new Panel();
            label5 = new Label();
            textStatus = new TextBox();
            textID = new TextBox();
            label4 = new Label();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // exitControl1
            // 
            exitControl1.Location = new Point(1, 1);
            exitControl1.Name = "exitControl1";
            exitControl1.Size = new Size(51, 51);
            exitControl1.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textStatus);
            panel1.Controls.Add(textID);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 84);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(440, 332);
            panel1.TabIndex = 10;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            label5.Location = new Point(27, 114);
            label5.Name = "label5";
            label5.Size = new Size(162, 30);
            label5.TabIndex = 31;
            label5.Text = "Статус услуги";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textStatus
            // 
            textStatus.Location = new Point(27, 147);
            textStatus.Multiline = true;
            textStatus.Name = "textStatus";
            textStatus.Size = new Size(386, 31);
            textStatus.TabIndex = 30;
            // 
            // textID
            // 
            textID.Location = new Point(27, 80);
            textID.Multiline = true;
            textID.Name = "textID";
            textID.Size = new Size(386, 31);
            textID.TabIndex = 29;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            label4.Location = new Point(27, 47);
            label4.Name = "label4";
            label4.Size = new Size(231, 30);
            label4.TabIndex = 28;
            label4.Text = "Индефикатор услуги";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(112, 270);
            button1.Name = "button1";
            button1.Size = new Size(220, 43);
            button1.TabIndex = 9;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(89, -2);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(243, 80);
            label1.TabIndex = 11;
            label1.Text = "Добавление \r\nуслуги к заказу\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            label2.Location = new Point(27, 9);
            label2.Name = "label2";
            label2.Size = new Size(140, 30);
            label2.TabIndex = 32;
            label2.Text = "Заказ номер";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            label3.Location = new Point(170, 10);
            label3.Name = "label3";
            label3.Size = new Size(0, 30);
            label3.TabIndex = 33;
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddService
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(84, 166, 136);
            ClientSize = new Size(440, 416);
            Controls.Add(exitControl1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "AddService";
            Text = "AddService";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ExitControl exitControl1;
        private Panel panel1;
        private Button button1;
        private Label label1;
        private Label label5;
        private TextBox textStatus;
        private TextBox textID;
        private Label label4;
        private Label label2;
        private Label label3;
    }
}