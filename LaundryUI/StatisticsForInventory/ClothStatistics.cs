using Dapper;
using LaundryLibrary.DataAccess;
using LaundryLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using MailKit.Security;

namespace LaundryUI.Inventory
{
    public partial class ClothStatistics : Form
    {

        public ClothStatistics()
        {
            InitializeComponent();
        }

        public List<ClothModel> GetClothForCurrentWeek()
        {
            List<ClothModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Laundry")))
            {
                output = connection.Query<ClothModel>
                    ("SELECT SUM(NapkinBrown) AS NapkinBrown, SUM(White) AS White, " +
                     "SUM(Brown54) AS Brown54, SUM(Brown70) AS Brown70, SUM(BarCloth) AS BarCloth FROM Cloth WHERE " +
                     "DATEPART(wk, DateTime) = DATEPART(wk, GETDATE())").ToList();
            }

            return output;
        }

        public List<ClothModel> GetClothForPreviousWeek()
        {
            List<ClothModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Laundry")))
            {

                output = connection.Query<ClothModel>
                   ("").ToList();
                   ("SELECT SUM(NapkinBrown) AS NapkinBrown, SUM(White) AS White, " +
                    "SUM(Brown54) AS Brown54, SUM(Brown70) AS Brown70, SUM(BarCloth) AS BarCloth FROM Cloth WHERE " +
                    "DATEPART(wk, DateTime) = DATEPART(wk, GETDATE())").ToList();
            }

            return output;
            
        }


        private void ClothStatistics_Load(object sender, EventArgs e)
        {
            List<ClothModel> clothStats = GetClothForCurrentWeek();

            clothStatisticsDataGridView.DataSource = clothStats;

            List<ClothModel> cloth = GetClothForPreviousWeek();

            previousWeekDataGridView.DataSource = cloth;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            InventoryAndAdmin iaa = new InventoryAndAdmin();
            iaa.ShowDialog();
            this.Close();
        }

        private void sendEmailButton_Click(object sender, EventArgs e)
        {

            MimeMessage message = new MimeMessage();
            message.From.Add(new MailboxAddress("Tester", "devseanmcpadden@hotmail.com"));
            message.To.Add(MailboxAddress.Parse("seanmcpadden@hotmail.com"));
            message.Subject = "Wuuf!";
            message.Body = new TextPart("plain")
            {
                Text = @"Yes, Hello! This is dog!"
            };
            SmtpClient client = new SmtpClient();
            client.Connect("smtp.mail.yahoo.com", 587, SecureSocketOptions.StartTls);
            client.Authenticate("devseanmcpadden@yahoo.com", "Thispasswordisreallysecure");
            client.Send(message);
            client.Disconnect(true);
            client.Dispose();
        }
    }
}
