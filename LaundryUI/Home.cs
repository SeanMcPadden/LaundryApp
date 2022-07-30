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
    public partial class Home : Form
    {
        public static string OrderOrReturn = "";

        public Home()
        {
            InitializeComponent();
        }

        private void ordersButton_Click(object sender, EventArgs e)
        {
            OrderOrReturn = "Order";
            this.Hide();
            Week week = new Week();
            week.ShowDialog();
            this.Close();
            
        }

        private void returnsButton_Click(object sender, EventArgs e)
        {
            OrderOrReturn = "Return";
            this.Hide();
            Week week = new Week();
            week.ShowDialog();
            this.Close();

        }

        private void analysisButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Analytics analysis = new Analytics();
            analysis.ShowDialog();
            this.Close();
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            InventoryAndAdmin iaa = new InventoryAndAdmin();
            iaa.ShowDialog();
            this.Close();
        }
    }
}
