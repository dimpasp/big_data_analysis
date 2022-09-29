using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace predictEnergy
{
    public partial class Form2 : Form
    {
        string conn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            getPredictGrid.DataSource = GetDataOfPrediction();
        }
        private DataTable GetDataOfPrediction()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(conn);
            //use Distinct to avoid dublicate values
            string sqlquery = "SELECT Distinct Predvalue,Year,Month,Day,Hour FROM testenergy.prednextwith ";
            mySqlConnection.Open();
            MySqlCommand cmd = new MySqlCommand(sqlquery, mySqlConnection);
            MySqlDataAdapter mySqlDataReader = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            mySqlDataReader.Fill(dataTable);
            mySqlConnection.Close();
            return dataTable;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
