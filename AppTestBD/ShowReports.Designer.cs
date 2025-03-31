namespace AppTestBD
{
    partial class ShowReports
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
            dataGridView1 = new DataGridView();
            label2 = new Label();
            textSearch = new TextBox();
            button1 = new Button();
            label1 = new Label();
            exitControl1 = new ExitControl();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textSearch);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 75);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(440, 455);
            panel1.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 140);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(416, 150);
            dataGridView1.TabIndex = 16;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(59, 17);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(315, 60);
            label2.TabIndex = 11;
            label2.Text = "Введите индефикатор отчета\r\n или ID сотрудника ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textSearch
            // 
            textSearch.Location = new Point(12, 93);
            textSearch.Multiline = true;
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(296, 31);
            textSearch.TabIndex = 15;
            // 
            // button1
            // 
            button1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(314, 93);
            button1.Name = "button1";
            button1.Size = new Size(114, 31);
            button1.TabIndex = 9;
            button1.Text = "Поиск";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(71, 17);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(280, 40);
            label1.TabIndex = 10;
            label1.Text = "Просмотр отчетов";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // exitControl1
            // 
            exitControl1.Location = new Point(0, 1);
            exitControl1.Name = "exitControl1";
            exitControl1.Size = new Size(51, 51);
            exitControl1.TabIndex = 11;
            // 
            // ShowReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(84, 166, 136);
            ClientSize = new Size(440, 530);
            Controls.Add(exitControl1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "ShowReports";
            Text = "ShowReports";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textSearch;
        private Button button1;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private ExitControl exitControl1;
    }
}