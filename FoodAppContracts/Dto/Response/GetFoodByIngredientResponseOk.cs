namespace FoodAppContracts.Dto.Response
{
    public class GetFoodByIngredientResponseOk: GetFoodByIngredientResponse
    {
        public string[] Food { get; set; }
    }
}