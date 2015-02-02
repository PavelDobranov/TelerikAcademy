namespace TwoFourEight
{
    using System;

    class TwoFourEightSolution
    {
        private static void Main()
        {
            long numberA = long.Parse(Console.ReadLine());
            long numberB = long.Parse(Console.ReadLine());
            long numberC = long.Parse(Console.ReadLine());

            long resultR = 0;

            if (numberB == 2)
            {
                resultR = numberA % numberC;
            }
            else if (numberB == 4)
            {
                resultR = numberA + numberC;
            }
            else
            {
                resultR = numberA * numberC;
            }

            if (resultR % 4 == 0)
            {
                Console.WriteLine(resultR / 4);
            }
            else
            {
                Console.WriteLine(resultR % 4);
            }

            Console.WriteLine(resultR);
        }
    }
}