using System;

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main()
        {
            double numOne = double.Parse(Console.ReadLine());
            double numTwo = double.Parse(Console.ReadLine());
            double minusNum = numOne - numTwo;
            double absoluteDiffrence = Math.Abs(minusNum);
            double allowedDifferance = 0.000001;
            if (allowedDifferance < absoluteDiffrence)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }
        }
    }
}
