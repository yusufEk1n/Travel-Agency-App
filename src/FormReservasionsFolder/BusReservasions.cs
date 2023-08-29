﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using YazılımMimarisiProjeV2.Builder;

namespace YazılımMimarisiProjeV2.FormReservasionsFolder
{
    public partial class BusReservasions : Form
    {
        public BusReservasions(FormReservasions reservasions, int userid)
        {
            InitializeComponent();
            this.reservasions = reservasions;
            reservasions.Enabled = false;
            userId = userid;
        }
        private FormReservasions reservasions;
        int userId;
        private void RezLoad()
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\;Initial Catalog=dbTravel;Integrated Security=True"); ;

            dgvReservasions.Columns.Clear();
            SqlCommand cmd = new SqlCommand("select * from tbl_RezBus Where UserID = " + userId, con);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            dgvReservasions.DataSource = ds.Tables[0];
            dgvReservasions.AllowUserToAddRows = false;
            con.Close();
        }

        private void BusReservasions_Load(object sender, EventArgs e)
        {
            RezLoad();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            reservasions.Enabled = true;
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int deleteId = Convert.ToInt32(dgvReservasions.SelectedRows[0].Cells[0].Value);
                int fieldCount = dgvReservasions.SelectedCells.Count;
                string rezNo = dgvReservasions.SelectedRows[0].Cells[fieldCount - 1].Value.ToString();

                if (MessageBox.Show("Diğer rezervasyon da silinsin mi ? ", "Kayıt Silme", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Delete(rezNo);
                    OtherRezDelete(rezNo);
                    MessageBox.Show("İşlem Başarıyla gerçekleşti.");
                }
                else
                {
                    Delete(rezNo);
                }
            }
            catch
            {
                MessageBox.Show("Bir satır seçiniz!");
            }

            RezLoad();
            dgvReservasions.ClearSelection();
            dgvReservasions.Refresh();
        }

        private void OtherRezDelete(string rezNo)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\;Initial Catalog=dbTravel;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from tbl_RezCamp Where RezNo = '" + rezNo + "'; " +
                                            "Delete from tbl_RezHotel Where RezNo = '" + rezNo + "' ", con);
            cmd.ExecuteNonQuery();
        }

        private void Delete(string rezNo)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=.\;Initial Catalog=dbTravel;Integrated Security=True");
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("Delete tbl_RezBus Where RezNo = '" + rezNo + "'", connection);
            sqlCommand.ExecuteNonQuery();
        }

        private string Report(string reportType)
        {
            string email = "", userName = "", busId, departurePoint, destinationPoint,
                   travelDate, seatNo, rezNo;

            try
            {
                SqlConnection sqlConnection = new SqlConnection(@"Data Source=.\;Initial Catalog=dbTravel;Integrated Security=True");
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("Select * From tbl_Users Where UserID = '" + userId + "'", sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    email = Convert.ToString(dr["Email"]);
                    userName = Convert.ToString(dr["UserName"]) + "\n";
                }

                busId = Convert.ToString(dgvReservasions.SelectedRows[0].Cells[0].Value);
                departurePoint = Convert.ToString(dgvReservasions.SelectedRows[0].Cells[2].Value);
                destinationPoint = Convert.ToString(dgvReservasions.SelectedRows[0].Cells[3].Value);
                travelDate = Convert.ToString(dgvReservasions.SelectedRows[0].Cells[4].Value);
                seatNo = Convert.ToString(dgvReservasions.SelectedRows[0].Cells[5].Value);
                rezNo = Convert.ToString(dgvReservasions.SelectedRows[0].Cells[6].Value);

                ReportInfo info = new ReportInfo();
                ReportBuilderBase builder;
                info.Title = "\nOtobüs Rezervasyonu";
                info.Title += "\nEmail: " + email + "\n";
                info.Title += "Kullanıcı Adı: " + userName;
                info.TotalCost = 200;
                info.Expenses = new List<string>();
                info.Expenses.Add("Rezervasyon Id = " + busId);
                info.Expenses.Add("Kalkış Noktası: " + departurePoint);
                info.Expenses.Add("Varış Noktası: " + destinationPoint);
                info.Expenses.Add("Kalkış Zamanı: " + travelDate);
                info.Expenses.Add("Koltuk Numarası: " + seatNo);
                info.Expenses.Add("Rezervasyon Numarası: " + rezNo);

                if (reportType == "html")
                    builder = new HtmlBasedReportBuilder(info);
                else if (reportType == "xml")
                    builder = new XmlReportBuilder(info);
                else
                    builder = new JsonReportBuilder(info);

                ReportManager reportManager = new ReportManager(builder);

                string str = reportManager.BuildUpsideDown();
                return str;
            }
            catch
            {
                return "Bir satır seçiniz!";
            }
        }

        private void btnXmlReport_Click(object sender, EventArgs e)
        {
            string report = Report("xml");
            MessageBox.Show(report);
        }

        private void btnJsonReport_Click(object sender, EventArgs e)
        {
            string report = Report("json");
            report = report.Replace('[', '{').Replace(']', '}');
            MessageBox.Show(report);
        }

        private void btnHtmlReport_Click(object sender, EventArgs e)
        {
            string report = Report("html");
            MessageBox.Show(report);
        }
    }
}
