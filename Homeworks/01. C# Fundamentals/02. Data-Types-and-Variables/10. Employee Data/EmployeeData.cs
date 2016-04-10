using System;

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main()
        {
            Console.WriteLine("Enter first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter age of the employee:");
            byte Age = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter gender: (m or f)");
            string gender = Console.ReadLine();
            Console.WriteLine("Enter Id Number of the employee:");
            long idNum = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter the qnique employee number:");
            int uniqueEmpNum = int.Parse(Console.ReadLine());
            Console.WriteLine(" {0} \n {1} \n {2} \n {3} \n {4} \n {5}", firstName, lastName, Age, gender, idNum, uniqueEmpNum);
        }
    }
}