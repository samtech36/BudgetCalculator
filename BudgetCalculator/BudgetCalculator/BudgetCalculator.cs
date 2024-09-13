namespace BudgetCalculator;

public class BudgetCalculator
{
    private Income _income;
    private Expense _expense;

    public BudgetCalculator(Income income, Expense expense)
    {
        _income = income;
        _expense = expense;
    }


    public decimal CalculateBalance()
    {
        decimal totalIncome = _income.GetTotalIncome();
        decimal totalExpenses = _expense.GetTotal();
        return totalIncome - totalExpenses;

    }
}