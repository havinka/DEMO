using System;

internal class Program
{
    static void Main(string[] args)
    {
        double hallRent = double.Parse(Console.ReadLine());
        double cake = hallRent * 0.2;
        double drinks = cake * (1 - 0.45);
        double animator = hallRent * (1 / 3.0);

        double sum = hallRent + cake + drinks + animator;

        Console.WriteLine($"{sum:f2}");

    }
}
