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
    public partial class frm_studentreturnedbooks : Form
    {
        public frm_studentreturnedbooks()
        {
            InitializeComponent();
        }

        private void frm_studentreturnedbooks_Load(object sender, EventArgs e)
        {
            Connection.Conn();
            csGlobal.cn.Open();

            OracleCommand cmd = new OracleCommand(@"SELECT ReturnBookTrans.BookID, ReturnBookTrans.UserID, NBooks.Title, ReturnBookTrans.BRTQuantity AS ""Books Returned""
                FROM
                (SELECT BookID, Title FROM LBR_TBL_BOOKS GROUP BY BookID, Title) NBooks
                INNER JOIN
                (SELECT BookID, UserID, SUM(Quantity) AS BRTQuantity FROM LBR_TBL_BOOKRETURNTRANSACTION GROUP BY BookID, USERID) ReturnBookTrans
                ON NBooks.BookID = ReturnBookTrans.BookID
                WHERE ReturnBookTrans.UserID = :UserID", csGlobal.cn);

            cmd.Parameters.Add("UserID", OracleDbType.Varchar2).Value = frm_login.SetValueForUserID;

            OracleDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                if (!rdr.IsDBNull(1))
                {
                    data_ReturnedBooks.Rows.Add(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString());
                }
            }

            csGlobal.cn.Close();
        }
    }
}
