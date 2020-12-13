namespace FoodAppContracts.Dto.Response
{
    public class GetIngredientsByFoodIdResponseOk: GetIngredientsByFoodIDResponse
    {
        public string[] Ingredients { get; set; }
    }
}