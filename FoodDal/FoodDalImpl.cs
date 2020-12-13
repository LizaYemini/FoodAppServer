using System;
using System.Data;
using DIContracts;
using FoodAppContracts.Dto.Request;
using FoodAppContracts.Interface;
using InfraContracts.Interfaces;
using Oracle.ManagedDataAccess.Client;

namespace FoodDal
{
    [Register(Policy.Transient, typeof(IFoodDal))]
    public class FoodDalImpl : IFoodDal
    {
        private readonly OracleConnection _conn;
        private readonly IInfraDal _infraDal;

        public FoodDalImpl(IInfraDal infraDal, IConnectionString connectionString)
        {
            _infraDal = infraDal;
            var strConn = connectionString.ConnectionString;
            _conn = new OracleConnection(strConn);
        }
        public DataSet GetAllCuisines(GetAllCuisinesRequest request)
        {
            throw new NotImplementedException();
        }

        public DataSet GetFoodByCuisineRequest(GetFoodByCuisineRequest request)
        {
            throw new NotImplementedException();
        }

        public DataSet GetFoodByFoodsRequirements(GetFoodByFoodsRequirementsRequest request)
        {
            throw new NotImplementedException();
        }

        public DataSet GetFoodByIngredient(GetFoodByIngredientRequest request)
        {
            throw new NotImplementedException();
        }

        public DataSet GetIngredient(GetIngredientRequest request)
        {
            throw new NotImplementedException();
        }

        public DataSet GetIngredientsByFoodId(GetIngredientsByFoodIdRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
