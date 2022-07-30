using Dapper;
using LaundryLibrary.DataAccess;
using LaundryLibrary.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundryUI.Analysis
{
    public partial class ClothOrders : Form
    {

        public string setValueForRestaurant = "";

        public ClothOrders()
        {
            InitializeComponent();
        }

        private void clothOrdersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public List<ClothModel> GetOrdersByRestaurant()
        {
            setValueForRestaurant = Analytics.setValueForRestaurant;

            List<ClothModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Laundry")))
            {
                output = connection.Query<ClothModel>
                    ("SELECT Id, IronedDate, NapkinBrown," +
                    " White, Brown54, Brown70, BarCloth," +
                    " Restaurant, DateTime from dbo.Cloth" +
                    " WHERE Restaurant = '"+setValueForRestaurant +
                    "' order by DateTime DESC;").ToList();
            }

            return output;
        }


            private void ClothOrders_Load(object sender, EventArgs e)
        {
            List<ClothModel> clothOrders = GetOrdersByRestaurant();

            clothOrdersGridView.DataSource = clothOrders;

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
