using System;

class ContainingClass
{
    const int MaxCount = 6;

    class InputData
    {
        public void PrintBoolData(bool inputData)
        {
            string boolAsString = inputData.ToString();
            Console.WriteLine(boolAsString);
        }
    }

    public static void Main()
    {
        NestedClass dataManager = new NestedClass();
        dataManager.ConvertBoolToString(true);
    }
}