using System;

class CompanyDetails
{
    static void Main()
    {
        Console.WriteLine("Please enter the following company details:");
        Console.Write("Name: ");
        string companyName = Console.ReadLine();
        Console.Write("Address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Phone number: ");
        int companyPhone = int.Parse(Console.ReadLine());
        Console.Write("Fax number: ");
        int companyFax = int.Parse(Console.ReadLine());
        Console.Write("Website: ");
        string companyWebsite = Console.ReadLine();
        Console.WriteLine("Please enter the following manager details:");
        Console.Write("Firstname: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Age: ");
        byte managerAge = byte.Parse(Console.ReadLine());
        Console.Write("Phone number: ");
        int managerPhone = int.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("-- Company details --");
        Console.WriteLine();
        Console.WriteLine("Company name: {0}", companyName);
        Console.WriteLine("Company address: {0}", companyAddress);
        Console.WriteLine("Company phone number: {0}", companyPhone);
        Console.WriteLine("Company fax number: {0}", companyFax);
        Console.WriteLine("Company website: {0}", companyWebsite);
        Console.WriteLine();
        Console.WriteLine("-- Manager details --");
        Console.WriteLine();
        Console.WriteLine("Manager name: {0} {1}", managerFirstName, managerLastName);
        Console.WriteLine("Manager age: {0}", managerAge);
        Console.WriteLine("Manager phone number: {0}", managerPhone);
    }
}