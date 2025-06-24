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
            ButtonOK = new Button();
            ButtonCancel = new Button();
            ButtonAddRandomElement = new Button();
            label1 = new Label();
            SelectElementGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // SelectElementGroupBox
            // 
            SelectElementGroupBox.Controls.Add(ElementTypesComboBox);
            SelectElementGroupBox.Location = new Point(18, 16);
            SelectElementGroupBox.Name = "SelectElementGroupBox";
            SelectElementGroupBox.Size = new Size(213, 69);
            SelectElementGroupBox.TabIndex = 0;
            SelectElementGroupBox.TabStop = false;
            SelectElementGroupBox.Text = "Select of elements";
            // 
            // ElementTypesComboBox
            // 
            ElementTypesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ElementTypesComboBox.FormattingEnabled = true;
            ElementTypesComboBox.Location = new Point(13, 27);
            ElementTypesComboBox.Name = "ElementTypesComboBox";
            ElementTypesComboBox.Size = new Size(190, 28);
            ElementTypesComboBox.TabIndex = 1;
            ElementTypesComboBox.SelectedIndexChanged += ElementTypesComboBox_SelectedIndexChanged;
            // 
            // ButtonOK
            // 
            ButtonOK.Location = new Point(18, 231);
            ButtonOK.Name = "ButtonOK";
            ButtonOK.Size = new Size(94, 29);
            ButtonOK.TabIndex = 2;
            ButtonOK.Text = "OK";
            ButtonOK.UseVisualStyleBackColor = true;
            ButtonOK.Click += ButtonOK_Click;
            // 
            // ButtonCancel
            // 
            ButtonCancel.Location = new Point(137, 232);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(94, 29);
            ButtonCancel.TabIndex = 3;
            ButtonCancel.Text = "Cancel";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // ButtonAddRandomElement
            // 
            ButtonAddRandomElement.Location = new Point(18, 267);
            ButtonAddRandomElement.Name = "ButtonAddRandomElement";
            ButtonAddRandomElement.Size = new Size(213, 29);
            ButtonAddRandomElement.TabIndex = 4;
            ButtonAddRandomElement.Text = "Add Random Element";
            ButtonAddRandomElement.UseVisualStyleBackColor = true;
            ButtonAddRandomElement.Click += ButtonAddRandomElement_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 88);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 5;
            label1.Text = "Parametrs";
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 316);
            Controls.Add(label1);
            Controls.Add(ButtonAddRandomElement);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonOK);
            Controls.Add(SelectElementGroupBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
        private Button ButtonOK;
        private Button ButtonCancel;
        private Button ButtonAddRandomElement;
        private Label label1;
    }
}