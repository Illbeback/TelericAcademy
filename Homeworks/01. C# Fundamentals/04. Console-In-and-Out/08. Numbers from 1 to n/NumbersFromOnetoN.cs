using System;

class NumbersFromOnetoN
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        for (int numbers = 1; numbers <= number; numbers++)
            {
                Console.WriteLine(numbers);
            }
    }
}