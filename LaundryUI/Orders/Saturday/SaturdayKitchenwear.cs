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

namespace LaundryUI.Orders.Saturday
{
    public partial class SaturdayKitchenwear : Form
    {
        public static string ConfirmDay = "";
        public List<DayModel> ordersNotYetPlaced = GlobalConfig.Connection.GetDay_Saturday();
        private List<DayModel> ordersPlaced = new List<DayModel>();
        public static string SetValueForRestaurant = "";

        public SaturdayKitchenwear()
        {
            InitializeComponent();

            WireUpLists();
        }

        public void LoadListData()
        {
            ordersNotYetPlaced = GlobalConfig.Connection.GetDay_Saturday();
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
            DayModel p = (DayModel)ordersNotYetPlacedListBox.SelectedItem;
            var obj = ordersNotYetPlacedListBox.SelectedItem as DayModel;
            SetValueForRestaurant = obj.Restaurant.ToString();
            ConfirmDay = "Saturday";

            ordersNotYetPlaced.Remove(p);
            ordersPlaced.Add(p);
            WireUpLists();

            Kitchenwear kitchenwear = new Kitchenwear();
            kitchenwear.ShowDialog();
        }

        private void editDayButton_Click(object sender, EventArgs e)
        {
            ConfirmDay = "Saturday";
            CreateNewRestaurant add = new CreateNewRestaurant();
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

        private void viewSaturdaysOrderButton_Click(object sender, EventArgs e)
        {
            ConfirmDay = "Saturday";
            this.Hide();
            KitchenwearOrders orders = new KitchenwearOrders();
            orders.ShowDialog();
            this.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ConfirmDay = "";
            this.Hide();
            ClothOrKitchenwear week = new ClothOrKitchenwear();
            week.ShowDialog();
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
