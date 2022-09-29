using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace predictEnergy
{
    public partial class Stats : Form
    {
        string conn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public Stats()
        {
            InitializeComponent();
        }
        private void Stats_Load(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(conn);
            string sqlquery = "SELECT Year,Month,Day,Hour FROM testenergy.prednextwith order by prednextwith.index desc LIMIT 1 ";
            mySqlConnection.Open();
            MySqlCommand cmd = new MySqlCommand(sqlquery, mySqlConnection);
            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            string year = dr.GetValue(0).ToString();
            string month = dr.GetValue(1).ToString();
            string day = dr.GetValue(2).ToString();
            string Hour = dr.GetValue(3).ToString();
            mySqlConnection.Close();


            getTodayValues.DataSource = GetAllData(year, month, day);
            tbLastYear.Text = GetLastMonth(year, month, day, Hour);
            tbMaxValue.Text = GetMaxOfMonth(year, month);
            tbMinValue.Text = GetMinOfMonth(year, month);

            if (IsDatasetUpToDate()) checkIfDataIsUp.Checked = true;
        }
        private DataTable GetAllData(string year, string month, string day)
        {
            DataTable dataTable = new DataTable();
            string conn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (MySqlConnection mySqlConnection = new MySqlConnection(conn))
            {
                using (MySqlCommand cmd = new MySqlCommand($"SELECT Hour,Predvalue FROM testenergy.prednextwith where Year = '{year}' and Month = '{month}' and day = '{day}'", mySqlConnection))
                {
                    mySqlConnection.Open();
                    MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                    dataTable.Load(mySqlDataReader);
                }
                mySqlConnection.Close();
            }
            return dataTable;
        }
        private string GetLastMonth(string year, string month, string day, string Hour)
        {
            int valueLastMonth = Convert.ToInt32(month) - 1;
            int valueLastDay = Convert.ToInt32(day) - 1;
            //αυτο εγινε για να εμφανισουμε κατι,καθως δεν εχουν ολοι οι μηνες 31 μερες!
            if (valueLastDay == 31) valueLastDay = 30;
            string getLastMonth = "";
            string sqlquery = $"SELECT Predvalue FROM testenergy.prednextwith where Year = '{year}' and Month = '{valueLastMonth.ToString()}' and day = '{valueLastDay.ToString()}' and Hour = '{Hour}'";
            MySqlConnection mySqlConnection = new MySqlConnection(conn);
            mySqlConnection.Open();
            MySqlCommand cmd = new MySqlCommand(sqlquery, mySqlConnection);
            MySqlDataReader dr = cmd.ExecuteReader();
            try
            {
                dr.Read();
                if (dr.HasRows) getLastMonth = dr.GetString(0);
            }
            finally
            {
                dr.Close();
                mySqlConnection.Close();
            }
            return getLastMonth.Substring(0, 5);
       
        }
        private string GetMinOfMonth(string year, string month)
        {
            List<double> ListOfValues = new List<double>();
            string getMinOfMonth = "";
            string sqlquery = $"SELECT Predvalue FROM testenergy.prednextwith where Year = '{year}' and Month = '{month}'";
            MySqlConnection mySqlConnection = new MySqlConnection(conn);
            mySqlConnection.Open();
            MySqlCommand cmd = new MySqlCommand(sqlquery, mySqlConnection);
            MySqlDataReader dr = cmd.ExecuteReader();
            try
            {
                while (dr.Read())
                {
                    ListOfValues.Add(Convert.ToDouble(dr.GetString(0)));
                }
                getMinOfMonth = ListOfValues.Min().ToString();
            }
            finally
            {
                dr.Close();
                mySqlConnection.Close();
            }
            return getMinOfMonth.Substring(0, 5);
        }
        private string GetMaxOfMonth(string year, string month)
        {
            List<double> ListOfValues = new List<double>();
            string getMaxOfMonth = "";
            string sqlquery = $"SELECT Predvalue FROM testenergy.prednextwith where Year = '{year}' and Month = '{month}'";
            MySqlConnection mySqlConnection = new MySqlConnection(conn);
            mySqlConnection.Open();
            MySqlCommand cmd = new MySqlCommand(sqlquery, mySqlConnection);
            MySqlDataReader dr = cmd.ExecuteReader();
            try
            {
                while (dr.Read())
                {
                    ListOfValues.Add(Convert.ToDouble(dr.GetString(0)));
                }
                getMaxOfMonth = ListOfValues.Max().ToString();
            }
            finally
            {
                dr.Close();
                mySqlConnection.Close();
            }
            return getMaxOfMonth.Substring(0, 5);
        }

        private bool IsDatasetUpToDate()
        {
            string conn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            MySqlConnection mySqlConnection = new MySqlConnection(conn);
            mySqlConnection.Open();

            // check last entry of dataset
            string sqlqueryPredNext = "SELECT Month,Day,Hour FROM testenergy.prednextwith order by prednextwith.index desc LIMIT 1 ";
            string datePredNext = "";
            MySqlCommand cmd = new MySqlCommand(sqlqueryPredNext, mySqlConnection);
            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            datePredNext = dr[2] + "/" + dr[1] + "/" + dr[0];
            dr.Close();

            //check last entry of prediction
            string sqlqueryPredEnergy = "SELECT Month,Day,Hour FROM testenergy.predictive_energy order by predictive_energy.index desc LIMIT 1 ";
            string datePredEnergy = "";
            cmd = new MySqlCommand(sqlqueryPredEnergy, mySqlConnection);
            dr = cmd.ExecuteReader();
            dr.Read();
            datePredEnergy = dr[2] + "/" + dr[1] + "/" + dr[0];
            dr.Close();

            //close connection
            mySqlConnection.Close();
            bool result = datePredNext.Equals(datePredEnergy);
            return result;
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            Stats_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
