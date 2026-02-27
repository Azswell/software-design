namespace lab5
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
            grpbxcSearch = new GroupBox();
            btnSearch = new Button();
            txtbxSearch = new TextBox();
            grpbxAdd = new GroupBox();
            lblBookTitle = new Label();
            lblAuthorName = new Label();
            lblBookId = new Label();
            btnAdd = new Button();
            txtbxBookTitle = new TextBox();
            txtbxAuthorName = new TextBox();
            txtbxBookId = new TextBox();
            grpbxDelete = new GroupBox();
            btnDelete = new Button();
            txtbxDelBookId = new TextBox();
            grpbxLibrary = new GroupBox();
            listbxTable = new ListBox();
            btnUpdate = new Button();
            btnShow = new Button();
            grpbxcSearch.SuspendLayout();
            grpbxAdd.SuspendLayout();
            grpbxDelete.SuspendLayout();
            grpbxLibrary.SuspendLayout();
            SuspendLayout();
            // 
            // grpbxcSearch
            // 
            grpbxcSearch.Controls.Add(btnSearch);
            grpbxcSearch.Controls.Add(txtbxSearch);
            grpbxcSearch.Location = new Point(12, 12);
            grpbxcSearch.Name = "grpbxcSearch";
            grpbxcSearch.Size = new Size(383, 82);
            grpbxcSearch.TabIndex = 0;
            grpbxcSearch.TabStop = false;
            grpbxcSearch.Text = "Search by Author";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(282, 32);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(95, 23);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtbxSearch
            // 
            txtbxSearch.Location = new Point(15, 32);
            txtbxSearch.Name = "txtbxSearch";
            txtbxSearch.Size = new Size(261, 23);
            txtbxSearch.TabIndex = 0;
            // 
            // grpbxAdd
            // 
            grpbxAdd.Controls.Add(lblBookTitle);
            grpbxAdd.Controls.Add(lblAuthorName);
            grpbxAdd.Controls.Add(lblBookId);
            grpbxAdd.Controls.Add(btnAdd);
            grpbxAdd.Controls.Add(txtbxBookTitle);
            grpbxAdd.Controls.Add(txtbxAuthorName);
            grpbxAdd.Controls.Add(txtbxBookId);
            grpbxAdd.Location = new Point(12, 100);
            grpbxAdd.Name = "grpbxAdd";
            grpbxAdd.Size = new Size(383, 229);
            grpbxAdd.TabIndex = 1;
            grpbxAdd.TabStop = false;
            grpbxAdd.Text = "Add a Book";
            // 
            // lblBookTitle
            // 
            lblBookTitle.AutoSize = true;
            lblBookTitle.Location = new Point(15, 134);
            lblBookTitle.Name = "lblBookTitle";
            lblBookTitle.Size = new Size(59, 15);
            lblBookTitle.TabIndex = 8;
            lblBookTitle.Text = "Book Title";
            // 
            // lblAuthorName
            // 
            lblAuthorName.AutoSize = true;
            lblAuthorName.Location = new Point(15, 84);
            lblAuthorName.Name = "lblAuthorName";
            lblAuthorName.Size = new Size(79, 15);
            lblAuthorName.TabIndex = 7;
            lblAuthorName.Text = "Author Name";
            // 
            // lblBookId
            // 
            lblBookId.AutoSize = true;
            lblBookId.Location = new Point(15, 32);
            lblBookId.Name = "lblBookId";
            lblBookId.Size = new Size(50, 15);
            lblBookId.TabIndex = 6;
            lblBookId.Text = "Book Id:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(290, 191);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtbxBookTitle
            // 
            txtbxBookTitle.Location = new Point(15, 152);
            txtbxBookTitle.Name = "txtbxBookTitle";
            txtbxBookTitle.Size = new Size(350, 23);
            txtbxBookTitle.TabIndex = 4;
            // 
            // txtbxAuthorName
            // 
            txtbxAuthorName.Location = new Point(15, 102);
            txtbxAuthorName.Name = "txtbxAuthorName";
            txtbxAuthorName.Size = new Size(350, 23);
            txtbxAuthorName.TabIndex = 3;
            // 
            // txtbxBookId
            // 
            txtbxBookId.Location = new Point(15, 50);
            txtbxBookId.Name = "txtbxBookId";
            txtbxBookId.Size = new Size(350, 23);
            txtbxBookId.TabIndex = 2;
            // 
            // grpbxDelete
            // 
            grpbxDelete.Controls.Add(btnDelete);
            grpbxDelete.Controls.Add(txtbxDelBookId);
            grpbxDelete.Location = new Point(12, 335);
            grpbxDelete.Name = "grpbxDelete";
            grpbxDelete.Size = new Size(383, 103);
            grpbxDelete.TabIndex = 2;
            grpbxDelete.TabStop = false;
            grpbxDelete.Text = "Delete a Book";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(290, 71);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtbxDelBookId
            // 
            txtbxDelBookId.Location = new Point(15, 40);
            txtbxDelBookId.Name = "txtbxDelBookId";
            txtbxDelBookId.Size = new Size(350, 23);
            txtbxDelBookId.TabIndex = 6;
            // 
            // grpbxLibrary
            // 
            grpbxLibrary.Controls.Add(listbxTable);
            grpbxLibrary.Controls.Add(btnUpdate);
            grpbxLibrary.Controls.Add(btnShow);
            grpbxLibrary.Location = new Point(401, 12);
            grpbxLibrary.Name = "grpbxLibrary";
            grpbxLibrary.Size = new Size(387, 426);
            grpbxLibrary.TabIndex = 3;
            grpbxLibrary.TabStop = false;
            grpbxLibrary.Text = "Library";
            // 
            // listbxTable
            // 
            listbxTable.FormattingEnabled = true;
            listbxTable.ItemHeight = 15;
            listbxTable.Location = new Point(6, 22);
            listbxTable.Name = "listbxTable";
            listbxTable.Size = new Size(375, 364);
            listbxTable.TabIndex = 9;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(204, 394);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(285, 394);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(96, 23);
            btnShow.TabIndex = 7;
            btnShow.Text = "Show Books";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpbxLibrary);
            Controls.Add(grpbxDelete);
            Controls.Add(grpbxAdd);
            Controls.Add(grpbxcSearch);
            Name = "Form1";
            Text = "Form1";
            grpbxcSearch.ResumeLayout(false);
            grpbxcSearch.PerformLayout();
            grpbxAdd.ResumeLayout(false);
            grpbxAdd.PerformLayout();
            grpbxDelete.ResumeLayout(false);
            grpbxDelete.PerformLayout();
            grpbxLibrary.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpbxcSearch;
        private Button btnSearch;
        private TextBox txtbxSearch;
        private GroupBox grpbxAdd;
        private Button btnAdd;
        private TextBox txtbxBookTitle;
        private TextBox txtbxAuthorName;
        private TextBox txtbxBookId;
        private GroupBox grpbxDelete;
        private Button btnDelete;
        private TextBox txtbxDelBookId;
        private GroupBox grpbxLibrary;
        private ListBox listbxTable;
        private Button btnUpdate;
        private Button btnShow;
        private Label lblBookTitle;
        private Label lblAuthorName;
        private Label lblBookId;
    }
}