namespace meal_Info;

internal class Program
{
    private static void Main(string[] args)
    {
        bool flag = true;
        while (flag)
        {
            UserInput userInput = new();

            userInput.GetCategoriesInput();
            
            Console.WriteLine("Press 0 if you wish to exit the application. If you wish to continue, press ENTER.");

            var check = Console.ReadLine();

            if (check == "0")
            {
                flag = false;
            }
        }
    }
}