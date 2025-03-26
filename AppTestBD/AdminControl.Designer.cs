namespace AppTestBD
{
    partial class AdminControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 312);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(440, 87);
            dataGridView1.TabIndex = 3;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button3.AutoSize = true;
            button3.Location = new Point(96, 137);
            button3.Name = "button3";
            button3.Size = new Size(250, 46);
            button3.TabIndex = 28;
            button3.Text = "Активность пользователей";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button4.AutoSize = true;
            button4.Location = new Point(96, 189);
            button4.Name = "button4";
            button4.Size = new Size(250, 46);
            button4.TabIndex = 27;
            button4.Text = "Сформировать отчет";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button5.AutoSize = true;
            button5.Location = new Point(96, 241);
            button5.Name = "button5";
            button5.Size = new Size(250, 46);
            button5.TabIndex = 26;
            button5.Text = "Расходные данные лаборотории";
            button5.UseVisualStyleBackColor = true;
            // 
            // AdminControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(dataGridView1);
            Name = "AdminControl";
            Size = new Size(440, 399);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
