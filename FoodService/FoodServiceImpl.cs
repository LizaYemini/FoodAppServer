using DIContracts;
using FoodAppContracts.Dto.Request;
using FoodAppContracts.Dto.Response;
using FoodAppContracts.Interface;
using InfraContracts.DTO;
using System;
using System.Collections.Generic;

namespace FoodService
{
    [Register(Policy.Transient, typeof(IFoodService))]
    public class FoodServiceImpl : IFoodService
    {
        private readonly IFoodDal _dal;
        public FoodServiceImpl(IFoodDal dal)
        {
            _dal = dal;
        }
        public Response GetAllCuisines(GetAllCuisinesRequest request)
        {
            List<string> cuisinesList = new List<string>();

            try
            {
                var dataSet = _dal.GetAllCuisines(request);
                var table = dataSet.Tables[0];
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    string temp = table.Rows[i]["Cuisine"].ToString();
                    cuisinesList.Add(temp);
                }

                GetAllCuisinesResponse ret = new GetAllCuisinesResponseOk
                {
                    Cuisines = cuisinesList.ToArray()
                };

                return ret;
            }
            catch (Exception ex)
            {
                return new AppResponseError(ex.Message);
            }
        }

        public Response GetFoodByCuisine(GetFoodByCuisineRequest request)
        {
            List<string> foodList = new List<string>();

            try
            {
                var dataSet = _dal.GetFoodByCuisine(request);
                var table = dataSet.Tables[0];
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    string temp = table.Rows[i]["food_id"].ToString();
                    foodList.Add(temp);
                }

                GetFoodByCuisineResponse ret = new GetFoodByCuisineResponseOk
                {
                    Food = foodList.ToArray()
                };

                return ret;
            }
            catch (Exception ex)
            {
                return new AppResponseError(ex.Message);
            }
        }

        public Response GetFoodByFoodsRequirements(GetFoodByFoodsRequirementsRequest request)
        {
            List<string> foodList = new List<string>();

            try
            {
                var dataSet = _dal.GetFoodByFoodsRequirements(request);
                var table = dataSet.Tables[0];
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    string temp = table.Rows[i]["food_id"].ToString();
                    foodList.Add(temp);
                }

                GetFoodByFoodsRequirementsResponse ret = new GetFoodByFoodsRequirementsResponseOk
                {
                    Food = foodList.ToArray()
                };

                return ret;
            }
            catch (Exception ex)
            {
                return new AppResponseError(ex.Message);
            }
        }

        public Response GetFoodByIngredient(GetFoodByIngredientRequest request)
        {
            List<string> foodList = new List<string>();

            try
            {
                var dataSet = _dal.GetFoodByIngredient(request);
                var table = dataSet.Tables[0];
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    string temp = table.Rows[i]["food_id"].ToString();
                    foodList.Add(temp);
                }

                GetFoodByIngredientResponse ret = new GetFoodByIngredientResponseOk
                {
                    Food = foodList.ToArray()
                };

                return ret;
            }
            catch (Exception ex)
            {
                return new AppResponseError(ex.Message);
            }
        }

        public Response GetIngredient(GetIngredientRequest request)
        {
            List<string> ingredientList = new List<string>();

            try
            {
                var dataSet = _dal.GetIngredient(request);
                var table = dataSet.Tables[0];
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    string temp = table.Rows[i]["ingredient"].ToString();
                    ingredientList.Add(temp);
                }

                GetFoodByIngredientResponse ret = new GetFoodByIngredientResponseOk
                {
                    Food = ingredientList.ToArray()
                };

                return ret;
            }
            catch (Exception ex)
            {
                return new AppResponseError(ex.Message);
            }
        }

        public Response GetIngredientsByFoodId(GetIngredientsByFoodIdRequest request)
        {
            List<string> ingredientList = new List<string>();

            try
            {
                var dataSet = _dal.GetIngredientsByFoodId(request);
                var table = dataSet.Tables[0];
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    string temp = table.Rows[i]["ingredient"].ToString();
                    ingredientList.Add(temp);
                }

                GetIngredientsByFoodIdResponse ret = new GetIngredientsByFoodIdResponseOk
                {
                    Ingredients = ingredientList.ToArray()
                };

                return ret;
            }
            catch (Exception ex)
            {
                return new AppResponseError(ex.Message);
            }
        }
    }
}
