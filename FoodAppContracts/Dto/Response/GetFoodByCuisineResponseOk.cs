namespace FoodAppContracts.Dto.Response
{
    public class GetFoodByCuisineResponseOk : GetFoodByCuisineResponse
    {
        public string[] Food { get; set; }
    }
}