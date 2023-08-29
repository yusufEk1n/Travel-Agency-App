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
    public partial class FormRezBus : Form
    {
        public FormRezBus(FormClient client)
        {
            InitializeComponent();
            this.client = client;

            client.Enabled = false;
        }

        FormClient client;
        bool panelExpand = false;
        string seatNo = "";

        private bool txtFill_Control()
        {
            TextBoxControl_Factory factory = new TextBoxControl_Factory();

            factory.textBoxAndLabelAdd(txtFrom, lblCheckFrom);
            factory.textBoxAndLabelAdd(txtTo, lblCheckTo);

            TextBoxControl textBoxControl = new TextBoxControl();
            textBoxControl.Controller = factory;

            return textBoxControl.Control();
        }

        private void timerExpand_Tick(object sender, EventArgs e)
        {
            timerExpand.Interval = 5;
            if (panelExpand)
            {
                panelSeat.Height -= 10;
                if (panelSeat.Height == panelSeat.MinimumSize.Height)
                {
                    panelExpand = false;
                    timerExpand.Stop();
                }
            }
            else
            {
                panelSeat.Height += 10;
                if (panelSeat.Height == panelSeat.MaximumSize.Height)
                {
                    panelExpand = true;
                    timerExpand.Stop();
                }
            }
        }

        private void btnSelectSeat_Click(object sender, EventArgs e)
        {
            timerExpand.Start();
        }

        private void btnSeat_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            btnFullSeat.Location = new Point(b.Location.X, b.Location.Y);
            btnFullSeat.BringToFront();
            seatNo = b.Name.Split('_')[1];
            MessageBox.Show(seatNo + " Numaralı koltuk seçildi.");
            lblCheckSeat.Text = "";
            btnSelectSeat.Enabled = false;
            timerExpand.Start();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (txtFill_Control())
            {
                lblCheckSeat.Text = "*";
                if (seatNo != "")
                {
                    lblCheckSeat.Text = "";
                    client.reservasionBus.Add("DeparturePoint", txtFrom.Text);
                    client.reservasionBus.Add("DestinationPoint", txtTo.Text);
                    client.reservasionBus.Add("TravelDate", dateTravel.Value.ToString());
                    client.reservasionBus.Add("SeatNo", seatNo);

                    MessageBox.Show("Rezervasyon alındı!");
                    client.Enabled = true;
                    client.reservasionCount++;
                    client.isRez(true, "Bus");

                    this.Close();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            client.Enabled = true;
            client.isRez(false, "Bus");
            this.Close();
        }

        # region txtKeyPress_Control
        private void txtFromTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
               char.IsDigit(e.KeyChar) ||
               char.IsSymbol(e.KeyChar) ||
               char.IsWhiteSpace(e.KeyChar) ||
               char.IsPunctuation(e.KeyChar)
               )
                e.Handled = true;
        }
        #endregion
    }
}
