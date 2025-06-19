namespace View
{
    partial class AddForm
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
            SelectElementGroupBox = new GroupBox();
            ElementTypesComboBox = new ComboBox();
            ParametersGgroupBox = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SelectElementGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // SelectElementGroupBox
            // 
            SelectElementGroupBox.Controls.Add(ElementTypesComboBox);
            SelectElementGroupBox.Location = new Point(18, 16);
            SelectElementGroupBox.Name = "SelectElementGroupBox";
            SelectElementGroupBox.Size = new Size(202, 69);
            SelectElementGroupBox.TabIndex = 0;
            SelectElementGroupBox.TabStop = false;
            SelectElementGroupBox.Text = "Select of elements";
            // 
            // ElementTypesComboBox
            // 
            ElementTypesComboBox.FormattingEnabled = true;
            ElementTypesComboBox.Location = new Point(6, 26);
            ElementTypesComboBox.Name = "ElementTypesComboBox";
            ElementTypesComboBox.Size = new Size(190, 28);
            ElementTypesComboBox.TabIndex = 1;
            // 
            // ParametersGgroupBox
            // 
            ParametersGgroupBox.Location = new Point(18, 100);
            ParametersGgroupBox.Name = "ParametersGgroupBox";
            ParametersGgroupBox.Size = new Size(202, 125);
            ParametersGgroupBox.TabIndex = 1;
            ParametersGgroupBox.TabStop = false;
            ParametersGgroupBox.Text = "Parameters";
            // 
            // button1
            // 
            button1.Location = new Point(18, 231);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(126, 231);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(18, 266);
            button3.Name = "button3";
            button3.Size = new Size(202, 29);
            button3.TabIndex = 4;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(240, 316);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ParametersGgroupBox);
            Controls.Add(SelectElementGroupBox);
            Name = "AddForm";
            Text = "AddElements";
            SelectElementGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox SelectElementGroupBox;
        private ComboBox ElementTypesComboBox;
        private GroupBox ParametersGgroupBox;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}