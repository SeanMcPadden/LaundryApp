using LaundryLibrary.DataAccess;
using LaundryLibrary.Models;
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
    public partial class Kitchenwear : Form
    {
        private string ConfirmDay = "";

        public Kitchenwear()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ReturnToDayAndCorrectForm();
        }

        private void submitKitchenwearFormButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                KitchenwearModel kitchenwear = new KitchenwearModel(
                      restaurantInput.Text,
                      jacketReturnValue.Text,
                      jacketSentValue.Text,
                      bibApronReturnValue.Text,
                      bibApronSentValue.Text,
                      kClothReturnValue.Text,
                      kClothSentValue.Text,
                      ovenClothValue.Text,
                      trouserBlackValue.Text,
                      polishClothValue.Text,
                      otherValue.Text,
                      dayOfWeekInput.Text);

                GlobalConfig.Connection.CreateKitchenwear(kitchenwear);

                ReturnToDayAndCorrectForm();

                //This section was only needed if we had kitchenwear being returned on this form.

                //if (SundayKitchenwear.ConfirmDay == "Sunday")
                //{
                //    GlobalConfig.Connection.CreateKitchenwear(kitchenwear);
                //}
                //if (MondayKitchenwear.ConfirmDay == "Monday")
                //{
                //    GlobalConfig.Connection.CreateKitchenwear(kitchenwear);
                //}
                //if (TuesdayKitchenwear.ConfirmDay == "Tuesday")
                //{
                //    GlobalConfig.Connection.CreateKitchenwear(kitchenwear);
                //}
                //if (WednesdayKitchenwear.ConfirmDay == "Wednesday")
                //{
                //    GlobalConfig.Connection.CreateKitchenwear(kitchenwear);
                //}
                //if (SundayKitchenwear.ConfirmDay == "Sunday")
                //{
                //    GlobalConfig.Connection.CreateKitchenwear(kitchenwear);
                //}
                //if (MondayKitchenwear.ConfirmDay == "Monday")
                //{
                //    GlobalConfig.Connection.CreateKitchenwear(kitchenwear);
                //}
                //if (SundayKitchenwear.ConfirmDay == "Sunday")
                //{
                //    GlobalConfig.Connection.CreateKitchenwear(kitchenwear);
                //}
                //if (MondayKitchenwear.ConfirmDay == "Monday")
                //{
                //    GlobalConfig.Connection.CreateKitchenwear(kitchenwear);
                //}
            }
            else
            {
                MessageBox.Show("All fields must be complete.");
            }
        }

        private bool ValidateForm()
        {
            if(jacketReturnValue.Text == null)
            {
                return false;
            }
            if(jacketSentValue.Text == null)
            {
                return false;
            }
            if(bibApronReturnValue.Text == null)
            {
                return false;
            }
            if(bibApronSentValue.Text == null)
            {
                return false;
            }
            if(kClothReturnValue.Text == null)
            {
                return false;
            }
            if(kClothSentValue.Text == null)
            {
                return false;
            }
            if(ovenClothValue.Text == null)
            {
                return false;
            }
            if(trouserBlackValue.Text == null)
            {
                return false;
            }
            if(polishClothValue.Text == null)
            {
                return false;
            }
            if(otherValue.Text == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Kitchenwear_Load(object sender, EventArgs e)
        {
            if (SundayKitchenwear.ConfirmDay == "Sunday")
            {
                restaurantInput.Text = SundayKitchenwear.SetValueForRestaurant;
                dayOfWeekInput.Text = "Sunday";
            }
            if (MondayKitchenwear.ConfirmDay == "Monday")
            {
                restaurantInput.Text = MondayKitchenwear.SetValueForRestaurant;
                dayOfWeekInput.Text = "Monday";
            }
            if (TuesdayKitchenwear.ConfirmDay == "Tuesday")
            {
                restaurantInput.Text = TuesdayKitchenwear.SetValueForRestaurant;
                dayOfWeekInput.Text = "Tuesday";
            }
            if (WednesdayKitchenwear.ConfirmDay == "Wednesday")
            {
                restaurantInput.Text = WednesdayKitchenwear.SetValueForRestaurant;
                dayOfWeekInput.Text = "Wednesday";
            }
            if (ThursdayKitchenwear.ConfirmDay == "Thursday")
            {
                restaurantInput.Text = ThursdayKitchenwear.SetValueForRestaurant;
                dayOfWeekInput.Text = "Thursday";
            }
            if (FridayKitchenwear.ConfirmDay == "Friday")
            {
                restaurantInput.Text = FridayKitchenwear.SetValueForRestaurant;
                dayOfWeekInput.Text = "Friday";
            }
            if (SaturdayKitchenwear.ConfirmDay == "Saturday")
            {
                restaurantInput.Text = SaturdayKitchenwear.SetValueForRestaurant;
                dayOfWeekInput.Text = "Saturday";
            }

        }

        private bool ReturnToDayAndCorrectForm()
        {
            if (SundayKitchenwear.ConfirmDay == "Sunday")
            {
                ConfirmDay = "";
                this.Hide();
                SundayKitchenwear day = new SundayKitchenwear();
                day.Show();
                this.Close();

                return true;
            }
            if (MondayKitchenwear.ConfirmDay == "Monday")
            {
                ConfirmDay = "";
                this.Hide();
                MondayKitchenwear day = new MondayKitchenwear();
                day.Show();
                this.Close();

                return true;
            }
            if (TuesdayKitchenwear.ConfirmDay == "Tuesday")
            {
                ConfirmDay = "";
                this.Hide();
                TuesdayKitchenwear day = new TuesdayKitchenwear();
                day.Show();
                this.Close();

                return true;
            }
            if (WednesdayKitchenwear.ConfirmDay == "Wednesday")
            {
                ConfirmDay = "";
                this.Hide();
                WednesdayKitchenwear day = new WednesdayKitchenwear();
                day.Show();
                this.Close();

                return true;
            }
            if (ThursdayKitchenwear.ConfirmDay == "Thursday")
            {
                ConfirmDay = "";
                this.Hide();
                ThursdayKitchenwear day = new ThursdayKitchenwear();
                day.Show();
                this.Close();

                return true;
            }
            if (FridayKitchenwear.ConfirmDay == "Friday")
            {
                ConfirmDay = "";
                this.Hide();
                FridayKitchenwear day = new FridayKitchenwear();
                day.Show();
                this.Close();

                return true;
            }
            if (SaturdayKitchenwear.ConfirmDay == "Saturday")
            {
                ConfirmDay = "";
                this.Hide();
                SaturdayKitchenwear day = new SaturdayKitchenwear();
                day.Show();
                this.Close();

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
