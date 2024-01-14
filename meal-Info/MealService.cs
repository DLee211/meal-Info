using RestSharp;

namespace meal_Info;

public class MealService
{
    public void GetCategories()
    {
        var client = new RestClient("www.themealdb.com/api/json/v1/1/");
        var request = new RestRequest("list.php?c=list");
        var response = client.ExecuteAsync(request);

        List<Category> categories = new();
    }
}