using System;

class ThirdBit
{
    static void Main()
    {
        int position = 3;
        int number = int.Parse(Console.ReadLine());
        int mask = 1 << position;
        int nAndMask = number & mask;
        int bit = nAndMask >> position;
        Console.WriteLine(bit);
    }
}