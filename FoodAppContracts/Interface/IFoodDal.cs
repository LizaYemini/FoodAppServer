using System.Data;
using FoodAppContracts.Dto.Request;

namespace FoodAppContracts.Interface
{
    public interface IFoodDal
    {
        public DataSet GetAllCuisines(GetAllCuisinesRequest request);
        public DataSet GetAllCourses(GetAllCoursesRequest request);

        public DataSet GetFoodByCuisine(GetFoodByCuisineRequest request);
        public DataSet GetFoodByFoodsRequirements(GetFoodByFoodsRequirementsRequest request);

        public DataSet GetFoodByIngredient(GetFoodByIngredientRequest request);

        public DataSet GetIngredient(GetIngredientRequest request);

        public DataSet GetIngredientsByFoodId(GetIngredientsByFoodIdRequest request);

        public DataSet GetFoodWithoutIngredient(GetFoodWithoutIngredientRequest request);

        public DataSet GetFoodByMaxIngredient(GetFoodByMaxIngredientRequest request);

        public DataSet GetCuisineByIngredient(GetCuisineByIngredientRequest request);

        public DataSet GetFoodByIngredients(GetFoodByIngredientsRequest request);

        public DataSet GetFoods(string cuisine, string ingredients, string withOutIngredients, string course,
            double maxTime, int rating, int maxIngredients);

        public DataSet GetFoodByFoodId(int id);
        public DataSet GetCoursesByFoodId(int id);
        public DataSet GetCuisinesByFoodId(int id);
        public DataSet GetImageByFoodId(int id);
    }
}