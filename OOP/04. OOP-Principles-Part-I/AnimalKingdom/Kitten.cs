namespace AnimalKingdom
{
    public class Kitten : Cat
    {
        private const char Sex = 'f';

        public Kitten(int age, string name)
            : base(age, name, Sex)
        {

        }
    }
}
