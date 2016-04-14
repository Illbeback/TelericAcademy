using System;

class Rectangles
{
    static void Main()
    {
        double widht = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double area = widht * height;
        double perimeter = (widht + height) * 2;
        Console.WriteLine("{0:0.00} {1:0.00}", area, perimeter);
    }
}