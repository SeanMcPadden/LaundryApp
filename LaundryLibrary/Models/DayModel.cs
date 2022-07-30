using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryLibrary.Models
{
    public class DayModel
    {
        public int Id { get; set; }

        public string? Restaurant { get; set; }

        public string? BagColour { get; set; }

        public string? Location { get; set; }

        public string? DayOfWeek { get; set; }

        public string? Address { get; set; }

        public string? Driver { get; set; }

        public string? Notes { get; set; }

        public List<DayModel> NotYetPlacedOrders { get; set; } = new List<DayModel>();

        public List<DayModel> PlacedOrders { get; set; } = new List<DayModel> ();

        public DayModel()
        {

        }

        public DayModel(string restaurant, 
                        string bagColour, 
                        string location, 
                        string dayOfWeek,
                        string address,
                        string driver,
                        string notes
                        )
        {
            Restaurant = restaurant;
            BagColour = bagColour;
            Location = location;
            DayOfWeek = dayOfWeek;
            Address = address;
            Driver = driver;
            Notes = notes;

        }
    }
}
