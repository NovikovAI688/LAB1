namespace View
{
    partial class ImpedanceUserControl
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
            realTextBox = new TextBox();
            imaginaryTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // realTextBox
            // 
            realTextBox.Location = new Point(3, 3);
            realTextBox.Name = "realTextBox";
            realTextBox.Size = new Size(50, 27);
            realTextBox.TabIndex = 0;
            // 
            // imaginaryTextBox
            // 
            imaginaryTextBox.Location = new Point(98, 3);
            imaginaryTextBox.Name = "imaginaryTextBox";
            imaginaryTextBox.Size = new Size(50, 27);
            imaginaryTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 6);
            label1.Name = "label1";
            label1.Size = new Size(19, 20);
            label1.TabIndex = 2;
            label1.Text = "+";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 6);
            label2.Name = "label2";
            label2.Size = new Size(14, 20);
            label2.TabIndex = 3;
            label2.Text = "(";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(154, 6);
            label3.Name = "label3";
            label3.Size = new Size(21, 20);
            label3.TabIndex = 4;
            label3.Text = ")j,";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(181, 6);
            label4.Name = "label4";
            label4.Size = new Size(31, 20);
            label4.TabIndex = 5;
            label4.Text = "Ом";
            // 
            // ImpedanceUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(imaginaryTextBox);
            Controls.Add(realTextBox);
            Name = "ImpedanceUserControl";
            Size = new Size(217, 34);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox realTextBox;
        private TextBox imaginaryTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
