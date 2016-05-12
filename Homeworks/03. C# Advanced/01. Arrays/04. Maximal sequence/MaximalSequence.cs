using System;

class MaximalSequence
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int[] array = new int[number];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        int counter = 1;
        int lengthCount = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i - 1] == array[i])
            {
                counter++;
                lengthCount = Math.Max(lengthCount, counter);
            }
            else
            {
                counter = 1;
            }
        }
        Console.WriteLine(lengthCount);
    }
}
