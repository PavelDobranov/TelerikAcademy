﻿// Problem 2. Gravitation on the Moon
// The gravitational field of the Moon is approximately 17% of that on the Earth.
// Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        double moonGravitationalField = 0.17;

        Console.Write("Please enter weight on the Earth: ");
        double weightOnTheEarth = double.Parse(Console.ReadLine());

        double weightOnTheMoon = weightOnTheEarth * moonGravitationalField;

        Console.WriteLine("Weight on the Moon: {0}", weightOnTheMoon);
    }
}