namespace AnimalKingdom
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Animal : ISound
    {
        private int age;
        private string name;
        private char sex;

        protected Animal(int age, string name, char sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value < 0 || value > 20)
                {
                    throw new ArgumentOutOfRangeException("The age cannot be a negative number or number greater than 20.");
                }

                this.age = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name cannot be null or empty.");
                }

                this.name = value;
            }
        }

        public char Sex
        {
            get
            {
                return this.sex;
            }
            private set
            {
                if (char.ToLower(value) != 'm' && char.ToLower(value) != 'f')
                {
                    throw new ArgumentException("The sex can be either 'm' for male or 'f' for female.");
                }

                this.sex = char.ToLower(value);
            }
        }

        public static void CalculateAndPrintAverageAge(IEnumerable<Animal> animals)
        {
            List<Animal> temp = new List<Animal>(animals);
            var groupedList = temp.GroupBy(animal => animal.GetType());

            foreach (var group in groupedList)
            {
                Console.WriteLine("{0} -> {1}", group.Key, group.Average(animal => animal.Age));
            }
        }

        public abstract void MakeSound();
    }
}