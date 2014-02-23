using System;

namespace StudentsAndWorkers
{
    public class Worker : Human
    {
        public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public int WeekSalary { get; set; }
        public int WorkHoursPerDay { get; set; }

        public double MoneyPerHour()
        {
            return (this.WeekSalary / (double)7) / (double)this.WorkHoursPerDay;
        }

        public override string ToString()
        {
            return string.Format("{0} - Money per hour earned: {1:C}", base.ToString(), this.MoneyPerHour());
        }
    }
}
