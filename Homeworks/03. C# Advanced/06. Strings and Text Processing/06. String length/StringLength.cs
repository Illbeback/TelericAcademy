using System;

class StringLength
{
    static void Main()
    {
        string stringInput = Console.ReadLine().Replace("\\", string.Empty);
        stringInput = stringInput.PadRight(20, '*');
        Console.WriteLine(stringInput);
    }

}