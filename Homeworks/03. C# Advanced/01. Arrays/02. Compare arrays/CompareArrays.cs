using System;

class CompareArrays
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int[] array1 = new int[number];
        int[] array2 = new int[number];
        bool isEqual = false;
        for (int i = 0; i < array1.Length; i++)
        {
            array1[i] = int.Parse(Console.ReadLine());
        }
        for (int j = 0; j < array2.Length; j++)
        {
            array2[j] = int.Parse(Console.ReadLine());
        }
        for (int l = 0; l < number; l++)
        {
            if (array1[l] == array2[l])
            {
                isEqual = true;
            }
            else
            {
                isEqual = false;
                break;
            }
        }
        if (isEqual)
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not equal");
        }
    }
}
