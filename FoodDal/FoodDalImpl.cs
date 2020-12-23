using System;
using System.Data;
using DIContracts;
using FoodAppContracts.Dto.Request;
using FoodAppContracts.Interface;
using InfraContracts.Interfaces;
using MySql.Data.MySqlClient;
using Oracle.ManagedDataAccess.Client;

namespace FoodDal
{
    [Register(Policy.Transient, typeof(IFoodDal))]
    public class FoodDalImpl : IFoodDal
    {
        private readonly MySqlConnection _conn;
        private readonly IInfraDal _infraDal;

        public FoodDalImpl(IInfraDal infraDal, IConnectionString connectionString)
        {
            _infraDal = infraDal;
            var strConn = connectionString.ConnectionString;
            _conn = new MySqlConnection(strConn);
        }
        public DataSet GetAllCuisines(GetAllCuisinesRequest request)
        {
            var cmd = new MySqlCommand
            {
                Connection = _conn,
                CommandText = "getAllCuisines"
            };
            return _infraDal.ExecSpQuery(cmd);
        }

        public DataSet GetFoodByCuisine(GetFoodByCuisineRequest request)
        {
            var cmd = new MySqlCommand
            {
                Connection = _conn,
                CommandText = "getFoodByCuisine"
            };
            var param = _infraDal.GetParameter("p_cuisine", MySqlDbType.VarChar, request.Cuisine);
            cmd.Parameters.Add(param);
            return _infraDal.ExecSpQuery(cmd);
        }

        public DataSet GetFoodByFoodsRequirements(GetFoodByFoodsRequirementsRequest request)
        {
            var cmd = new MySqlCommand
            {
                Connection = _conn,
                CommandText = "getFoodByFoodsRequirements"
            };
            var param1 = _infraDal.GetParameter("p_time", MySqlDbType.VarChar, request.Time);
            var param2 = _infraDal.GetParameter("p_rating", MySqlDbType.Int32, request.Rating);
            var param3 = _infraDal.GetParameter("p_course", MySqlDbType.VarChar, request.Course);
            cmd.Parameters.Add(param1);
            cmd.Parameters.Add(param2);
            cmd.Parameters.Add(param3);
            return _infraDal.ExecSpQuery(cmd);
        }

        public DataSet GetFoodByIngredient(GetFoodByIngredientRequest request)
        {
            var cmd = new MySqlCommand
            {
                Connection = _conn,
                CommandText = "getFoodByIngredient"
            };
            var param = _infraDal.GetParameter("p_ingredient", MySqlDbType.VarChar, request.Ingredient);
            cmd.Parameters.Add(param);
            return _infraDal.ExecSpQuery(cmd);
        }

        public DataSet GetIngredient(GetIngredientRequest request)
        {
            var cmd = new MySqlCommand
            {
                Connection = _conn,
                CommandText = "getIngredient"
            };
            var param = _infraDal.GetParameter("p_ingredient", MySqlDbType.VarChar, request.Ingredient);
            cmd.Parameters.Add(param);
            return _infraDal.ExecSpQuery(cmd);
        }

        public DataSet GetIngredientsByFoodId(GetIngredientsByFoodIdRequest request)
        {
            var cmd = new MySqlCommand
            {
                Connection = _conn,
                CommandText = "getIngredientsByFoodId"
            };
            var param = _infraDal.GetParameter("p_id", MySqlDbType.Int32, request.Id);
            cmd.Parameters.Add(param);
            return _infraDal.ExecSpQuery(cmd);
        }
    }
}
