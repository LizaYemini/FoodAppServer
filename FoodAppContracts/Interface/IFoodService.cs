using System.Data;
using FoodAppContracts.Dto.Request;
using InfraContracts.DTO;

namespace FoodAppContracts.Interface
{
    public interface IFoodService
    {
        public Response GetAllCuisines(GetAllCuisinesRequest request);

        public Response GetFoodByCuisineRequest(GetFoodByCuisineRequest request);
        public Response GetFoodByFoodsRequirements(GetFoodByFoodsRequirementsRequest request);

        public Response GetFoodByIngredient(GetFoodByIngredientRequest request);

        public Response GetIngredient(GetIngredientRequest request);

        public Response GetIngredientsByFoodId(GetIngredientsByFoodIdRequest request);
    }
}