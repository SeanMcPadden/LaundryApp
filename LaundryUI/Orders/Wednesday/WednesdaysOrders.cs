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

namespace LaundryUI.Orders.Wednesday
{
    public partial class WednesdaysOrders : Form
    {
        public List<DayModel> ordersNotYetPlaced = GlobalConfig.Connection.GetDay_Wednesday();
        private List<DayModel> ordersPlaced = new List<DayModel>();
        public static string SetValueForRestaurant = "";
        public static string ConfirmDay = "";

        public WednesdaysOrders()
        {
            InitializeComponent();

            WireUpLists();
        }

        public void LoadListData()
        {
            ordersNotYetPlaced = GlobalConfig.Connection.GetDay_Wednesday();
        }

        public void WireUpLists()
        {
            // this helps refresh the list
            ordersNotYetPlacedListBox.DataSource = null;

            ordersNotYetPlacedListBox.DataSource = ordersNotYetPlaced;
            ordersNotYetPlacedListBox.DisplayMember = "Restaurant";

            // this helps refresh the list
            ordersPlacedListBox.DataSource = null;

            ordersPlacedListBox.DataSource = ordersPlaced;
            ordersPlacedListBox.DisplayMember = "Restaurant";
        }

        private void placeOrderButton_Click(object sender, EventArgs e)
        {

            if (ordersNotYetPlacedListBox.SelectedItem != null)
            {
                DayModel p = (DayModel)ordersNotYetPlacedListBox.SelectedItem;
                var obj = ordersNotYetPlacedListBox.SelectedItem as DayModel;
                SetValueForRestaurant = obj.Restaurant.ToString();
                ConfirmDay = "Wednesday";

                ordersNotYetPlaced.Remove(p);
                ordersPlaced.Add(p);
                WireUpLists();

                Cloth cloth = new Cloth();
                cloth.ShowDialog();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ConfirmDay = "";
            this.Hide();
            ClothOrKitchenwear week = new ClothOrKitchenwear();
            week.ShowDialog();
            this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            ConfirmDay = "Wednesday";
            AddRestaurantToDay add = new AddRestaurantToDay();
            add.ShowDialog();
        }

        private void moveSelectedBackButton_Click(object sender, EventArgs e)
        {
            DayModel p = (DayModel)ordersPlacedListBox.SelectedItem;

            if (p != null)
            {
                ordersPlaced.Remove(p);
                ordersNotYetPlaced.Add(p);

                WireUpLists();
            }
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            DayModel p = (DayModel)ordersNotYetPlacedListBox.SelectedItem;

            if (p != null)
            {
                ordersNotYetPlaced.Remove(p);
                ordersPlaced.Add(p);

                WireUpLists();
            }
        }

        private void viewWednesdaysOrdersButton_Click(object sender, EventArgs e)
        {
            ConfirmDay = "Wednesday";
            this.Hide();
            OrdersData orders = new OrdersData();
            orders.ShowDialog();
            this.Close();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            ConfirmDay = "";
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
            this.Close();
        }
    }
}
