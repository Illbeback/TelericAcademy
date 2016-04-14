using System;

class Trapezoids
{
    static void Main()
    {
        double a, b, h, s;
        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
        h = double.Parse(Console.ReadLine());
        s = (0.5 * (a + b) * h);
        Console.WriteLine("{0:0.0000000}", s);
    }
}
