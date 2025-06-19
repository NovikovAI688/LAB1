namespace View
{
    partial class FilterForm
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
            groupBox1 = new GroupBox();
            ElementCheckedListBox = new CheckedListBox();
            OKbutton = new Button();
            CancelButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CancelButton);
            groupBox1.Controls.Add(OKbutton);
            groupBox1.Controls.Add(ElementCheckedListBox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(205, 160);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            // 
            // ElementCheckedListBox
            // 
            ElementCheckedListBox.FormattingEnabled = true;
            ElementCheckedListBox.Location = new Point(6, 26);
            ElementCheckedListBox.Name = "ElementCheckedListBox";
            ElementCheckedListBox.Size = new Size(191, 92);
            ElementCheckedListBox.TabIndex = 0;
            ElementCheckedListBox.SelectedIndexChanged += ElementCheckedListBox_SelectedIndexChanged;
            // 
            // OKbutton
            // 
            OKbutton.Location = new Point(6, 124);
            OKbutton.Name = "OKbutton";
            OKbutton.Size = new Size(94, 29);
            OKbutton.TabIndex = 1;
            OKbutton.Text = "OK";
            OKbutton.UseVisualStyleBackColor = true;
            OKbutton.Click += OKbutton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(103, 124);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 29);
            CancelButton.TabIndex = 2;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // FilterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(223, 180);
            Controls.Add(groupBox1);
            Name = "FilterForm";
            Text = "Filter";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button CancelButton;
        private Button OKbutton;
        private CheckedListBox ElementCheckedListBox;
    }
}