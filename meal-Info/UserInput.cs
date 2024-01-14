﻿namespace meal_Info;

public class UserInput
{
    private readonly MealService mealService = new();

    public void GetCategoriesInput()
    {
        var categories = mealService.GetCategories();

        Console.WriteLine("Choose category:");
        var category = Console.ReadLine();

        GetMealInput(category);
    }

    private void GetMealInput(string category)
    {
        mealService.GetMealByCategory(category);

        Console.WriteLine("Choose a meal ID or go back to category menu by typing 0:");

        var mealId = Console.ReadLine();

        if (mealId == "0") GetCategoriesInput();

        mealService.GetMeal(mealId);
    }
}