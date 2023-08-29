using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace YazılımMimarisiProjeV2.SqlManager
{
    public class SqlOperations
    {
        private Sql sql;
        public bool Cells_Control()
        {
            SqlConnection connection = new SqlConnection(sql.conStr);
            connection.Open();
            SqlCommand command = new SqlCommand(sql.cmdStr, connection);
            SqlDataReader dr = command.ExecuteReader();
            return dr.Read() ? true : false;
        }

        public bool AddToDatabase(List<string> texts)
        {
            List<string> values = new List<string>();

            int i = 1;
            while (true)
            {
                string value = "";
                foreach (char item in sql.cmdStr.Split('@')[i])
                {
                    if (item != ',' && item != ')')
                        value += item;
                    else
                        break;
                }
                values.Add(value);
                i++;

                if (values.Count == texts.Count) break;
            }

            SqlConnection connection = new SqlConnection(sql.conStr);
            connection.Open();
            SqlCommand command = new SqlCommand(sql.cmdStr, connection);

            try
            {
                for (int j = 0; j < texts.Count; j++)
                {
                    command.Parameters.AddWithValue(values[j], texts[j]);
                }
                command.ExecuteNonQuery();
                connection.Close();
                System.Windows.Forms.MessageBox.Show("Kayıt başarıyla oluşturuldu");
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Hata : " + ex.Message);
                return false;
            }
        }

        public string DataExtraction(string columnData)
        {
            SqlConnection connection = new SqlConnection(sql.conStr);
            connection.Open();
            SqlCommand command = new SqlCommand(sql.cmdStr, connection);
            SqlDataReader dr = command.ExecuteReader();
            return dr.Read() ? Convert.ToString(dr[columnData]) : "İstenilen veri cekilemedi";
        }

        public SqlOperations(Sql sql)
        {
            this.sql = sql;
        }
    }
}
