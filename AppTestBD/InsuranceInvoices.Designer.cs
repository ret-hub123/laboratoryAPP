﻿namespace AppTestBD
{
    partial class InsuranceInvoices
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
            textname = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textSum = new TextBox();
            labelFIO = new Label();
            textDescript = new RichTextBox();
            button1 = new Button();
            label1 = new Label();
            exitControl1 = new ExitControl();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Controls.Add(textname);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textSum);
            panel1.Controls.Add(labelFIO);
            panel1.Controls.Add(textDescript);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 84);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(440, 437);
            panel1.TabIndex = 5;
            // 
            // textname
            // 
            textname.Location = new Point(27, 44);
            textname.Multiline = true;
            textname.Name = "textname";
            textname.Size = new Size(386, 31);
            textname.TabIndex = 15;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            label3.Location = new Point(27, 11);
            label3.Name = "label3";
            label3.Size = new Size(234, 30);
            label3.TabIndex = 14;
            label3.Text = "Страховая компания:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            label2.Location = new Point(27, 86);
            label2.Name = "label2";
            label2.Size = new Size(225, 30);
            label2.TabIndex = 13;
            label2.Text = "Контрольная сумма:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textSum
            // 
            textSum.Location = new Point(27, 119);
            textSum.Multiline = true;
            textSum.Name = "textSum";
            textSum.Size = new Size(386, 31);
            textSum.TabIndex = 12;
            // 
            // labelFIO
            // 
            labelFIO.Anchor = AnchorStyles.None;
            labelFIO.AutoSize = true;
            labelFIO.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            labelFIO.Location = new Point(27, 165);
            labelFIO.Name = "labelFIO";
            labelFIO.Size = new Size(126, 30);
            labelFIO.TabIndex = 11;
            labelFIO.Text = "Описание:";
            labelFIO.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textDescript
            // 
            textDescript.Location = new Point(27, 198);
            textDescript.Name = "textDescript";
            textDescript.Size = new Size(386, 144);
            textDescript.TabIndex = 10;
            textDescript.Text = "";
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
            label1.Size = new Size(327, 80);
            label1.TabIndex = 6;
            label1.Text = "Создание счёта\r\n страховой компании\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // exitControl1
            // 
            exitControl1.Location = new Point(0, -1);
            exitControl1.Name = "exitControl1";
            exitControl1.Size = new Size(51, 51);
            exitControl1.TabIndex = 7;
            // 
            // InsuranceInvoices
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(84, 166, 136);
            ClientSize = new Size(440, 521);
            Controls.Add(exitControl1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "InsuranceInvoices";
            Text = "InsuranceInvoices";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textname;
        private Label label3;
        private Label label2;
        private TextBox textSum;
        private Label labelFIO;
        private RichTextBox textDescript;
        private Button button1;
        private ExitControl exitControl1;
    }
}