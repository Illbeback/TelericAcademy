using System;

class BiggestOfFive
{
    static void Main()
    {
        double a1 = double.Parse(Console.ReadLine());
        double b2 = double.Parse(Console.ReadLine());
        double c3 = double.Parse(Console.ReadLine());
        double d4 = double.Parse(Console.ReadLine());
        double e5 = double.Parse(Console.ReadLine());
        double f6 = Math.Max(a1, b2);
        double j7 = Math.Max(c3, d4);
        double h8 = Math.Max(f6, j7);
        double y8 = Math.Max(h8, e5);
        Console.WriteLine(y8);
    }
}