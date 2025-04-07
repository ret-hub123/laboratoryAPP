namespace AppTestBD
{
    partial class AddBiomaterial
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
            panel1 = new Panel();
            button3 = new Button();
            label5 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            label4 = new Label();
            label2 = new Label();
            textPatient = new TextBox();
            label3 = new Label();
            button1 = new Button();
            label1 = new Label();
            exitControl1 = new ExitControl();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textPatient);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 84);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(440, 437);
            panel1.TabIndex = 7;
            // 
            // button3
            // 
            button3.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.Location = new Point(21, 274);
            button3.Name = "button3";
            button3.Size = new Size(386, 62);
            button3.TabIndex = 21;
            button3.Text = "Добавить услугу к заказу";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            label5.Location = new Point(25, 190);
            label5.Name = "label5";
            label5.Size = new Size(267, 30);
            label5.TabIndex = 20;
            label5.Text = "Введите ФИО пациента:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(21, 76);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(386, 31);
            textBox1.TabIndex = 19;
            // 
            // button2
            // 
            button2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.Location = new Point(154, 143);
            button2.Name = "button2";
            button2.Size = new Size(138, 34);
            button2.TabIndex = 18;
            button2.Text = "Сканировать";
            button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            label4.Location = new Point(188, 110);
            label4.Name = "label4";
            label4.Size = new Size(61, 30);
            label4.TabIndex = 17;
            label4.Text = "ИЛИ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            label2.Location = new Point(21, 43);
            label2.Name = "label2";
            label2.Size = new Size(202, 30);
            label2.TabIndex = 16;
            label2.Text = "Введите вручную:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textPatient
            // 
            textPatient.Location = new Point(23, 223);
            textPatient.Multiline = true;
            textPatient.Name = "textPatient";
            textPatient.Size = new Size(386, 31);
            textPatient.TabIndex = 15;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            label3.Location = new Point(149, 13);
            label3.Name = "label3";
            label3.Size = new Size(154, 30);
            label3.TabIndex = 14;
            label3.Text = "Код пробирки";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(112, 368);
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
            label1.Location = new Point(44, -1);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(365, 80);
            label1.TabIndex = 8;
            label1.Text = "Добавление \r\nбиоматериала пациента\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // exitControl1
            // 
            exitControl1.Location = new Point(0, 0);
            exitControl1.Name = "exitControl1";
            exitControl1.Size = new Size(51, 51);
            exitControl1.TabIndex = 9;
            // 
            // AddBiomaterial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(84, 166, 136);
            ClientSize = new Size(440, 521);
            Controls.Add(exitControl1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "AddBiomaterial";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textPatient;
        private Label label3;
        private Button button1;
        private Label label1;
        private ExitControl exitControl1;
        private Label label4;
        private Label label2;
        private Label label5;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
    }
}