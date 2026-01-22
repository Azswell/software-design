namespace Task5Galanida
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            listBoxNumbers = new ListBox();
            button1 = new Button();
            displayArr = new Button();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // listBoxNumbers
            // 
            listBoxNumbers.FormattingEnabled = true;
            listBoxNumbers.Location = new Point(322, 0);
            listBoxNumbers.Name = "listBoxNumbers";
            listBoxNumbers.Size = new Size(478, 444);
            listBoxNumbers.TabIndex = 2;
            listBoxNumbers.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(168, 228);
            button1.Name = "button1";
            button1.Size = new Size(120, 29);
            button1.TabIndex = 3;
            button1.Text = "Sort";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnSort_Click;
            // 
            // displayArr
            // 
            displayArr.Location = new Point(28, 228);
            displayArr.Name = "displayArr";
            displayArr.Size = new Size(124, 29);
            displayArr.TabIndex = 5;
            displayArr.Text = "Display Array";
            displayArr.UseVisualStyleBackColor = true;
            displayArr.Click += btnDisplayArr_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(displayArr);
            Controls.Add(button1);
            Controls.Add(listBoxNumbers);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ListBox listBoxNumbers;
        private Button button1;
        private Button displayArr;
    }
}
