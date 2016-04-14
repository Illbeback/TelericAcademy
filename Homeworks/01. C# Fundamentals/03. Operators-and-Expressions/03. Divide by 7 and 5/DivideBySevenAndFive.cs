using System;

class DivideBySevenAndFive
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int numberDevitedToFive = number % 5;
        int numberDevidetToSeven = number % 7;
        if (numberDevitedToFive == 0)
        {
            if (numberDevidetToSeven == 0)
            {
                Console.WriteLine("true {0}", number);
            }
            else
            {
                Console.WriteLine("false {0}", number);
            }
        }
        else
        {
            Console.WriteLine("false {0}", number);
        }
    }
}