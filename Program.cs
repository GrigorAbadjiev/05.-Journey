using System;

namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination;
            string restType;
            double budgetSpentPercentage;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    restType = "Camp";
                    budgetSpentPercentage = 0.3;
                }
                else
                {
                    restType = "Hotel";
                    budgetSpentPercentage = 0.7;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    restType = "Camp";
                    budgetSpentPercentage = 0.4;
                }
                else
                {
                    restType = "Hotel";
                    budgetSpentPercentage = 0.8;
                }
            }
            else
            {
                destination = "Europe";
                restType = "Hotel";
                budgetSpentPercentage = 0.9;
            }
            double budgetSpent = budget * budgetSpentPercentage;
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{restType} – {budgetSpent:f2}");

        }
    }
}
