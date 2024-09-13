using System;
using System.Collections.Generic;

public class Income
{
    public List<decimal> IncomeSources { get; set; }

    public Income()
    {
        IncomeSources = new List<decimal>();
    }

    // Add income
    public void AddIncome(decimal amount)
    {
        if (amount > 0)
        {
            IncomeSources.Add(amount);
            Console.WriteLine($"Income of {amount:C} added.");
        }
        else
        {
            Console.WriteLine("Invalid income amount. Must be greater than 0.");
        }
    }

    // Calculate total income
    public decimal GetTotalIncome()
    {
        decimal totalIncome = 0;
        foreach (var income in IncomeSources)
        {
            totalIncome += income;
        }
        return totalIncome;
    }
}
