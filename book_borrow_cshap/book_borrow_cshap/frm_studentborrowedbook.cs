using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace book_borrow_cshap
{
    public partial class frm_studentborrowedbook : Form
    {
        public frm_studentborrowedbook()
        {
            InitializeComponent();
        }

        private void frm_studentborrowedbook_Load(object sender, EventArgs e)
        {
            Connection.Conn();
            csGlobal.cn.Open();

            OracleCommand cmd = new OracleCommand(@"SELECT BorrowTrans.BookID, BorrowTrans.UserID, NBooks.Title, BorrowTrans.Quantity
            FROM
            (SELECT BookID, UserID, SUM(Quantity) AS Quantity FROM LBR_TBL_BORROWINGTRANSACTION GROUP BY BookID, UserID) BorrowTrans
            INNER JOIN
            (SELECT BookID, Title FROM LBR_TBL_BOOKS GROUP BY BookID, Title) NBooks
            on NBooks.BookID = BorrowTrans.BookID", csGlobal.cn);

            OracleDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                if (!rdr.IsDBNull(1))
                {
                    data_BorrowedBooks.Rows.Add(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString());
                }
            }

            csGlobal.cn.Close();
        }
    }
}
