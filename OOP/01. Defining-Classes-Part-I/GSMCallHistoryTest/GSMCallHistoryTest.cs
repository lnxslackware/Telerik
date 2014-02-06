using System;
using MobilePhone.Library;

namespace GSMCallHistoryTest
{
    class GSMCallHistoryTest
    {
        static void Main()
        {
            //creating instance of the GSM class
            GSM gsm = new GSM("ZTE", "Blade Q");

            //adding calls
            gsm.AddCall("0888888888", 234);
            gsm.AddCall("0878432553", 454);
            gsm.AddCall("064532533", 143);

            //print call history
            gsm.PrintCallHistory();

            //calculating the total price for all calls
            decimal price = gsm.CalculateTotalCallPrice(0.37);
            Console.WriteLine(price);

            //removing the longest call and calculating the total price again
            gsm.DeleteCall(1);
            price = gsm.CalculateTotalCallPrice(0.37);
            Console.WriteLine(price);

            //clearing the call history and printing it again
            gsm.ClearCalls();
            gsm.PrintCallHistory();
        }
    }
}
