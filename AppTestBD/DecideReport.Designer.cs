namespace AppTestBD
{
    partial class DecideReport
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
            components = new System.ComponentModel.Container();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button2.AutoSize = true;
            button2.Location = new Point(77, 31);
            button2.Name = "button2";
            button2.Size = new Size(250, 46);
            button2.TabIndex = 13;
            button2.Text = "Отчет по оказанным услугам";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button1.AutoSize = true;
            button1.Location = new Point(77, 117);
            button1.Name = "button1";
            button1.Size = new Size(250, 46);
            button1.TabIndex = 14;
            button1.Text = "Контроль качество";
            button1.UseVisualStyleBackColor = true;
           
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            label2.Location = new Point(169, 82);
            label2.Name = "label2";
            label2.Size = new Size(61, 30);
            label2.TabIndex = 17;
            label2.Text = "ИЛИ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
           
            // 
            // DecideReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(84, 166, 136);
            ClientSize = new Size(412, 189);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(button2);
            Name = "DecideReport";
            Text = "DecideReport";
          
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Label label2;
        private BindingSource bindingSource1;
    }
}