// Problem 12. Subtracting polynomials
// Extend the previous program to support also subtraction and multiplication of polynomials.

using System;
using System.Text;

class SubtractingPolynomials
{
    static void Main()
    {
        int[] firstPolynomialArray = new int[] { -2, 6, 7, 0, 2 }; // 2x^4 + 7x^2 + 6x - 2
        int[] secondPolynomialArray = new int[] { 5, 0, 1 }; // x^2 + 5 

        Console.WriteLine("First polynomial: {0}", GetPolynomialFromArray(firstPolynomialArray));
        Console.WriteLine("Second polynomial: {0}", GetPolynomialFromArray(secondPolynomialArray));

        int[] polynomialSumArray = SubstractPolynomials(firstPolynomialArray, secondPolynomialArray);

        Console.WriteLine("Result: {0}", GetPolynomialFromArray(polynomialSumArray));
    }

    static string GetPolynomialFromArray(int[] polynomialArray)
    {
        StringBuilder result = new StringBuilder();

        for (int pow = polynomialArray.Length - 1; pow >= 0; pow--)
        {
            if (polynomialArray[pow] != 0 && polynomialArray[pow] != 1 && polynomialArray[pow] != -1)
            {
                result.Append(polynomialArray[pow] > 0 ? " + " : " - ");
                result.Append(Math.Abs(polynomialArray[pow]));

                if (pow != 0)
                {
                    result.Append(pow > 1 ? "x^" + pow : "x");
                }
            }
            else if (polynomialArray[pow] == 1 || polynomialArray[pow] == -1)
            {
                result.Append(polynomialArray[pow] > 0 ? " + " : " - ");

                if (pow != 0)
                {
                    result.Append(pow > 1 ? "x^" + pow : "x");
                }
            }
        }

        if (result[1] != '-')
        {
            result.Remove(0, 3);
        }
        else
        {
            result.Remove(0, 1);
        }

        return result.ToString();
    }

    static int[] SubstractPolynomials(int[] firstPolynomialArray, int[] secondPolynomialArray)
    {
        int maxLength = Math.Max(firstPolynomialArray.Length, secondPolynomialArray.Length);
        int[] result = new int[maxLength];

        for (int i = 0; i < firstPolynomialArray.Length; i++)
        {
            result[i] = firstPolynomialArray[i];
        }

        for (int i = 0; i < secondPolynomialArray.Length; i++)
        {
            result[i] = result[i] - secondPolynomialArray[i];
        }

        return result;
    }
}