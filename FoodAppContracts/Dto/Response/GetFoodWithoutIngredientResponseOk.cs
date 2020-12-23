namespace FoodAppContracts.Dto.Response
{
    public class GetFoodWithoutIngredientResponseOk: GetFoodWithoutIngredientResponse
    {
        public string[] Food { get; set; }
    }
}