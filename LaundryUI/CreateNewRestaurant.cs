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

namespace LaundryUI
{
    public partial class CreateNewRestaurant : Form
    {
        public static string ConfirmDay = "";

        public CreateNewRestaurant()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ReturnToDay();
        }

        private void createButton_Click(object sender, EventArgs e)
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
                    notesValue.Text
                    );

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
                MessageBox.Show("The restaurant field must be completed" +
                           " before a new restaurant log can be created.");
            }
        }

        private bool ValidateForm()
        {
            if (restaurantValue.Text.Length == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        private void dayViewerForm_Load(object sender, EventArgs e)
        {
            if (SundayKitchenwear.ConfirmDay == "Sunday")
            {
                dayOfWeekInput.Text = "Sunday";
            }
            if (MondayKitchenwear.ConfirmDay == "Monday")
            {
                dayOfWeekInput.Text = "Monday";
            }
            if (TuesdayKitchenwear.ConfirmDay == "Tuesday")
            {
                dayOfWeekInput.Text = "Tuesday";
            }
            if (WednesdayKitchenwear.ConfirmDay == "Wednesday")
            {
                dayOfWeekInput.Text = "Wednesday";
            }
            if (ThursdayKitchenwear.ConfirmDay == "Thursday")
            {
                dayOfWeekInput.Text = "Thursday";
            }
            if (FridayKitchenwear.ConfirmDay == "Friday")
            {
                dayOfWeekInput.Text = "Friday";
            }
            if (FridayKitchenwear.ConfirmDay == "Friday")
            {
                dayOfWeekInput.Text = "Friday";
            }
            if (SaturdayKitchenwear.ConfirmDay == "Saturday")
            {
                dayOfWeekInput.Text = "Saturday";
            }

        }

        private void ReturnToDay()
        {
            if (SundayKitchenwear.ConfirmDay == "Sunday")
            {
                ConfirmDay = "Sunday";
                this.Hide();
                SundayKitchenwear day = new SundayKitchenwear();
                day.Show();
                this.Close();
            }
            if (MondayKitchenwear.ConfirmDay == "Monday")
            {
                ConfirmDay = "Monday";
                this.Hide();
                MondayKitchenwear day = new MondayKitchenwear();
                day.Show();
                this.Close();
            }
            if (TuesdayKitchenwear.ConfirmDay == "Tuesday")
            {
                ConfirmDay = "Tuesday";
                this.Hide();
                TuesdayKitchenwear day = new TuesdayKitchenwear();
                day.Show();
                this.Close();
            }
            if (WednesdayKitchenwear.ConfirmDay == "Wednesday")
            {
                ConfirmDay = "Wednesday";
                this.Hide();
                WednesdayKitchenwear day = new WednesdayKitchenwear();
                day.Show();
                this.Close();
            }
            if (ThursdayKitchenwear.ConfirmDay == "Thursday")
            {
                ConfirmDay = "Thursday";
                this.Hide();
                ThursdayKitchenwear day = new ThursdayKitchenwear();
                day.Show();
                this.Close();
            }
            if (FridayKitchenwear.ConfirmDay == "Friday")
            {
                ConfirmDay = "Friday";
                this.Hide();
                FridayKitchenwear day = new FridayKitchenwear();
                day.Show();
                this.Close();
            }
            if (SaturdayKitchenwear.ConfirmDay == "Saturday")
            {
                ConfirmDay = "Saturday";
                this.Hide();
                SaturdayKitchenwear day = new SaturdayKitchenwear();
                day.Show();
                this.Close();
            }
        }
    }
}