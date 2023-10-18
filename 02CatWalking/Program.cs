namespace _02CatWalking;
class Program
{
    static void Main(string[] args)
    {
        int mins = int.Parse(Console.ReadLine());
        int walksCount = int.Parse(Console.ReadLine());
        int caloriesPerDay = int.Parse(Console.ReadLine());

        int walksTime = mins * walksCount;
        int burnedCal = walksCount * 5;
        int halfOfTheCal = caloriesPerDay / 2;

        if (burnedCal >= halfOfTheCal)
        {
            Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {burnedCal}.");
        }

        else
        {
            Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {burnedCal}.");
        }
    }
}

