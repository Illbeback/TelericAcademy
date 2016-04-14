using System;

class ModifyBit
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        int value = int.Parse(Console.ReadLine());

        if (((number >> position) & 1) != value) number = ChangeBit(number, position);

        Console.WriteLine(number);
    }

    private static int ChangeBit(int number, int position)
    {
        return number ^ (1 << position);
    }

}