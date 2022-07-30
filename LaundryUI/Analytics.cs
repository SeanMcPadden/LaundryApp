using LaundryLibrary.DataAccess;
using LaundryLibrary.Models;
using LaundryUI.Analysis;
using LaundryUI.AnalysisDataGrids;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundryUI
{
    public partial class Analytics : Form
    {
        public List<DayModel> restaurants = GlobalConfig.Connection.GetDay_All();
        public static string? setValueForRestaurant = "";
        //public static string? setValueForAddress = "";


        public void LoadListData()
        {
            restaurantListbox.DataSource = restaurants;
            restaurantListbox.DisplayMember = "Restaurant";
        }


        public Analytics()
        {
            InitializeComponent();

            LoadListData();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
            this.Close();
        }

        private void restaurantsOrdersButton_Click(object sender, EventArgs e)
        {
            var obj = restaurantListbox.SelectedItem as DayModel;
            setValueForRestaurant = obj.Restaurant.ToString();

            this.Hide();
            ClothOrders orders = new ClothOrders();
            orders.ShowDialog();
            this.Close();
        }

        private void restaurantsKitchenwearOrdersButton_Click(object sender, EventArgs e)
        {
            var obj = restaurantListbox.SelectedItem as DayModel;
            setValueForRestaurant = obj.Restaurant.ToString();

            this.Hide();
            kitchenwearOrders orders = new kitchenwearOrders();
            orders.ShowDialog();
            this.Close();
        }

        private void restaurantReturnsButton_Click(object sender, EventArgs e)
        {
            var obj = restaurantListbox.SelectedItem as DayModel;
            setValueForRestaurant = obj.Restaurant.ToString();

            this.Hide();
            ClothReturns orders = new ClothReturns();
            orders.ShowDialog();
            this.Close();
        }

        private void restaurantDetailsButton_Click(object sender, EventArgs e)
        {
            var obj = restaurantListbox.SelectedItem as DayModel;
            setValueForRestaurant = obj.Restaurant.ToString();
            //var address = restaurantListbox.SelectedItem as DayModel;
            //setValueForAddress = address.Address.ToString();

            this.Hide();
            RestaurantDetails restaurant = new RestaurantDetails();
            restaurant.ShowDialog();
            this.Close();
        }
    }
}
