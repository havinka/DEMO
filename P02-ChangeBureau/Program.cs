using System;

internal class Program
{
    static void Main()
    {
        int bitcoinCount = int.Parse(Console.ReadLine());
        double china = double.Parse(Console.ReadLine());
        double comm = double.Parse(Console.ReadLine());

        double bitcSum = bitcoinCount * 1168;
        double chinaSum = china * 0.15;
        double sumLeva = bitcSum + (chinaSum * 1.76);

        double euro = sumLeva / 1.95;
        double commision = (comm * euro) / 100;
        double total = euro - commision;

        Console.WriteLine($"{total:f2}");

    }
}
