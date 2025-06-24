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
            SearchTextBox = new TextBox();
            label1 = new Label();
            CancelButton = new Button();
            OKbutton = new Button();
            ElementCheckedListBox = new CheckedListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(SearchTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(CancelButton);
            groupBox1.Controls.Add(OKbutton);
            groupBox1.Controls.Add(ElementCheckedListBox);
            groupBox1.Location = new Point(11, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(205, 187);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(68, 111);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(129, 27);
            SearchTextBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 114);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 3;
            label1.Text = "Search:";
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(103, 152);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 29);
            CancelButton.TabIndex = 2;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // OKbutton
            // 
            OKbutton.Location = new Point(6, 152);
            OKbutton.Name = "OKbutton";
            OKbutton.Size = new Size(94, 29);
            OKbutton.TabIndex = 1;
            OKbutton.Text = "OK";
            OKbutton.UseVisualStyleBackColor = true;
            OKbutton.Click += OKbutton_Click;
            // 
            // ElementCheckedListBox
            // 
            ElementCheckedListBox.FormattingEnabled = true;
            ElementCheckedListBox.Location = new Point(6, 27);
            ElementCheckedListBox.Name = "ElementCheckedListBox";
            ElementCheckedListBox.Size = new Size(191, 70);
            ElementCheckedListBox.TabIndex = 0;
            ElementCheckedListBox.SelectedIndexChanged += ElementCheckedListBox_SelectedIndexChanged;
            // 
            // FilterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(223, 211);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FilterForm";
            Text = "Filter";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button CancelButton;
        private Button OKbutton;
        private CheckedListBox ElementCheckedListBox;
        private TextBox SearchTextBox;
        private Label label1;
    }
}