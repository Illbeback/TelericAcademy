using System;
using System.Numerics;

class NthCatalanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (1 <= n && n <= 100)
        {
            BigInteger numerator = 1;

            for (int i = 1; i <= (2 * n); i++)
            {
                // (2*n)!
                numerator *= i;
            }

            BigInteger denominator = 1;

            for (int i = 1; i <= (n + 1); i++)
            {
                // (n+1)!
                denominator *= i;
            }

            for (int i = 1; i <= n; i++)
            {
                // n!
                denominator *= i;
            }

            Console.WriteLine(numerator / denominator);
        }
        else            // n == 0
        {
            Console.WriteLine(1);
        }

    }
}