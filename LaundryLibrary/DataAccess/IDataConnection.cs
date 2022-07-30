using LaundryLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryLibrary.DataAccess
{
    public interface IDataConnection
    {
        DayModel CreateDay(DayModel day);

        ClothModel CreateCloth (ClothModel cloth);

        ClothModel CreateClothReturn (ClothModel cloth);

        KitchenwearModel CreateKitchenwear(KitchenwearModel kitchenwear);

        List<DayModel> GetDay_All();

        List<DayModel> GetDay_Sunday();

        List<DayModel> GetDay_Monday();

        List<DayModel> GetDay_Tuesday();

        List<DayModel> GetDay_Wednesday();

        List<DayModel> GetDay_Thursday();

        List<DayModel> GetDay_Friday();

        List<DayModel> GetDay_Saturday();

        List<ClothModel> GetCloth_All();

        List<ClothModel> GetCloth_GetByWeek();

        List<ClothModel> GetCloth_GetSunday();

        List<ClothModel> GetCloth_GetMonday();

        List<ClothModel> GetCloth_GetTuesday();

        List<ClothModel> GetCloth_GetWednesday();

        List<ClothModel> GetCloth_GetThursday();

        List<ClothModel> GetCloth_GetFriday();

        List<ClothModel> GetCloth_GetSaturday();

        List<ClothModel> GetClothReturn_GetByWeek();

        List<ClothModel> GetClothReturn_GetSunday();

        List<ClothModel> GetClothReturn_GetMonday();

        List<ClothModel> GetClothReturn_GetTuesday();

        List<ClothModel> GetClothReturn_GetWednesday();

        List<ClothModel> GetClothReturn_GetThursday();

        List<ClothModel> GetClothReturn_GetFriday();

        List<ClothModel> GetClothReturn_GetSaturday();

        List<KitchenwearModel> GetKitchenwear_GetByWeek();

        List<KitchenwearModel> GetKitchenwear_GetSunday();

        List<KitchenwearModel> GetKitchenwear_GetMonday();

        List<KitchenwearModel> GetKitchenwear_GetTuesday();

        List<KitchenwearModel> GetKitchenwear_GetWednesday();

        List<KitchenwearModel> GetKitchenwear_GetThursday();

        List<KitchenwearModel> GetKitchenwear_GetFriday();

        List<KitchenwearModel> GetKitchenwear_GetSaturday();

        //ClothModel ClothStatistics (ClothModel statistics);

        //List<ClothModel> GetOrdersByRestaurant();
    }
}
