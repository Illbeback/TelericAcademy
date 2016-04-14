using System;

class ThirdDigit
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int numberTwo = number / 100;
        int numberThree = numberTwo % 10;
        if (numberThree == 7)
            {
            Console.WriteLine("true");
            }
        else
        {
            Console.WriteLine("false {0}", numberThree);
        }
    }
}