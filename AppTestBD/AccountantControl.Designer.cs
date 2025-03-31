namespace AppTestBD
{
    partial class AccountantControl
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
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 216);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(440, 91);
            dataGridView1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button2.AutoSize = true;
            button2.Location = new Point(95, 97);
            button2.Name = "button2";
            button2.Size = new Size(250, 46);
            button2.TabIndex = 13;
            button2.Text = "Просмотр отчетов";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button1.AutoSize = true;
            button1.Location = new Point(95, 149);
            button1.Name = "button1";
            button1.Size = new Size(250, 46);
            button1.TabIndex = 12;
            button1.Text = "Сформировать счёт страховой компании ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AccountantControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "AccountantControl";
            Size = new Size(440, 307);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button2;
        private Button button1;
    }
}
