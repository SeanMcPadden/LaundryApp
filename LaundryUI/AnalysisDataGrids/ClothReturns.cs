using Dapper;
using LaundryLibrary.DataAccess;
using LaundryLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundryUI.AnalysisDataGrids
{
    public partial class ClothReturns : Form
    {
        public string setValueForRestaurant = "";

        public ClothReturns()
        {
            InitializeComponent();
        }

        public List<ClothModel> GetOrdersByRestaurant()
        {
            setValueForRestaurant = Analytics.setValueForRestaurant;

            List<ClothModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Laundry")))
            {
                output = connection.Query<ClothModel>
                    ("SELECT Id, NapkinBrown," +
                    " White, Brown54, Brown70, BarCloth," +
                    " Restaurant, DateTime from dbo.ClothReturn" +
                    " WHERE Restaurant = '" + setValueForRestaurant +
                    "' order by DateTime DESC").ToList();
            }

            return output;
        }


        private void ClothReturns_Load(object sender, EventArgs e)
        {
            List<ClothModel> clothOrders = GetOrdersByRestaurant();

            ClothReturnsDataGridView.DataSource = clothOrders;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Analytics analytics = new Analytics();
            analytics.ShowDialog();
            this.Close();
        }
    }
}
