using System;

class ExchangeIfGreater
{
    static void Main()
    {
        double numOne = double.Parse(Console.ReadLine());
        double numTwo = double.Parse(Console.ReadLine());
        if (numOne > numTwo)
        {
            Console.WriteLine("{0} {1}", numTwo, numOne);
        }
        if (numOne <= numTwo)
        {
            Console.WriteLine("{0} {1}", numOne, numTwo);
        }
    }   
}
