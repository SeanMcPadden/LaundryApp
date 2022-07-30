using Dapper;
using LaundryLibrary.DataAccess;
using LaundryLibrary.Models;
using LaundryUI.Orders;
using LaundryUI.Orders.Friday;
using LaundryUI.Orders.Saturday;
using LaundryUI.Orders.Sunday;
using LaundryUI.Orders.Thursday;
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

namespace LaundryUI
{
    public partial class OrdersData : Form
    {
        string testing3 = MondaysOrders.ConfirmDay;
        string testing4 = SundaysOrders.ConfirmDay;
        private List<ClothModel> sundaysOrders = GlobalConfig.Connection.GetCloth_GetSunday();
        private List<ClothModel> mondaysOrders = GlobalConfig.Connection.GetCloth_GetMonday();
        private List<ClothModel> tuesdaysOrders = GlobalConfig.Connection.GetCloth_GetTuesday();
        private List<ClothModel> wednesdaysOrders = GlobalConfig.Connection.GetCloth_GetWednesday();
        private List<ClothModel> thursdaysOrders = GlobalConfig.Connection.GetCloth_GetThursday();
        private List<ClothModel> fridaysOrders = GlobalConfig.Connection.GetCloth_GetFriday();
        private List<ClothModel> saturdaysOrders = GlobalConfig.Connection.GetCloth_GetSaturday();


        public OrdersData()
        {
            InitializeComponent();
        }

        private void MondaysOrders_Load(object sender, EventArgs e)
        {
            if (SundaysOrders.ConfirmDay == "Sunday")
            {
                mondaysOrdersGridView.DataSource = sundaysOrders;
            }
            if (MondaysOrders.ConfirmDay == "Monday")
            {
                mondaysOrdersGridView.DataSource = mondaysOrders;
            }
            if (TuesdaysOrders.ConfirmDay == "Tuesday")
            {
                mondaysOrdersGridView.DataSource = tuesdaysOrders;
            }
            if (WednesdaysOrders.ConfirmDay == "Wednesday")
            {
                mondaysOrdersGridView.DataSource = wednesdaysOrders;
            }
            if (ThursdaysOrders.ConfirmDay == "Thursday")
            {
                mondaysOrdersGridView.DataSource = thursdaysOrders;
            }
            if (FridaysOrders.ConfirmDay == "Friday")
            {
                mondaysOrdersGridView.DataSource = fridaysOrders;
            }
            if (SaturdaysOrders.ConfirmDay == "Saturday")
            {
                mondaysOrdersGridView.DataSource = saturdaysOrders;
            }

        }

        //Dont think this is being used.
        private void LoadListData()
        {
            if (SundaysOrders.ConfirmDay == "Sunday")
            {
                sundaysOrders = GlobalConfig.Connection.GetCloth_GetSunday();
            }
            if (MondaysOrders.ConfirmDay == "Monday")
            {
                mondaysOrders = GlobalConfig.Connection.GetCloth_GetMonday();
            }
            if (TuesdaysOrders.ConfirmDay == "Tuesday")
            {
                tuesdaysOrders = GlobalConfig.Connection.GetCloth_GetTuesday();
            }
            if (WednesdaysOrders.ConfirmDay == "Wednesday")
            {
                wednesdaysOrders = GlobalConfig.Connection.GetCloth_GetWednesday();
            }
            if (ThursdaysOrders.ConfirmDay == "Thursday")
            {
                thursdaysOrders = GlobalConfig.Connection.GetCloth_GetThursday();
            }
            if (FridaysOrders.ConfirmDay == "Friday")
            {
                fridaysOrders = GlobalConfig.Connection.GetCloth_GetFriday();
            }
            if (SaturdaysOrders.ConfirmDay == "Saturday")
            {
                saturdaysOrders = GlobalConfig.Connection.GetCloth_GetSaturday();
            }


        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (SundaysOrders.ConfirmDay == "Sunday")
            {
                this.Hide();
                SundaysOrders sundaysOrdersForm = new SundaysOrders();
                sundaysOrdersForm.ShowDialog();
                this.Close();
            }
            if (MondaysOrders.ConfirmDay == "Monday")
            {
                
                this.Hide();
                MondaysOrders monday = new MondaysOrders();
                monday.ShowDialog();
                this.Close();
            }
            if (TuesdaysOrders.ConfirmDay == "Tuesday")
            {
                this.Hide();
                TuesdaysOrders tuesday = new TuesdaysOrders();
                tuesday.ShowDialog();
                this.Close();
            }
            if (WednesdaysOrders.ConfirmDay == "Wednesday")
            {
                this.Hide();
                WednesdaysOrders tuesday = new WednesdaysOrders();
                tuesday.ShowDialog();
                this.Close();
            }
            if (ThursdaysOrders.ConfirmDay == "Thursday")
            {
                this.Hide();
                ThursdaysOrders thursday = new ThursdaysOrders();
                thursday.ShowDialog();
                this.Close();
            }
            if (FridaysOrders.ConfirmDay == "Friday")
            {
                this.Hide();
                FridaysOrders friday = new FridaysOrders();
                friday.ShowDialog();
                this.Close();
            }
            if (SaturdaysOrders.ConfirmDay == "Saturday")
            {
                this.Hide();
                SaturdaysOrders saturday = new SaturdaysOrders();
                saturday.ShowDialog();
                this.Close();
            }


        }

        private void mondaysOrdersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
