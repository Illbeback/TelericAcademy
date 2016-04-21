using System;

class HexToDecimal
{
    static void Main()
    {
        string hexNumber = Console.ReadLine();

        long decimalNumber = 0;

        for (int i = 0; i < hexNumber.Length; i++)
        {
            int multiplier;

            switch (hexNumber[hexNumber.Length - i - 1])
            {
                case 'A': multiplier = 10; break;
                case 'B': multiplier = 11; break;
                case 'C': multiplier = 12; break;
                case 'D': multiplier = 13; break;
                case 'E': multiplier = 14; break;
                case 'F': multiplier = 15; break;
                default: multiplier = int.Parse(hexNumber[hexNumber.Length - i - 1].ToString()); break;
            }

            decimalNumber += multiplier * (long)Math.Pow(16, i);
        }

        Console.WriteLine(decimalNumber);

    }
}