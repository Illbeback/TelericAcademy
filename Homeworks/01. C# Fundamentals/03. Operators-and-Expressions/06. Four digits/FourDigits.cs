using System;

class FourDigits
{
    static void Main()
    {
        int x, a, b, c, d;
        x = int.Parse(Console.ReadLine());
        a = x / 1000;
        b = (x / 100) % 10;
        c = (x / 10) % 10;
        d = (x / 1) % 10;
        Console.WriteLine(a + b + c + d);
        string a1 = a.ToString();
        string b1 = b.ToString();
        string c1 = c.ToString();
        string d1 = d.ToString();
        Console.WriteLine(d1 + c1 + b1 + a1);
        Console.WriteLine(d1 + a1 + b1 + c1);
        Console.WriteLine(a1 + c1 + b1 + d1);
        Console.ReadLine();
    }
}