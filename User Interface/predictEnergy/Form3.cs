using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace predictEnergy
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            dtGetALL.DataSource = GetAllData();
        }

        private DataTable GetAllData()
        {
            DataTable dataTable = new DataTable();
            string conn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (MySqlConnection mySqlConnection= new MySqlConnection(conn))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM predictive_energy order by predictive_energy.index desc", mySqlConnection))
                {
                    mySqlConnection.Open();
                    MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                    dataTable.Load(mySqlDataReader);
                }
            }
            return dataTable;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
