using System;

class MoonGravity
{
    static void Main()
    {
        float weightOnEarth = float.Parse(Console.ReadLine());
        float weightOnEarthOnePercent = weightOnEarth / 100;
        float weightOnTheMoon = weightOnEarthOnePercent * 17;
        Console.WriteLine("{0:0.000}", weightOnTheMoon);
    }
}