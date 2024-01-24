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
    public partial class frm_studentmenu : Form
    {
        public frm_studentmenu()
        {
            InitializeComponent();
        }


        /* Form Return Book*/
        private void returnedBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_studentreturnedbooks form = new frm_studentreturnedbooks();
            form.Show();
        }

        /* Form logout*/
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frm_login login = new frm_login();
            login.Show();
        }

        /* Form Load */
        private void frm_studentmenu_Load(object sender, EventArgs e)
        {
            lbl_studentID.Text = frm_login.SetValueForUserID;
            lbl_studentID.Text = frm_login.SetValueForUserID;
            btn_StudentName.Text = frm_login.SetValueForUserName;
        }

        /* Form List Book*/
        private void listOfBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_listOfBooks form = new frm_listOfBooks();
            form.Show();
        }

        /* Form Brrow Book*/
        private void borrowedBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_studentborrowedbook form = new frm_studentborrowedbook();
            form.Show();
        }
    }
}
