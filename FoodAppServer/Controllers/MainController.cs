using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodAppContracts.Dto.Request;
using FoodAppContracts.Interface;
using InfraContracts.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodAppServer.Controllers
{
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly IFoodService _service;
        public MainController(IFoodService service)
        {
            _service = service;
        }

        [Route("api/Main/GetAllCuisines")]
        [HttpPost]
        public Response GetAllCuisines([FromBody] GetAllCuisinesRequest request)
        {
            var ret = _service.GetAllCuisines(request);
            return ret;
        }

        [Route("api/Main/GetFoodByCuisine")]
        [HttpPost]
        public Response GetFoodByCuisine([FromBody] GetFoodByCuisineRequest request)
        {
            var ret = _service.GetFoodByCuisine(request);
            return ret;
        }

        [Route("api/Main/GetFoodByFoodsRequirements")]
        [HttpPost]
        public Response GetFoodByFoodsRequirements([FromBody] GetFoodByFoodsRequirementsRequest request)
        {
            var ret = _service.GetFoodByFoodsRequirements(request);
            return ret;
        }

        [Route("api/Main/GetFoodByIngredient")]
        [HttpPost]
        public Response GetFoodByIngredient([FromBody] GetFoodByIngredientRequest request)
        {
            var ret = _service.GetFoodByIngredient(request);
            return ret;
        }

        [Route("api/Main/GetIngredient")]
        [HttpPost]
        public Response GetIngredient([FromBody] GetIngredientRequest request)
        {
            var ret = _service.GetIngredient(request);
            return ret;
        }

        [Route("api/Main/GetIngredientsByFoodId")]
        [HttpPost]
        public Response GetIngredientsByFoodId([FromBody] GetIngredientsByFoodIdRequest request)
        {
            var ret = _service.GetIngredientsByFoodId(request);
            return ret;
        }
    }
}
