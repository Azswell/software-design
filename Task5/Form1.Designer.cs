namespace Task5
{
    partial class Form1Task5
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
            btnDisplay = new Button();
            btnSort = new Button();
            listBoxNumbers = new ListBox();
            SuspendLayout();
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(57, 183);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(124, 29);
            btnDisplay.TabIndex = 0;
            btnDisplay.Text = "Display Array";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(225, 183);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(124, 29);
            btnSort.TabIndex = 1;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // listBoxNumbers
            // 
            listBoxNumbers.FormattingEnabled = true;
            listBoxNumbers.Location = new Point(395, 50);
            listBoxNumbers.Name = "listBoxNumbers";
            listBoxNumbers.Size = new Size(351, 344);
            listBoxNumbers.TabIndex = 2;
            // 
            // Form1Task5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxNumbers);
            Controls.Add(btnSort);
            Controls.Add(btnDisplay);
            Name = "Form1Task5";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDisplay;
        private Button btnSort;
        private ListBox listBoxNumbers;
    }
}
