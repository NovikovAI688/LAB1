namespace View
{
    partial class capacitorUserControl1
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
            Capacity = new Label();
            Frequency = new Label();
            textBoxCapacity = new TextBox();
            textBoxFrequency = new TextBox();
            SuspendLayout();
            // 
            // Capacity
            // 
            Capacity.AutoSize = true;
            Capacity.Location = new Point(4, 11);
            Capacity.Name = "Capacity";
            Capacity.Size = new Size(66, 20);
            Capacity.TabIndex = 0;
            Capacity.Text = "Capacity";
            // 
            // Frequency
            // 
            Frequency.AutoSize = true;
            Frequency.Location = new Point(4, 45);
            Frequency.Name = "Frequency";
            Frequency.Size = new Size(76, 20);
            Frequency.TabIndex = 1;
            Frequency.Text = "Frequency";
            // 
            // textBoxCapacity
            // 
            textBoxCapacity.Location = new Point(86, 8);
            textBoxCapacity.Name = "textBoxCapacity";
            textBoxCapacity.Size = new Size(125, 27);
            textBoxCapacity.TabIndex = 2;
            // 
            // textBoxFrequency
            // 
            textBoxFrequency.Location = new Point(86, 42);
            textBoxFrequency.Name = "textBoxFrequency";
            textBoxFrequency.Size = new Size(125, 27);
            textBoxFrequency.TabIndex = 3;
            // 
            // capacitorUserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBoxFrequency);
            Controls.Add(textBoxCapacity);
            Controls.Add(Frequency);
            Controls.Add(Capacity);
            Name = "capacitorUserControl1";
            Size = new Size(218, 78);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Capacity;
        private Label Frequency;
        private TextBox textBoxCapacity;
        private TextBox textBoxFrequency;
    }
}
