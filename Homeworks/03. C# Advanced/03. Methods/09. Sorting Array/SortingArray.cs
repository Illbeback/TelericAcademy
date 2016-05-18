using System;
using System.Linq;

class SortingArray
{
    static void Main()
    {
        Console.ReadLine();
        int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        SortArray(array);
    }

    static void SortArray(int[] array)
    {
        Array.Sort(array);
        Console.WriteLine(string.Join(" ", array));
    }
}