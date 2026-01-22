namespace Task5Descend
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
            btnDisplay = new Button();
            btnDescend = new Button();
            listBoxNums = new ListBox();
            SuspendLayout();
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(36, 198);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(138, 29);
            btnDisplay.TabIndex = 0;
            btnDisplay.Text = "Display Numbers";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // btnDescend
            // 
            btnDescend.Location = new Point(192, 198);
            btnDescend.Name = "btnDescend";
            btnDescend.Size = new Size(138, 29);
            btnDescend.TabIndex = 1;
            btnDescend.Text = "Sort Descending";
            btnDescend.UseVisualStyleBackColor = true;
            btnDescend.Click += btnDescend_Click;
            // 
            // listBoxNums
            // 
            listBoxNums.FormattingEnabled = true;
            listBoxNums.Location = new Point(359, 65);
            listBoxNums.Name = "listBoxNums";
            listBoxNums.Size = new Size(393, 324);
            listBoxNums.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxNums);
            Controls.Add(btnDescend);
            Controls.Add(btnDisplay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDisplay;
        private Button btnDescend;
        private ListBox listBoxNums;
    }
}
