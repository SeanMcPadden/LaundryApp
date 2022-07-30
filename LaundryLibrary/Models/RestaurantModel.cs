using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryLibrary.Models
{
    public class RestaurantModel
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Address { get; set; }

        public string? DeliveryDay { get; set; }

        public string? BagColour { get; set; }

        public string? RackingNumber { get; set; }

        public string? DispatchLocation { get; set; }

        public string? DayOfWeek { get; set; }


    }
}
