using System;
class Program
{
    static void Main(string[] args)
    {

        double price = int.Parse(Console.ReadLine());
        string gender = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        string sport = Console.ReadLine();
        double priceOfCard = 0;

        if (sport == "Gym")
        {
            if (gender == "m")
            {
                priceOfCard = 42;
            }
            else if (gender == "f")
            {
                priceOfCard = 35;
            }
            if (age <= 19)
            {
                priceOfCard = priceOfCard * (1 - 0.20);
            }
        }

        if (sport == "Boxing")
        {
            if (gender == "m")
            {
                priceOfCard = 41;
            }
            else if (gender == "f")
            {
                priceOfCard = 37;
            }
            if (age <= 19)
            {
                priceOfCard = priceOfCard * (1 - 0.20);
            }
        }

        if (sport == "Yoga")
        {
            if (gender == "m")
            {
                priceOfCard = 45;
            }
            else if (gender == "f")
            {
                priceOfCard = 42;
            }
            if (age <= 19)
            {
                priceOfCard = priceOfCard * (1 - 0.20);
            }
        }

        if (sport == "Zumba")
        {
            if (gender == "m")
            {
                priceOfCard = 34;
            }
            else if (gender == "f")
            {
                priceOfCard = 31;
            }
            if (age <= 19)
            {
                priceOfCard = priceOfCard * (1 - 0.20);
            }
        }

        if (sport == "Dances")
        {
            if (gender == "m")
            {
                priceOfCard = 51;
            }
            else if (gender == "f")
            {
                priceOfCard = 53;
            }
            if (age <= 19)
            {
                priceOfCard = priceOfCard * (1 - 0.20);
            }
        }

        if (sport == "Pilates")
        {
            if (gender == "m")
            {
                priceOfCard = 39;
            }
            else if (gender == "f")
            {
                priceOfCard = 37;
            }
            if (age <= 19)
            {
                priceOfCard = priceOfCard * (1 - 0.20);
            }
        }

        if (price >= priceOfCard)
        {
            Console.WriteLine($"You purchased a 1 month pass for {sport}.");
        }
        else
        {
            Console.WriteLine($"You don't have enough money! You need {(priceOfCard - price):f2} more.");
        }
    }
}

