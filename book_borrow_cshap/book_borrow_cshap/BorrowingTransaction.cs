using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_borrow_cshap
{
    public class BorrowingTransaction
    {
        //Property
        public string error;
        public int BBRID { get; set; }
        public string Quantity { get; set; }
        public int UserID { get; set; }
        public int BookID { get; set; }


        //Insert 
        public bool Insert()
        {
            bool check = false;
            OracleCommand cmd = new OracleCommand("LBR_TBL_BORROWINGTRANSACTION_TAPI.ins", csGlobal.cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("P_QUANTITY", Quantity);
            cmd.Parameters.Add("P_USERID", UserID);
            cmd.Parameters.Add("P_BORROWTRANSID", BBRID);
            cmd.Parameters.Add("P_BOOKID", BookID);

            try
            {
                cmd.ExecuteNonQuery();
                check = true;
            }
            catch (Exception ex)
            {
                check = false;
                error = ex.Message;
            }

            return check;
        }
    }
}
