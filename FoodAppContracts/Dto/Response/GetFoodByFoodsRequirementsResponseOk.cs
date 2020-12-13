namespace FoodAppContracts.Dto.Response
{
    public class GetFoodByFoodsRequirementsResponseOk: GetFoodByCuisineResponse
    {
        public string[] Food { get; set; }
    }
}