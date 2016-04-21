using System;
using System.Numerics;

class CalculateThree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());


        BigInteger numerator = 1;
        BigInteger denominator = 1;

        for (int i = k + 1; i <= n; i++)
        {
            numerator *= i;
        }

        for (int j = 2; j <= (n - k); j++)
        {
            denominator *= j;
        }

        BigInteger result = numerator / denominator;
        Console.WriteLine(result);

    }
}