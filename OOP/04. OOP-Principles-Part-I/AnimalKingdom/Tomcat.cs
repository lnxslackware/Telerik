namespace AnimalKingdom
{
    public class Tomcat : Cat
    {
        private const char Sex = 'm';

        public Tomcat(int age, string name)
            : base(age, name, Sex)
        {

        }
    }
}
