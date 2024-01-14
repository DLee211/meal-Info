using Newtonsoft.Json;

namespace meal_Info.Model;

internal class MealDetailObject
{
    [JsonProperty("meals")] public List<MealDetails> MealDetailList { get; set; }
}

public class MealDetails
{
    public object idMeal { get; set; }
    public string strMeal { get; set; }

    public string strDrinkAlternate { get; set; }

    public string strArea { get; set; }

    public object strTags { get; set; }
    public object strVideo { get; set; }
    public string strCategory { get; set; }
    public string strInstructions { get; set; }
    public object strInstructionsES { get; set; }
    public string strInstructionsDE { get; set; }
    public object strInstructionsFR { get; set; }
    public string strInstructionsIT { get; set; }
    public object strInstructionsZHHANS { get; set; }
    public object strInstructionsZHHANT { get; set; }
    public string strDrinkThumb { get; set; }
    public string strIngredient1 { get; set; }
    public string strIngredient2 { get; set; }
    public string strIngredient3 { get; set; }
    public string strIngredient4 { get; set; }
    public object strIngredient5 { get; set; }
    public object strIngredient6 { get; set; }
    public object strIngredient7 { get; set; }
    public object strIngredient8 { get; set; }
    public object strIngredient9 { get; set; }
    public object strIngredient10 { get; set; }
    public object strIngredient11 { get; set; }
    public object strIngredient12 { get; set; }
    public object strIngredient13 { get; set; }
    public object strIngredient14 { get; set; }
    public object strIngredient15 { get; set; }
    public string strMeasure1 { get; set; }
    public string strMeasure2 { get; set; }
    public string strMeasure3 { get; set; }
    public string strMeasure4 { get; set; }
    public object strMeasure5 { get; set; }
    public object strMeasure6 { get; set; }
    public object strMeasure7 { get; set; }
    public object strMeasure8 { get; set; }
    public object strMeasure9 { get; set; }
    public object strMeasure10 { get; set; }
    public object strMeasure11 { get; set; }
    public object strMeasure12 { get; set; }
    public object strMeasure13 { get; set; }
    public object strMeasure14 { get; set; }
    public object strMeasure15 { get; set; }
    public object strImageSource { get; set; }
    public object strImageAttribution { get; set; }
    public string strCreativeCommonsConfirmed { get; set; }
    public string dateModified { get; set; }
}