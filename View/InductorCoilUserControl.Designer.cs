namespace View
{
    partial class InductorCoilUserControl
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
            Inductance = new Label();
            Frequency = new Label();
            textBoxInductance = new TextBox();
            textBoxFrequency = new TextBox();
            SuspendLayout();
            // 
            // Inductance
            // 
            Inductance.AutoSize = true;
            Inductance.Location = new Point(3, 13);
            Inductance.Name = "Inductance";
            Inductance.Size = new Size(81, 20);
            Inductance.TabIndex = 0;
            Inductance.Text = "Inductance";
            // 
            // Frequency
            // 
            Frequency.AutoSize = true;
            Frequency.Location = new Point(3, 46);
            Frequency.Name = "Frequency";
            Frequency.Size = new Size(76, 20);
            Frequency.TabIndex = 1;
            Frequency.Text = "Frequency";
            // 
            // textBoxInductance
            // 
            textBoxInductance.Location = new Point(90, 10);
            textBoxInductance.Name = "textBoxInductance";
            textBoxInductance.Size = new Size(139, 27);
            textBoxInductance.TabIndex = 2;
            // 
            // textBoxFrequency
            // 
            textBoxFrequency.Location = new Point(90, 43);
            textBoxFrequency.Name = "textBoxFrequency";
            textBoxFrequency.Size = new Size(139, 27);
            textBoxFrequency.TabIndex = 3;
            // 
            // InductorCoilUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBoxFrequency);
            Controls.Add(textBoxInductance);
            Controls.Add(Frequency);
            Controls.Add(Inductance);
            Name = "InductorCoilUserControl";
            Size = new Size(241, 84);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Inductance;
        private Label Frequency;
        private TextBox textBoxInductance;
        private TextBox textBoxFrequency;
    }
}
