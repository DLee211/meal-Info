using meal_Info.Model;
using Newtonsoft.Json;
using RestSharp;

namespace meal_Info;

public class MealService
{
    public List<Category> GetCategories()
    {
        var client = new RestClient("http://www.themealdb.com/api/json/v1/1/");
        var request = new RestRequest("list.php?c=list");
        var response = client.ExecuteAsync(request);

        List<Category> categories = new();

        if (response.Result.StatusCode == System.Net.HttpStatusCode.OK)
        {
            string rawResponse = response.Result.Content;
            var serialize = JsonConvert.DeserializeObject<Categories>(rawResponse);
            
            categories = serialize.CategoriesList;
            TableVisualisationEngine.ShowTable(categories, "Categories Menu");
            return categories;
        }

        return categories;
    }
}