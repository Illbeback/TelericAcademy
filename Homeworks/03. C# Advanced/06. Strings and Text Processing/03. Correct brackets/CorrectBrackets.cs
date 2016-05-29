using System;

class CorrectBrackets
{
    static void Main()
    {
        string input = Console.ReadLine();
        int openingBraces = 0;
        int closingBraces = 0;

        foreach (var letter in input)
        {
            if (letter == '(')
            {
                openingBraces++;
            }
            else if (letter == ')')
            {
                closingBraces++;
            }
        }
        Console.WriteLine(openingBraces == closingBraces ? "Correct" : "Incorrect");
    }
}