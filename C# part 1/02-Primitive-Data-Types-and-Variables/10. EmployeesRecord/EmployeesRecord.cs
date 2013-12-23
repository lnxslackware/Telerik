using System;

class EmployeesRecord
{
    static void Main()
    {
        string firstName = "John";
        string lastName = "Doe";
        sbyte age = 35;
        char gender = 'M';
        int idNumber = 140563435;
        int employeeNumber = 27565684;

        Console.WriteLine("Employee full name: {0} {1}", firstName, lastName);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Gender: {0}", gender);
        Console.WriteLine("ID Number: {0}", idNumber);
        Console.WriteLine("Unique Employee Number: {0}", employeeNumber);
    }
}