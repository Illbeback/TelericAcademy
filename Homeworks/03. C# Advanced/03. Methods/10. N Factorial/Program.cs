using System;
using System.Numerics;

class Program
    {
        static void Factoriel(BigInteger number)
        {
        BigInteger counter = 1;
        for (BigInteger i = 2; i <= number; i++)
        {
            counter *= i;
        }
        Console.WriteLine(counter);
        }

        static void Main()
        {
        int number = int.Parse(Console.ReadLine());
        Factoriel(number);
        }
    }
