using System;

class NthBit
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        int mask = 1 << position;
        int nAndMask = number & mask;
        int bit = nAndMask >> position;
        Console.WriteLine(bit);
    }
}