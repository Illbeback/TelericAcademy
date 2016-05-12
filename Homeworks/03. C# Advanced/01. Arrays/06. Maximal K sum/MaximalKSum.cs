using System;

class MaximalKSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int counter = 0;
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
            Array.Sort(array);
            Array.Reverse(array);
        }
        for (int i = 0; i <= k - 1; i++)
        {
            counter += array[i];
        }
        Console.WriteLine(counter);
    }
}