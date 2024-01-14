namespace meal_Info;

public class UserInput
{

    private MealService mealService = new();
    public void GetCategoriesInput()
    {
        mealService.GetCategories();
        Console.ReadLine();
    }
}