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
using YazılımMimarisiProjeV2.Builder;

namespace YazılımMimarisiProjeV2
{
    public partial class FormClient : Form
    {
        public FormClient(string username, int userid)
        {
            InitializeComponent();
            lblUserName.Text = username;
            label1.Width = lblUserName.Width;
            userId = userid;
        }

        public int userId = 0;
        public string randRezNo = "";
        public int reservasionCount = 0;
        public string rezTransportation = "", rezAccommodation = "";
        public Dictionary<string, string> reservasionAir = new Dictionary<string, string>();
        public Dictionary<string, string> reservasionHotel = new Dictionary<string, string>();
        public Dictionary<string, string> reservasionBus = new Dictionary<string, string>();
        public Dictionary<string, string> reservasionCamp = new Dictionary<string, string>();
        
        private void TakeRez(Form form)
        {
            form.Show();
        }

        private void Clear()
        {
            btnAccept.Enabled = false;
            panelAeroplane.Enabled = true;
            panelBus.Enabled = true;
            panelCamp.Enabled = true;
            panelHotel.Enabled = true;
            picTrueIcon1.Visible = false;
            picTrueIcon2.Visible = false;
            picTrueIcon3.Visible = false;
            picTrueIcon4.Visible = false;
        }

        private void RandomRezNo()
        {
            Random r = new Random();
            const string alphanum = "0123ABCD4EFGHIJK567LMNOP9QRSTU8VWXYZ";
            string rezNo = "";

            for (int i = 0; i < 8; i++)
            {
                rezNo += alphanum[r.Next(alphanum.Length)];
            }

            randRezNo = rezNo;
        }

        private void isRezOperation(string rezType, bool picBool, bool panelBool)
        {
            switch (rezType)
            {
                case "Aeroplane":
                    picTrueIcon1.Visible = picBool;
                    panelAeroplane.Enabled = panelBool;
                    panelBus.Enabled = panelBool;
                    break;
                case "Bus":
                    picTrueIcon2.Visible = picBool;
                    panelBus.Enabled = panelBool;
                    panelAeroplane.Enabled = panelBool;
                    break;
                case "Camp":
                    picTrueIcon3.Visible = picBool;
                    panelCamp.Enabled = panelBool;
                    panelHotel.Enabled = panelBool;
                    break;
                case "Hotel":
                    picTrueIcon4.Visible = picBool;
                    panelHotel.Enabled = panelBool;
                    panelCamp.Enabled = panelBool;
                    break;
                default:
                    break;
            }
        }

        public void isRez(bool isRez, string rezType)
        {
            if (reservasionCount == 2) btnAccept.Enabled = true;

            if (isRez)
            {
                isRezOperation(rezType, true, false);
                if (rezType == "Aeroplane" || rezType == "Bus")
                    rezTransportation = rezType;
                else
                    rezAccommodation = rezType;
            }
            else
            {
                isRezOperation(rezType, false, true);

            }

        }

        private void btnAeroplane_Click(object sender, EventArgs e)
        {
            panelBus.Enabled = false;
            FormRezAeroplane formRezAeroplane = new FormRezAeroplane(this);
            TakeRez(formRezAeroplane);
        }

        private void btnBus_Click(object sender, EventArgs e)
        {
            panelAeroplane.Enabled = false;
            FormRezBus formRezBus = new FormRezBus(this);
            TakeRez(formRezBus);
        }

        private void btnCamp_Click(object sender, EventArgs e)
        {
            panelHotel.Enabled = false;
            FormRezCamp formRezCamp = new FormRezCamp(this);
            TakeRez(formRezCamp);
        }

        private void btnHotel_Click(object sender, EventArgs e)
        {
            panelCamp.Enabled = false;
            FormRezHotel formRezHotel = new FormRezHotel(this);
            TakeRez(formRezHotel);
        }

        private void Rez_Aeroplane_Camp()
        {
            RandomRezNo();
            reservasionAir.Add("RezNo", randRezNo);
            reservasionAir.Add("UserID", userId.ToString());
            reservasionCamp.Add("RezNo", randRezNo);
            reservasionCamp.Add("UserID", userId.ToString());

            Travel generator_Airplane_Camp_Rez = new Travel(new Generate_Aeroplane_Camp());
            generator_Airplane_Camp_Rez.RezFill(reservasionAir, reservasionCamp);
            generator_Airplane_Camp_Rez.BuildTravel();
            MessageBox.Show("Rezervasyon numarası : " + randRezNo);
            Clear();
        }

