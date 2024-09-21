namespace BudgetCalculator;

public class ExpenseManager
{
    private List<Expense> expenses;

    public ExpenseManager()
    {
        expenses = new List<Expense>();
    }
    
    //add expenses into the list
    public void AddExpense(Expense expense)
    {
        expenses.Add(expense);
    }
    
    //calculate total income
    public double CalculateTotalExpense()
    {
        double total = 0;
        foreach (var expense in expenses)
        {
            total += expense.Amount;
        }

        return total;
    }

    public void DisplayExpensesSummary()
    {
        Console.WriteLine("Expense Breakdown: ");
        foreach (var expense in expenses)
        {
            Console.WriteLine($"{expense.Category}: {expense.Amount:F2}");
        }
    }

    public List<Expense> GetExpenses()
    {
        return expenses;
    }
}