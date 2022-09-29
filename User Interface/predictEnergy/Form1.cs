using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace predictEnergy
{
    public partial class Form1 : Form
    {
        string conn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void btPredictions_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btGetAllData_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tbNextPredict.Text = GetNextPrediction();
            FillChart();

            string Month, Day, Hour, Year;
            CreateTimeStamp(out Month, out Day, out Hour, out Year);
            lbNewDay.Text = $"Predict price for {Day}/{Month}/{Year} {Hour}:00";
        }

        private void CreateTimeStamp(out string Month, out string Day, out string Hour, out string Year)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(conn);
            string sqlquery = "SELECT Month,Day,Hour,Year FROM testenergy.prednextwith order by prednextwith.index desc LIMIT 1  ";
            mySqlConnection.Open();
            MySqlCommand cmd = new MySqlCommand(sqlquery, mySqlConnection);
            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            Month = string.Format("{0:#.##}", dr.GetValue(0));
            Day = string.Format("{0:#.##}", dr.GetValue(1));
            Hour = string.Format("{0:#.##}", dr.GetValue(2));
            Year = string.Format("{0:#.##}", dr.GetValue(3));
            mySqlConnection.Close();
        }

        private string GetNextPrediction()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(conn);
            string sqlquery = "SELECT Predvalue FROM testenergy.prednextwith  order by prednextwith.index desc LIMIT 1 ";
            mySqlConnection.Open();
            MySqlCommand cmd = new MySqlCommand(sqlquery, mySqlConnection);
            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            string nextPredict = string.Format("{0:#.##}", dr.GetValue(0));
            mySqlConnection.Close();
            return nextPredict;
        }

        private void FillChart()
        {
            List<double> prefictValues = new List<double>();
            List<double> actualPrice = new List<double>();
            MySqlConnection mySqlConnection = new MySqlConnection(conn);
            mySqlConnection.Open();
            FillActualPriceList(actualPrice, mySqlConnection);
            FillPredictList(prefictValues, mySqlConnection);
            CreateChart(prefictValues, actualPrice);
            mySqlConnection.Close();
        }

        private static void FillActualPriceList(List<double> actualPrice, MySqlConnection mySqlConnection)
        {
            string sqlquery2 = "SELECT priceactual FROM testenergy.actualprice  order by actualprice.index desc LIMIT 12 ";
            MySqlCommand cmd2 = new MySqlCommand(sqlquery2, mySqlConnection);
            using (MySqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    actualPrice.Add(reader.GetDouble(0));
                }
            }
        }

        private static void FillPredictList(List<double> prefictValues, MySqlConnection mySqlConnection)
        {
            string sqlquery = "SELECT Predvalue FROM testenergy.prednextwith  order by prednextwith.index desc LIMIT 12 ";
            MySqlCommand cmd = new MySqlCommand(sqlquery, mySqlConnection);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {

                    prefictValues.Add(reader.GetDouble(0));
                }
            }
        }

        private void CreateChart(List<double> prefictValues, List<double> actualPrice)
        {
            cartesianChart1.Series = new SeriesCollection
                {
                    new LineSeries
                    {
                        Title="predicted values",
                        Values=new ChartValues<ObservablePoint>
                        {
                            new ObservablePoint(0,prefictValues[11]),
                            new ObservablePoint(1,prefictValues[10]),
                            new ObservablePoint(2,prefictValues[9]),
                            new ObservablePoint(3,prefictValues[8]),
                            new ObservablePoint(4,prefictValues[7]),
                            new ObservablePoint(5,prefictValues[6]),
                            new ObservablePoint(6,prefictValues[5]),
                            new ObservablePoint(7,prefictValues[4]),
                            new ObservablePoint(8,prefictValues[3]),
                            new ObservablePoint(9,prefictValues[2]),
                            new ObservablePoint(10,prefictValues[1]),
                            new ObservablePoint(11,prefictValues[0])
                        }
                    },
                      new LineSeries
                    {
                        Title="actual price",
                        Values=new ChartValues<ObservablePoint>
                        {
                            new ObservablePoint(0,actualPrice[11]),
                            new ObservablePoint(1,actualPrice[10]),
                            new ObservablePoint(2,actualPrice[9]),
                            new ObservablePoint(3,actualPrice[8]),
                            new ObservablePoint(4,actualPrice[7]),
                            new ObservablePoint(5,actualPrice[6]),
                            new ObservablePoint(6,actualPrice[5]),
                            new ObservablePoint(7,actualPrice[4]),
                            new ObservablePoint(8,actualPrice[3]),
                            new ObservablePoint(9,actualPrice[2]),
                            new ObservablePoint(10,actualPrice[1]),
                            new ObservablePoint(11,actualPrice[0])
                        }
                    }
                };
        }

        private void btStats_Click(object sender, EventArgs e)
        {
            Stats stats = new Stats();
            stats.Show();
        }
    }
}
