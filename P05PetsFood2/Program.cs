using System;
namespace P05PetsFood2;
internal class Program
{
    static void Main()
    {
        int days = int.Parse(Console.ReadLine());
        double totalFood = int.Parse(Console.ReadLine());
        double totalBiscuits = 0;
        double totalDogFood = 0;
        double totalCatFood = 0;

        for (int i = 1; i <= days; i++)
        {
            int dailyFoodDog = int.Parse(Console.ReadLine());
            int dailyFoodCat = int.Parse(Console.ReadLine());

            totalDogFood += dailyFoodDog;
            totalCatFood += dailyFoodCat;
            
            if (i == 3)
            {
                totalBiscuits += (dailyFoodDog + dailyFoodCat) * 0.10;
            }

        }

        double total = totalDogFood + totalCatFood;
        double percentageEatenFood = (total / totalFood) * 100;
        double percentageDogFood = (totalDogFood / total) * 100;
        double percentageCatFood = (totalCatFood / total) * 100;

        Console.WriteLine(value: $"Total eaten biscuits: {Math.Ceiling(totalBiscuits)}gr.");
        Console.WriteLine($"{percentageEatenFood:f2}% of the food has been eaten.");
        Console.WriteLine($"{percentageDogFood:f2}% eaten from the dog.");
        Console.WriteLine($"{percentageCatFood:f2}% eaten from the cat.");
        
    }
}

