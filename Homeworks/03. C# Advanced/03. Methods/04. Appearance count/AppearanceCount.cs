using System;
using System.Linq;

class AppearanceCount
{
    static void Main()
    {
        Console.ReadLine();
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int numberToSearch = int.Parse(Console.ReadLine());

        Console.WriteLine(ArrayAppearanceCount(numbers, numberToSearch));
    }

    static int ArrayAppearanceCount(int[] numbers, int numberToSearch)
    {
        int counter = 0;
        foreach (var number in numbers)
        {
            if (number == numberToSearch)
            {
                counter++;
            }
        }
        return counter;
    }
}
