    using System;
    class PrimeNumberCheck
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(IsPrime(number) ? "true" : "false");
        }

        private static bool IsPrime(int number)
        {
            if (number < 2) return false;
            if (number == 2) return true;
            for (int i = 2; i <= (int)Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }