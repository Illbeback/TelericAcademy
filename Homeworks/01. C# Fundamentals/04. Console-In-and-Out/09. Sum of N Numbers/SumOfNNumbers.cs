﻿using System;

class SumOfNNumbers
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 0; i < count; i++)
        {
            sum += double.Parse(Console.ReadLine());
        }

        Console.WriteLine(sum);
    }
}