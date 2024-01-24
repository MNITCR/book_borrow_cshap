using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace book_borrow_cshap
{
    public static class Connection
    {
        public static void Conn()
        {
            csGlobal.cn.ConnectionString = "Data Source=orcl; User ID=MN; Password=1234;";

            try
            {
                csGlobal.cn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection fail!", ex.ToString());
            }
            finally
            {
                csGlobal.cn.Close();
            }
        }
    }
}
