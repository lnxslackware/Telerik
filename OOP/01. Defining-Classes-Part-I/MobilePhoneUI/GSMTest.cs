using System;
using MobilePhone.Library;

class GSMTest
{
    private static GSM[] phones = new GSM[]
        {
            new GSM("Motorola", "Milestone XT720", 600, "LnX"),
            new GSM("Nokia", "n70"),
            new GSM("ZTE", "Blade Q")
        };

    static void Main()
    {
        foreach (var gsm in phones)
        {
            Console.WriteLine(gsm);
        }
        
        Console.WriteLine(GSM.IPhone4S);
    }
}