namespace meal_Info;

public class UserInput
{

    private MealService mealService = new();
    public void GetCategoriesInput()
    {
        var categories = mealService.GetCategories();
        
        Console.WriteLine("Choose category:");
        string category = Console.ReadLine();

        GetMealInput(category);
    }

    private void GetMealInput(string category)
    {
        throw new NotImplementedException();
    }
}