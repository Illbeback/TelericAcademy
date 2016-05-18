using System;
using System.Linq;

class Program
{
    static int MinElement(int[] array)
    {
        int minNumber = array[0];
        for (int i = 0; i < array.Length; i++)
        {

            if (minNumber > array[i])
            {
                minNumber = array[i];
            }

        }
        return minNumber;
    }

    static int MaxElement(int[] array)
    {
        int maxNumber = array[0];
        for (int i = 0; i < array.Length; i++)
        {

            if (maxNumber < array[i])
            {
                maxNumber = array[i];
            }

        }
        return maxNumber;
    }

    static decimal Average(int[] array)
    {
        long sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        decimal average = (decimal)sum / array.Length;
        return average;
    }

    static long Sum(int[] array)
    {
        long sum = 0;
        foreach (var number in array)
        {
            sum += number;
        }
        return sum;
    }

    static long Product(int[] array)
    {
        long product = 1;
        foreach (var number in array)
        {
            product *= number;
        }
        return product;

    }
    static void Main(string[] args)
    {
        int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine(MinElement(array));
        Console.WriteLine(MaxElement(array));
        Console.WriteLine("{0:F2}", Average(array));
        Console.WriteLine(Sum(array));
        Console.WriteLine(Product(array));
    }
}