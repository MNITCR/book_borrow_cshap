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
    public partial class frm_listOfBooks : Form
    {
        public frm_listOfBooks()
        {
            InitializeComponent();
        }
        

        private void LoadBooks()
        {
            Connection.Conn();
            csGlobal.cn.Open();
            OracleCommand cmd = new OracleCommand(@"SELECT ISBN, Title, Author, Abstract, Category FROM LBR_TBL_Books", csGlobal.cn);
            OracleDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dataListOfBooks.Rows.Add(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(),
                    rdr[3].ToString(), rdr[4].ToString());
            }
            csGlobal.cn.Close();
        }

        private void frm_listOfBooks_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }
    }
}
