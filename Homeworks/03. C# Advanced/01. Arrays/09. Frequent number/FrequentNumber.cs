using System;

class FrequentNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int[] numbers = new int[number];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(numbers);
        int count = 1;
        int frequent = 1;
        int mostFrequent = 0;

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] == numbers[i + 1])
            {
                count++;
            }
            else
            {
                if (count >= frequent)
                {
                    frequent = count;
                    mostFrequent = numbers[i];
                    count = 1;
                }
                else
                {
                    count = 1;
                }
            }
        }
        Console.WriteLine("{0} ({1} times)", mostFrequent, frequent);
    }
}