using System;

class OddOrEven
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int trueNumber = number % 2;
        if (trueNumber == 0)
        {
            Console.WriteLine("even {0}", number);
        }
        else
        {
            Console.WriteLine("odd {0}", number);
        }
    }
}