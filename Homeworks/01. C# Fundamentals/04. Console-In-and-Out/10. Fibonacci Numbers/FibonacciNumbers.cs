using System;

class FibonacciNumbers
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());

        long[] fibonacciNumbers = new long[Math.Max(count, 3)];
        fibonacciNumbers[0] = 0;
        fibonacciNumbers[1] = 1;
        fibonacciNumbers[2] = 1;

        for (int index = 3; index < fibonacciNumbers.Length; index++)
        {
            fibonacciNumbers[index] = fibonacciNumbers[index - 1] + fibonacciNumbers[index - 2];
        }

        Console.WriteLine(string.Join(", ", fibonacciNumbers));
    }
}