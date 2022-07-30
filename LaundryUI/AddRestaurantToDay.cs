using LaundryLibrary.DataAccess;
using LaundryLibrary.Models;
using LaundryUI.Orders;
using LaundryUI.Orders.Friday;
using LaundryUI.Orders.Monday;
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
    public partial class AddRestaurantToDay : Form
    {
        public static string ConfirmDay = "";
        
        public AddRestaurantToDay()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ReturnToDay();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                DayModel day = new DayModel(
                    restaurantValue.Text,
                    bagColourValue.Text,
                    locationValue.Text,
                    dayOfWeekInput.Text,
                    addressValue.Text,
                    driverValue.Text,
                    notesValue.Text);

                GlobalConfig.Connection.CreateDay(day);

                restaurantValue.Text = "";
                bagColourValue.Text = "";
                locationValue.Text = "";
                addressValue.Text = "";
                driverValue.Text = "";
                notesValue.Text = "";
            }
            else
            {
                MessageBox.Show("The Restaurant Field must be completed" +
                    " before the restaurant log can be created.");
            }

        }

        private bool ValidateForm()
        {
            if (restaurantValue.Text == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ReturnToDay()
        {
            if (SundaysOrders.ConfirmDay == "Sunday")
            {
                ConfirmDay = "Sunday";
                this.Hide();
                SundaysOrders day = new SundaysOrders();
                day.Show();
                this.Close();

                return true;
            }
            if (MondaysOrders.ConfirmDay == "Monday")
            {
                ConfirmDay = "Monday"; 
                this.Hide();
                MondaysOrders day = new MondaysOrders();
                day.Show();
                this.Close();

                return true;
            }
            if (TuesdaysOrders.ConfirmDay == "Tuesday")
            {
                ConfirmDay = "Tuesday";
                this.Hide();
                TuesdaysOrders day = new TuesdaysOrders();
                day.Show();
                this.Close();

                return true;
            }
            if (WednesdaysOrders.ConfirmDay == "Wednesday")
            {
                ConfirmDay = "Wednesday";
                this.Hide();
                WednesdaysOrders day = new WednesdaysOrders();
                day.Show();
                this.Close();

                return true;
            }
            if (ThursdaysOrders.ConfirmDay == "Thursday")
            {
                ConfirmDay = "Thursday";
                this.Hide();
                ThursdaysOrders day = new ThursdaysOrders();
                day.Show();
                this.Close();

                return true;
            }
            if (FridaysOrders.ConfirmDay == "Friday")
            {
                ConfirmDay = "Friday";
                this.Hide();
                FridaysOrders day = new FridaysOrders();
                day.Show();
                this.Close();

                return true;
            }
            if (SaturdaysOrders.ConfirmDay == "Saturday")
            {
                ConfirmDay = "Saturday";
                this.Hide();
                SaturdaysOrders day = new SaturdaysOrders();
                day.Show();
                this.Close();

                return true;
            }
            if (SundayReturns.ConfirmDay == "Sunday")
            {
                ConfirmDay = "Sunday";
                this.Hide();
                SundayReturns returns = new SundayReturns();
                returns.Show();
                this.Close();

                return true;
            }
            if (MondayReturns.ConfirmDay == "Monday")
            {
                ConfirmDay = "Monday";
                this.Hide();
                MondayReturns returns = new MondayReturns();
                returns.Show();
                this.Close();

                return true;
            }
            if (TuesdaysReturns.ConfirmDay == "Tuesday")
            {
                ConfirmDay = "Tuesday";
                this.Hide();
                TuesdaysReturns returns = new TuesdaysReturns();
                returns.Show();
                this.Close();

                return true;
            }
            if (WednesdayReturns.ConfirmDay == "Wednesday")
            {
                ConfirmDay = "Wednesday";
                this.Hide();
                WednesdayReturns returns = new WednesdayReturns();
                returns.Show();
                this.Close();

                return true;
            }
            if (ThursdayReturns.ConfirmDay == "Thursday")
            {
                ConfirmDay = "Thursday";
                this.Hide();
                ThursdayReturns returns = new ThursdayReturns();
                returns.Show();
                this.Close();

                return true;
            }
            if (FridayReturns.ConfirmDay == "Friday")
            {
                ConfirmDay = "Friday";
                this.Hide();
                FridayReturns returns = new FridayReturns();
                returns.Show();
                this.Close();

                return true;
            }
            if (SaturdaysReturns.ConfirmDay == "Saturday")
            {
                ConfirmDay = "Saturday";
                this.Hide();
                SaturdaysReturns returns = new SaturdaysReturns();
                returns.Show();
                this.Close();

                return true;
            }
            else
            {
                return false;
            }
        }

        private void AddRestaurantToDay_Load(object sender, EventArgs e)
        {
            if (SundaysOrders.ConfirmDay == "Sunday")
            {
                dayOfWeekInput.Text = "Sunday";
            }
            if (SundayReturns.ConfirmDay == "Sunday")
            {
                dayOfWeekInput.Text = "Sunday";
            }
            if (MondaysOrders.ConfirmDay == "Monday")
            {
                dayOfWeekInput.Text = "Monday";
            }
            if (MondayReturns.ConfirmDay == "Monday")
            {
                dayOfWeekInput.Text = "Monday";
            }
            if (TuesdaysOrders.ConfirmDay == "Tuesday")
            {
                dayOfWeekInput.Text = "Tuesday";
            }
            if (TuesdaysReturns.ConfirmDay == "Tuesday")
            {
                dayOfWeekInput.Text = "Tuesday";
            }
            if (WednesdaysOrders.ConfirmDay == "Wednesday")
            {
                dayOfWeekInput.Text = "Wednesday";
            }
            if (WednesdayReturns.ConfirmDay == "Wednesday")
            {
                dayOfWeekInput.Text = "Wednesday";
            }
            if (ThursdaysOrders.ConfirmDay == "Thursday")
            {
                dayOfWeekInput.Text = "Thursday";
            }
            if (ThursdayReturns.ConfirmDay == "Thursday")
            {
                dayOfWeekInput.Text = "Thursday";
            }
            if (FridaysOrders.ConfirmDay == "Friday")
            {
                dayOfWeekInput.Text = "Friday";
            }
            if (FridayReturns.ConfirmDay == "Friday")
            {
                dayOfWeekInput.Text = "Friday";
            }
            if (SaturdaysOrders.ConfirmDay == "Saturday")
            {
                dayOfWeekInput.Text = "Saturday";
            }
            if (SaturdaysReturns.ConfirmDay == "Saturday")
            {
                dayOfWeekInput.Text = "Saturday";
            }
        }
    }
}
