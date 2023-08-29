using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace YazılımMimarisiProjeV2.AbstractFactory
{
    public class Hotel : IAccommodation
    {
        private string userID;
        public string UserID { get { return userID; } set { userID = value; } }
        public string CheckInDate { get; set; }
        public string CheckOutDate { get; set; }
        public string RoomNo { get; set; }
        public string RezNo { get; set; }
        //Gerçek uygulamamızda burada veritabanımızdaki
        //Bilgilere göre Otel konaklaması oluşturulacaktır.
        public bool BuildAccommodation()
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=.\;Initial Catalog=dbTravel;Integrated Security=True");
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("Insert Into tbl_RezHotel" +
                                                       "(UserID, CheckInDate, CheckOutDate, RoomNo, RezNo)" +
                                                       "values " +
                                                       "(@UserID, @CheckInDate, @CheckOutDate, @RoomNo, @RezNo)", connection);
                sqlCommand.Parameters.AddWithValue("UserID", this.UserID);
                sqlCommand.Parameters.AddWithValue("CheckInDate", this.CheckInDate);
                sqlCommand.Parameters.AddWithValue("CheckOutDate", this.CheckOutDate);
                sqlCommand.Parameters.AddWithValue("RoomNo", this.RoomNo);
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

        public void RezFillAccommodation(Dictionary<string, string> hotelInfo)
        {
            this.UserID = hotelInfo["UserID"];
            this.CheckInDate = hotelInfo["CheckInDate"];
            this.CheckOutDate = hotelInfo["CheckOutDate"];
            this.RoomNo = hotelInfo["RoomNo"];
            this.RezNo = hotelInfo["RezNo"];
        }
    }
}
