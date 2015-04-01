// Problem 3. Range Exceptions
// Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. 
// It should hold error message and a range definition [start … end].
// Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> 
// by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].

namespace RangeException
{
    using System;

    public static class TestRangeException
    {
        static void Main()
        {
            try
            {
                //TestNumber();
                TestDate();
            }
            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine("Number must be in range {0} - {1}", ex.RangeMin, ex.RangeMax);
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine("Date must be in range {0:dd/MM/yyyy} - {1:dd/MM/yyyy}", ex.RangeMin, ex.RangeMax);
            }
        }

        private static void TestNumber()
        {
            const int MinNumber = 0;
            const int MaxNumber = 100;

            int number = 130;

            if (number < MinNumber || number > MaxNumber)
            {
                throw new InvalidRangeException<int>("Number is out of range", MinNumber, MaxNumber);
            }
        }

        private static void TestDate()
        {
            DateTime MinDate = new DateTime(1980, 1, 1);
            DateTime MaxDate = new DateTime(2013, 12, 31);

            DateTime date = new DateTime(2018, 6, 3);

            if (date < MinDate || date > MaxDate)
            {
                throw new InvalidRangeException<DateTime>("Date is out of range", MinDate, MaxDate);
            }
        }
    }
}