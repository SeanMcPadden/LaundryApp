using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryLibrary.Models
{
    public class KitchenwearModel
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public int JacketReturn { get; set; }

        public int JacketSent { get; set; }

        public int BibApronReturn { get; set; }

        public int BibApronSent { get; set; }

        public int KClothReturn { get; set; }

        public int KClothSent { get; set; }

        public int OvenCloth { get; set; }

        public int TrouserBlack { get; set; }

        public int PolishCloth { get; set; }

        public int Other { get; set; }

        public string Restaurant { get; set; }

        public int WeekNumber { get; set; }

        public int CurrentWeek { get; set; }

        public string DayOfWeek { get; set; }

        public KitchenwearModel()
        {

        }

        public KitchenwearModel(
            string restaurant,
            //string dateTime,
            string jacketReturn,
            string jacketSent,
            string bibApronReturn,
            string bibApronSent,
            string kClothReturn,
            string kClothSent,
            string ovenCloth,
            string trouserBlack,
            string polishCloth,
            string other,
            string dayOfWeek)
        {
            int jacketReturnValue = 0;
            int.TryParse(jacketReturn, out jacketReturnValue);
            JacketReturn = jacketReturnValue;

            int jacketSentValue = 0;
            int.TryParse(jacketSent, out jacketSentValue);
            JacketSent = jacketSentValue;

            int bibApronReturnValue = 0;
            int.TryParse(bibApronReturn, out bibApronReturnValue);
            BibApronReturn = bibApronReturnValue;

            int bibApronSentValue = 0;
            int.TryParse(bibApronSent, out bibApronSentValue);
            BibApronSent = bibApronSentValue;

            int kClothReturnValue = 0;
            int.TryParse(kClothReturn, out kClothReturnValue);
            KClothReturn = kClothReturnValue;

            int kClothSentValue = 0;
            int.TryParse(kClothSent, out kClothSentValue);
            KClothSent = kClothSentValue;

            int ovenClothValue = 0;
            int.TryParse(ovenCloth, out ovenClothValue);
            OvenCloth = ovenClothValue;

            int trouserBlackValue = 0;
            int.TryParse(trouserBlack, out trouserBlackValue);
            TrouserBlack = trouserBlackValue;

            int polishClothValue = 0;
            int.TryParse(polishCloth, out polishClothValue);
            PolishCloth = polishClothValue;

            int otherValue = 0;
            int.TryParse(other, out otherValue);
            Other = otherValue;

            Restaurant = restaurant;
            DayOfWeek = dayOfWeek;
        }


    }
}
