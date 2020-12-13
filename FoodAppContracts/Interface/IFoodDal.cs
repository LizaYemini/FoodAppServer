using System.Data;
using FoodAppContracts.Dto.Request;

namespace FoodAppContracts.Interface
{
    public interface IFoodDal
    {
        public DataSet GetAllCuisines(GetAllCuisinesRequest request);

        public DataSet GetFoodByCuisineRequest(GetFoodByCuisineRequest request);
        public DataSet GetFoodByFoodsRequirements(GetFoodByFoodsRequirementsRequest request);

        public DataSet GetFoodByIngredient(GetFoodByIngredientRequest request);

        public DataSet GetIngredient(GetIngredientRequest request);

        public DataSet GetIngredientsByFoodId(GetIngredientsByFoodIdRequest request);
    }
}