using System;

namespace PrintSequence
{
    class PrintSequence
    {
        static void Main()
        {
            int currentPostiveNumber = 2;
            int currentNegativeNumber = -3;
            for (int i = 0; i <= 4; i++)
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