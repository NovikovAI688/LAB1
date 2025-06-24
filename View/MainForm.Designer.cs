namespace View
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            OpenToolStripMenuItem = new ToolStripMenuItem();
            SaveToolStripMenuItem = new ToolStripMenuItem();
            ElementDataGridView = new DataGridView();
            ButtonAdd = new Button();
            ButtonRemove = new Button();
            ButtonClear = new Button();
            ButtonFilter = new Button();
            groupBox1 = new GroupBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ElementDataGridView).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(1073, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { OpenToolStripMenuItem, SaveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // OpenToolStripMenuItem
            // 
            OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            OpenToolStripMenuItem.Size = new Size(128, 26);
            OpenToolStripMenuItem.Text = "Open";
            OpenToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
            // 
            // SaveToolStripMenuItem
            // 
            SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            SaveToolStripMenuItem.Size = new Size(128, 26);
            SaveToolStripMenuItem.Text = "Save";
            SaveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // ElementDataGridView
            // 
            ElementDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ElementDataGridView.BorderStyle = BorderStyle.None;
            ElementDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ElementDataGridView.Location = new Point(7, 28);
            ElementDataGridView.Margin = new Padding(3, 4, 3, 4);
            ElementDataGridView.Name = "ElementDataGridView";
            ElementDataGridView.RowHeadersVisible = false;
            ElementDataGridView.RowHeadersWidth = 51;
            ElementDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ElementDataGridView.Size = new Size(1034, 200);
            ElementDataGridView.TabIndex = 4;
            // 
            // ButtonAdd
            // 
            ButtonAdd.Location = new Point(7, 235);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(94, 29);
            ButtonAdd.TabIndex = 3;
            ButtonAdd.Text = "Add";
            ButtonAdd.UseVisualStyleBackColor = true;
            ButtonAdd.Click += ButtonAdd_Click;
            // 
            // ButtonRemove
            // 
            ButtonRemove.Location = new Point(107, 235);
            ButtonRemove.Margin = new Padding(3, 4, 3, 4);
            ButtonRemove.Name = "ButtonRemove";
            ButtonRemove.Size = new Size(94, 29);
            ButtonRemove.TabIndex = 5;
            ButtonRemove.Text = "Remove";
            ButtonRemove.UseVisualStyleBackColor = true;
            ButtonRemove.Click += ButtonRemove_Click;
            // 
            // ButtonClear
            // 
            ButtonClear.Location = new Point(847, 235);
            ButtonClear.Name = "ButtonClear";
            ButtonClear.Size = new Size(94, 29);
            ButtonClear.TabIndex = 6;
            ButtonClear.Text = "Clear";
            ButtonClear.UseVisualStyleBackColor = true;
            ButtonClear.Click += ButtonClear_Click;
            // 
            // ButtonFilter
            // 
            ButtonFilter.Location = new Point(947, 235);
            ButtonFilter.Name = "ButtonFilter";
            ButtonFilter.Size = new Size(94, 29);
            ButtonFilter.TabIndex = 7;
            ButtonFilter.Text = "Filter";
            ButtonFilter.UseVisualStyleBackColor = true;
            ButtonFilter.Click += ButtonFilter_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ButtonFilter);
            groupBox1.Controls.Add(ElementDataGridView);
            groupBox1.Controls.Add(ButtonAdd);
            groupBox1.Controls.Add(ButtonClear);
            groupBox1.Controls.Add(ButtonRemove);
            groupBox1.Location = new Point(14, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1048, 272);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Element List";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 332);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Text = "Calculator impedance";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ElementDataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem OpenToolStripMenuItem;
        private ToolStripMenuItem SaveToolStripMenuItem;
        private DataGridView ElementDataGridView;
        private Button ButtonAdd;
        private Button ButtonRemove;
        private Button ButtonClear;
        private Button ButtonFilter;
        private GroupBox groupBox1;
    }
}
