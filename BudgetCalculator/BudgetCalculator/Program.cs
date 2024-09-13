using System;
using BudgetCalculator;

class Program
{
    static void Main(string[] args)
    {
        Income income = new Income();
        Expense expense = new Expense();
        BudgetCalculator.BudgetCalculator budgetCalculator = new BudgetCalculator.BudgetCalculator(income, expense);

        while (true)
        {
            Console.WriteLine("\n--- Budget Calculator ---");
            Console.WriteLine("1. Add Income");
            Console.WriteLine("2. Add Expense");
            Console.WriteLine("3. View Balance");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Write("Enter income amount: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal incomeAmount))
                    {
                        income.AddIncome(incomeAmount);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                    break;

                case "2":
                    Console.Write("Enter expense amount: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal expenseAmount))
                    {
                        expense.AddExpense(expenseAmount);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                    break;

                case "3":
                    decimal balance = budgetCalculator.CalculateBalance();
                    Console.WriteLine($"Your current balance is: {balance:C}");
                    break;

                case "4":
                    Console.WriteLine("Exiting...");
                    return;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
