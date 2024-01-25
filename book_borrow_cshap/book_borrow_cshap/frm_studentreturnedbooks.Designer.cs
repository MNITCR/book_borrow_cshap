namespace book_borrow_cshap
{
    partial class frm_studentreturnedbooks
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
            this.data_ReturnedBooks = new System.Windows.Forms.DataGridView();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BooksReturned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_ReturnedBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // data_ReturnedBooks
            // 
            this.data_ReturnedBooks.AllowUserToAddRows = false;
            this.data_ReturnedBooks.AllowUserToDeleteRows = false;
            this.data_ReturnedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_ReturnedBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.UserID,
            this.Title,
            this.BooksReturned});
            this.data_ReturnedBooks.Location = new System.Drawing.Point(53, 127);
            this.data_ReturnedBooks.Margin = new System.Windows.Forms.Padding(4);
            this.data_ReturnedBooks.Name = "data_ReturnedBooks";
            this.data_ReturnedBooks.ReadOnly = true;
            this.data_ReturnedBooks.RowHeadersWidth = 51;
            this.data_ReturnedBooks.Size = new System.Drawing.Size(967, 451);
            this.data_ReturnedBooks.TabIndex = 2;
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
            // BooksReturned
            // 
            this.BooksReturned.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BooksReturned.HeaderText = "Books Returned";
            this.BooksReturned.MinimumWidth = 6;
            this.BooksReturned.Name = "BooksReturned";
            this.BooksReturned.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(327, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 54);
            this.label1.TabIndex = 63;
            this.label1.Text = "List Of Return Book";
            // 
            // frm_studentreturnedbooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 602);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_ReturnedBooks);
            this.Name = "frm_studentreturnedbooks";
            this.Text = "frm_studentreturnedbooks";
            this.Load += new System.EventHandler(this.frm_studentreturnedbooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_ReturnedBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_ReturnedBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn BooksReturned;
        private System.Windows.Forms.Label label1;
    }
}