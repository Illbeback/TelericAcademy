using System;

namespace Age
{
    class Age
    {
        static void Main()
        {
            DateTime today = DateTime.Today;
            Console.WriteLine("Add your birthday in format mm/dd/yyyy:");
            string birthday = Console.ReadLine();
            int inputYear = int.Parse(birthday.Substring(6, 4));
            int inputMonth = int.Parse(birthday.Substring(0, 2));
            int inputDay = int.Parse(birthday.Substring(3, 2));
            int age = today.Year - inputYear;
            if (inputMonth == today.Month)
            {
                if (inputDay > today.Day)
                {
                    age--;
                }
            }
            if (inputMonth > today.Month)
            {
                age--;
            }

            int ageAfterTenYears = age + 10;
            Console.WriteLine(age);
            Console.WriteLine(ageAfterTenYears);
            //    Console.WriteLine("Your current age is: " + age);
            //    Console.WriteLine("Your age after 10 years will be: " + ageAfterTenYears);
        }
    }
}