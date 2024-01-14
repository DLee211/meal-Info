using Newtonsoft.Json;

namespace meal_Info.Model;

public class Meals
{
    [JsonProperty("meals")] public List<Meal> MealsList { get; set; }
}

public class Meal
{
    public string idMeal { get; set; }
    public string strMeal { get; set; }
}