using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryLibrary.Models
{
    public class ClothModel
    {
        public DateTime DateTime { get; set; }

        public int Id { get; set; }

        public string? Restaurant { get; set; }

        public string? DayOfWeek { get; set; }

        //public string? IronedDate { get; set; }

        public int NapkinBrown { get; set; }

        public int White { get; set; }

        public int Brown54 { get; set; }

        public int Brown70 { get; set; }

        public int BarCloth { get; set; }

        public int CurrentWeek { get; set; }

        public int WeekNumber { get; set; }

        public ClothModel()
        {

        }

        public ClothModel(
            string restaurant,
            string napkinBrown, 
            string white, 
            string brown54, 
            string brown70, 
            string barCloth,
            string dayOfWeek)
            //string ironedDate,
            //string restaurant)
        {
            int napkinBrownValue = 0;
            int.TryParse(napkinBrown, out napkinBrownValue);
            NapkinBrown = napkinBrownValue;

            int whiteValue = 0;
            int.TryParse(white, out whiteValue);
            White = whiteValue;

            int brown54Value = 0;
            int.TryParse(brown54, out brown54Value);
            Brown54 = brown54Value;

            int brown70Value = 0;
            int.TryParse(brown70, out brown70Value);
            Brown70 = brown70Value;

            int barClothValue = 0;
            int.TryParse(barCloth, out barClothValue);
            BarCloth = barClothValue;

            //IronedDate = ironedDate;

            Restaurant = restaurant;

            DayOfWeek = dayOfWeek;
        }
    }
}
