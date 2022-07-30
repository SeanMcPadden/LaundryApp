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
    public partial class kitchenwearOrders : Form
    {
        public string setValueForRestaurant = "";

        public kitchenwearOrders()
        {
            InitializeComponent();
        }

        public List<KitchenwearModel> GetOrdersByRestaurant()
        {
            setValueForRestaurant = Analytics.setValueForRestaurant;

            List<KitchenwearModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Laundry")))
            {
                output = connection.Query<KitchenwearModel>
                    ("SELECT Id, Date, JacketReturn, JacketSent," +
                    " BibApronReturn, BibApronSent," +
                    " KClothReturn, KClothSent, OvenCloth," +
                    " TrouserBlack, PolishCloth, Other," +
                    " Restaurant from Kitchenwear" +
                    " WHERE Restaurant = '" + setValueForRestaurant +
                    "' order by Date DESC").ToList();
            }

            return output;
        }

        private void kitchenwearOrders_Load(object sender, EventArgs e)
        {
            List<KitchenwearModel> orders = GetOrdersByRestaurant();

            kitchenwearOrdersDataGridView.DataSource = orders;

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
