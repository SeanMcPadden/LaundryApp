using LaundryUI.Inventory;
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
    public partial class InventoryAndAdmin : Form
    {
        public InventoryAndAdmin()
        {
            InitializeComponent();
        }

        private void clothStatisticsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClothStatistics stats = new ClothStatistics();
            stats.ShowDialog();
            this.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
            this.Close();
        }
    }
}
