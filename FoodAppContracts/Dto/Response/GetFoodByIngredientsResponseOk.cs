using System;
using System.Collections.Generic;
using System.Text;

namespace FoodAppContracts.Dto.Response
{
    public class GetFoodByIngredientsResponseOk: GetFoodByCuisineResponse
    {
        public string[] Food { get; set; }
    }
}
