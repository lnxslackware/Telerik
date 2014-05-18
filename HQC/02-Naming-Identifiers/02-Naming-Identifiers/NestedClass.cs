using System;

class ContainingClass
{
    const int MaxCount = 6;

    class NestedClass
    {
        public void ConvertBoolToString(bool promenliva)
        {
            string promenlivaKatoString = promenliva.ToString();
            Console.WriteLine(promenlivaKatoString);
        }
    }

    public static void Main()
    {
        NestedClass instanceOfNestedClass = new NestedClass();
        instanceOfNestedClass.ConvertBoolToString(true);
    }
}