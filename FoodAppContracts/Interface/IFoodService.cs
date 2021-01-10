using System.Collections.Generic;
using System.Data;
using FoodAppContracts.Dto;
using FoodAppContracts.Dto.Request;
using FoodAppContracts.Dto.Response;
using InfraContracts.DTO;

namespace FoodAppContracts.Interface
{
    public interface IFoodService
    {
        public Response GetAllCuisines(GetAllCuisinesRequest request);

        public Response GetFoodByCuisine(GetFoodByCuisineRequest request);
        public Response GetFoodByFoodsRequirements(GetFoodByFoodsRequirementsRequest request);

        public Response GetFoodByIngredient(GetFoodByIngredientRequest request);

        public Response GetIngredient(GetIngredientRequest request);

        public Response GetIngredientsByFoodId(GetIngredientsByFoodIdRequest request);

        public Response GetFoodWithoutIngredient(GetFoodWithoutIngredientRequest request);

        public Response GetFoodByMaxIngredient(GetFoodByMaxIngredientRequest request);

        public Response GetCuisineByIngredient(GetCuisineByIngredientRequest request);
        public Response GetFoodByIngredients(GetFoodByIngredientsRequest request);
        public Response GetFoods(GetFoodsRequest request);
        public FoodDto GetFoodByFoodId(int id);
        public List<string> GetCoursesByFoodId(int id);
        public List<string> GetCuisinesByFoodId(int id);
        public string GetImageByFoodId(int id);
        public List<string> GetIngredientsByFoodId(int id);
    }
}