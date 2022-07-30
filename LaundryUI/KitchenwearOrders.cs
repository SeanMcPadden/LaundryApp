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

namespace LaundryUI
{
    public partial class KitchenwearOrders : Form
    {
        //private string ConfirmDay = "";

        private List<KitchenwearModel> sundaysKitchenwear = GlobalConfig.Connection.GetKitchenwear_GetSunday();
        private List<KitchenwearModel> mondaysKitchenwear = GlobalConfig.Connection.GetKitchenwear_GetMonday();
        private List<KitchenwearModel> tuesdaysKitchenwear = GlobalConfig.Connection.GetKitchenwear_GetTuesday();
        private List<KitchenwearModel> wednesdaysKitchenwear = GlobalConfig.Connection.GetKitchenwear_GetWednesday();
        private List<KitchenwearModel> thursdaysKitchenwear = GlobalConfig.Connection.GetKitchenwear_GetThursday();
        private List<KitchenwearModel> fridaysKitchenwear = GlobalConfig.Connection.GetKitchenwear_GetFriday();
        private List<KitchenwearModel> saturdaysKitchenwear = GlobalConfig.Connection.GetKitchenwear_GetSaturday();


        public KitchenwearOrders()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kitchenwearOrders_Load(object sender, EventArgs e)
        {
            if (SundayKitchenwear.ConfirmDay == "Sunday")
            {
                kitchenwearOrdersGridView.DataSource = sundaysKitchenwear;
            }
            if (MondayKitchenwear.ConfirmDay == "Monday")
            {
                kitchenwearOrdersGridView.DataSource = mondaysKitchenwear;
            }
            if (TuesdayKitchenwear.ConfirmDay == "Tuesday")
            {
                kitchenwearOrdersGridView.DataSource = tuesdaysKitchenwear;
            }
            if (WednesdayKitchenwear.ConfirmDay == "Wednesday")
            {
                kitchenwearOrdersGridView.DataSource = wednesdaysKitchenwear;
            }
            if (ThursdayKitchenwear.ConfirmDay == "Thursday")
            {
                kitchenwearOrdersGridView.DataSource = thursdaysKitchenwear;
            }
            if (FridayKitchenwear.ConfirmDay == "Friday")
            {
                kitchenwearOrdersGridView.DataSource = fridaysKitchenwear;
            }
            if (SaturdayKitchenwear.ConfirmDay == "Saturday")
            {
                kitchenwearOrdersGridView.DataSource = saturdaysKitchenwear;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //cloth form doesnt use confirmDay = ""; and has no navigation issues.
            if (SundayKitchenwear.ConfirmDay == "Sunday")
            {
                //ConfirmDay = "";
                this.Hide();
                SundayKitchenwear orders = new SundayKitchenwear();
                orders.ShowDialog();
                this.Close();
            }
            if (MondayKitchenwear.ConfirmDay == "Monday")
            {
                //ConfirmDay = "";
                this.Hide();
                MondayKitchenwear orders = new MondayKitchenwear();
                orders.ShowDialog();
                this.Close();
            }
            if (TuesdayKitchenwear.ConfirmDay == "Tuesday")
            {
                //ConfirmDay = "";
                this.Hide();
                TuesdayKitchenwear orders = new TuesdayKitchenwear();
                orders.ShowDialog();
                this.Close();
            }
            if (WednesdayKitchenwear.ConfirmDay == "Wednesday")
            {
                //ConfirmDay = "";
                this.Hide();
                WednesdayKitchenwear orders = new WednesdayKitchenwear();
                orders.ShowDialog();
                this.Close();
            }
            if (ThursdayKitchenwear.ConfirmDay == "Thursday")
            {
                //ConfirmDay = "";
                this.Hide();
                ThursdayKitchenwear orders = new ThursdayKitchenwear();
                orders.ShowDialog();
                this.Close();
            }
            if (FridayKitchenwear.ConfirmDay == "Friday")
            {
                //ConfirmDay = "";
                this.Hide();
                FridayKitchenwear orders = new FridayKitchenwear();
                orders.ShowDialog();
                this.Close();
            }
            if (SaturdayKitchenwear.ConfirmDay == "Saturday")
            {
                //ConfirmDay = "";
                this.Hide();
                SaturdayKitchenwear orders = new SaturdayKitchenwear();
                orders.ShowDialog();
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
