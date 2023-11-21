namespace Astronomical_Processing
{
    partial class Form1
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
            TxtSearch = new TextBox();
            ListBox1 = new ListBox();
            menuStrip1 = new MenuStrip();
            statusStrip1 = new StatusStrip();
            BtnSearch = new Button();
            BtnSort = new Button();
            BtnEdit = new Button();
            BtnGenerate = new Button();
            BtnDelete = new Button();
            SuspendLayout();
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(23, 333);
            TxtSearch.Margin = new Padding(2, 1, 2, 1);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.Size = new Size(212, 23);
            TxtSearch.TabIndex = 0;
            TxtSearch.TextChanged += textBox1_TextChanged;
            // 
            // ListBox1
            // 
            ListBox1.FormattingEnabled = true;
            ListBox1.ItemHeight = 15;
            ListBox1.Location = new Point(23, 25);
            ListBox1.Margin = new Padding(2, 1, 2, 1);
            ListBox1.Name = "ListBox1";
            ListBox1.Size = new Size(212, 304);
            ListBox1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(3, 1, 0, 1);
            menuStrip1.Size = new Size(691, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(32, 32);
            statusStrip1.Location = new Point(0, 444);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 8, 0);
            statusStrip1.Size = new Size(691, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // BtnSearch
            // 
            BtnSearch.Location = new Point(23, 358);
            BtnSearch.Margin = new Padding(2, 1, 2, 1);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(212, 72);
            BtnSearch.TabIndex = 4;
            BtnSearch.Text = "Search Button";
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // BtnSort
            // 
            BtnSort.Location = new Point(239, 25);
            BtnSort.Margin = new Padding(2, 1, 2, 1);
            BtnSort.Name = "BtnSort";
            BtnSort.Size = new Size(212, 72);
            BtnSort.TabIndex = 5;
            BtnSort.Text = "Sort Button";
            BtnSort.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Location = new Point(239, 99);
            BtnEdit.Margin = new Padding(2, 1, 2, 1);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(212, 72);
            BtnEdit.TabIndex = 6;
            BtnEdit.Text = "Edit Button";
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnGenerate
            // 
            BtnGenerate.Location = new Point(239, 173);
            BtnGenerate.Margin = new Padding(2, 1, 2, 1);
            BtnGenerate.Name = "BtnGenerate";
            BtnGenerate.Size = new Size(212, 72);
            BtnGenerate.TabIndex = 7;
            BtnGenerate.Text = "Generate Random numbers";
            BtnGenerate.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(239, 247);
            BtnDelete.Margin = new Padding(2, 1, 2, 1);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(212, 72);
            BtnDelete.TabIndex = 8;
            BtnDelete.Text = "Delete Button ";
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 466);
            Controls.Add(BtnDelete);
            Controls.Add(BtnGenerate);
            Controls.Add(BtnEdit);
            Controls.Add(BtnSort);
            Controls.Add(BtnSearch);
            Controls.Add(statusStrip1);
            Controls.Add(ListBox1);
            Controls.Add(TxtSearch);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtSearch;
        private ListBox ListBox1;
        private MenuStrip menuStrip1;
        private StatusStrip statusStrip1;
        private Button BtnSearch;
        private Button BtnSort;
        private Button BtnEdit;
        private Button BtnGenerate;
        private Button BtnDelete;
    }
}