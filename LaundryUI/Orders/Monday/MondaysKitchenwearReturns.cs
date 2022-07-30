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

namespace LaundryUI.Orders.Monday
{
    public partial class MondaysKitchenwearReturns : Form
    {
        public List<DayModel> returnsNotYetProcessed = GlobalConfig.Connection.GetDay_All();
        private List<DayModel> processedReturns = new List<DayModel>();
        public static string SetValueForRestaurant = "";
        public static string ConfirmDay = "";

        public MondaysKitchenwearReturns()
        {
            InitializeComponent();

            WireUpLists();
        }

        public void LoadListData()
        {
            returnsNotYetProcessed = GlobalConfig.Connection.GetDay_All();
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
            DayModel p = (DayModel)returnsNotYetProcessedListBox.SelectedItem;
            var obj = returnsNotYetProcessedListBox.SelectedItem as DayModel;
            SetValueForRestaurant = obj.Restaurant.ToString();
            ConfirmDay = "Monday";
            

            returnsNotYetProcessed.Remove(p);
            processedReturns.Add(p);
            WireUpLists();

            //this.Hide();
            Kitchenwear kitchenwear = new Kitchenwear();
            kitchenwear.ShowDialog();
            //this.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClothOrKitchenwear week = new ClothOrKitchenwear();
            week.ShowDialog();
            //added this.close
            this.Close();
        }

        private void editDayButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateNewRestaurant add = new CreateNewRestaurant();
            add.ShowDialog();
            this.Close();
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

        private void viewMondaysReturnsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MondaysKitchenwearReturnsOrders orders = new MondaysKitchenwearReturnsOrders();
            orders.ShowDialog();
            this.Close();
        }
    }
}
