using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace YazılımMimarisiProjeV2.AbstractFactory
{
    public class Camp : IAccommodation
    {
        private string userID;
        public string UserID { get { return userID; } set { userID = value; } }
        public string PersonCount { get; set; }
        public string CheckInDate { get; set; }
        public string CheckOutDate { get; set; }
        public string CampType { get; set; }
        public string RezNo { get; set; }

        public bool BuildAccommodation()
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=.\;Initial Catalog=dbTravel;Integrated Security=True");
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("Insert Into tbl_RezCamp" +
                                                       "(UserID, PersonCount, CheckInDate, CheckOutDate, CampType, RezNo)" +
                                                       "values " +
                                                       "(@UserID, @PersonCount, @CheckInDate, @CheckOutDate, @CampType, @RezNo)", connection);
                sqlCommand.Parameters.AddWithValue("UserID", this.UserID);
                sqlCommand.Parameters.AddWithValue("PersonCount", this.PersonCount);
                sqlCommand.Parameters.AddWithValue("CheckInDate", this.CheckInDate);
                sqlCommand.Parameters.AddWithValue("CheckOutDate", this.CheckOutDate);
                sqlCommand.Parameters.AddWithValue("CampType", this.CampType);
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

        public void RezFillAccommodation(Dictionary<string, string> campInfo)
        {
            this.UserID = campInfo["UserID"];
            this.PersonCount = campInfo["PersonCount"];
            this.CheckInDate = campInfo["CheckInDate"];
            this.CheckOutDate = campInfo["CheckOutDate"];
            this.CampType = campInfo["CampType"];
            this.RezNo = campInfo["RezNo"];
        }
    }
}
