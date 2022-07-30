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
    public partial class RestaurantsDetails : Form
    {
        public string setValueForRestaurant = "";
        public string setValueForAddress = "";

        public RestaurantsDetails()
        {
            InitializeComponent();
        }

        public List<DayModel> GetOrdersByRestaurant()
        {
            setValueForRestaurant = Analytics.setValueForRestaurant;

            List<DayModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Laundry")))
            {
                output = connection.Query<DayModel>
                    ("SELECT Id, Restaurant, BagColour," +
                    " Location, DayOfWeek, Address," +
                    " Driver, Notes" +
                    " from Day where Restaurant = '" + setValueForRestaurant + "'")
                    .ToList();
            }

            return output;
        }

        private void RestaurantsDetails_Load(object sender, EventArgs e)
        {
            List<DayModel> details = GetOrdersByRestaurant();

            //restaurantInput.Text = GetOrdersByRestaurant.Restaurant;

            setValueForRestaurant = Analytics.setValueForRestaurant;
            //setValueForAddress = Analytics.setValueForAddress;
            //setValueForAddress = details;

            restaurantInput.Text = setValueForRestaurant;
            addressInput.Text = setValueForAddress;
        }
    }
}
