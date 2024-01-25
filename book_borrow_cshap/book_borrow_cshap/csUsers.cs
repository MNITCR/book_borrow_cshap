using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace book_borrow_cshap
{
    public class csUsers
    {
        //Property
        public string error;
        public int UserID { get; set; }
        public string MiddleName { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string IsAdmin { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }


        //GetData
        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            OracleDataAdapter da = new OracleDataAdapter("Select * From LBR_TBL_USERS", csGlobal.cn);

            try
            {
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                dt = null;
                error = ex.Message;
            }
            return dt;
        }


        //Insert 
        public bool Insert()
        {
            bool check = false;
            OracleCommand cmd = new OracleCommand("LBR_TBL_USERS_TAPI.ins", csGlobal.cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("p_MIDDLENAME", MiddleName);
            cmd.Parameters.Add("p_PHONENUMBER", PhoneNumber);
            cmd.Parameters.Add("p_PASSWORD", Password);
            cmd.Parameters.Add("p_LASTNAME", LastName);
            cmd.Parameters.Add("p_ADDRESS", Address);
            cmd.Parameters.Add("UserID", UserID);
            cmd.Parameters.Add("p_ISADMIN", IsAdmin);
            cmd.Parameters.Add("p_USERNAME", Username);
            cmd.Parameters.Add("p_FIRSTNAME", FirstName);
            cmd.Parameters.Add("p_EMAIL", Email);



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


        /*update*/
        public bool Update()
        {
            bool check = false;
            OracleCommand cmd = new OracleCommand("LBR_TBL_USERS_tapi.upd", csGlobal.cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("p_MIDDLENAME", MiddleName);
            cmd.Parameters.Add("p_PHONENUMBER", PhoneNumber);
            cmd.Parameters.Add("p_PASSWORD", Password);
            cmd.Parameters.Add("p_LASTNAME", LastName);
            cmd.Parameters.Add("p_ADDRESS", Address);
            cmd.Parameters.Add("p_USERID", UserID);
            cmd.Parameters.Add("p_ISADMIN", IsAdmin);
            cmd.Parameters.Add("p_USERNAME", Username);
            cmd.Parameters.Add("p_FIRSTNAME", FirstName);
            cmd.Parameters.Add("p_EMAIL", Email);

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


        /*Delete*/
        public bool Delete()
        {
            bool check = false;
            OracleCommand cmd = new OracleCommand("LBR_TBL_USERS_tapi.del", csGlobal.cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("p_STAFFID", UserID);

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
