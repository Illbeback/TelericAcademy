using System;

namespace SquareRoot
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();

            try
            {
                double number = double.Parse(input);

                double result = Math.Sqrt(number);

                if (number < 0 || number == 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid number");
                }
                else if (number == double.NaN)
                {
                    throw new FormatException("Invalid number");
                }
                else
                {
                    Console.WriteLine("{0:F3}", result);
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}