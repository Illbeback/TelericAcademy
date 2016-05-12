using System;

class MaximalSum
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int[] numbers = new int[number];
        int currentBigger = 0;
        int biggestEver = int.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < numbers.Length; i++)
        {
            currentBigger = currentBigger + numbers[i];
            if (currentBigger > biggestEver)
            {
                biggestEver = currentBigger;
            }
            if (currentBigger < 0)
            {
                currentBigger = 0;
            }
        }
        Console.WriteLine(biggestEver);
    }
}
