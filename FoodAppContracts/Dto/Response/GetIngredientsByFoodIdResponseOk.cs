namespace FoodAppContracts.Dto.Response
{
    public class GetIngredientsByFoodIdResponseOk: GetIngredientsByFoodIdResponse
    {
        public string[] Ingredients { get; set; }
    }
}