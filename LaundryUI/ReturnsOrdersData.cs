using LaundryLibrary.DataAccess;
using LaundryLibrary.Models;
using LaundryUI.Orders.Friday;
using LaundryUI.Orders.Saturday;
using LaundryUI.Orders.Sunday;
using LaundryUI.Orders.Thursday;
using LaundryUI.Orders.Tuesday;
using LaundryUI.Orders.Wednesday;
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
    public partial class ReturnsOrdersData : Form
    {
        //string testing5 = MondayReturns.ConfirmDay;
        //string testing6 = SundayReturns.ConfirmDay;
        //public static string ConfirmDay = "";
        //private List<ClothModel> mondaysReturns = GlobalConfig.Connection.GetClothReturn_GetByWeek();

        private List<ClothModel> sundayReturns = GlobalConfig.Connection.GetClothReturn_GetSunday();
        private List<ClothModel> mondayReturns = GlobalConfig.Connection.GetClothReturn_GetMonday();
        private List<ClothModel> tuesdayReturns = GlobalConfig.Connection.GetClothReturn_GetTuesday();
        private List<ClothModel> wednesdayReturns = GlobalConfig.Connection.GetClothReturn_GetWednesday();
        private List<ClothModel> thursdayReturns = GlobalConfig.Connection.GetClothReturn_GetThursday();
        private List<ClothModel> fridayReturns = GlobalConfig.Connection.GetClothReturn_GetFriday();
        private List<ClothModel> saturdayReturns = GlobalConfig.Connection.GetClothReturn_GetSaturday();


        public ReturnsOrdersData()
        {
            InitializeComponent();
        }

        private void MondaysReturnsOrders_Load(object sender, EventArgs e)
        {
            if (SundayReturns.ConfirmDay == "Sunday")
            {
                mondaysReturnsDataGridView.DataSource = sundayReturns;
            }
            if (MondayReturns.ConfirmDay == "Monday")
            {
                mondaysReturnsDataGridView.DataSource = mondayReturns;
            }
            if (TuesdaysReturns.ConfirmDay == "Tuesday")
            {
                mondaysReturnsDataGridView.DataSource = tuesdayReturns;
            }
            if (WednesdayReturns.ConfirmDay == "Wednesday")
            {
                mondaysReturnsDataGridView.DataSource = wednesdayReturns;
            }
            if (ThursdayReturns.ConfirmDay == "Thursday")
            {
                mondaysReturnsDataGridView.DataSource = thursdayReturns;
            }
            if (FridayReturns.ConfirmDay == "Friday")
            {
                mondaysReturnsDataGridView.DataSource = fridayReturns;
            }
            if (SaturdaysReturns.ConfirmDay == "Saturday")
            {
                mondaysReturnsDataGridView.DataSource = saturdayReturns;
            }
        }

        private void LoadListData()
        {
            if (SundayReturns.ConfirmDay == "Sunday")
            {
                sundayReturns = GlobalConfig.Connection.GetClothReturn_GetSunday();
            }
            if (MondayReturns.ConfirmDay == "Monday")
            {
                mondayReturns = GlobalConfig.Connection.GetClothReturn_GetMonday();
            }
            if (TuesdaysReturns.ConfirmDay == "Tuesday")
            {
                tuesdayReturns = GlobalConfig.Connection.GetClothReturn_GetTuesday();
            }
            if (WednesdayReturns.ConfirmDay == "Wednesday")
            {
                wednesdayReturns = GlobalConfig.Connection.GetClothReturn_GetWednesday();
            }
            if (ThursdayReturns.ConfirmDay == "Thursday")
            {
                thursdayReturns = GlobalConfig.Connection.GetClothReturn_GetThursday();
            }
            if (FridayReturns.ConfirmDay == "Friday")
            {
                fridayReturns = GlobalConfig.Connection.GetClothReturn_GetFriday();
            }
            if (FridayReturns.ConfirmDay == "Friday")
            {
                fridayReturns = GlobalConfig.Connection.GetClothReturn_GetSaturday();
            }

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (SundayReturns.ConfirmDay == "Sunday")
            {
                //This line prevents duplicates and wrong navigation.
                SundayReturns.ConfirmDay = "";
                this.Hide();
                SundayReturns sundayReturns = new SundayReturns();
                sundayReturns.ShowDialog();
                this.Close();
            }
            if (MondayReturns.ConfirmDay == "Monday")
            {
                //This line prevents duplicates and wrong navigation.
                MondayReturns.ConfirmDay = "";
                this.Hide();
                MondayReturns mondayReturns = new MondayReturns();
                mondayReturns.ShowDialog();
                this.Close();
            }
            if (TuesdaysReturns.ConfirmDay == "Tuesday")
            {
                //This line prevents duplicates and wrong navigation.
                TuesdaysReturns.ConfirmDay = "";
                this.Hide();
                TuesdaysReturns returns = new TuesdaysReturns();
                returns.ShowDialog();
                this.Close();
            }
            if (WednesdayReturns.ConfirmDay == "Wednesday")
            {
                //This line prevents duplicates and wrong navigation.
                WednesdayReturns.ConfirmDay = "";
                this.Hide();
                WednesdayReturns returns = new WednesdayReturns();
                returns.ShowDialog();
                this.Close();

            }
            if (ThursdayReturns.ConfirmDay == "Thursday")
            {
                //This line prevents duplicates and wrong navigation.
                ThursdayReturns.ConfirmDay = "";
                this.Hide();
                ThursdayReturns returns = new ThursdayReturns();
                returns.ShowDialog();
                this.Close();

            }
            if (FridayReturns.ConfirmDay == "Friday")
            {
                //This line prevents duplicates and wrong navigation.
                FridayReturns.ConfirmDay = "";
                this.Hide();
                FridayReturns returns = new FridayReturns();
                returns.ShowDialog();
                this.Close();

            }
            if (SaturdaysReturns.ConfirmDay == "Saturday")
            {
                //This line prevents duplicates and wrong navigation.
                SaturdaysReturns.ConfirmDay = "";
                this.Hide();
                SaturdaysReturns returns = new SaturdaysReturns();
                returns.ShowDialog();
                this.Close();
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
            this.Close();
        }
    }
}
