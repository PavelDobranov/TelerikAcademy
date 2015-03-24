namespace StudentsAndWorkers.Humans
{
    using System;

    using StudentsAndWorkers.Interfaces;

    public class Worker : Human, IHuman, IWorker
    {
        private const string ValueLessThanZeroErrorMessage = "Cannot be less than zero";
        private const string ToStringFormat = "{0}, Week salary: {1:F3}, Work hours per day: {2:F3}, Money per hour: {3:F3}";
        private const int WorkDays = 5;

        private decimal weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string secondName, decimal weekSalary, int workHoursPerDay)
            : base(firstName, secondName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("WeekSalary", Worker.ValueLessThanZeroErrorMessage);
                }

                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("WorkHoursPerDay", Worker.ValueLessThanZeroErrorMessage);
                }

                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            decimal moneyPerDay = this.WeekSalary / Worker.WorkDays;

            return moneyPerDay / this.WorkHoursPerDay;
        }

        public override string ToString()
        {
            return string.Format(Worker.ToStringFormat, base.ToString(), this.WeekSalary, this.WorkHoursPerDay, this.MoneyPerHour());
        }
    }
}