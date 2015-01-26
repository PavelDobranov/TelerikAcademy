using System;

class Garden
{
    static void Main()
    {
        double[] seedsCost = { 0.5, 0.4, 0.25, 0.6, 0.3, 0.4 };
        double totalArea = 250;
        double totalCosts = 0;

        for (int i = 0; i < seedsCost.Length; i++)
        {
            double currentSeedAmount = double.Parse(Console.ReadLine());
            double currentSeedCost = seedsCost[i];

            totalCosts += currentSeedAmount * currentSeedCost;

            if (i < seedsCost.Length - 1)
            {
                double currentSeedArea = double.Parse(Console.ReadLine());

                totalArea -= currentSeedArea;
            }
        }

        Console.WriteLine("Total costs: {0:0.00}", totalCosts);

        if (totalArea > 0)
        {
            Console.WriteLine("Beans area: {0}", totalArea);
        }
        else if (totalArea < 0)
        {
            Console.WriteLine("Insufficient area");
        }
        else if (totalArea == 0)
        {
            Console.WriteLine("No area for beans");
        }
    }
}