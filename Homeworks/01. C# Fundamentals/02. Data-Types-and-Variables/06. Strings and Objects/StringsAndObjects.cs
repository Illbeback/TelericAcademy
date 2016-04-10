using System;

namespace StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main()
        {
            string variableOne = "Hello";
            string variableTwo = "World";
            object getThisTwo;
            getThisTwo = variableOne + " " + variableTwo;
            Console.WriteLine(getThisTwo);
        }
    }
}
