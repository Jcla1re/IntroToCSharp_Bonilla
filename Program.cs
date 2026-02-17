using System;

class Program
{
    static void Main()
    {
        // TASK 1: DRIVER PROFILE INPUT
        

        // The string is used for names because it stores text
        Console.Write("Enter Driver's Full Name: ");
        string driverName = Console.ReadLine();

        // decimal is used for money to avoid rounding errors
        Console.Write("Enter Weekly Fuel Budget: ");
        decimal weeklyBudget = Convert.ToDecimal(Console.ReadLine());

        // double is used for distance because it may contain decimals 
        double totalDistance = 0;

        // while loop is used for validation, it will repeats until The input is valid
        while (totalDistance < 1.0 || totalDistance > 5000.0)
        {
            Console.Write("Enter Total Distance Traveled (1 - 5000 km): ");
            totalDistance = Convert.ToDouble(Console.ReadLine());

            if (totalDistance < 1.0 || totalDistance > 5000.0)
            {
                Console.WriteLine("Invalid input. Distance must be between 1 and 5000 km.");

            }
        }


        // TASK 2: FUEL EXPENSE TRACKING


        // 1D array to store 5 days of fuel expenses
        decimal[] fuelExpenses = new decimal[5];

        decimal totalFuelSpent = 0;

        // for loop is used because we know exactly 5 days
        for (int i = 0; i < fuelExpenses.Length; i++)
        {
            Console.Write($"Enter fuel expense for Day {i + 1}: ");
            fuelExpenses[i] = Convert.ToDecimal(Console.ReadLine());

            totalFuelSpent += fuelExpenses[i];
            Console.WriteLine($"\nTotal Fuel Spent: {totalFuelSpent:C}");
        }


        // TASK 3: PERFORMANCE ANALYSIS


        decimal averageFuelExpense = totalFuelSpent / 5;

        // Convert decimal to double for efficiency calculation
        double efficiency = totalDistance / (double)totalFuelSpent;

        string efficiencyRating;

        if (efficiency > 15)
        {
            efficiencyRating = "High Efficiency";
        }
        else if (efficiency >= 10)
        {
            efficiencyRating = "Standard Efficiency";
        }
        else
        {
            efficiencyRating = "Low Efficiency / Maintenance Required";
        }

        // bool is used to check if budget was exceeded
        bool underBudget = totalFuelSpent <= weeklyBudget;

        Console.WriteLine($"Efficiency: {efficiency}");
        Console.WriteLine($"Efficiency Rating: {efficiencyRating}");
        Console.WriteLine($"Stayed Under Budget: {underBudget}");


        // TASK 4: AUDIT REPORT

        Console.WriteLine("\n========== WEEKLY AUDIT REPORT ==========");
        Console.WriteLine($"Driver Name: {driverName}");
        Console.WriteLine("\nFuel Expenses Breakdown:");

        for (int i = 0; i < fuelExpenses.Length; i++)
        {
            Console.WriteLine($"Day {i + 1}: {fuelExpenses[i]:C}");
        }

        Console.WriteLine($"\nTotal Fuel Spent: {totalFuelSpent:C}");
        Console.WriteLine($"Average Daily Expense: {averageFuelExpense:C}");
        Console.WriteLine($"Total Distance: {totalDistance} km");
        Console.WriteLine($"Fuel Efficiency Rating: {efficiencyRating}");
        Console.WriteLine($"Stayed Under Budget: {underBudget}");
        Console.ReadLine();
    }
}