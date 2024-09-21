namespace BudgetCalculator;

public class Expense
{

    public string Category { get; set; }
    public double Amount { get; set; }

    public Expense(string category, double amount)
    {
        Category = category;
        Amount = amount;
    }
    
    //store expenses
    static List<Expense> expenses = new List<Expense>();
    static double totalIncome = 0.0;







}