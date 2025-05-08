using MySql.Data.MySqlClient;
using sims.Admin_Side.Stocks;
using System;
using System.Data;
using System.Windows.Forms;

namespace sims.Staff_Side.Stocks
{
    public partial class Low_Stocks_Staff : Form
    {
        private Inventory_Dashboard_Staff _inventoryDashboard;
        private Manage_Stocks_Staff dashboard;

        public Low_Stocks_Staff(Inventory_Dashboard_Staff _inventoryDashboard, Manage_Stocks_Staff dashboard)
        {
            InitializeComponent();
            this.dashboard = dashboard;
        }

        public DataGridView ItemsLowStockDgv
        {
            get { return itemStockDgv; }
        }

        private void Low_Stocks_Staff_Load(object sender, EventArgs e)
        {
            ViewStock();
        }

        public void ViewStock()
        {
            dbModule db = new dbModule();
            MySqlConnection conn = db.GetConnection();
            MySqlCommand cmd = db.GetCommand();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable dataTable = new DataTable();

            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM lowstocks";

                adapter.SelectCommand = cmd;
                adapter.Fill(dataTable);

                itemStockDgv.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to populate stock data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                cmd.Dispose();
                conn.Dispose();
            }
        }

        private void DeleteStockBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void UpdateStockBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to update this record?", "Update Item!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    int selectedRowIndex = itemStockDgv.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = itemStockDgv.Rows[selectedRowIndex];
                    string itemID = selectedRow.Cells["Stock_ID"]?.Value?.ToString();
                    if (!string.IsNullOrEmpty(itemID))
                    {
                        Edit_Low_Stocks_Staff updateProductForm = new Edit_Low_Stocks_Staff(itemID, _inventoryDashboard, dashboard, this);
                        updateProductForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Item_ID. Unable to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
