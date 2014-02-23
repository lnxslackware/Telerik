namespace AnimalKingdom
{
    using System;

    public abstract class Cat : Animal
    {
        protected Cat(int age, string name, char sex)
            : base(age, name, sex)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
