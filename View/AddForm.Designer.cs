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
            buttonOK = new Button();
            buttonCancel = new Button();
            buttonAddRandomElement = new Button();
            label1 = new Label();
            SelectElementGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // SelectElementGroupBox
            // 
            SelectElementGroupBox.Controls.Add(ElementTypesComboBox);
            SelectElementGroupBox.Location = new Point(16, 12);
            SelectElementGroupBox.Margin = new Padding(3, 2, 3, 2);
            SelectElementGroupBox.Name = "SelectElementGroupBox";
            SelectElementGroupBox.Padding = new Padding(3, 2, 3, 2);
            SelectElementGroupBox.Size = new Size(186, 52);
            SelectElementGroupBox.TabIndex = 0;
            SelectElementGroupBox.TabStop = false;
            SelectElementGroupBox.Text = "Select of elements";
            // 
            // ElementTypesComboBox
            // 
            ElementTypesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ElementTypesComboBox.FormattingEnabled = true;
            ElementTypesComboBox.Location = new Point(11, 20);
            ElementTypesComboBox.Margin = new Padding(3, 2, 3, 2);
            ElementTypesComboBox.Name = "ElementTypesComboBox";
            ElementTypesComboBox.Size = new Size(167, 23);
            ElementTypesComboBox.TabIndex = 1;
            ElementTypesComboBox.SelectedIndexChanged += ElementTypesComboBox_SelectedIndexChanged;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(16, 173);
            buttonOK.Margin = new Padding(3, 2, 3, 2);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(82, 22);
            buttonOK.TabIndex = 2;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(120, 174);
            buttonCancel.Margin = new Padding(3, 2, 3, 2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(82, 22);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonAddRandomElement
            // 
            buttonAddRandomElement.Location = new Point(16, 200);
            buttonAddRandomElement.Margin = new Padding(3, 2, 3, 2);
            buttonAddRandomElement.Name = "buttonAddRandomElement";
            buttonAddRandomElement.Size = new Size(186, 22);
            buttonAddRandomElement.TabIndex = 4;
            buttonAddRandomElement.Text = "Add Random Element";
            buttonAddRandomElement.UseVisualStyleBackColor = true;
            buttonAddRandomElement.Click += buttonAddRandomElement_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 66);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 5;
            label1.Text = "Parametrs";
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(232, 237);
            Controls.Add(label1);
            Controls.Add(buttonAddRandomElement);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOK);
            Controls.Add(SelectElementGroupBox);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddForm";
            Text = "AddElements";
            SelectElementGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox SelectElementGroupBox;
        private ComboBox ElementTypesComboBox;
        private Button buttonOK;
        private Button buttonCancel;
        private Button buttonAddRandomElement;
        private Label label1;
    }
}