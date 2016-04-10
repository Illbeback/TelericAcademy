using System;

namespace BankAccountData
{
    class BankAccountData
    {
        static void Main()
        {
            string firstName = "Vasil";
            string secondName = "Nikolaev";
            string thirdName = "Vasilev";
            decimal money = 300.025M;
            string bankName = "First Bank of Bulgaria";
            string iban = "BG80 BNBG 9661 1020 3456 78";
            long cardOne = 4539612515787517;
            long cardTwo = 4024007121992472;
            long cardThree = 4929048467810023;
            Console.WriteLine(@"{0} {1} {2} have {3} leva in {4}.
His IBAN is ""{5}"" and his card numbers are: {6}; {7}; {8}.",
                firstName, secondName, thirdName, money, bankName, iban, cardOne, cardTwo, cardThree);
        }
    }
}