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
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            ElementDataGridView = new DataGridView();
            buttonAdd = new Button();
            buttonRemove = new Button();
            buttonClear = new Button();
            buttonFilter = new Button();
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
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(939, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(103, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(103, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // ElementDataGridView
            // 
            ElementDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ElementDataGridView.BorderStyle = BorderStyle.None;
            ElementDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ElementDataGridView.Location = new Point(6, 21);
            ElementDataGridView.Name = "ElementDataGridView";
            ElementDataGridView.RowHeadersWidth = 51;
            ElementDataGridView.Size = new Size(905, 150);
            ElementDataGridView.TabIndex = 4;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(6, 176);
            buttonAdd.Margin = new Padding(3, 2, 3, 2);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(82, 22);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(94, 176);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(82, 22);
            buttonRemove.TabIndex = 5;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(741, 176);
            buttonClear.Margin = new Padding(3, 2, 3, 2);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(82, 22);
            buttonClear.TabIndex = 6;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonFilter
            // 
            buttonFilter.Location = new Point(829, 176);
            buttonFilter.Margin = new Padding(3, 2, 3, 2);
            buttonFilter.Name = "buttonFilter";
            buttonFilter.Size = new Size(82, 22);
            buttonFilter.TabIndex = 7;
            buttonFilter.Text = "Filter";
            buttonFilter.UseVisualStyleBackColor = true;
            buttonFilter.Click += buttonFilter_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonFilter);
            groupBox1.Controls.Add(ElementDataGridView);
            groupBox1.Controls.Add(buttonAdd);
            groupBox1.Controls.Add(buttonClear);
            groupBox1.Controls.Add(buttonRemove);
            groupBox1.Location = new Point(12, 23);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(917, 204);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Element List";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 249);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
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
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private DataGridView ElementDataGridView;
        private Button buttonAdd;
        private Button buttonRemove;
        private Button buttonClear;
        private Button buttonFilter;
        private GroupBox groupBox1;
    }
}
