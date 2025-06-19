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
            label1 = new Label();
            label2 = new Label();
            textBoxInductance = new TextBox();
            textBoxFrequency = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 13);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "Inductance";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 46);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 1;
            label2.Text = "Frequency";
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
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "InductorCoilUserControl";
            Size = new Size(241, 84);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxInductance;
        private TextBox textBoxFrequency;
    }
}
