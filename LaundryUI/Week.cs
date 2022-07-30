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
    public partial class Week : Form
    {
        public static string ChosenDay = "";

        public Week()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChosenDay = "Wednesday";
            GoToClothOrKitchenwearWithOOR();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChosenDay = "Monday";
            GoToClothOrKitchenwearWithOOR();
            //this.Hide();
            //ClothOrKitchenwear monday = new ClothOrKitchenwear();
            //monday.ShowDialog();
            //this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Back Button
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
            this.Close();
        }

        private bool GoToClothOrKitchenwearWithOOR()
        {
            if (Home.OrderOrReturn == "Order")
            {
                Home.OrderOrReturn = "Order";
                this.Hide();
                ClothOrKitchenwear cOK = new ClothOrKitchenwear();
                cOK.ShowDialog();
                this.Close();

                return true;
            }
            if (Home.OrderOrReturn == "Return")
            {
                Home.OrderOrReturn = "Return";
                this.Hide();
                ClothOrKitchenwear cOK = new ClothOrKitchenwear();
                cOK.ShowDialog();
                this.Close();

                return true;
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChosenDay = "Sunday";
            GoToClothOrKitchenwearWithOOR();
        }

        private void tuesdayButton_Click(object sender, EventArgs e)
        {
            ChosenDay = "Tuesday";
            GoToClothOrKitchenwearWithOOR();
        }

        private void thursdayButton_Click(object sender, EventArgs e)
        {
            ChosenDay = "Thursday";
            GoToClothOrKitchenwearWithOOR();
        }

        private void fridayButton_Click(object sender, EventArgs e)
        {
            ChosenDay = "Friday";
            GoToClothOrKitchenwearWithOOR();
        }

        private void saturdayButton_Click(object sender, EventArgs e)
        {
            ChosenDay = "Saturday";
            GoToClothOrKitchenwearWithOOR();
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
