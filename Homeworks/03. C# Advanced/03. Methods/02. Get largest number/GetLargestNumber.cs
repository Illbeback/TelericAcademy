using System;
using System.Linq;

class GetLargestNumber
{
    static void Main()
    {
        int[] sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int firstNumber = sequence[0];
        int secondNumber = sequence[1];
        int thirdNumber = sequence[2];
        int greatherOfFirstTwo = GetMax(firstNumber, secondNumber);
        int greatherOfSecondTwo = GetMax(greatherOfFirstTwo, thirdNumber);
        Console.WriteLine(greatherOfSecondTwo);
    }

    static int GetMax(int numberOne, int numberTwo)
    {

       if (numberOne > numberTwo)
            {
            return numberOne;
            }
       else
        {
            return numberTwo;
        }
    }
}