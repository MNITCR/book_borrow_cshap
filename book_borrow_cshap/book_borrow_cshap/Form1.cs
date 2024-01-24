using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace book_borrow_cshap
{
    public partial class frm_login : Form
    {
        public static string SetValueForUserID;
        public static string SetValueForUserName;

        public frm_login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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

        /* Login button */
        private void btn_login_Click(object sender, EventArgs e)
        {
            /* Check if any input is null */
            if (string.IsNullOrWhiteSpace(txt_Password.Text) || string.IsNullOrWhiteSpace(txt_Username.Text))
            {
                MessageBox.Show("Invalid Input!", "Error");
                return;
            }

            /* if all input is not null */
            else
            {
                if (UserExists(txt_Username.Text, txt_Password.Text))
                {

                    string isAdmin = "";

                    try
                    {
                        csGlobal.cn.Open();  // Open the connection here

                        OracleCommand cmd = new OracleCommand(@"SELECT CASE WHEN EXISTS 
                                                            (
                                                                SELECT * FROM LBR_TBL_USERS
                                                                WHERE USERNAME = :username AND PASSWORD = :password AND IsAdmin = 1
                                                            ) THEN 1 ELSE 0 END AS result
                                                        FROM dual");

                        cmd.Connection = csGlobal.cn;  // Assign the connection here
                        cmd.Parameters.Add(":username", txt_Username.Text);
                        cmd.Parameters.Add(":password", txt_Password.Text);

                        isAdmin = cmd.ExecuteScalar().ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error checking admin status: " + ex.Message);
                    }
                    finally
                    {
                        csGlobal.cn.Close();  // Close the connection here
                    }

                    /*if user is admin*/
                    if (isAdmin == "1")
                    {
                        frm_adminmenu form = new frm_adminmenu();
                        this.Visible = false;
                        form.Show();
                        return;
                    }

                    /*if user is not admin*/
                    else
                    {
                        frm_studentmenu form = new frm_studentmenu();

                        csGlobal.cn.Open();

                        OracleCommand cmdUser = new OracleCommand(@"SELECT userid, firstname, middlename, lastname AS FullName FROM LBR_TBL_USERS WHERE username = :username");
                        cmdUser.Connection = csGlobal.cn;
                        cmdUser.Parameters.Add("username", OracleDbType.Varchar2).Value = txt_Username.Text;

                        try
                        {
                            OracleDataReader rdr = cmdUser.ExecuteReader();

                            while (rdr.Read())
                            {
                                if (!rdr.IsDBNull(0))
                                {
                                    SetValueForUserID = rdr["userid"].ToString();
                                    SetValueForUserName = rdr["FullName"].ToString();

                                }

                                this.Visible = false;
                                form.Show();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error retrieving user information: " + ex.Message);
                        }
                        finally
                        {
                            csGlobal.cn.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Credentials", "Error");
                    txt_Username.Clear();
                    txt_Password.Clear();
                }
            }
        }

        private bool UserExists(string username, string password)
        {
            try
            {
                using (OracleCommand cmd = new OracleCommand("SELECT COUNT(*) FROM LBR_TBL_USERS WHERE \"USERNAME\" = :username AND \"PASSWORD\" = :password AND ROWNUM = 1"))
                {
                    csGlobal.cn.Open();

                    cmd.Connection = csGlobal.cn;
                    cmd.Parameters.Add(":username", OracleDbType.Varchar2).Value = username.Trim();
                    cmd.Parameters.Add(":password", OracleDbType.Varchar2).Value = password.Trim();

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Error checking user existence: " + ex.Message);
                return false;
            }
            finally
            {
                csGlobal.cn.Close();
            }
        }


        /* Register button */
        private void btn_Register_Click(object sender, EventArgs e)
        {
            frm_studentregistration studregform = new frm_studentregistration();
            studregform.Show();
        }
    }
}
