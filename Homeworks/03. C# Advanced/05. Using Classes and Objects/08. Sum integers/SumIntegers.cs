using System;

    class SumIntegers
    {
    static void Main()
    {
        string[] splitNumbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int sum = 0;

        for (int i = 0; i < splitNumbers.Length; i++)
        {
            sum += int.Parse(splitNumbers[i]);
        }

        Console.WriteLine(sum);
    }
}