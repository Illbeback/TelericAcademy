using System;

class BinaryToDecimal
{
    static void Main()
    {
        string binaryNumber = Console.ReadLine();

        long decimalNumber = 0;

        for (int i = 0; i < binaryNumber.Length; i++)
        {
            if (binaryNumber[binaryNumber.Length - i - 1] == '1')
            {
                decimalNumber += (long)Math.Pow(2, i);
            }
        }

        Console.WriteLine(decimalNumber);
    }
}