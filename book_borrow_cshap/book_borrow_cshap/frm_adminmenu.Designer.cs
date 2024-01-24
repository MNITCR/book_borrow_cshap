namespace book_borrow_cshap
{
    partial class frm_adminmenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCurrentStocks = new System.Windows.Forms.DataGridView();
            this.Available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookBorrowReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookSupplyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookSupplyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dataCurrentStocks)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Menu;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(59, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Currently Available Books";
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // BookID
            // 
            this.BookID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookID.HeaderText = "BookID";
            this.BookID.MinimumWidth = 6;
            this.BookID.Name = "BookID";
            this.BookID.ReadOnly = true;
            // 
            // dataCurrentStocks
            // 
            this.dataCurrentStocks.AllowUserToAddRows = false;
            this.dataCurrentStocks.AllowUserToDeleteRows = false;
            this.dataCurrentStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCurrentStocks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.Title,
            this.Available});
            this.dataCurrentStocks.Location = new System.Drawing.Point(65, 157);
            this.dataCurrentStocks.Margin = new System.Windows.Forms.Padding(4);
            this.dataCurrentStocks.Name = "dataCurrentStocks";
            this.dataCurrentStocks.ReadOnly = true;
            this.dataCurrentStocks.RowHeadersWidth = 51;
            this.dataCurrentStocks.Size = new System.Drawing.Size(916, 346);
            this.dataCurrentStocks.TabIndex = 7;
            // 
            // Available
            // 
            this.Available.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Available.HeaderText = "Available";
            this.Available.MinimumWidth = 6;
            this.Available.Name = "Available";
            this.Available.ReadOnly = true;
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(95, 74);
            this.logOutToolStripMenuItem.Text = "Log Out";
            // 
            // manageMembersToolStripMenuItem
            // 
            this.manageMembersToolStripMenuItem.Name = "manageMembersToolStripMenuItem";
            this.manageMembersToolStripMenuItem.Size = new System.Drawing.Size(184, 74);
            this.manageMembersToolStripMenuItem.Text = "Manage Members";
            // 
            // bookBorrowReportToolStripMenuItem
            // 
            this.bookBorrowReportToolStripMenuItem.Name = "bookBorrowReportToolStripMenuItem";
            this.bookBorrowReportToolStripMenuItem.Size = new System.Drawing.Size(275, 28);
            this.bookBorrowReportToolStripMenuItem.Text = "Book Borrow Report";
            // 
            // bookSupplyReportToolStripMenuItem
            // 
            this.bookSupplyReportToolStripMenuItem.Name = "bookSupplyReportToolStripMenuItem";
            this.bookSupplyReportToolStripMenuItem.Size = new System.Drawing.Size(275, 28);
            this.bookSupplyReportToolStripMenuItem.Text = "Book Supply Report";
            // 
            // addBookSupplyToolStripMenuItem
            // 
            this.addBookSupplyToolStripMenuItem.Name = "addBookSupplyToolStripMenuItem";
            this.addBookSupplyToolStripMenuItem.Size = new System.Drawing.Size(245, 28);
            this.addBookSupplyToolStripMenuItem.Text = "Add Book Supply";
            // 
            // addBookToolStripMenuItem
            // 
            this.addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            this.addBookToolStripMenuItem.Size = new System.Drawing.Size(245, 28);
            this.addBookToolStripMenuItem.Text = "Add Book Info";
            // 
            // returnBookToolStripMenuItem
            // 
            this.returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            this.returnBookToolStripMenuItem.Size = new System.Drawing.Size(245, 28);
            this.returnBookToolStripMenuItem.Text = "Return Book";
            // 
            // borrowBookToolStripMenuItem
            // 
            this.borrowBookToolStripMenuItem.Name = "borrowBookToolStripMenuItem";
            this.borrowBookToolStripMenuItem.Size = new System.Drawing.Size(245, 28);
            this.borrowBookToolStripMenuItem.Text = "Borrow Book";
            // 
            // listOfBookToolStripMenuItem
            // 
            this.listOfBookToolStripMenuItem.Name = "listOfBookToolStripMenuItem";
            this.listOfBookToolStripMenuItem.Size = new System.Drawing.Size(245, 28);
            this.listOfBookToolStripMenuItem.Text = "List of Books";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfBookToolStripMenuItem,
            this.borrowBookToolStripMenuItem,
            this.returnBookToolStripMenuItem,
            this.addBookToolStripMenuItem,
            this.addBookSupplyToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 9, 0);
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(159, 74);
            this.fileToolStripMenuItem.Text = "Manage Books";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookSupplyReportToolStripMenuItem,
            this.bookBorrowReportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(84, 74);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.manageMembersToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1064, 80);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frm_adminmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 557);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataCurrentStocks);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frm_adminmenu";
            this.Text = "frm_adminmenu";
            ((System.ComponentModel.ISupportInitialize)(this.dataCurrentStocks)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridView dataCurrentStocks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Available;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageMembersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookBorrowReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookSupplyReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBookSupplyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}