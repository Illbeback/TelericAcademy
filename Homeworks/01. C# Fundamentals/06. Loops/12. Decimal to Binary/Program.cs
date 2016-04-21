using System;

class DecimalToBinary
{
    static void Main()
    {
        long decimalNumber = long.Parse(Console.ReadLine());

        if (decimalNumber == 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            string binaryNumber = "";      

            while (decimalNumber > 0)
            {
                int remainder = (int)decimalNumber % 2;
                binaryNumber = remainder + binaryNumber;
                decimalNumber /= 2;
            }

            Console.WriteLine(binaryNumber);
        }

    }
}