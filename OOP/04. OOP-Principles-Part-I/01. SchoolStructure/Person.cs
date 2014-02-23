using System;

namespace SchoolStructure
{
    public abstract class Person
    {
        private string name;

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

        public Person(string name)
        {
            this.Name = name;
        }
    }
}