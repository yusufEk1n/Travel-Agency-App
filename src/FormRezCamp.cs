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

namespace YazılımMimarisiProjeV2
{
    public partial class FormRezCamp : Form
    {
        public FormRezCamp(FormClient client)
        {
            InitializeComponent();
            this.client = client;

            client.Enabled = false;
        }

        FormClient client;
        string campType = "";

        private bool txtFill_Control()
        {
            TextBoxControl_Factory factory = new TextBoxControl_Factory();

            factory.textBoxAndLabelAdd(txtPersonCount, lblCheckPersonCount);
            
            TextBoxControl textBoxControl = new TextBoxControl();
            textBoxControl.Controller = factory;

            return textBoxControl.Control();
        }

        private void lblTentCamp_Click(object sender, EventArgs e)
        {
            picTrueTentCamp.Visible = true;
            picTrueFixCamp.Visible = false;
            lblCheckCampType.Text = "";
            campType = lblTentCamp.Text;
        }

        private void lblFixCamp_Click(object sender, EventArgs e)
        {
            picTrueTentCamp.Visible = false;
            picTrueFixCamp.Visible = true;
            lblCheckCampType.Text = "";
            campType = lblFixCamp.Text;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (txtFill_Control())
            {
                lblCheckCampType.Text = "*";
                if (campType != "")
                {
                    lblCheckCampType.Text = "";
                    client.reservasionCamp.Add("PersonCount", txtPersonCount.Text);
                    client.reservasionCamp.Add("CheckInDate", dateCheckIn.Value.ToString());
                    client.reservasionCamp.Add("CheckOutDate", dateCheckOut.Value.ToString());
                    client.reservasionCamp.Add("CampType", campType);

                    MessageBox.Show("Rezervasyon alındı!");
                    client.Enabled = true;
                    client.reservasionCount++;
                    client.isRez(true, "Camp");

                    this.Close();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            client.Enabled = true;
            client.isRez(false, "Camp");
            this.Close();
        }

        #region lblMouseMoveLeave_Control

        private void lblTentCamp_MouseMove(object sender, MouseEventArgs e)
        {
            lblStickTent.Visible = true;
            lblTentCamp.BackColor = Color.Azure;
        }

        private void lblTentCamp_MouseLeave(object sender, EventArgs e)
        {
            lblStickTent.Visible = false;
            lblTentCamp.BackColor = Color.LightCyan;
        }

        private void lblFixCamp_MouseMove(object sender, MouseEventArgs e)
        {
            lblStickFix.Visible = true;
            lblFixCamp.BackColor = Color.Azure;
        }

        private void lblFixCamp_MouseLeave(object sender, EventArgs e)
        {
            lblStickFix.Visible = false;
            lblFixCamp.BackColor = Color.LightCyan;
        }

        #endregion

        private void txtPersonCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
               char.IsLetter(e.KeyChar) ||
               char.IsSymbol(e.KeyChar) ||
               char.IsWhiteSpace(e.KeyChar) ||
               char.IsPunctuation(e.KeyChar)
               )
                e.Handled = true;
        }
    }
}