        private void Rez_Aeroplane_Hotel()
        {
            RandomRezNo();
            reservasionAir.Add("RezNo", randRezNo);
            reservasionAir.Add("UserID", userId.ToString());
            reservasionHotel.Add("RezNo", randRezNo);
            reservasionHotel.Add("UserID", userId.ToString());

            Travel generator_Airplane_Hotel_Rez = new Travel(new Generate_Aeroplane_Hotel());
            generator_Airplane_Hotel_Rez.RezFill(reservasionAir, reservasionHotel);
            generator_Airplane_Hotel_Rez.BuildTravel();
            MessageBox.Show("Rezervasyon numarası : " + randRezNo);
            Clear();
        }

        private void Rez_Bus_Camp()
        {
            RandomRezNo();
            reservasionBus.Add("RezNo", randRezNo);
            reservasionBus.Add("UserID", userId.ToString());
            reservasionCamp.Add("RezNo", randRezNo);
            reservasionCamp.Add("UserID", userId.ToString());

            Travel generator_Bus_Camp_Rez = new Travel(new Generate_Bus_Camp());
            generator_Bus_Camp_Rez.RezFill(reservasionBus, reservasionCamp);
            generator_Bus_Camp_Rez.BuildTravel();
            MessageBox.Show("Rezervasyon numarası : " + randRezNo);
            Clear();
        }

        private void Rez_Bus_Hotel()    
        {
            RandomRezNo();
            reservasionBus.Add("RezNo", randRezNo);
            reservasionBus.Add("UserID", userId.ToString());
            reservasionHotel.Add("RezNo", randRezNo);
            reservasionHotel.Add("UserID", userId.ToString());

            Travel generator_Bus_Hotel_Rez = new Travel(new Generate_Hotel_Bus());
            generator_Bus_Hotel_Rez.RezFill(reservasionBus, reservasionHotel);
            generator_Bus_Hotel_Rez.BuildTravel();
            MessageBox.Show("Rezervasyon numarası : " + randRezNo);
            Clear();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (rezTransportation == "Aeroplane" && rezAccommodation == "Camp")
                Rez_Aeroplane_Camp();
            else if (rezTransportation == "Aeroplane" && rezAccommodation == "Hotel")
                Rez_Aeroplane_Hotel();
            else if (rezTransportation == "Bus" && rezAccommodation == "Camp")
                Rez_Bus_Camp();
            else
                Rez_Bus_Hotel();
        }

        #region PanelMouseMoveLeave_Control
        private void panelAeroplane_MouseMove(object sender, MouseEventArgs e)
        {
            panelAeroplane.BackColor = Color.FromArgb(131, 247, 255);
        }

        private void panelAeroplane_MouseLeave(object sender, EventArgs e)
        {
            panelAeroplane.BackColor = Color.FromArgb(123, 237, 255);
        }

        private void panelBus_MouseMove(object sender, MouseEventArgs e)
        {
            panelBus.BackColor = Color.FromArgb(131, 247, 255);
        }

        private void panelBus_MouseLeave(object sender, EventArgs e)
        {
            panelBus.BackColor = Color.FromArgb(123, 237, 255);
        }

        private void panelCamp_MouseMove(object sender, MouseEventArgs e)
        {
            panelCamp.BackColor = Color.FromArgb(131, 247, 255);
        }

        private void panelCamp_MouseLeave(object sender, EventArgs e)
        {
            panelCamp.BackColor = Color.FromArgb(123, 237, 255);
        }

        private void panelHotel_MouseMove(object sender, MouseEventArgs e)
        {
            panelHotel.BackColor = Color.FromArgb(131, 247, 255);
        }

        private void panelHotel_MouseLeave(object sender, EventArgs e)
        {
            panelHotel.BackColor = Color.FromArgb(123, 237, 255);
        }
        #endregion

        private void btnLeave_Click(object sender, EventArgs e)
        {
            FormSignInUp formSignInUp = new FormSignInUp();
            formSignInUp.Show();
            this.Hide();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            FormReservasions formReservasions = new FormReservasions(this, userId);
            formReservasions.Show();
        }
    }
}
