namespace Methods
{
    static class StudentExtensions
    {
        public static bool IsOlderThan(this Student firstStudent, Student secondStudent)
        {
            //If the second students birth date is greater it means that the first student is older.
            bool isOlder = firstStudent.BirthDate > secondStudent.BirthDate;
            return !isOlder;
        }
    }
}
