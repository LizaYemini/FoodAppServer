using DIContracts;
using FoodAppContracts.Dto;
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

        public Response GetAllCourses(GetAllCoursesRequest request)
        {
            List<string> coursesList = new List<string>();

            try
            {
                var dataSet = _dal.GetAllCourses(request);
                var table = dataSet.Tables[0];
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    string temp = table.Rows[i]["Course"].ToString();
                    coursesList.Add(temp);
                }

                GetAllCuisinesResponse ret = new GetAllCuisinesResponseOk
                {
                    Cuisines = coursesList.ToArray()
                };

                return ret;
            }
            catch (Exception ex)
            {
                return new AppResponseError(ex.Message);
            }
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

        public List<string> GetCoursesByFoodId(int id)
        {
            List<string> coursesList = new List<string>();

            try
            {
                var dataSet = _dal.GetCoursesByFoodId(id);
                var table = dataSet.Tables[0];
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    string temp = table.Rows[i]["Course"].ToString();
                    coursesList.Add(temp);
                }

                return coursesList;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Response GetCuisineByIngredient(GetCuisineByIngredientRequest request)
        {
            List<string> cuisinesList = new List<string>();

            try
            {
                var dataSet = _dal.GetCuisineByIngredient(request);
                var table = dataSet.Tables[0];
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    string temp = table.Rows[i]["Cuisine"].ToString();
                    cuisinesList.Add(temp);
                }

                GetCuisineByIngredientResponse ret = new GetCuisineByIngredientResponseOk
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

        public List<string> GetCuisinesByFoodId(int id)
        {
            List<string> cuisinesList = new List<string>();

            try
            {
                var dataSet = _dal.GetCuisinesByFoodId(id);
                var table = dataSet.Tables[0];
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    string temp = table.Rows[i]["Cuisine"].ToString();
                    cuisinesList.Add(temp);
                }

                return cuisinesList;
            }
            catch (Exception)
            {
                return null;
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

        public FoodDto GetFoodByFoodId(int id)
        {
            try
            {
                var dataSet = _dal.GetFoodByFoodId(id);
                var table = dataSet.Tables[0];
                var name = table.Rows[0]["Name"].ToString();
                var total_time = Convert.ToDouble(table.Rows[0]["total_time"]);
                var rating = Convert.ToInt32(table.Rows[0]["rating"]);
                var recipe = table.Rows[0]["Recipe"].ToString();
                return new FoodDto
                {
                    Name = name,
                    TotalTime = total_time,
                    Rating = rating,
                    RecipeUrl = recipe

                };
            }
            catch (Exception)
            {
                return null;
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

        public Response GetFoodByIngredients(GetFoodByIngredientsRequest request)
        {
            List<string> foodList = new List<string>();

            try
            {
                var dataSet = _dal.GetFoodByIngredients(request);
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

        public Response GetFoodByMaxIngredient(GetFoodByMaxIngredientRequest request)
        {
            List<string> foodList = new List<string>();

            try
            {
                var dataSet = _dal.GetFoodByMaxIngredient(request);
                var table = dataSet.Tables[0];
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    string temp = table.Rows[i]["food_id"].ToString();
                    foodList.Add(temp);
                }

                GetFoodByMaxIngredientResponse ret = new GetFoodByMaxIngredientResponseOk
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

        public Response GetFoods(GetFoodsRequest request)
        {
            List<FoodDto> foodList = new List<FoodDto>();

            try
            {
                var inputIngredients = ConvertToStringWith4SemiColons(request.Ingredients);
                var inputWithoutIngredients = ConvertToStringWith4SemiColons(request.WithoutIngredients);
                var dataSet = _dal.GetFoods(request.Cuisine, inputIngredients, inputWithoutIngredients,
                    request.Course, request.MaxTime, request.Rating, request.MaxIngredients);
                var table = dataSet.Tables[0];
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    int id = Convert.ToInt32(table.Rows[i]["food_id"]);
                    var foodData = GetFoodByFoodId(id);
                    var courses = GetCoursesByFoodId(id);
                    var cuisines = GetCuisinesByFoodId(id);
                    var ingredients = GetIngredientsByFoodId(id);
                    var image = GetImageByFoodId(id);
                    FoodDto food = new FoodDto
                    {
                        Cuisines = cuisines.ToArray(),
                        Courses = courses.ToArray(),
                        Id = id,
                        ImageUrl = image,
                        Ingredients = ingredients.ToArray(),
                        Name = foodData.Name,
                        Rating = foodData.Rating,
                        RecipeUrl = foodData.RecipeUrl,
                        TotalTime = foodData.TotalTime
                    };
                    foodList.Add(food);
                }

                return new GetFoodsResponseOk
                {
                    Foods = foodList.ToArray()
                };
            }
            catch (Exception ex)
            {
                return new AppResponseError(ex.Message);
            }
        }

        public Response GetFoodWithoutIngredient(GetFoodWithoutIngredientRequest request)
        {
            List<string> foodList = new List<string>();

            try
            {
                var dataSet = _dal.GetFoodWithoutIngredient(request);
                var table = dataSet.Tables[0];
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    string temp = table.Rows[i]["food_id"].ToString();
                    foodList.Add(temp);
                }

                GetFoodWithoutIngredientResponse ret = new GetFoodWithoutIngredientResponseOk
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

        public string GetImageByFoodId(int id)
        {
            try
            {
                var dataSet = _dal.GetImageByFoodId(id);
                var table = dataSet.Tables[0];
                return table.Rows[0]["image"].ToString(); ;
            }
            catch (Exception)
            {
                return null;
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

        public List<string> GetIngredientsByFoodId(int id)
        {
            List<string> ingredientList = new List<string>();

            try
            {
                GetIngredientsByFoodIdRequest request = new GetIngredientsByFoodIdRequest
                {
                    Id = id
                };
                var dataSet = _dal.GetIngredientsByFoodId(request);
                var table = dataSet.Tables[0];
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    string temp = table.Rows[i]["ingredient"].ToString();
                    ingredientList.Add(temp);
                }

                return ingredientList;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private string ConvertToStringWith4SemiColons(string[] array)
        {
            string ret = "";
            for (int i = 0; i < array.Length; i++)
            {
                ret = ret + array[i];
                if (i != array.Length - 1)
                {
                    ret = ret + ';';
                }
            }
            for (int i = 0; i < 5 - array.Length; i++)
            {
                ret = ret + ';';
            }
            return ret;
        }
    }
}
