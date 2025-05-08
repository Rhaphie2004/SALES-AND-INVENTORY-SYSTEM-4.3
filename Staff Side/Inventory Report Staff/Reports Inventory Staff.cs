using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sims.Staff_Side.Inventory_Report_Staff
{
    public partial class Reports_Inventory_Staff : Form
    {
        public Reports_Inventory_Staff()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Reports_Inventory_Staff_Load(object sender, EventArgs e)
        {
            PopulateStocks();
        }
        public void PopulateStocks()
        {
            dbModule db = new dbModule();
            MySqlDataAdapter adapter = db.GetAdapter();
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM stocks";
                    MySqlCommand command = new MySqlCommand(query, conn);
                    adapter.SelectCommand = command;

                    // Fill the DataTable with data from the "stocks" table
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Use the embedded Crystal Report
                    sims.Stocks_Report_Staff stocksReport = new sims.Stocks_Report_Staff();

                    // Set the DataTable as the data source for the report
                    stocksReport.SetDataSource(dt);

                    // Assign the report to the CrystalReportViewer
                    crystalReportViewer1.ReportSource = stocksReport;
                    crystalReportViewer1.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
