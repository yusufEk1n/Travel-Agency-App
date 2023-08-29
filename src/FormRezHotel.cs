using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazılımMimarisiProjeV2
{
    public partial class FormRezHotel : Form
    {
        public FormRezHotel(FormClient client)
        {
            InitializeComponent();
            this.client = client;

            client.Enabled = false;
        }

        bool panelExpand = false;
        FormClient client;
        string roomNo = "";

        private void timerExpand_Tick(object sender, EventArgs e)
        {
            timerExpand.Interval = 5;
            if (panelExpand)
            {
                panelRoom.Height -= 10;
                lblCheckInDate.Location = new Point(lblCheckInDate.Location.X, lblCheckInDate.Location.Y - 8);
                dateCheckIn.Location = new Point(dateCheckIn.Location.X, dateCheckIn.Location.Y - 8);
                lblCheckOutDate.Location = new Point(lblCheckOutDate.Location.X, lblCheckOutDate.Location.Y - 8);
                dateCheckOut.Location = new Point(dateCheckOut.Location.X, dateCheckOut.Location.Y - 8);
                if (panelRoom.Height == panelRoom.MinimumSize.Height)
                {
                    panelExpand = false;
                    timerExpand.Stop();
                }
            }
            else
            {
                panelRoom.Height += 10;
                lblCheckInDate.Location = new Point(lblCheckInDate.Location.X, lblCheckInDate.Location.Y + 8);
                dateCheckIn.Location = new Point(dateCheckIn.Location.X, dateCheckIn.Location.Y + 8);
                lblCheckOutDate.Location = new Point(lblCheckOutDate.Location.X, lblCheckOutDate.Location.Y + 8);
                dateCheckOut.Location = new Point(dateCheckOut.Location.X, dateCheckOut.Location.Y + 8);
                if (panelRoom.Height == panelRoom.MaximumSize.Height)
                {
                    panelExpand = true;
                    timerExpand.Stop();
                }
            }
        }

        private void btnSelectRoom_Click(object sender, EventArgs e)
        {
            timerExpand.Start();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            btnFullRoom.Location = new Point(b.Location.X, b.Location.Y);
            btnFullRoom.BringToFront();
            roomNo = b.Name.Split('_')[1];
            MessageBox.Show(roomNo + " Numaralı oda seçildi.");
            lblCheckRoom.Text = "";
            btnSelectRoom.Enabled = false;
            timerExpand.Start();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (roomNo != "")
            {
                lblCheckRoom.Text = "";
                client.reservasionHotel.Add("CheckInDate", dateCheckIn.Value.ToString());
                client.reservasionHotel.Add("CheckOutDate", dateCheckOut.Value.ToString());
                client.reservasionHotel.Add("RoomNo", roomNo);

                MessageBox.Show("Rezervasyon alındı!");
                client.Enabled = true;
                client.reservasionCount++;
                client.isRez(true, "Hotel");

                this.Close();
            }
            else
            {
                lblCheckRoom.Text = "*";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            client.Enabled = true;
            client.isRez(false, "Hotel");
            this.Close();
        }
    }
}
