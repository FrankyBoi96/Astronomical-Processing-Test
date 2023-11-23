namespace Astronomical_Processing
{
    partial class Form1
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
            this.lstBox = new System.Windows.Forms.ListBox();
            this.btnBinarySearch = new System.Windows.Forms.Button();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnRange = new System.Windows.Forms.Button();
            this.btnAverage = new System.Windows.Forms.Button();
            this.btnMode = new System.Windows.Forms.Button();
            this.btnMidEx = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnSeq = new System.Windows.Forms.Button();
            this.txtBoxRange = new System.Windows.Forms.TextBox();
            this.txtBoxAverage = new System.Windows.Forms.TextBox();
            this.txtBoxMode = new System.Windows.Forms.TextBox();
            this.txtBoxMidEx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstBox
            // 
            this.lstBox.FormattingEnabled = true;
            this.lstBox.Location = new System.Drawing.Point(50, 15);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(268, 329);
            this.lstBox.TabIndex = 0;
            this.lstBox.SelectedIndexChanged += new System.EventHandler(this.lstBox_SelectedIndexChanged);
            this.lstBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstBox_MouseDown);
            // 
            // btnBinarySearch
            // 
            this.btnBinarySearch.Location = new System.Drawing.Point(324, 213);
            this.btnBinarySearch.Name = "btnBinarySearch";
            this.btnBinarySearch.Size = new System.Drawing.Size(118, 60);
            this.btnBinarySearch.TabIndex = 1;
            this.btnBinarySearch.Text = "Binary Search";
            this.btnBinarySearch.UseVisualStyleBackColor = true;
            this.btnBinarySearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(50, 350);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(392, 20);
            this.txtBox.TabIndex = 2;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(324, 15);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(118, 60);
            this.btnSort.TabIndex = 3;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(324, 81);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(118, 60);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(324, 147);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(118, 60);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate Random Numbers";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // btnRange
            // 
            this.btnRange.Location = new System.Drawing.Point(50, 375);
            this.btnRange.Name = "btnRange";
            this.btnRange.Size = new System.Drawing.Size(106, 42);
            this.btnRange.TabIndex = 6;
            this.btnRange.Text = "Range";
            this.btnRange.UseVisualStyleBackColor = true;
            this.btnRange.Click += new System.EventHandler(this.btnRange_Click);
            // 
            // btnAverage
            // 
            this.btnAverage.Location = new System.Drawing.Point(50, 423);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(106, 42);
            this.btnAverage.TabIndex = 7;
            this.btnAverage.Text = "Average";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // btnMode
            // 
            this.btnMode.Location = new System.Drawing.Point(50, 471);
            this.btnMode.Name = "btnMode";
            this.btnMode.Size = new System.Drawing.Size(106, 42);
            this.btnMode.TabIndex = 8;
            this.btnMode.Text = "Mode";
            this.btnMode.UseVisualStyleBackColor = true;
            this.btnMode.Click += new System.EventHandler(this.btnMode_Click);
            // 
            // btnMidEx
            // 
            this.btnMidEx.Location = new System.Drawing.Point(50, 519);
            this.btnMidEx.Name = "btnMidEx";
            this.btnMidEx.Size = new System.Drawing.Size(106, 42);
            this.btnMidEx.TabIndex = 9;
            this.btnMidEx.Text = "Mid-Extreme";
            this.btnMidEx.UseVisualStyleBackColor = true;
            this.btnMidEx.Click += new System.EventHandler(this.btnMidEx_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(324, 375);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(118, 60);
            this.btnCalc.TabIndex = 10;
            this.btnCalc.Text = "Calculate All";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnSeq
            // 
            this.btnSeq.Location = new System.Drawing.Point(324, 279);
            this.btnSeq.Name = "btnSeq";
            this.btnSeq.Size = new System.Drawing.Size(118, 60);
            this.btnSeq.TabIndex = 11;
            this.btnSeq.Text = "Sequential Search ";
            this.btnSeq.UseVisualStyleBackColor = true;
            this.btnSeq.Click += new System.EventHandler(this.btnSeq_Click);
            // 
            // txtBoxRange
            // 
            this.txtBoxRange.Location = new System.Drawing.Point(163, 388);
            this.txtBoxRange.Name = "txtBoxRange";
            this.txtBoxRange.Size = new System.Drawing.Size(100, 20);
            this.txtBoxRange.TabIndex = 12;
            // 
            // txtBoxAverage
            // 
            this.txtBoxAverage.Location = new System.Drawing.Point(163, 435);
            this.txtBoxAverage.Name = "txtBoxAverage";
            this.txtBoxAverage.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAverage.TabIndex = 13;
            // 
            // txtBoxMode
            // 
            this.txtBoxMode.Location = new System.Drawing.Point(163, 483);
            this.txtBoxMode.Name = "txtBoxMode";
            this.txtBoxMode.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMode.TabIndex = 14;
            // 
            // txtBoxMidEx
            // 
            this.txtBoxMidEx.Location = new System.Drawing.Point(163, 531);
            this.txtBoxMidEx.Name = "txtBoxMidEx";
            this.txtBoxMidEx.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMidEx.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 580);
            this.Controls.Add(this.txtBoxMidEx);
            this.Controls.Add(this.txtBoxMode);
            this.Controls.Add(this.txtBoxAverage);
            this.Controls.Add(this.txtBoxRange);
            this.Controls.Add(this.btnSeq);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnMidEx);
            this.Controls.Add(this.btnMode);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.btnRange);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.btnBinarySearch);
            this.Controls.Add(this.lstBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBox;
        private System.Windows.Forms.Button btnBinarySearch;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnRange;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Button btnMode;
        private System.Windows.Forms.Button btnMidEx;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnSeq;
        private System.Windows.Forms.TextBox txtBoxRange;
        private System.Windows.Forms.TextBox txtBoxAverage;
        private System.Windows.Forms.TextBox txtBoxMode;
        private System.Windows.Forms.TextBox txtBoxMidEx;
    }
}

