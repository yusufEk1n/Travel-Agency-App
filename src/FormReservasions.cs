using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YazılımMimarisiProjeV2.FormReservasionsFolder;

namespace YazılımMimarisiProjeV2
{
    public partial class FormReservasions : Form
    {
        public FormReservasions(FormClient client ,int userid)
        {
            InitializeComponent();
            
            userId = userid;
            client.Enabled = false;
            this.Client = client;
        }
        int userId;
        FormClient Client;

        private void btnAeroplanes_Click(object sender, EventArgs e)
        {
            AeroplaneReservasions aeroplaneReservasions = new AeroplaneReservasions(this, userId);
            aeroplaneReservasions.Show();
        }

        private void btnBus_Click(object sender, EventArgs e)
        {
            BusReservasions busReservasions = new BusReservasions(this, userId);
            busReservasions.Show();
        }

        private void btnCamps_Click(object sender, EventArgs e)
        {
            CampReservasions campReservasions = new CampReservasions(this, userId);
            campReservasions.Show();
        }

        private void btnHotels_Click(object sender, EventArgs e)
        {
            HotelReservasions hotelReservasions = new HotelReservasions(this, userId);
            hotelReservasions.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Client.Enabled = true;
            this.Close();
        }
    }
}
