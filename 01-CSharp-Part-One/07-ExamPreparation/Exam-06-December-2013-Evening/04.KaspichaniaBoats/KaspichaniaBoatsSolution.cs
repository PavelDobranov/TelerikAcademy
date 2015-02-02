namespace KaspichaniaBoats
{
    using System;

    class KaspichaniaBoatsSolution
    {
        private static void Main()
        {
            int numberN = int.Parse(Console.ReadLine());

            Console.Write(new string('.', numberN));
            Console.Write('*');
            Console.WriteLine(new string('.', numberN));

            int outerDots = numberN - 1;
            int innerDots = 0;

            for (int i = 0; i < numberN - 1; i++)
            {
                Console.Write(new string('.', outerDots));
                Console.Write('*');
                Console.Write(new string('.', innerDots));
                Console.Write('*');
                Console.Write(new string('.', innerDots));
                Console.Write('*');
                Console.WriteLine(new string('.', outerDots));

                outerDots--;
                innerDots++;
            }

            Console.WriteLine(new string('*', numberN * 2 + 1));

            for (int i = 0; i < numberN / 2; i++)
            {
                outerDots++;
                innerDots--;

                Console.Write(new string('.', outerDots));
                Console.Write('*');
                Console.Write(new string('.', innerDots));
                Console.Write('*');
                Console.Write(new string('.', innerDots));
                Console.Write('*');
                Console.WriteLine(new string('.', outerDots));
            }


            Console.Write(new string('.', outerDots + 1));
            Console.Write(new string('*', numberN));
            Console.WriteLine(new string('.', outerDots + 1));

        }
    }
}