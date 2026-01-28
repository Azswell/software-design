namespace lab2
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
            btnFibCalculate = new Button();
            inputFibBox = new TextBox();
            label1 = new Label();
            labelFibResult = new Label();
            label2 = new Label();
            inputSumBox = new TextBox();
            btnSumCalculate = new Button();
            labelSumResult = new Label();
            SuspendLayout();
            // 
            // btnFibCalculate
            // 
            btnFibCalculate.Location = new Point(82, 157);
            btnFibCalculate.Name = "btnFibCalculate";
            btnFibCalculate.Size = new Size(231, 48);
            btnFibCalculate.TabIndex = 0;
            btnFibCalculate.Text = "Calculate";
            btnFibCalculate.UseVisualStyleBackColor = true;
            btnFibCalculate.Click += button1_Click;
            // 
            // inputFibBox
            // 
            inputFibBox.Location = new Point(82, 95);
            inputFibBox.Name = "inputFibBox";
            inputFibBox.Size = new Size(231, 27);
            inputFibBox.TabIndex = 1;
            inputFibBox.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 55);
            label1.Name = "label1";
            label1.Size = new Size(195, 20);
            label1.TabIndex = 2;
            label1.Text = "Input Number for Fibonnaci:";
            label1.Click += label1_Click;
            // 
            // labelFibResult
            // 
            labelFibResult.AutoSize = true;
            labelFibResult.Font = new Font("Segoe UI", 15F);
            labelFibResult.Location = new Point(482, 112);
            labelFibResult.Name = "labelFibResult";
            labelFibResult.Size = new Size(193, 35);
            labelFibResult.TabIndex = 3;
            labelFibResult.Text = "Fibonacci Result";
            labelFibResult.Click += label2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 269);
            label2.Name = "label2";
            label2.Size = new Size(249, 20);
            label2.TabIndex = 4;
            label2.Text = "Input Numbers to Calculate for Sum:";
            label2.Click += label2_Click_1;
            // 
            // inputSumBox
            // 
            inputSumBox.Location = new Point(82, 316);
            inputSumBox.Name = "inputSumBox";
            inputSumBox.Size = new Size(231, 27);
            inputSumBox.TabIndex = 5;
            inputSumBox.TextChanged += textBox1_TextChanged_1;
            // 
            // btnSumCalculate
            // 
            btnSumCalculate.Location = new Point(82, 366);
            btnSumCalculate.Name = "btnSumCalculate";
            btnSumCalculate.Size = new Size(231, 48);
            btnSumCalculate.TabIndex = 6;
            btnSumCalculate.Text = "Calculate";
            btnSumCalculate.UseVisualStyleBackColor = true;
            btnSumCalculate.Click += button1_Click_1;
            // 
            // labelSumResult
            // 
            labelSumResult.AutoSize = true;
            labelSumResult.Font = new Font("Segoe UI", 15F);
            labelSumResult.Location = new Point(515, 316);
            labelSumResult.Name = "labelSumResult";
            labelSumResult.Size = new Size(137, 35);
            labelSumResult.TabIndex = 8;
            labelSumResult.Text = "Sum Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelSumResult);
            Controls.Add(btnSumCalculate);
            Controls.Add(inputSumBox);
            Controls.Add(label2);
            Controls.Add(labelFibResult);
            Controls.Add(label1);
            Controls.Add(inputFibBox);
            Controls.Add(btnFibCalculate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFibCalculate;
        private TextBox inputFibBox;
        private Label label1;
        private Label labelFibResult;
        private Label label2;
        private TextBox inputSumBox;
        private Button btnSumCalculate;
        private Label labelSumResult;
    }
}
