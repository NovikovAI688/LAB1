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
            buttonOK = new Button();
            buttonCancel = new Button();
            buttonAddRandomElement = new Button();
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
            ElementTypesComboBox.SelectedIndexChanged += ElementTypesComboBox_SelectedIndexChanged;
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
            // buttonOK
            // 
            buttonOK.Location = new Point(18, 231);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(94, 29);
            buttonOK.TabIndex = 2;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(126, 231);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonAddRandomElement
            // 
            buttonAddRandomElement.Location = new Point(18, 266);
            buttonAddRandomElement.Name = "buttonAddRandomElement";
            buttonAddRandomElement.Size = new Size(202, 29);
            buttonAddRandomElement.TabIndex = 4;
            buttonAddRandomElement.Text = "Add Random Element";
            buttonAddRandomElement.UseVisualStyleBackColor = true;
            buttonAddRandomElement.Click += buttonAddRandomElement_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(240, 316);
            Controls.Add(buttonAddRandomElement);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOK);
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
        private Button buttonOK;
        private Button buttonCancel;
        private Button buttonAddRandomElement;
    }
}