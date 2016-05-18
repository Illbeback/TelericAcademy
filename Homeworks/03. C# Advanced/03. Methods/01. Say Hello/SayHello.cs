using System;

class SayHello
{
    static void Main()
    {
        Name();
    }

    static void Name()
    {
        string name = Console.ReadLine();
        Console.WriteLine("Hello, {0}!", name);
    }
}
