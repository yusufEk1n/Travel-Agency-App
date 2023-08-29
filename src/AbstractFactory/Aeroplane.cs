using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace YazılımMimarisiProjeV2.AbstractFactory
{
    public class Aeroplane : ITransportation
    {
        private string userID;
        public string UserID { get { return userID; } set { userID = value; } }
        public string FlightFrom { get; set; }
        public string FlightTo { get; set; }
        public string DepartureDate { get; set; }
        public string ReturnDate { get; set; }
        public string SeatNo { get; set; }
        public string RezNo { get; set; }

        //Gerçek uygulamamızda burada veritabanımızdaki
        //Bilgilere göre uçak ulaşımı oluşturulacaktır.
        public bool BuildTransportation()
        {
            //System.Windows.Forms.MessageBox.Show("Uçak ulaşımı oluşturuldu!");

            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=.\;Initial Catalog=dbTravel;Integrated Security=True");
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("Insert Into tbl_RezAeroplane " +
                                                       "(UserID, FlightFrom, FlightTo, DepartureDate, ReturnDate, SeatNo, RezNo)" +
                                                       "values " +
                                                       "(@UserID, @FlightFrom, @FlightTo, @DepartureDate, @ReturnDate, @SeatNo, @RezNo)", connection);
                sqlCommand.Parameters.AddWithValue("UserID", this.UserID);
                sqlCommand.Parameters.AddWithValue("FlightFrom", this.FlightFrom);
                sqlCommand.Parameters.AddWithValue("FlightTo", this.FlightTo);
                sqlCommand.Parameters.AddWithValue("DepartureDate", this.DepartureDate);
                sqlCommand.Parameters.AddWithValue("ReturnDate", this.ReturnDate);
                sqlCommand.Parameters.AddWithValue("SeatNo", this.SeatNo);
                sqlCommand.Parameters.AddWithValue("RezNo", this.RezNo);
                sqlCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public void RezFillTransportation(Dictionary<string, string> aeroplaneInfo)
        {
            this.UserID = aeroplaneInfo["UserID"];
            this.FlightFrom = aeroplaneInfo["FlightFrom"];
            this.FlightTo = aeroplaneInfo["FlightTo"];
            this.DepartureDate = aeroplaneInfo["DepartureDate"];
            this.ReturnDate = aeroplaneInfo["ReturnDate"];
            this.SeatNo = aeroplaneInfo["SeatNo"];
            this.RezNo = aeroplaneInfo["RezNo"];
        }
    }
}
