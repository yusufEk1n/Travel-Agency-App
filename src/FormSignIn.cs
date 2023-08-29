using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YazılımMimarisiProjeV2.TextBox_Control;
using YazılımMimarisiProjeV2.SqlManager;

namespace YazılımMimarisiProjeV2
{
    public partial class FormSignIn : Form
    {
        public FormSignIn()
        {
            InitializeComponent();
        }

        public int userId = 0;

        private bool txtFill_Control()
        {
            TextBoxControl_Factory factory = new TextBoxControl_Factory();

            factory.textBoxAndLabelAdd(txtUserName, lblCheckUserName);
            factory.textBoxAndLabelAdd(txtPassword, lblCheckPassword);

            TextBoxControl textBoxControl = new TextBoxControl();
            textBoxControl.Controller = factory;

            return textBoxControl.Control();
        }

        private bool User_Control()
        {
            Sql sql = new Sql
            {
                cmdStr = "Select * From tbl_Users Where UserName = '" + txtUserName.Text + "' and " +
                         "Password = '" + txtPassword.Text + "'"
            };

            if(!new SqlOperations(sql).Cells_Control())
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
                return false;
            }
            return true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (txtFill_Control() && User_Control())
            {

                Sql sql = new Sql
                {
                    cmdStr = "Select * From tbl_Users Where UserName = '" + txtUserName.Text + "'"
                };

                userId = Convert.ToInt32(new SqlOperations(sql).DataExtraction("UserID"));

                FormClient formClient = new FormClient(txtUserName.Text, userId);
                formClient.Show();
                this.Hide();
            }
            else
                txtUserName.Focus();
        }

        #region buttonMouseMoveLeave_Control
        private void btnNext2_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            btnNext.BringToFront();

        }

        private void btnNext_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void btnNext_MouseLeave(object sender, EventArgs e)
        {
            btnNext2.BringToFront();
        }

        private void btnBack_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormSignInUp formSignInUp = new FormSignInUp();
            formSignInUp.Show();
            this.Hide();
        }
        #endregion

        #region KeyPress_Control

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
               char.IsSymbol(e.KeyChar) ||
               char.IsPunctuation(e.KeyChar)
               )
                e.Handled = true;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
               char.IsLetter(e.KeyChar) ||
               char.IsSymbol(e.KeyChar) ||
               char.IsWhiteSpace(e.KeyChar) ||
               char.IsPunctuation(e.KeyChar)
               )
                e.Handled = true;
        }

        #endregion
    }
}
