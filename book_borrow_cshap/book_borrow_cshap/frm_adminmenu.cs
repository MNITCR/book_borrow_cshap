using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace book_borrow_cshap
{
    public partial class frm_adminmenu : Form
    {
        public frm_adminmenu()
        {
            InitializeComponent();
        }

        private void LoadCurrentStocks()
        {
            Connection.Conn();
            csGlobal.cn.Open();

            OracleCommand cmd = new OracleCommand(@"
                SELECT 
                    TotalBorrowTrans.BookID, 
                    NTotal.Title, 
                    TSupply - TBorrow AS CurrentStocks 
                FROM
                    (SELECT 
                        BookID, 
                        NVL(SUM(Quantity), 0) AS TBorrow 
                    FROM 
                        LBR_TBL_BORROWINGTRANSACTION 
                    GROUP BY 
                        BookID) TotalBorrowTrans
                INNER JOIN
                    (SELECT 
                        BookID, 
                        NVL(SUM(Supplies), 0) AS TSupply 
                    FROM 
                        LBR_TBL_BOOKSUPPLYTRANSACTION 
                    GROUP BY 
                        BookID) TotalSupplyTrans
                ON TotalSupplyTrans.BookID = TotalBorrowTrans.BookID
                INNER JOIN
                    (SELECT 
                        BookID, 
                        Title 
                    FROM 
                        LBR_TBL_BOOKS) NTotal
                ON NTotal.BookID = TotalSupplyTrans.BookID", csGlobal.cn);

            OracleDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                dataCurrentStocks.Rows.Add(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString());
            }

            csGlobal.cn.Close();
        }


        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_addbook form = new frm_addbook();
            try
            {
                form.Show();
            }
            catch (InvalidOperationException)
            {
                form.Show();
            }
        }

        private void addBookSupplyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_addBookSupply form = new frm_addBookSupply();
            try
            {
                form.Show();
            }
            catch (InvalidOperationException)
            {
                form.Show();
            }
        }

        private void manageMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_manageMembers form = new frm_manageMembers();
            try
            {
                form.Show();
            }
            catch (InvalidOperationException)
            {
                form.Show();
            }
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_returnedbooks form = new frm_returnedbooks();
            try
            {
                form.Show();
            }
            catch (InvalidOperationException)
            {
                form.Show();
            }
        }

        private void listOfBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_listOfBooks form = new frm_listOfBooks();
            try
            {
                form.Show();
            }
            catch (InvalidOperationException)
            {
                form.Show();
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frm_login login = new frm_login();
            try
            {
                login.Show();
            }
            catch (InvalidOperationException)
            {
                login.Show();
            }
        }

        private void borrowBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_borrowBook form = new frm_borrowBook();
            form.Show();
        }

        private void bookSupplyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_bookSupplyReport form = new frm_bookSupplyReport();
            form.Show();
        }

        private void bookBorrowReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_borrowedBooksReport form = new frm_borrowedBooksReport();
            form.Show();
        }

        private void frm_adminmenu_Load(object sender, EventArgs e)
        {
            dataCurrentStocks.Rows.Clear();
            LoadCurrentStocks();
        }
    }
}
