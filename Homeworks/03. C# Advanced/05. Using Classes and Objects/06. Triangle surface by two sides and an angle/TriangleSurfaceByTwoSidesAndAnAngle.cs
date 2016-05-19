using System;

    class TriangleSurfaceByTwoSidesAndAnAngle
    {
    static void Main()
    {
        double sideA = double.Parse(Console.ReadLine());
        double sideB = double.Parse(Console.ReadLine());
        double angleAB = double.Parse(Console.ReadLine());

        double area;

        area = SidesAngleTriangleArea(sideA, sideB, angleAB);

        Console.WriteLine("{0:F2}", area);
    }

    public static double SidesAngleTriangleArea(double sideA, double sideB, double angleAB)
    {
        return (sideA * sideB * Math.Sin(angleAB * Math.PI / 180)) / 2;
    }

}