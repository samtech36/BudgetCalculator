namespace BudgetCalculator;

public class InputHelper
{
    public static double GetValidDouble(string prompt)
    {
        double value;
        Console.Write(prompt);
        while (!double.TryParse(Console.ReadLine(), out value) && value < 0)
        {
            Console.WriteLine("Wrong input. Re enter a valid number.");
        }

        return value;
    }
    
    //enter an input from the user
    public static string GetValidString(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }
}