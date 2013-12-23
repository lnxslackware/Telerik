using System;

class AgeInTenYears
{
    static void Main()
    {
        Console.WriteLine("Enter your age:");
        int age = int.Parse(Console.ReadLine());
        int futureAge = age + 10;
        Console.WriteLine("In ten years you will be " + futureAge + " years old");
    }
}