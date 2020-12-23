using FoodAppContracts.Dto.Request;

namespace FoodAppContracts.Dto.Response
{
    public class GetFoodByMaxIngredientResponseOk: GetFoodByMaxIngredientResponse
    {
        public string[] Food { get; set; }
    }
}