namespace View
{
    partial class CapacitorUserControl
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
            label2 = new Label();
            textBoxCapacity = new TextBox();
            textBoxFrequency = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 9);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "Capacity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 35);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Frequency";
            // 
            // textBoxCapacity
            // 
            textBoxCapacity.Location = new Point(68, 5);
            textBoxCapacity.Margin = new Padding(3, 2, 3, 2);
            textBoxCapacity.Name = "textBoxCapacity";
            textBoxCapacity.Size = new Size(110, 23);
            textBoxCapacity.TabIndex = 2;
            // 
            // textBoxFrequency
            // 
            textBoxFrequency.Location = new Point(68, 32);
            textBoxFrequency.Margin = new Padding(3, 2, 3, 2);
            textBoxFrequency.Name = "textBoxFrequency";
            textBoxFrequency.Size = new Size(110, 23);
            textBoxFrequency.TabIndex = 3;
            // 
            // CapacitorUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBoxFrequency);
            Controls.Add(textBoxCapacity);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CapacitorUserControl";
            Size = new Size(191, 58);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxCapacity;
        private TextBox textBoxFrequency;
    }
}
