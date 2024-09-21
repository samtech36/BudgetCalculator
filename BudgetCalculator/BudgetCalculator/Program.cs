using System;
using BudgetCalculator;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        BudgetCalculator.BudgetCalculator budgetCalculator = new BudgetCalculator.BudgetCalculator();
        budgetCalculator.Start();
        
        Console.WriteLine("Thanks for using the Budget Calculator!");
        Console.WriteLine("Press any key to continue...");
        Console.ReadLine();

    }
}
