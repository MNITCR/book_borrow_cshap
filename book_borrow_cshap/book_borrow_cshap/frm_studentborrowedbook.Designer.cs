namespace book_borrow_cshap
{
    partial class frm_studentborrowedbook
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
            this.data_BorrowedBooks = new System.Windows.Forms.DataGridView();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentBookBorrowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_BorrowedBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // data_BorrowedBooks
            // 
            this.data_BorrowedBooks.AllowUserToAddRows = false;
            this.data_BorrowedBooks.AllowUserToDeleteRows = false;
            this.data_BorrowedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_BorrowedBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.UserID,
            this.Title,
            this.CurrentBookBorrowed});
            this.data_BorrowedBooks.Location = new System.Drawing.Point(22, 141);
            this.data_BorrowedBooks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.data_BorrowedBooks.Name = "data_BorrowedBooks";
            this.data_BorrowedBooks.ReadOnly = true;
            this.data_BorrowedBooks.RowHeadersWidth = 51;
            this.data_BorrowedBooks.Size = new System.Drawing.Size(1026, 416);
            this.data_BorrowedBooks.TabIndex = 1;
            // 
            // BookID
            // 
            this.BookID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookID.HeaderText = "BookID";
            this.BookID.MinimumWidth = 6;
            this.BookID.Name = "BookID";
            this.BookID.ReadOnly = true;
            // 
            // UserID
            // 
            this.UserID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserID.HeaderText = "UserID";
            this.UserID.MinimumWidth = 6;
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // CurrentBookBorrowed
            // 
            this.CurrentBookBorrowed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CurrentBookBorrowed.HeaderText = "Current Book Borrowed";
            this.CurrentBookBorrowed.MinimumWidth = 6;
            this.CurrentBookBorrowed.Name = "CurrentBookBorrowed";
            this.CurrentBookBorrowed.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(331, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 54);
            this.label1.TabIndex = 62;
            this.label1.Text = "Borrowe Book Form";
            // 
            // frm_studentborrowedbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 604);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_BorrowedBooks);
            this.Name = "frm_studentborrowedbook";
            this.Text = "frm_studentborrowedbook";
            ((System.ComponentModel.ISupportInitialize)(this.data_BorrowedBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_BorrowedBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentBookBorrowed;
        private System.Windows.Forms.Label label1;
    }
}