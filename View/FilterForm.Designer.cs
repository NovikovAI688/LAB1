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
            CancelButton = new Button();
            OKbutton = new Button();
            ElementCheckedListBox = new CheckedListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CancelButton);
            groupBox1.Controls.Add(OKbutton);
            groupBox1.Controls.Add(ElementCheckedListBox);
            groupBox1.Location = new Point(10, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(179, 120);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(90, 93);
            CancelButton.Margin = new Padding(3, 2, 3, 2);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(82, 22);
            CancelButton.TabIndex = 2;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // OKbutton
            // 
            OKbutton.Location = new Point(5, 93);
            OKbutton.Margin = new Padding(3, 2, 3, 2);
            OKbutton.Name = "OKbutton";
            OKbutton.Size = new Size(82, 22);
            OKbutton.TabIndex = 1;
            OKbutton.Text = "OK";
            OKbutton.UseVisualStyleBackColor = true;
            OKbutton.Click += OKbutton_Click;
            // 
            // ElementCheckedListBox
            // 
            ElementCheckedListBox.FormattingEnabled = true;
            ElementCheckedListBox.Location = new Point(5, 20);
            ElementCheckedListBox.Margin = new Padding(3, 2, 3, 2);
            ElementCheckedListBox.Name = "ElementCheckedListBox";
            ElementCheckedListBox.Size = new Size(168, 58);
            ElementCheckedListBox.TabIndex = 0;
            ElementCheckedListBox.SelectedIndexChanged += ElementCheckedListBox_SelectedIndexChanged;
            // 
            // FilterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(195, 135);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
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