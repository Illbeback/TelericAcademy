using System;

class MultiplicationSign
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        string plus = "+";
        string minus = "-";

        if (a > 0 && b > 0 && c > 0)
        {
            Console.WriteLine(plus);
        }
        else if (a < 0 && b < 0 && c > 0)
        {
            Console.WriteLine(plus);
        }
        else if (a < 0 && b > 0 && c < 0)
        {
            Console.WriteLine(plus);
        }
        else if (a > 0 && b < 0 && c < 0)
        {
            Console.WriteLine(plus);
        }
        else if (a < 0 && b > 0 && c > 0)
        {
            Console.WriteLine(minus);
        }
        else if (a > 0 && b < 0 && c > 0)
        {
            Console.WriteLine(minus);
        }
        else if (a > 0 && b > 0 && c < 0)
        {
            Console.WriteLine(minus);
        }
        else if (a < 0 && b < 0 && c < 0)
        {
            Console.WriteLine(minus);
        }
        else if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine(0);
        }
    }
}