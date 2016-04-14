using System;

class PointInACircle
{
    static void Main()
    {
        double x, y, r, z;
        x = double.Parse(Console.ReadLine());
        y = double.Parse(Console.ReadLine());
        r = 2;
        z = Math.Sqrt((x * x) + (y * y));
        if (z <= r)
        {
            Console.WriteLine("yes {0:0.00}", z);
        }
        else
        {
            Console.WriteLine("no {0:0.00}", z);
        }
    }
}
