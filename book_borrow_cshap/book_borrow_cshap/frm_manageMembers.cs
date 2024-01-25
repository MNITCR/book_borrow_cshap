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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace book_borrow_cshap
{
    public partial class frm_manageMembers : Form
    {
        csUsers us = new csUsers();
     
        public frm_manageMembers()
        {
            InitializeComponent();
        }
        private void LoadMembers()
        {
            Connection.Conn();
            csGlobal.cn.Open();

            OracleCommand cmd = new OracleCommand(@"SELECT UserID, FirstName, MiddleName, Lastname, Address, PHONENUMBER, Email, isAdmin FROM LBR_TBL_USERS", csGlobal.cn);

            OracleDataReader rdr = cmd.ExecuteReader();
            dataMembers.Rows.Clear();
            while (rdr.Read())
            {
                string isAdmin = rdr["isAdmin"].ToString() == "1" ? "Yes" : "No";

                dataMembers.Rows.Add(
                    rdr["UserID"].ToString(),
                    rdr["FirstName"].ToString(),
                    rdr["MiddleName"].ToString(),
                    rdr["Lastname"].ToString(),
                    rdr["Address"].ToString(),
                    rdr["PHONENUMBER"].ToString(),
                    rdr["Email"].ToString(),
                    isAdmin
                );
            }


            csGlobal.cn.Close();

            EnableAddButton();
        }

        private void frm_manageMembers_Load(object sender, EventArgs e)
        {
            LoadMembers();
        }

        private void DisableAddButton()
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = true;
        }

        private void EnableAddButton()
        {
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
        }

        private void Reset()
        {
            /*dataMembers.Rows.Clear();*/
            txtPassword.Clear();
            txtUsername.Clear();
            txtAddress.Clear();
            txtContactNumber.Clear();
            txtEmail.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtMiddleName.Clear();
            txtUserID.Clear();
            checkbox_admin.Checked = false;
            EnableAddButton();
            LoadMembers();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private bool isTextBoxEmpty(TextBox input_text)
        {
            //checks if textbox is empty
            bool output;
            if (input_text.Text == "")
            {
                output = true;
            }
            else
            {
                output = false;
            }
            return output;
        }

        private bool checkTextBoxes()
        {
            bool output;
            output = isTextBoxEmpty(txtFirstName) || isTextBoxEmpty(txtLastName) ||
            isTextBoxEmpty(txtEmail) || isTextBoxEmpty(txtContactNumber) || isTextBoxEmpty(txtAddress);
            return output;
        }

        /*Add button*/
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //if admin

            if (checkbox_admin.Checked.Equals(true))
            {

                if (txtUsername.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("You have Missing Values", "Error");
                    return;
                }

                if (checkTextBoxes())
                {
                    MessageBox.Show("You have Missing Values!", "Error");
                    return;
                }

                Connection.Conn();
                csGlobal.cn.Open();

                us.MiddleName = txtMiddleName.Text;
                us.PhoneNumber = txtContactNumber.Text;
                us.Password = txtPassword.Text;
                us.LastName = txtLastName.Text;
                us.Address = txtAddress.Text;
                us.IsAdmin = "1";
                us.Username = txtUsername.Text;
                us.FirstName = txtFirstName.Text;
                us.Email = txtEmail.Text;



                if (us.Insert())
                {
                    MessageBox.Show("Insert success!");

                    // Clear input fields
                    txtMiddleName.Text = "";
                    txtFirstName.Text = "";
                    txtLastName.Text = "";
                    txtAddress.Text = "";
                    txtContactNumber.Text = "";
                    txtContactNumber.Text = "";
                    txtEmail.Text = "";
                    txtAddress.Text = "";
                }
                else
                {
                    MessageBox.Show(us.error);
                }

                csGlobal.cn.Close();
            }



            //if not admin
            if (checkbox_admin.Checked.Equals(false))
            {

                if (checkTextBoxes())
                {
                    MessageBox.Show("You have Missing Values!");
                    return;
                }

                Connection.Conn();
                csGlobal.cn.Open();

                us.MiddleName = txtMiddleName.Text;
                us.PhoneNumber = txtContactNumber.Text;
                us.Password = txtPassword.Text;
                us.LastName = txtLastName.Text;
                us.Address = txtAddress.Text;
                us.IsAdmin = "0";
                us.Username = txtUsername.Text;
                us.FirstName = txtFirstName.Text;
                us.Email = txtEmail.Text;


                if (us.Insert())
                {
                    MessageBox.Show("Insert success!");

                    // Clear input fields
                    txtMiddleName.Text = "";
                    txtFirstName.Text = "";
                    txtLastName.Text = "";
                    txtAddress.Text = "";
                    txtContactNumber.Text = "";
                    txtUserID.Text = "";
                    txtContactNumber.Text = "";
                    txtEmail.Text = "";
                    txtAddress.Text = "";
                }
                else
                {
                    MessageBox.Show(us.error);
                }

                csGlobal.cn.Close();
            }

            Reset();
        }

        /*edit button*/
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int admin;
            if (checkbox_admin.Checked == true)
            {
                admin = 1;
            }
            else
            {
                admin = 0;
            }

            Connection.Conn();
            csGlobal.cn.Open();

            us.MiddleName = txtMiddleName.Text;
            us.FirstName = txtFirstName.Text;
            us.LastName = txtLastName.Text;
            us.Username = txtUsername.Text;
            us.IsAdmin = admin.ToString();
            us.Password = txtPassword.Text;
            us.UserID = int.Parse(txtUserID.Text == "" ? "0" : txtUserID.Text);
            us.PhoneNumber = txtContactNumber.Text;
            us.Email = txtEmail.Text;
            us.Address = txtAddress.Text;

            if (us.Update())
            {
                MessageBox.Show("Update success!");
                csGlobal.cn.Close();
            }
            else
            {
                MessageBox.Show("Update fail!");
            }

            dataMembers.Rows.Clear();
            csGlobal.cn.Close();

            Reset();
        }

        private void dataMembers_SelectionChanged(object sender, EventArgs e)
        {
            
            if (dataMembers.SelectedRows.Count != 0)
            {
                txtUserID.Text = dataMembers.SelectedRows[0].Cells[0].Value.ToString();
                txtFirstName.Text = dataMembers.SelectedRows[0].Cells[1].Value.ToString();
                txtMiddleName.Text = dataMembers.SelectedRows[0].Cells[2].Value.ToString();
                txtLastName.Text = dataMembers.SelectedRows[0].Cells[3].Value.ToString();
                txtAddress.Text = dataMembers.SelectedRows[0].Cells[4].Value.ToString();
                txtContactNumber.Text = dataMembers.SelectedRows[0].Cells[5].Value.ToString();
                txtEmail.Text = dataMembers.SelectedRows[0].Cells[6].Value.ToString();

                if (dataMembers.SelectedRows[0].Cells[7].Value.ToString() == "Yes")
                {
                    checkbox_admin.Checked = true;
                }
                else
                {
                    checkbox_admin.Checked = false;
                }

                DisableAddButton();
            }

            
            if (checkbox_admin.Checked == true)
            {
                Connection.Conn();
                csGlobal.cn.Open();

                OracleCommand cmd = new OracleCommand(@"SELECT UserName, Password FROM LBR_TBL_USERS WHERE UserID = :UserID", csGlobal.cn);
                cmd.Parameters.Add("UserID", OracleDbType.Int32).Value = Convert.ToInt32(txtUserID.Text);

                OracleDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    txtUsername.Text = rdr[0].ToString();
                    txtPassword.Text = rdr[1].ToString();
                }

                csGlobal.cn.Close();

            }
        }




    }
}
