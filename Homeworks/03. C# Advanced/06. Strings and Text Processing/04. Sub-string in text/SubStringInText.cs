using System;

class SubStringInText
{
    static void Main()
    {
        string search = Console.ReadLine();
        string input = Console.ReadLine();
        int numberOfOccurences = 0;
        for (int i = 0; i < input.Length - search.Length + 1; i++)
        {
            if (input.Substring(i, search.Length).Equals(search, StringComparison.OrdinalIgnoreCase))
            {
                numberOfOccurences++;
            }
        }

        Console.WriteLine(numberOfOccurences);
    }
}