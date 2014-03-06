using System.Text;
namespace PersonClass
{
    public class Person
    {
        private string name;
        private int? age;

        public Person(string name, int? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name 
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public int? Age
        { 
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("Name: {0} Age: {1}", this.Name, this.Age != null ? this.Age.ToString() : "Not specified");
            
            return result.ToString();
        }
    }
}
