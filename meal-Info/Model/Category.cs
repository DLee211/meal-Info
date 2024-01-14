using Newtonsoft.Json;

namespace meal_Info.Model;

public class Category
{
    public string strCategory { get; set; }
}

public class Categories
{
    [JsonProperty("meals")] public List<Category> CategoriesList { get; set; }
}