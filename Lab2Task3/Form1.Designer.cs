namespace Lab2Task3
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
            textFibPlaceInput = new TextBox();
            btnFibPlace = new Button();
            lblFibResult = new Label();
            textBaseNum = new TextBox();
            textExponentBox = new TextBox();
            btnCalculate = new Button();
            lblExpoResult = new Label();
            SuspendLayout();
            // 
            // textFibPlaceInput
            // 
            textFibPlaceInput.Location = new Point(75, 94);
            textFibPlaceInput.Name = "textFibPlaceInput";
            textFibPlaceInput.Size = new Size(245, 27);
            textFibPlaceInput.TabIndex = 0;
            // 
            // btnFibPlace
            // 
            btnFibPlace.Location = new Point(75, 152);
            btnFibPlace.Name = "btnFibPlace";
            btnFibPlace.Size = new Size(245, 52);
            btnFibPlace.TabIndex = 1;
            btnFibPlace.Text = "Find Number";
            btnFibPlace.UseVisualStyleBackColor = true;
            btnFibPlace.Click += btnFibPlace_Click;
            // 
            // lblFibResult
            // 
            lblFibResult.AutoSize = true;
            lblFibResult.Font = new Font("Segoe UI", 15F);
            lblFibResult.ForeColor = Color.Black;
            lblFibResult.Location = new Point(527, 129);
            lblFibResult.Name = "lblFibResult";
            lblFibResult.Size = new Size(81, 35);
            lblFibResult.TabIndex = 2;
            lblFibResult.Text = "Result";
            // 
            // textBaseNum
            // 
            textBaseNum.Location = new Point(75, 282);
            textBaseNum.Name = "textBaseNum";
            textBaseNum.Size = new Size(104, 27);
            textBaseNum.TabIndex = 3;
            // 
            // textExponentBox
            // 
            textExponentBox.Location = new Point(216, 282);
            textExponentBox.Name = "textExponentBox";
            textExponentBox.Size = new Size(104, 27);
            textExponentBox.TabIndex = 4;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(75, 331);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(245, 52);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblExpoResult
            // 
            lblExpoResult.AutoSize = true;
            lblExpoResult.Font = new Font("Segoe UI", 15F);
            lblExpoResult.Location = new Point(527, 300);
            lblExpoResult.Name = "lblExpoResult";
            lblExpoResult.Size = new Size(81, 35);
            lblExpoResult.TabIndex = 7;
            lblExpoResult.Text = "Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblExpoResult);
            Controls.Add(btnCalculate);
            Controls.Add(textExponentBox);
            Controls.Add(textBaseNum);
            Controls.Add(lblFibResult);
            Controls.Add(btnFibPlace);
            Controls.Add(textFibPlaceInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textFibPlaceInput;
        private Button btnFibPlace;
        private Label lblFibResult;
        private TextBox textBaseNum;
        private TextBox textExponentBox;
        private Button btnCalculate;
        private Label lblExpoResult;
    }
}
