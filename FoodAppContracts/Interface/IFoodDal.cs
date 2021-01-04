using System.Data;
using FoodAppContracts.Dto.Request;

namespace FoodAppContracts.Interface
{
    public interface IFoodDal
    {
        public DataSet GetAllCuisines(GetAllCuisinesRequest request);

        public DataSet GetFoodByCuisine(GetFoodByCuisineRequest request);
        public DataSet GetFoodByFoodsRequirements(GetFoodByFoodsRequirementsRequest request);

        public DataSet GetFoodByIngredient(GetFoodByIngredientRequest request);

        public DataSet GetIngredient(GetIngredientRequest request);

        public DataSet GetIngredientsByFoodId(GetIngredientsByFoodIdRequest request);

        public DataSet GetFoodWithoutIngredient(GetFoodWithoutIngredientRequest request);

        public DataSet GetFoodByMaxIngredient(GetFoodByMaxIngredientRequest request);

        public DataSet GetCuisineByIngredient(GetCuisineByIngredientRequest request);

        public DataSet GetFoodByIngredients(GetFoodByIngredientsRequest request);
    }
}