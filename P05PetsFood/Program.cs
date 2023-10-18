using System;

internal class Program
{
    static void Main(string[] args)
    {
        int days = int.Parse(Console.ReadLine());
        double totalFood = int.Parse(Console.ReadLine());
        int totalBiscuits = 0;
        double totalDogFood = 0;
        double totalCatFood = 0;

        for (int i = 0; i <= days; i++)
        {
            int foodDog = int.Parse(Console.ReadLine());
            int foodCat = int.Parse(Console.ReadLine());

            totalDogFood += foodDog;
            totalCatFood += totalCatFood;

            if (i % 3 == 0)
            {
                totalBiscuits += (int)(foodDog + foodCat * 0.10);
            }
                
        }

        double total = totalDogFood + totalCatFood;
        double percentageEatenFood = (total / totalFood) * 100;
        double percentageDogFood = (totalDogFood / total) * 100;
        double percentageCatFood = (totalCatFood / total) * 100;

        Console.WriteLine(value: $"Total eaten biscuits: {(totalBiscuits)}gr.");
        Console.WriteLine($"{percentageEatenFood} % of the food has been eaten.");
        Console.WriteLine($"{percentageDogFood} % eaten from the dog.");
        Console.WriteLine($"{percentageCatFood} % eaten from the cat.");

    }
}

