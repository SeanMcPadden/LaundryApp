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
    public partial class ClothOrKitchenwear : Form
    {
        private static string ChosenCOK = "";

        public ClothOrKitchenwear()
        {
            InitializeComponent();
        }

        private void clothFormButton_Click(object sender, EventArgs e)
        {
            ChosenCOK = "Cloth";
            GoToDay();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Week week = new Week();
            week.ShowDialog();
            this.Close();
        }

        private void kitchenwearFormButton_Click(object sender, EventArgs e)
        {
            ChosenCOK = "Kitchenwear";
            GoToDay();
        }

        private bool GoToDay()
        {
            if (Home.OrderOrReturn == "Order")
            {

                if (Week.ChosenDay == "Sunday")
                {
                    if (ChosenCOK == "Cloth")
                    {
                        this.Hide();
                        SundaysOrders ordersForm = new SundaysOrders();
                        ordersForm.ShowDialog();
                        this.Close();
                    }
                    if (ChosenCOK == "Kitchenwear")
                    {
                        this.Hide();
                        SundayKitchenwear day = new SundayKitchenwear();
                        day.ShowDialog();
                        this.Close();
                    }

                    return true;
                }

                if (Week.ChosenDay == "Monday")
                {

                    if (ChosenCOK == "Cloth")
                    {
                        this.Hide();
                        MondaysOrders mondayCloth = new MondaysOrders();
                        mondayCloth.ShowDialog();
                        this.Close();
                    }
                    if (ChosenCOK == "Kitchenwear")
                    {
                        this.Hide();
                        MondayKitchenwear day = new MondayKitchenwear();
                        day.ShowDialog();
                        this.Close();
                    }
                }

                if (Week.ChosenDay == "Tuesday")
                {
                    if (ChosenCOK == "Cloth")
                    {
                        this.Hide();
                        TuesdaysOrders ordersForm = new TuesdaysOrders();
                        ordersForm.ShowDialog();
                        this.Close();
                    }
                    if (ChosenCOK == "Kitchenwear")
                    {
                        this.Hide();
                        TuesdayKitchenwear day = new TuesdayKitchenwear();
                        day.ShowDialog();
                        this.Close();
                    }

                    return true;
                }
                if (Week.ChosenDay == "Wednesday")
                {
                    if (ChosenCOK == "Cloth")
                    {
                        this.Hide();
                        WednesdaysOrders ordersForm = new WednesdaysOrders();
                        ordersForm.ShowDialog();
                        this.Close();
                    }
                    if (ChosenCOK == "Kitchenwear")
                    {
                        this.Hide();
                        WednesdayKitchenwear day = new WednesdayKitchenwear();
                        day.ShowDialog();
                        this.Close();
                    }

                    return true;
                }
                if (Week.ChosenDay == "Thursday")
                {
                    if (ChosenCOK == "Cloth")
                    {
                        this.Hide();
                        ThursdaysOrders ordersForm = new ThursdaysOrders();
                        ordersForm.ShowDialog();
                        this.Close();
                    }
                    if (ChosenCOK == "Kitchenwear")
                    {
                        this.Hide();
                        ThursdayKitchenwear day = new ThursdayKitchenwear();
                        day.ShowDialog();
                        this.Close();
                    }

                    return true;
                }
                if (Week.ChosenDay == "Friday")
                {
                    if (ChosenCOK == "Cloth")
                    {
                        this.Hide();
                        FridaysOrders ordersForm = new FridaysOrders();
                        ordersForm.ShowDialog();
                        this.Close();
                    }
                    if (ChosenCOK == "Kitchenwear")
                    {
                        this.Hide();
                        FridayKitchenwear day = new FridayKitchenwear();
                        day.ShowDialog();
                        this.Close();
                    }

                    return true;
                }
                if (Week.ChosenDay == "Saturday")
                {
                    if (ChosenCOK == "Cloth")
                    {
                        this.Hide();
                        SaturdaysOrders ordersForm = new SaturdaysOrders();
                        ordersForm.ShowDialog();
                        this.Close();
                    }
                    if (ChosenCOK == "Kitchenwear")
                    {
                        this.Hide();
                        SaturdayKitchenwear day = new SaturdayKitchenwear();
                        day.ShowDialog();
                        this.Close();
                    }

                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (Home.OrderOrReturn == "Return")
            {
                if (Week.ChosenDay == "Monday")
                {
                    if(ChosenCOK == "Cloth")
                    {
                        this.Hide();
                        MondayReturns mondayReturnsCloth = new MondayReturns();
                        mondayReturnsCloth.ShowDialog();
                        this.Close();
                    }
                    if (ChosenCOK == "Kitchenwear")
                    {
                        this.Hide();
                        MondaysKitchenwearReturns mondayK = new MondaysKitchenwearReturns();
                        mondayK.ShowDialog();
                        this.Close();
                    }
                    return true;
                }
                if (Week.ChosenDay == "Sunday")
                {
                    if(ChosenCOK == "Cloth")
                    {
                        this.Hide();
                        SundayReturns sundayReturnsCloth = new SundayReturns();
                        sundayReturnsCloth.ShowDialog();
                        this.Close();
                    }
                    if (ChosenCOK == "Kitchenwear")
                    {
                        this.Hide();
                        MondaysKitchenwearReturns mondayK = new MondaysKitchenwearReturns();
                        mondayK.ShowDialog();
                        this.Close();
                    }
                    return true;
                }
                if (Week.ChosenDay == "Tuesday")
                {
                    if (ChosenCOK == "Cloth")
                    {
                        this.Hide();
                        TuesdaysReturns returns = new TuesdaysReturns();
                        returns.ShowDialog();
                        this.Close();
                    }
                    if (ChosenCOK == "Kitchenwear")
                    {
                        this.Hide();
                        MondaysKitchenwearReturns mondayK = new MondaysKitchenwearReturns();
                        mondayK.ShowDialog();
                        this.Close();
                    }


                    return true;
                }
                if (Week.ChosenDay == "Wednesday")
                {
                    if (ChosenCOK == "Cloth")
                    {
                        this.Hide();
                        WednesdayReturns returns = new WednesdayReturns();
                        returns.ShowDialog();
                        this.Close();
                    }
                    if (ChosenCOK == "Kitchenwear")
                    {
                        this.Hide();
                        MondaysKitchenwearReturns mondayK = new MondaysKitchenwearReturns();
                        mondayK.ShowDialog();
                        this.Close();
                    }


                    return true;
                }
                if (Week.ChosenDay == "Thursday")
                {
                    if (ChosenCOK == "Cloth")
                    {
                        this.Hide();
                        ThursdayReturns returns = new ThursdayReturns();
                        returns.ShowDialog();
                        this.Close();
                    }
                    if (ChosenCOK == "Kitchenwear")
                    {
                        this.Hide();
                        MondaysKitchenwearReturns mondayK = new MondaysKitchenwearReturns();
                        mondayK.ShowDialog();
                        this.Close();
                    }


                    return true;
                }
                if (Week.ChosenDay == "Friday")
                {
                    if (ChosenCOK == "Cloth")
                    {
                        this.Hide();
                        FridayReturns returns = new FridayReturns();
                        returns.ShowDialog();
                        this.Close();
                    }
                    if (ChosenCOK == "Kitchenwear")
                    {
                        this.Hide();
                        MondaysKitchenwearReturns mondayK = new MondaysKitchenwearReturns();
                        mondayK.ShowDialog();
                        this.Close();
                    }


                    return true;
                }
                if (Week.ChosenDay == "Saturday")
                {
                    if (ChosenCOK == "Cloth")
                    {
                        this.Hide();
                        SaturdaysReturns returns = new SaturdaysReturns();
                        returns.ShowDialog();
                        this.Close();
                    }
                    if (ChosenCOK == "Kitchenwear")
                    {
                        this.Hide();
                        MondaysKitchenwearReturns mondayK = new MondaysKitchenwearReturns();
                        mondayK.ShowDialog();
                        this.Close();
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
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
