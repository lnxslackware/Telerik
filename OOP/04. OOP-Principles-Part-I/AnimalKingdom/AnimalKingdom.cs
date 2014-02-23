using System;
using System.Collections.Generic;

namespace AnimalKingdom
{
    class AnimalKingdom
    {
        static void Main()
        {
            //TODO: Add more animals to the list
            List<Animal> farm = new List<Animal>()
            {
                new Dog(1, "Sharo", 'm'),
                new Tomcat(2, "Tom"),
                new Dog(4, "Furer", 'm'),
                new Kitten(3, "Mathilda"),
                new Frog(1, "Kermitt", 'm'),
                new Dog(6, "Balkan", 'm'),
                new Tomcat(7, "Ra"),
                new Dog(8, "Betti", 'f'),
                new Kitten(1, "Fluffy"),
                new Frog(2, "Aria", 'f')
            };

            Animal.CalculateAndPrintAverageAge(farm);
        }
    }
}
