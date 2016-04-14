using System;

class PointCircleRectangle
{
    static void Main()
    {
        double x, y, r, z;
        x = double.Parse(Console.ReadLine());
        y = double.Parse(Console.ReadLine());
        r = 1.5;
        z = Math.Sqrt((x - 1) * (x - 1) + (y - 1) * (y - 1));
        bool inCircle = (z <= r);
        bool outRectangle = (x < -1 || x > 5 || y > 1 || y < -1);
        if ((inCircle == true) && (outRectangle == true))
        {
            Console.WriteLine("{0} {1}", "inside circle", "outside rectangle");
        }
        else
            if ((inCircle == true) && (outRectangle == false))
        { Console.WriteLine("{0} {1}", "inside circle", "inside rectangle"); }
        else
                if ((inCircle == false) && (outRectangle == true))
        { Console.WriteLine("{0} {1}", "outside circle", "outside rectangle"); }
        else
        { Console.WriteLine("{0} {1}", "outside circle", "inside rectangle"); }
    }
}