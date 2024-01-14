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
        mealService.GetMealByCategory(category);
        
        Console.WriteLine("Choose a meal ID or go back to category menu by typing 0:");

        string meal = Console.ReadLine();

    }
}