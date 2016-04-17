using System;

class Circle
{
    static void Main()
    {
        double radius = double.Parse(Console.ReadLine());
        double Pi = Math.PI;
        double perimeter = (2 * Pi * radius);
        double area = (Pi * (radius * radius));

        Console.WriteLine("{0:0.00} {1:0.00}", perimeter, area);

    }
}