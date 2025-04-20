namespace AppTestBD
{
    partial class AddReports
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
            label6 = new Label();
            TextDescription = new TextBox();
            label5 = new Label();
            NamePdf = new TextBox();
            button2 = new Button();
            label4 = new Label();
            label2 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            button1 = new Button();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            exitControl1 = new ExitControl();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(TextDescription);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(NamePdf);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 82);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(440, 545);
            panel1.TabIndex = 9;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(12, 308);
            label6.Name = "label6";
            label6.Size = new Size(106, 27);
            label6.TabIndex = 39;
            label6.Text = "Описание";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TextDescription
            // 
            TextDescription.Location = new Point(16, 338);
            TextDescription.Multiline = true;
            TextDescription.Name = "TextDescription";
            TextDescription.Size = new Size(412, 76);
            TextDescription.TabIndex = 38;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(12, 251);
            label5.Name = "label5";
            label5.Size = new Size(209, 27);
            label5.TabIndex = 37;
            label5.Text = "Название pdf файла";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NamePdf
            // 
            NamePdf.Location = new Point(16, 279);
            NamePdf.Name = "NamePdf";
            NamePdf.Size = new Size(211, 23);
            NamePdf.TabIndex = 36;
            // 
            // button2
            // 
            button2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.Location = new Point(251, 436);
            button2.Name = "button2";
            button2.Size = new Size(158, 56);
            button2.TabIndex = 35;
            button2.Text = "Создать pdf файл\r\n";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            label4.Location = new Point(214, 55);
            label4.Name = "label4";
            label4.Size = new Size(39, 30);
            label4.TabIndex = 33;
            label4.Text = "по";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            label2.Location = new Point(45, 53);
            label2.Name = "label2";
            label2.Size = new Size(24, 30);
            label2.TabIndex = 32;
            label2.Text = "с";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(259, 60);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(138, 23);
            dateTimePicker2.TabIndex = 31;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(70, 60);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(138, 23);
            dateTimePicker1.TabIndex = 30;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            label3.Location = new Point(57, 14);
            label3.Name = "label3";
            label3.Size = new Size(335, 30);
            label3.TabIndex = 29;
            label3.Text = "Выберите временной интервал";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(70, 103);
            button1.Name = "button1";
            button1.Size = new Size(304, 30);
            button1.TabIndex = 28;
            button1.Text = "Вывести выполненные услуги";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(16, 501);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(254, 19);
            radioButton3.TabIndex = 25;
            radioButton3.TabStop = true;
            radioButton3.Text = "Вывести график и таблицу в pdf формате";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(16, 466);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(196, 19);
            radioButton2.TabIndex = 24;
            radioButton2.TabStop = true;
            radioButton2.Text = "Вывести график в pdf формате";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(16, 428);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(201, 19);
            radioButton1.TabIndex = 23;
            radioButton1.TabStop = true;
            radioButton1.Text = "Вывести таблицу в pdf формате";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 148);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(416, 78);
            dataGridView1.TabIndex = 22;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(44, -1);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(348, 80);
            label1.TabIndex = 10;
            label1.Text = "Добавление отчета \r\nпо оказанным услугам\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // exitControl1
            // 
            exitControl1.Location = new Point(0, -1);
            exitControl1.Name = "exitControl1";
            exitControl1.Size = new Size(51, 51);
            exitControl1.TabIndex = 11;
            // 
            // AddReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(84, 166, 136);
            ClientSize = new Size(440, 627);
            Controls.Add(exitControl1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "AddReports";
            Text = " ";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ExitControl exitControl1;
        private RadioButton radioButton1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private Label label4;
        private Label label2;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Button button1;
        private Button button2;
        private Label label5;
        private TextBox NamePdf;
        private Label label6;
        private TextBox TextDescription;
        private DataGridView dataGridView1;
    }
}