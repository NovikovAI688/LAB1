namespace View
{
    partial class ResistorUserControl
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
            label1 = new Label();
            resistanceTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 7);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Resistance";
            // 
            // resistanceTextBox
            // 
            resistanceTextBox.Location = new Point(68, 4);
            resistanceTextBox.Margin = new Padding(3, 2, 3, 2);
            resistanceTextBox.Name = "resistanceTextBox";
            resistanceTextBox.Size = new Size(110, 23);
            resistanceTextBox.TabIndex = 1;
            // 
            // ResistorUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(resistanceTextBox);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ResistorUserControl";
            Size = new Size(195, 28);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox resistanceTextBox;
    }
}
