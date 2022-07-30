using Dapper;
using LaundryLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LaundryLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        public string setValueForRestaurant = "";

        private const string db = "Laundry";

        public ClothModel CreateCloth(ClothModel cloth)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {

                var c = new DynamicParameters();
                c.Add("@Restaurant", cloth.Restaurant);
                //c.Add("@ironedDate", cloth.IronedDate);
                c.Add("@napkinBrown", cloth.NapkinBrown);
                c.Add("@white", cloth.White);
                c.Add("@brown54", cloth.Brown54);
                c.Add("@brown70", cloth.Brown70);
                c.Add("@barCloth", cloth.BarCloth);
                c.Add("@DayOfWeek", cloth.DayOfWeek);
                c.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spCloth_Insert", c, commandType: CommandType.StoredProcedure);

                cloth.Id = c.Get<int>("@Id");

                return cloth;
            }



        }

        public DayModel CreateDay(DayModel day)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Restaurant", day.Restaurant);
                p.Add("@BagColour", day.BagColour);
                p.Add("@Location", day.Location);
                p.Add("@DayOfWeek", day.DayOfWeek);
                p.Add("@Address", day.Address);
                p.Add("@Driver", day.Driver);
                p.Add("@Notes", day.Notes);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spDays", p, commandType: CommandType.StoredProcedure);

                day.Id = p.Get<int>("@Id");

                return day;
            }
        }

        public List<DayModel> GetDay_All()
        {
            List<DayModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<DayModel>("dbo.spDay_GetAll").ToList();
            }

            return output;
        }

        public List<ClothModel> GetCloth_All()
        {
            List<ClothModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<ClothModel>("dbo.spCloth_GetAll").ToList();
            }

            return output;
        }

        public List<ClothModel> GetCloth_GetByWeek()
        {
            List<ClothModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<ClothModel>("dbo.spCloth_GetByWeek").ToList();
            }

            return output;
        }

        public KitchenwearModel CreateKitchenwear(KitchenwearModel kitchenwear)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {

                var c = new DynamicParameters();
                c.Add("@Restaurant", kitchenwear.Restaurant);
                c.Add("@JacketReturn", kitchenwear.JacketReturn);
                c.Add("@JacketSent", kitchenwear.JacketSent);
                c.Add("@BibApronReturn", kitchenwear.BibApronReturn);
                c.Add("@BibApronSent", kitchenwear.BibApronSent);
                c.Add("@KClothReturn", kitchenwear.KClothReturn);
                c.Add("@KClothSent", kitchenwear.KClothSent);
                c.Add("@OvenCloth", kitchenwear.OvenCloth);
                c.Add("@TrouserBlack", kitchenwear.TrouserBlack);
                c.Add("@PolishCloth", kitchenwear.PolishCloth);
                c.Add("@Other", kitchenwear.Other);
                c.Add("@DayOfWeek", kitchenwear.DayOfWeek);
                c.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spKitchenwear_Insert", c, commandType: CommandType.StoredProcedure);

                kitchenwear.Id = c.Get<int>("@Id");

                return kitchenwear;
            }

        }

        public List<KitchenwearModel> GetKitchenwear_GetByWeek()
        {
            List<KitchenwearModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<KitchenwearModel>("dbo.spKitchenwear_GetByWeek").ToList();
            }

            return output;
        }

        public ClothModel CreateClothReturn(ClothModel cloth)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {

                var c = new DynamicParameters();
                c.Add("@Restaurant", cloth.Restaurant);
                c.Add("@DayOfWeek", cloth.DayOfWeek);
                //c.Add("@ironedDate", cloth.IronedDate);
                c.Add("@napkinBrown", cloth.NapkinBrown);
                c.Add("@white", cloth.White);
                c.Add("@brown54", cloth.Brown54);
                c.Add("@brown70", cloth.Brown70);
                c.Add("@barCloth", cloth.BarCloth);
                c.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spClothReturn_Insert", c, commandType: CommandType.StoredProcedure);

                cloth.Id = c.Get<int>("@Id");

                return cloth;
            }
        }

        public List<ClothModel> GetClothReturn_GetByWeek()
        {
            List<ClothModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<ClothModel>("dbo.spClothReturn_GetByWeek").ToList();
            }

            return output;
        }

        public List<ClothModel> GetCloth_GetSunday()
        {
            List<ClothModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<ClothModel>("dbo.spCloth_GetSunday").ToList();
            }

            return output;
        }

        public List<ClothModel> GetCloth_GetMonday()
        {
            List<ClothModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<ClothModel>("dbo.spCloth_GetMonday").ToList();
            }

            return output;
        }

        public List<ClothModel> GetClothReturn_GetSunday()
        {
            List<ClothModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<ClothModel>("dbo.spClothReturn_GetSunday").ToList();
            }

            return output;
        }

        public List<ClothModel> GetClothReturn_GetMonday()
        {
            List<ClothModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<ClothModel>("dbo.spClothReturn_GetMonday").ToList();
            }

            return output;
        }

        public List<DayModel> GetDay_Sunday()
        {
            List<DayModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<DayModel>("dbo.spDay_GetSunday").ToList();
            }

            return output;
        }

        public List<DayModel> GetDay_Monday()
        {
            List<DayModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<DayModel>("dbo.spDay_GetMonday").ToList();
            }

            return output;
        }

        public List<DayModel> GetDay_Tuesday()
        {
            List<DayModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<DayModel>("dbo.spDay_GetTuesday").ToList();
            }

            return output;
        }

        public List<DayModel> GetDay_Wednesday()
        {
            List<DayModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<DayModel>("dbo.spDay_GetWednesday").ToList();
            }

            return output;
        }

        public List<DayModel> GetDay_Thursday()
        {
            List<DayModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<DayModel>("dbo.spDay_GetThursday").ToList();
            }

            return output;
        }

        public List<DayModel> GetDay_Friday()
        {
            List<DayModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<DayModel>("dbo.spDay_GetFriday").ToList();
            }

            return output;
        }

        public List<DayModel> GetDay_Saturday()
        {
            List<DayModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<DayModel>("dbo.spDay_GetSaturday").ToList();
            }

            return output;
        }

        public List<ClothModel> GetCloth_GetTuesday()
        {
            List<ClothModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<ClothModel>("dbo.spCloth_GetTuesday").ToList();
            }

            return output;
        }

        public List<ClothModel> GetCloth_GetWednesday()
        {
            List<ClothModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<ClothModel>("dbo.spCloth_GetWednesday").ToList();
            }

            return output;
        }

        public List<ClothModel> GetCloth_GetThursday()
        {
            List<ClothModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<ClothModel>("dbo.spCloth_GetThursday").ToList();
            }

            return output;
        }

        public List<ClothModel> GetCloth_GetFriday()
        {
            List<ClothModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<ClothModel>("dbo.spCloth_GetFriday").ToList();
            }

            return output;
        }

        public List<ClothModel> GetCloth_GetSaturday()
        {
            List<ClothModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<ClothModel>("dbo.spCloth_GetSaturday").ToList();
            }

            return output;
        }

        public List<ClothModel> GetClothReturn_GetTuesday()
        {
            List<ClothModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<ClothModel>("dbo.spClothReturn_GetTuesday").ToList();
            }

            return output;
        }

        public List<ClothModel> GetClothReturn_GetWednesday()
        {
            List<ClothModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<ClothModel>("dbo.spClothReturn_GetWednesday").ToList();
            }

            return output;
        }

        public List<ClothModel> GetClothReturn_GetThursday()
        {
            List<ClothModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<ClothModel>("dbo.spClothReturn_GetThursday").ToList();
            }

            return output;
        }

        public List<ClothModel> GetClothReturn_GetFriday()
        {
            List<ClothModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<ClothModel>("dbo.spClothReturn_GetFriday").ToList();
            }

            return output;
        }

        public List<ClothModel> GetClothReturn_GetSaturday()
        {
            List<ClothModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<ClothModel>("dbo.spClothReturn_GetSaturday").ToList();
            }

            return output;
        }

        public List<KitchenwearModel> GetKitchenwear_GetSunday()
        {
            List<KitchenwearModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<KitchenwearModel>("dbo.spKitchenwear_GetSunday").ToList();
            }

            return output;
        }

        public List<KitchenwearModel> GetKitchenwear_GetMonday()
        {
            List<KitchenwearModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<KitchenwearModel>("dbo.spKitchenwear_GetMonday").ToList();
            }

            return output;
        }

        public List<KitchenwearModel> GetKitchenwear_GetTuesday()
        {
            List<KitchenwearModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<KitchenwearModel>("dbo.spKitchenwear_GetTuesday").ToList();
            }

            return output;
        }

        public List<KitchenwearModel> GetKitchenwear_GetWednesday()
        {
            List<KitchenwearModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<KitchenwearModel>("dbo.spKitchenwear_GetWednesday").ToList();
            }

            return output;
        }

        public List<KitchenwearModel> GetKitchenwear_GetThursday()
        {
            List<KitchenwearModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<KitchenwearModel>("dbo.spKitchenwear_GetThursday").ToList();
            }

            return output;
        }

        public List<KitchenwearModel> GetKitchenwear_GetFriday()
        {
            List<KitchenwearModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<KitchenwearModel>("dbo.spKitchenwear_GetFriday").ToList();
            }

            return output;
        }

        public List<KitchenwearModel> GetKitchenwear_GetSaturday()
        {
            List<KitchenwearModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<KitchenwearModel>("dbo.spKitchenwear_GetSaturday").ToList();
            }

            return output;
        }
    }
}
