namespace MobilePhone
{
    using System;

    public class GSMTest
    {
        public static void TestGSMClass()
        {
            GSM[] gsms = new GSM[10];
            Random randomManufacturer = new Random();
            string[] manufacturers = { "Apple", "Samsung", "Lenovo", "Nokia", "LG" };
            for (int i = 0; i < 10; i++)
            {
                gsms[i] = new GSM(i.ToString(), manufacturers[randomManufacturer.Next(0, 5)]);
            }

            foreach (var gsm in gsms)
            {
                Console.WriteLine(gsm);
            }

            Console.WriteLine(GSM.IPhone4S);
        }
    }
}