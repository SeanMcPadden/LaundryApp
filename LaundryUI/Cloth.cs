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
    public partial class Cloth : Form
    {

        public Cloth()
        {
            InitializeComponent();

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ReturnToDayAndCorrectForm();
        }

        private void submitClothFormButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                ClothModel cloth = new ClothModel(
                    restaurantInput.Text,
                    napkinBrownValue.Text,
                    whiteValue.Text,
                    brown70Value.Text,
                    barClothValue.Text,
                    brown54Value.Text,                   
                    dayOfWeekInput.Text);

                //This section of code only needs applied to seperate orders from returns

                if (SundaysOrders.ConfirmDay == "Sunday")
                {
                    GlobalConfig.Connection.CreateCloth(cloth);
                }
                if (SundayReturns.ConfirmDay == "Sunday")
                {
                    GlobalConfig.Connection.CreateClothReturn(cloth);
                }
                if (MondaysOrders.ConfirmDay == "Monday")
                {
                    GlobalConfig.Connection.CreateCloth(cloth);
                }
                if(MondayReturns.ConfirmDay == "Monday")
                {
                    GlobalConfig.Connection.CreateClothReturn(cloth);
                }
                if (TuesdaysOrders.ConfirmDay == "Tuesday")
                {
                    GlobalConfig.Connection.CreateCloth(cloth);
                }
                if (TuesdaysReturns.ConfirmDay == "Tuesday")
                {
                    GlobalConfig.Connection.CreateClothReturn(cloth);
                }
                if (WednesdaysOrders.ConfirmDay == "Wednesday")
                {
                    GlobalConfig.Connection.CreateCloth(cloth);
                }
                if (WednesdayReturns.ConfirmDay == "Wednesday")
                {
                    GlobalConfig.Connection.CreateClothReturn(cloth);
                }
                if (ThursdaysOrders.ConfirmDay == "Thursday")
                {
                    GlobalConfig.Connection.CreateCloth(cloth);
                }
                if (ThursdayReturns.ConfirmDay == "Thursday")
                {
                    GlobalConfig.Connection.CreateClothReturn(cloth);
                }
                if (FridaysOrders.ConfirmDay == "Friday")
                {
                    GlobalConfig.Connection.CreateCloth(cloth);
                }
                if (FridayReturns.ConfirmDay == "Friday")
                {
                    GlobalConfig.Connection.CreateClothReturn(cloth);
                }
                if (SaturdaysOrders.ConfirmDay == "Saturday")
                {
                    GlobalConfig.Connection.CreateCloth(cloth);
                }
                if (SaturdaysReturns.ConfirmDay == "Saturday")
                {
                    GlobalConfig.Connection.CreateClothReturn(cloth);
                }


            }
            else
            {
                MessageBox.Show("Please complete all fields before submitting.");
            }

            ReturnToDayAndCorrectForm();
        }

        private bool ValidateForm()
        {
            if(napkinBrownValue.Text == null)
            {
                return false;
            }
            if(whiteValue.Text == null)
            {
                return false;
            }
            if(brown54Value.Text == null)
            {
                return false;
            }
            if(brown70Value.Text == null)
            {
                return false;
            }
            if(barClothValue.Text == null)
            {
                return false;
            }

            return true;
        }


        private bool ReturnToDayAndCorrectForm()
        {
            if (SundaysOrders.ConfirmDay == "Sunday")
            {
                this.Hide();
                SundaysOrders sunday = new SundaysOrders();
                sunday.Show();
                this.Close();

                return true;
            }
            if (MondaysOrders.ConfirmDay == "Monday")
            {
                this.Hide();
                MondaysOrders monday = new MondaysOrders();
                monday.Show();
                this.Close();

                return true;
            }
            if (TuesdaysOrders.ConfirmDay == "Tuesday")
            {
                this.Hide();
                TuesdaysOrders day = new TuesdaysOrders();
                day.Show();
                this.Close();

                return true;
            }
            if (WednesdaysOrders.ConfirmDay == "Wednesday")
            {
                this.Hide();
                WednesdaysOrders day = new WednesdaysOrders();
                day.Show();
                this.Close();

                return true;
            }
            if (ThursdaysOrders.ConfirmDay == "Thursday")
            {
                this.Hide();
                ThursdaysOrders day = new ThursdaysOrders();
                day.Show();
                this.Close();

                return true;
            }
            if (FridaysOrders.ConfirmDay == "Friday")
            {
                this.Hide();
                FridaysOrders day = new FridaysOrders();
                day.Show();
                this.Close();

                return true;
            }
            if (SaturdaysOrders.ConfirmDay == "Saturday")
            {
                this.Hide();
                SaturdaysOrders day = new SaturdaysOrders();
                day.Show();
                this.Close();

                return true;
            }
            if (SundayReturns.ConfirmDay == "Sunday")
            {
                this.Hide();
                SundayReturns sunday = new SundayReturns();
                sunday.Show();
                this.Close();

                return true;
            }
            if (MondayReturns.ConfirmDay == "Monday")
            {
                this.Hide();
                MondayReturns monday = new MondayReturns();
                monday.Show();
                this.Close();

                return true;
            }
            if (TuesdaysReturns.ConfirmDay == "Tuesday")
            {
                this.Hide();
                TuesdaysReturns day = new TuesdaysReturns();
                day.Show();
                this.Close();

                return true;
            }
            if (WednesdayReturns.ConfirmDay == "Wednesday")
            {
                this.Hide();
                WednesdayReturns day = new WednesdayReturns();
                day.Show();
                this.Close();

                return true;
            }
            if (ThursdayReturns.ConfirmDay == "Thursday")
            {
                this.Hide();
                ThursdayReturns day = new ThursdayReturns();
                day.Show();
                this.Close();

                return true;
            }
            if (FridayReturns.ConfirmDay == "Friday")
            {
                this.Hide();
                FridayReturns day = new FridayReturns();
                day.Show();
                this.Close();

                return true;
            }
            if (SaturdaysReturns.ConfirmDay == "Saturday")
            {
                this.Hide();
                SaturdaysReturns day = new SaturdaysReturns();
                day.Show();
                this.Close();

                return true;
            }
            else
            {
                return false;
            }
        }

        private void Cloth_Load_1(object sender, EventArgs e)
        {
            if(SundaysOrders.ConfirmDay == "Sunday")
            {
                restaurantInput.Text = SundaysOrders.SetValueForRestaurant;
                dayOfWeekInput.Text = "Sunday";
            }
            if (SundayReturns.ConfirmDay == "Sunday")
            {
                restaurantInput.Text = SundayReturns.SetValueForRestaurant;
                dayOfWeekInput.Text = "Sunday";
            }
            if (MondaysOrders.ConfirmDay == "Monday")
            {
                restaurantInput.Text = MondaysOrders.SetValueForRestaurant;
                dayOfWeekInput.Text = "Monday";
            }
            if (MondayReturns.ConfirmDay == "Monday")
            {
                restaurantInput.Text = MondayReturns.SetValueForRestaurant;
                dayOfWeekInput.Text = "Monday";
            }
            if (TuesdaysOrders.ConfirmDay == "Tuesday")
            {
                restaurantInput.Text = TuesdaysOrders.SetValueForRestaurant;
                dayOfWeekInput.Text = "Tuesday";
            }
            if (TuesdaysReturns.ConfirmDay == "Tuesday")
            {
                restaurantInput.Text = TuesdaysReturns.SetValueForRestaurant;
                dayOfWeekInput.Text = "Tuesday";
            }
            if (WednesdaysOrders.ConfirmDay == "Wednesday")
            {
                restaurantInput.Text = WednesdaysOrders.SetValueForRestaurant;
                dayOfWeekInput.Text = "Wednesday";
            }
            if (WednesdayReturns.ConfirmDay == "Wednesday")
            {
                restaurantInput.Text = WednesdayReturns.SetValueForRestaurant;
                dayOfWeekInput.Text = "Wednesday";
            }
            if (ThursdaysOrders.ConfirmDay == "Thursday")
            {
                restaurantInput.Text = ThursdaysOrders.SetValueForRestaurant;
                dayOfWeekInput.Text = "Thursday";
            }
            if (ThursdayReturns.ConfirmDay == "Thursday")
            {
                restaurantInput.Text = ThursdayReturns.SetValueForRestaurant;
                dayOfWeekInput.Text = "Thursday";
            }
            if (FridaysOrders.ConfirmDay == "Friday")
            {
                restaurantInput.Text = FridaysOrders.SetValueForRestaurant;
                dayOfWeekInput.Text = "Friday";
            }
            if (FridayReturns.ConfirmDay == "Friday")
            {
                restaurantInput.Text = FridayReturns.SetValueForRestaurant;
                dayOfWeekInput.Text = "Friday";
            }
            if (SaturdaysOrders.ConfirmDay == "Saturday")
            {
                restaurantInput.Text = SaturdaysOrders.SetValueForRestaurant;
                dayOfWeekInput.Text = "Saturday";
            }
            if (SaturdaysReturns.ConfirmDay == "Saturday")
            {
                restaurantInput.Text = SaturdaysReturns.SetValueForRestaurant;
                dayOfWeekInput.Text = "Saturday";
            }


        }
    }
}
