using System;

class Program
{
    static void Main()
    {
        double numOne = double.Parse(Console.ReadLine());
        double numTwo = double.Parse(Console.ReadLine());
        double numThree = double.Parse(Console.ReadLine());

        if (numOne > numTwo)
        {
            if (numOne >= numThree)
            {
                Console.WriteLine(numOne);
            }
            else if (numThree >= numOne)
            {
                Console.WriteLine(numThree);
            }
        }
        if (numTwo > numOne)
        {
            if (numTwo >= numThree)
            {
                Console.WriteLine(numTwo);
            }
            else if (numThree >= numTwo)
            {
                Console.WriteLine(numThree);
            }
        }
        if (numOne == numTwo)
        {
            if (numOne >= numThree)
            {
                Console.WriteLine(numOne);
            }
            else if (numThree >= numOne)
            {
                Console.WriteLine(numThree);
            }
        }
    }
}