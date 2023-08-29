using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YazılımMimarisiProjeV2.AbstractFactory;

namespace YazılımMimarisiProjeV2
{
    public partial class FormSignInUp : Form
    {
        public FormSignInUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            FormSignUp formSignInUp = new FormSignUp();
            formSignInUp.Show();
            this.Hide();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            FormSignIn formSignIn = new FormSignIn();
            formSignIn.Show();
            this.Hide();
        }

        private void FormSignInUp_Load(object sender, EventArgs e)
        {
            //Travel generator_Bus_Hotel_Rez = new Travel(new Generate_Hotel_Bus());
            //generator_Bus_Hotel_Rez.BuildTravel();

            
            //Generate_Hotel_Bus generete_Bus_Rez = new Generate_Hotel_Bus();
            //generete_Bus_Rez.CreateTransportation().BuildTransportation();

        }
    }
}
