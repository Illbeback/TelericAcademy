using System;

class NumbersComparer
{
    static void Main()
    {
        double numberOne = double.Parse(Console.ReadLine());
        double numberTwo = double.Parse(Console.ReadLine());
        bool result = numberOne > numberTwo;
        Console.WriteLine("{0}", result ? numberOne : numberTwo);
    }
}