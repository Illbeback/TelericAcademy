using System;

namespace ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main()
        {
            Console.WriteLine("Enter first number:");
            string firstNumber = Console.ReadLine();
            Console.WriteLine("Enter second number:");
            string secondNumber = Console.ReadLine();
            int a = Int32.Parse(firstNumber);
            int b = Int32.Parse(secondNumber);
            Console.WriteLine(@"Currently number one is ""{0}"" and number two is ""{1}"".", a, b);
            int c = a;
            a = b;
            b = c;
            Console.WriteLine(@"Now number one is ""{0}"" and number two is ""{1}"", so they are swaped.", a, b);
        }
    }
}
