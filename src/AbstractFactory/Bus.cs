using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace YazılımMimarisiProjeV2.AbstractFactory
{
    public class Bus : ITransportation
    {
        private string userID;
        public string UserID { get { return userID; } set { userID = value; } }
        public string DeparturePoint { get; set; }
        public string DestinationPoint { get; set; }
        public string TravelDate { get; set; }
        public string SeatNo { get; set; }
        public string RezNo { get; set; }

        //Gerçek uygulamamızda burada veritabanımızdaki
        //Bilgilere göre otobüs ulaşımı oluşturulacaktır.
        public bool BuildTransportation()
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=.\;Initial Catalog=dbTravel;Integrated Security=True");
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("Insert Into tbl_RezBus" +
                                                       "(UserID, DeparturePoint, DestinationPoint, TravelDate, SeatNo, RezNo)" +
                                                       "values " +
                                                       "(@UserID, @DeparturePoint, @DestinationPoint, @TravelDate, @SeatNo, @RezNo)", connection);
                sqlCommand.Parameters.AddWithValue("UserID", this.UserID);
                sqlCommand.Parameters.AddWithValue("DeparturePoint", this.DeparturePoint);
                sqlCommand.Parameters.AddWithValue("DestinationPoint", this.DestinationPoint);
                sqlCommand.Parameters.AddWithValue("TravelDate", this.TravelDate);
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

        public void RezFillTransportation(Dictionary<string, string> busInfo)
        {
            this.UserID = busInfo["UserID"];
            this.DeparturePoint = busInfo["DeparturePoint"];
            this.DestinationPoint = busInfo["DestinationPoint"];
            this.TravelDate = busInfo["TravelDate"];
            this.SeatNo = busInfo["SeatNo"];
            this.RezNo = busInfo["RezNo"];
        }
    }
}
