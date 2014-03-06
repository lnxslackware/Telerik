using System;

namespace PersonClass
{
    class PersonClassTest
    {
        static void Main()
        {
            Person john = new Person("John", 17);
            
            Console.WriteLine(john);

            Console.WriteLine(new string('-', 20));

            Person ivan = new Person("Ivan");

            Console.WriteLine(ivan);
        }
    }
}