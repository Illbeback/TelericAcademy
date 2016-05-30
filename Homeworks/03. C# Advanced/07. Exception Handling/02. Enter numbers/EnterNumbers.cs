using System;

class EnterNumers
{
    static void Main()
    {
        int[] arr = new int[12];

        arr[0] = 1;
        for (int i = 1; i < arr.Length - 1; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        arr[11] = 100;

        for (int i = 0; i < 9; i++)
        {
            if (ReadNumber(arr[i], arr[i + 1]))
            {
                continue;
            }
            else
            {
                Console.WriteLine("Exception");
                return;
            }
        }

        Console.WriteLine(string.Join(" < ", arr));
    }

    static bool ReadNumber(int start, int end)
    {
        if (start < end)
        {
            return true;
        }

        return false;
    }
}