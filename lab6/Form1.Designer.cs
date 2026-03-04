namespace lab6
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
            txtAuthorName = new TextBox();
            txtBookTitle = new TextBox();
            btnAddBook = new Button();
            listBoxBooks = new ListBox();
            btnFetchBooks = new Button();
            btnSearch = new Button();
            btnDelete = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            txtBookId = new TextBox();
            progressBar1 = new ProgressBar();
            txtSearch = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(16, 52);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.PlaceholderText = "Author Name";
            txtAuthorName.Size = new Size(330, 27);
            txtAuthorName.TabIndex = 8;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(16, 117);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.PlaceholderText = "Book Title";
            txtBookTitle.Size = new Size(330, 27);
            txtBookTitle.TabIndex = 7;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(250, 150);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(96, 34);
            btnAddBook.TabIndex = 6;
            btnAddBook.Text = "Add";
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(407, 39);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(370, 344);
            listBoxBooks.TabIndex = 3;
            // 
            // btnFetchBooks
            // 
            btnFetchBooks.Location = new Point(634, 409);
            btnFetchBooks.Name = "btnFetchBooks";
            btnFetchBooks.Size = new Size(143, 29);
            btnFetchBooks.TabIndex = 4;
            btnFetchBooks.Text = "Fetch Books";
            btnFetchBooks.UseVisualStyleBackColor = true;
            btnFetchBooks.Click += btnFetchBooks_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(315, 28);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 29);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search";
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(267, 90);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtAuthorName);
            groupBox1.Controls.Add(txtBookTitle);
            groupBox1.Controls.Add(btnAddBook);
            groupBox1.Location = new Point(21, 107);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(367, 200);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtBookId);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Location = new Point(21, 313);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(367, 125);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(16, 43);
            txtBookId.Name = "txtBookId";
            txtBookId.PlaceholderText = "Book Id";
            txtBookId.Size = new Size(330, 27);
            txtBookId.TabIndex = 9;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 72);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(376, 29);
            progressBar1.TabIndex = 12;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(14, 30);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search Title";
            txtSearch.Size = new Size(295, 27);
            txtSearch.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSearch);
            Controls.Add(progressBar1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnSearch);
            Controls.Add(btnFetchBooks);
            Controls.Add(listBoxBooks);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAuthorName;
        private TextBox txtBookTitle;
        private Button btnAddBook;
        private ListBox listBoxBooks;
        private Button btnFetchBooks;
        private Button btnSearch;
        private Button btnDelete;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtBookId;
        private ProgressBar progressBar1;
        private TextBox txtSearch;
    }
}
