using System;

namespace LongSequence
{
    class LongSequence
    {
        static void Main()
        {
            int currentPostiveNumber = 2;
            int currentNegativeNumber = -3;
            for (int i = 0; i <= 499; i++)
            {
                {
                    Console.WriteLine(currentPostiveNumber);
                    Console.WriteLine(currentNegativeNumber);
                    currentPostiveNumber += 2;
                    currentNegativeNumber -= 2;
                }
            }
        }
    }
}