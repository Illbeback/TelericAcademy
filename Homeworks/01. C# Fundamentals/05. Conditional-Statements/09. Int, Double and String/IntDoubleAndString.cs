using System;

class IntDoubleAndString
{
    static void Main()
    {
        string choise = Console.ReadLine();
        switch (choise)
        {
            case "integer":
                {
                    int inputInt = int.Parse(Console.ReadLine());
                    Console.WriteLine(inputInt + 1);
                }
                break;
            case "real":
                {
                    double inputDouble = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:0.00}", inputDouble + 1);
                    break;
                }
            case "text":
                {
                    string inputString = Console.ReadLine();
                    Console.WriteLine(inputString + "*");
                }
                break;
            default:
                {
                    Console.Write("Invalid command!");
                }
                break;
        }
    }
}