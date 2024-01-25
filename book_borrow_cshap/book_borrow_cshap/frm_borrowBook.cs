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
using Oracle.DataAccess.Client;

namespace book_borrow_cshap
{
    public partial class frm_borrowBook : Form
    {
        BorrowingTransaction brrobook = new BorrowingTransaction();
        public frm_borrowBook()
        {
            InitializeComponent();
        }

        // Load book
        private void loadBooks()
        {
            Connection.Conn();
            csGlobal.cn.Open();
            OracleCommand cmd = new OracleCommand(@"
                SELECT NTotal.BookID, Title, TSupply - TBorrow AS CurrentStocks 
                FROM
                (SELECT BookID, NVL(SUM(Quantity), 0) AS TBorrow FROM LBR_TBL_BOOKRETURNTRANSACTION GROUP BY BookID) TotalBorrowTrans
                JOIN
                (SELECT BookID, NVL(SUM(Supplies), 0) AS TSupply FROM LBR_TBL_BOOKSUPPLYTRANSACTION GROUP BY BookID) TotalSupplyTrans
                ON TotalBorrowTrans.BookID = TotalSupplyTrans.BookID
                JOIN
                (SELECT BookID, Title FROM LBR_TBL_BOOKS GROUP BY BookID, Title) NTotal
                ON NTotal.BookID = TotalSupplyTrans.BookID", csGlobal.cn);

            OracleDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                dataBooks.Rows.Add(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString());
            }

            csGlobal.cn.Close();
        }

        // load user
        private void loadUsers()
        {
            Connection.Conn();
            csGlobal.cn.Open();
            OracleCommand cmd = new OracleCommand(@"SELECT UserID, FirstName, MiddleName, LastName FROM LBR_TBL_Users", csGlobal.cn);
            OracleDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                dataUser.Rows.Add(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString());
            }

            csGlobal.cn.Close();
        }

        //form load
        private void frm_borrowBook_Load(object sender, EventArgs e)
        {
            loadBooks();
            loadUsers();
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataCart.SelectedRows)
            {
                if (!row.IsNewRow)
                    dataCart.Rows.Remove(row);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dataCart.Rows.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataCart.Rows.Clear();
            dataBooks.Rows.Clear();
            dataUser.Rows.Clear();
            txtName.Clear();
            txtUserID.Clear();
            loadBooks();
            loadUsers();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (dataCart.RowCount.ToString() != "")
            {

                for (int x = 0; x < dataCart.Rows.Count; x++)
                {
                    Connection.Conn();
                    csGlobal.cn.Open();

                    brrobook.BookID = int.Parse(dataCart.Rows[x].Cells[0].Value.ToString());
                    if (int.TryParse(txtUserID.Text, out int userId))
                    {
                        brrobook.UserID = userId;
                    }
                    brrobook.BookID = int.Parse(dataCart.Rows[x].Cells[2].Value.ToString());


                    if (brrobook.Insert())
                    {
                        MessageBox.Show("Insert success!");
                        csGlobal.cn.Close();
                    }
                    else
                    {
                        MessageBox.Show(brrobook.error);
                    }
                    csGlobal.cn.Close();
                }

                
            }

            else
            {
                MessageBox.Show("Input Error", "Error");
            }
        }



        private void dataBooks_Click(object sender, EventArgs e)
        {
            //This simply adds selected books to cart

            if (dataBooks.SelectedRows.Count != 0)
            {
                bool exist = false;
                int currentQuantity = int.Parse(dataBooks.SelectedRows[0].Cells[2].Value.ToString());

                if (currentQuantity > 0) //Checks if the quantity of the currently selected book if greater than 0
                {
                    for (int i = 0; i < dataCart.Rows.Count; i++) // search the cart if it exist
                    {
                        for (int j = 0; j < dataCart.Columns.Count; j++)
                        {
                            if (dataCart.Rows[i].Cells[0].Value != null && dataBooks.SelectedRows[0].Cells[0].Value.ToString() == dataCart.Rows[i].Cells[0].Value.ToString())
                            {
                                //if it exist then increment the one in the cart then decrement the one in the databook
                                exist = true;
                                int quantity = 1;
                                string squantity;

                                squantity = dataCart.Rows[i].Cells[2].Value.ToString();
                                quantity += Int32.Parse(squantity);
                                squantity = quantity.ToString();

                                dataCart.Rows[i].Cells[2].Value = quantity;

                                currentQuantity = currentQuantity - 1;
                                dataBooks.SelectedRows[0].Cells[2].Value = currentQuantity.ToString();

                                break;
                            }
                        }
                    }
                    if (exist == false) // adds a new row if the book does not exist in the cart
                    {
                        dataCart.Rows.Add(dataBooks.SelectedRows[0].Cells[0].Value.ToString(),
                            dataBooks.SelectedRows[0].Cells[1].Value.ToString(), 1);
                        currentQuantity = currentQuantity - 1;
                        dataBooks.SelectedRows[0].Cells[2].Value = currentQuantity.ToString();
                    }
                }

                if (currentQuantity == 0)
                {
                    MessageBox.Show("Error no more available books", "Error");
                }
            }
        }

        private void dataUser_SizeChanged(object sender, EventArgs e)
        {
            if (dataUser.SelectedRows.Count != 0)
            {
                txtUserID.Text =
                    dataUser.SelectedRows[0].Cells[0].Value.ToString();
                txtName.Text =
                    dataUser.SelectedRows[0].Cells[1].Value.ToString() + " " + dataUser.SelectedRows[0].Cells[2].Value.ToString() + " " + dataUser.SelectedRows[0].Cells[3].Value.ToString();

            }
        }
    }
}
