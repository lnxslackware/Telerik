namespace School
{
    using System;

    public class School
    {
        private int nextStudentNumber = 10000;

        public int NextStudentNumber
        {
            get
            {
                if (nextStudentNumber > 99999)
                {
                    throw new InvalidOperationException("The school is full(There are no available student numbers).");
                }

                int availableNumber = nextStudentNumber;
                nextStudentNumber++;
                return availableNumber;
            }
        }
    }
}
