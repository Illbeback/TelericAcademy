namespace MobilePhone
{
    using System;

    public class GSMCallHistoryTest
    {
        public static void TestGSMCallHistory()
        {
            GSM gsm = new GSM("10", "Samsung");
            gsm.PerformCall("0864743331", 110);
            gsm.PerformCall("0891362423", 65);
            gsm.PerformCall("0870303991", 304);
            Console.WriteLine(gsm.PrintCallHistory());
            Console.WriteLine(gsm.TotalCallsPrice(0.37));

            Call call = gsm.CallHistory[0];
            foreach (var historyCall in gsm.CallHistory)
            {
                if (call.Duration < historyCall.Duration)
                {
                    call = historyCall;
                }
            }
            gsm.CallHistory.Remove(call);
            Console.WriteLine(gsm.TotalCallsPrice(0.37));
            gsm.ClearCallHistory();
            Console.WriteLine(gsm.PrintCallHistory());
        }
    }
}