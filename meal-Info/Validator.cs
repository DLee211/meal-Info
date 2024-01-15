using meal_Info.Model;

namespace meal_Info;

public class Validator
{
    public static string? ValidateCategory(string searchString, List<Category> categories)
    {
        bool stringExists;
        bool flag = true;

        while (flag == true)
        {
            if (stringExists = categories.Any(category => category.strCategory == searchString))
            {
                flag = false;
            }
            else
            {
                Console.WriteLine("Category does not exist, Try again:");
                searchString = Console.ReadLine();
            }
        }
        return searchString;
    }

    public static string? ValidateMeal(string searchString , List<Meal> meals)
    {
        bool stringExists;
        bool flag = true;

        while (flag == true)
        {
            if (stringExists = meals.Any(meal => meal.idMeal == searchString))
            {
                flag = false;
            }
            else
            {
                Console.WriteLine("Meal does not exist, Try again:");
                searchString = Console.ReadLine();
            }
        }
        return searchString;
    }
}