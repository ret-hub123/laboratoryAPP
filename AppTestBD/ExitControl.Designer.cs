namespace AppTestBD
{
    partial class ExitControl
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
            pictureExit = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureExit).BeginInit();
            SuspendLayout();
            // 
            // pictureExit
            // 
            pictureExit.ErrorImage = Properties.Resources.free_icon_exit_3483569;
            pictureExit.Image = Properties.Resources.free_icon_exit_3483569;
            pictureExit.Location = new Point(7, 8);
            pictureExit.Name = "pictureExit";
            pictureExit.Size = new Size(35, 28);
            pictureExit.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureExit.TabIndex = 0;
            pictureExit.TabStop = false;
            pictureExit.Click += pictureBox1_Click;
            // 
            // ExitControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureExit);
            Name = "ExitControl";
            Size = new Size(51, 51);
            ((System.ComponentModel.ISupportInitialize)pictureExit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureExit;
    }
}
