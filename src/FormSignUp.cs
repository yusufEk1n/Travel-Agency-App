using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;
using YazılımMimarisiProjeV2.TextBox_Control;
using YazılımMimarisiProjeV2.SqlManager;

namespace YazılımMimarisiProjeV2
{
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }

        private bool txtFill_Control()
        {
            TextBoxControl_Factory factory = new TextBoxControl_Factory();

            factory.textBoxAndLabelAdd(txtUserName, lblCheckUserName);
            factory.textBoxAndLabelAdd(txtEposta, lblCheckEPosta);
            factory.textBoxAndLabelAdd(txtPassword, lblCheckPassword);
            factory.textBoxAndLabelAdd(txtPasswordConfrim, lblCheckPasswordConfrim);

            TextBoxControl textBoxControl = new TextBoxControl();
            textBoxControl.Controller = factory;

            return textBoxControl.Control();
        }
        private bool Email_Format_Control(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch
            {
                MessageBox.Show("Lütfen doğru bir eposta yazdığınızdan emin olun!");
                return false;
            }
        }
        private bool PasswordControl()
        {
            if (txtPassword.Text == txtPasswordConfrim.Text)
                return true;
            else
            {
                MessageBox.Show("Şifreler eşleşmiyor!");
                return false;
            }
        }
        private string RandomGenerateUserName()
        {
            Random r = new Random();
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "t", "v", "w", "x", "y" };
            string[] vowels = { "a", "e", "i", "o", "u" };
            string Name = "";
            Name += vowels[r.Next(vowels.Length)];
            Name += consonants[r.Next(consonants.Length)];
            Name += numbers[r.Next(numbers.Length)];

            return Name;
        }
        private void TrueFalseVisible(object picIconFalse, object picIconTrue, object btn)
        {
            picTrueIcon.Visible = Convert.ToBoolean(picIconTrue);
            picFalseIcon.Visible = Convert.ToBoolean(picIconFalse);
            btnGenerateUserName.Visible = Convert.ToBoolean(btn);

        }
        private bool UserName_Control(string username)
        {
            Sql sql = new Sql { cmdStr = "Select * From tbl_Users Where UserName = '" + username + "'" };
            return new SqlOperations(sql).Cells_Control();
        }

        private bool AddToDatabase()
        {
            List<string> texts = new List<string>(){ txtUserName.Text, txtEposta.Text, txtPassword.Text };
            Sql sql = new Sql
            {
                cmdStr = "Insert Into tbl_Users " +
                         "(UserName, Email, Password)" +
                         "values " +
                         "(@UserName, @Email, @Password)"
            };
            return new SqlOperations(sql).AddToDatabase(texts);
        }

        private void btnGenerateUserName_Click(object sender, EventArgs e)
        {
            txtUserName.Text = txtEposta.Text.Split('@')[0] + RandomGenerateUserName();

            if (UserName_Control(txtUserName.Text))
                TrueFalseVisible(true, false, true);
            else
                TrueFalseVisible(false, true, true);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (txtFill_Control() && Email_Format_Control(txtEposta.Text) && PasswordControl())
            {
                if (UserName_Control(txtUserName.Text) || !AddToDatabase())
                    TrueFalseVisible(true, false, true);
                else
                {
                    FormSignIn formSignIn = new FormSignIn();
                    formSignIn.Show();
                    this.Hide();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormSignInUp formSignInUp = new FormSignInUp();
            formSignInUp.Show();
            this.Hide();
        }

        #region buttonMouseMoveLeave_Control

        private void btnNext2_MouseMove(object sender, MouseEventArgs e)
        {
            btnNext.BringToFront();
        }

        private void btnNext_MouseLeave(object sender, EventArgs e)
        {
            btnNext2.BringToFront();
        }

        private void btnBack2_MouseMove(object sender, MouseEventArgs e)
        {
            btnBack.BringToFront();
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack2.BringToFront();
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

        private void txtPasswordConfrim_KeyPress(object sender, KeyPressEventArgs e)
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

        #region ButtonPasswordShow

        private void btnShowPassword_MouseMove(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnShowPassword_MouseLeave(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void btnShowPasswordConfrim_MouseMove(object sender, MouseEventArgs e)
        {
            txtPasswordConfrim.UseSystemPasswordChar = true;
        }

        private void btnShowPasswordConfrim_MouseLeave(object sender, EventArgs e)
        {
            txtPasswordConfrim.UseSystemPasswordChar = false;
        }

        #endregion
        
    }
}
