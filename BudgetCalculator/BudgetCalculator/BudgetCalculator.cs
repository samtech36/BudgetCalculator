namespace BudgetCalculator;

public class BudgetCalculator
{
    private double totalIncome;
    private ExpenseManager expenseManager;

    public BudgetCalculator()
    {
        expenseManager = new ExpenseManager();
    }

    public void Start()
    {
        Console.WriteLine("Welcome to Budget Calculator!");
        
        //total income enter
        totalIncome = InputHelper.GetValidDouble("Please enter your total income: $");
        
        //add expenses until it stops by the user
        bool addingExpenses = true;
        while (addingExpenses)
        {
            AddExpense();
            Console.Write("Would you like to add expense? [y/n]: ");
            addingExpenses = Console.ReadLine() == "y";
        }
        
        //displaying summary
        DisplaySummary();
    }

    void AddExpense()
    {
        string category = InputHelper.GetValidString("Please enter a category: ");
        double amount  = InputHelper.GetValidDouble("Please enter a amount for this expense: ");
        
        Expense expense = new Expense(category, amount);
        expenseManager.AddExpense(expense);
        Console.WriteLine("Expense added successful!.");
    }

    private void DisplaySummary()
    {
        double totalExpenses = expenseManager.CalculateTotalExpense();
        double remainingBalance = totalIncome - totalExpenses;
        
        Console.WriteLine("---Budget Summary----");
        Console.WriteLine($"Total income: ${totalIncome:F2}");
        Console.WriteLine($"Total expenses: ${totalExpenses:F2}");
        Console.WriteLine($"Remaining balance: ${remainingBalance:F2}");
        
        
        expenseManager.DisplayExpensesSummary();

        if (remainingBalance < 0)
        {
            Console.WriteLine("You have reached the maximum allowed expense.");
        }
    }

}