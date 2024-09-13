namespace BudgetCalculator;

public class Expense
{
    
    //properties
    public List<decimal> Expenses { get; set; }

    
    
    
    public Expense ()
    {
        Expenses = new List<decimal>();
       
    }

    public void AddExpense(decimal amount)
    {
        if (amount > 0)
        {
            Expenses.Add(amount);
            Console.WriteLine($"Expense added: {amount}");
        }

        else
        {
            Console.WriteLine("Expense amount is invalid");
        }
        
    }


    public decimal GetTotal()
    {
        decimal totalExpenses = 0;

        foreach (var expense in Expenses)
        {
            totalExpenses += expense;
        }

        return totalExpenses;

    }

    
}