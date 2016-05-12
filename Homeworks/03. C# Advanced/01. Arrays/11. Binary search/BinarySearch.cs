using System;

class BinarySearch
{
    static void Main()
    {

        int arraySize = int.Parse(Console.ReadLine());
        int[] arrayA = new int[arraySize];
        for (int i = 0; i < arraySize; i++)
        {
            arrayA[i] = int.Parse(Console.ReadLine());
        }
        int toFind = int.Parse(Console.ReadLine());
        int Left = 0;
        int Right = arraySize - 1;
        int Middle = (Left + Right) / 2;
        int currCheck = Middle;

        while (true)
        {
            if (arrayA[currCheck] < toFind)
            {

                currCheck++;
                continue;
            }

            if (toFind < arrayA[currCheck])
            {

                currCheck--;
                continue;
            }

            try
            {
                if (arrayA[currCheck] == toFind)
                {
                    Console.WriteLine(currCheck);
                    return;
                }
            }
            catch (System.IndexOutOfRangeException) 
            {                                         
                Console.WriteLine("-1");              
                return;                               
            }
        }
    }
}
