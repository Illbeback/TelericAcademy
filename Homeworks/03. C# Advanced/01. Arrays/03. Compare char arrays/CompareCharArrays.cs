using System;

class CompareCharArrays
{
    static void Main()
    {
        string first = Console.ReadLine();
        string second = Console.ReadLine();
        char[] firstArr = first.ToCharArray();
        char[] secondArr = second.ToCharArray();
        if (firstArr.Length > secondArr.Length)
        {
            Console.WriteLine(">");
        }
        else if (firstArr.Length < secondArr.Length)
        {
            Console.WriteLine("<");
        }
        else
        {
            for (int i = 0; i < firstArr.Length; i++)
            {
                bool areEqual = firstArr[i] == secondArr[i];
                bool firstIsBigger = firstArr[i] > secondArr[i];
                if (areEqual)
                {
                    if (i == firstArr.Length - 1)
                    {
                        Console.WriteLine("=");
                    }

                }
                else if (firstIsBigger)
                {
                    Console.WriteLine(">");
                    break;
                }
                else
                {
                    Console.WriteLine("<");
                    break;
                }
            }
        }
    }
}