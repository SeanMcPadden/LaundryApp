using LaundryLibrary.DataAccess;
using LaundryLibrary.Models;
using LaundryUI.Orders.Monday;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundryUI.Orders.Sunday
{
    public partial class SundayReturns : Form
    {
            
        public List<DayModel> returnsNotYetProcessed = GlobalConfig.Connection.GetDay_Sunday();
        private List<DayModel> processedReturns = new List<DayModel>();
        public static string SetValueForRestaurant = "";
        public static string ConfirmDay = "";

        public SundayReturns()
        {
            InitializeComponent();

            WireUpLists();
        }

        public void LoadListData()
        {
            returnsNotYetProcessed = GlobalConfig.Connection.GetDay_Sunday();
        }

        public void WireUpLists()
        {
            // this helps refresh the list
            returnsNotYetProcessedListBox.DataSource = null;

            returnsNotYetProcessedListBox.DataSource = returnsNotYetProcessed;
            returnsNotYetProcessedListBox.DisplayMember = "Restaurant";

            // this helps refresh the list
            processedReturnsListBox.DataSource = null;

            processedReturnsListBox.DataSource = processedReturns;
            processedReturnsListBox.DisplayMember = "Restaurant";
        }

        private void placeOrderButton_Click(object sender, EventArgs e)
        {
            if(returnsNotYetProcessedListBox.SelectedItem != null)
            {
                DayModel p = (DayModel)returnsNotYetProcessedListBox.SelectedItem;
                var obj = returnsNotYetProcessedListBox.SelectedItem as DayModel;
                SetValueForRestaurant = obj.Restaurant.ToString();
                ConfirmDay = "Sunday";

                returnsNotYetProcessed.Remove(p);
                processedReturns.Add(p);
                WireUpLists();

                Cloth cloth = new Cloth();
                cloth.ShowDialog();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClothOrKitchenwear week = new ClothOrKitchenwear();
            week.ShowDialog();
            this.Close();
        }

        private void editDayButton_Click(object sender, EventArgs e)
        {
            ConfirmDay = "Sunday";
            AddRestaurantToDay add = new AddRestaurantToDay();
            add.ShowDialog();
        }

        private void moveSelectedBackButton_Click(object sender, EventArgs e)
        {
            DayModel p = (DayModel)processedReturnsListBox.SelectedItem;

            if (p != null)
            {
                processedReturns.Remove(p);
                returnsNotYetProcessed.Add(p);

                WireUpLists();
            }
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            DayModel p = (DayModel)returnsNotYetProcessedListBox.SelectedItem;

            if (p != null)
            {
                returnsNotYetProcessed.Remove(p);
                processedReturns.Add(p);

                WireUpLists();
            }
        }

        private void viewSundaysReturnsButton_Click(object sender, EventArgs e)
        {
            ConfirmDay = "Sunday";
            this.Hide();
            ReturnsOrdersData orders = new ReturnsOrdersData();
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
