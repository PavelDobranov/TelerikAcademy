namespace Enigmanation
{
    using System;

    public class EnigmanationSolution
    {
        private const char ExpressionEndSymbol = '=';
        private const char SubExpressionStartSymbol = '(';
        private const char SubExpressionEndSymbol = ')';
        private const char Sum = '+';
        private const char Substract = '-';
        private const char Module = '%';
        private const char Multiply = '*';

        private static int expressionSymbolPosition = 0;

        static void Main()
        {
            string expression = Console.ReadLine();

            double result = EvaluateExpression(expression, ExpressionEndSymbol);

            Console.WriteLine("{0:F3}", result);
        }

        private static double EvaluateExpression(string expression, char endSymbol)
        {
            char mathOperator = Sum;
            double expressionResult = 0;
            char currentSymbol;

            while (true)
            {
                currentSymbol = expression[expressionSymbolPosition];
                expressionSymbolPosition++;

                if (char.IsDigit(currentSymbol))
                {
                    expressionResult = RecalculateResult(expressionResult, mathOperator, currentSymbol - '0');
                }

                if (currentSymbol == Sum || currentSymbol == Substract || currentSymbol == Module || currentSymbol == Multiply)
                {
                    mathOperator = currentSymbol;
                }

                if (currentSymbol == SubExpressionStartSymbol)
                {
                    double subExpressionResult = EvaluateExpression(expression, SubExpressionEndSymbol);

                    expressionResult = RecalculateResult(expressionResult, mathOperator, subExpressionResult);
                }

                if (currentSymbol == endSymbol)
                {
                    break;
                }
            }

            return expressionResult;
        }

        private static double RecalculateResult(double result, char mathOperator, double value)
        {
            switch (mathOperator)
            {
                case Sum: result += value; break;
                case Substract: result -= value; break;
                case Module: result %= value; break;
                case Multiply: result *= value; break;
            }

            return result;
        }
    }
}