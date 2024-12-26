
using System;

class Program
{
    static void Main()
    {
        int a = 1, b = 2, c = 3;
        int minValue = FindMinimum(a, b, c);
        Console.WriteLine($"Min value: {minValue}");
    }

    static int FindMinimum(int a, int b, int c)
    {
        int[] numbers = { a, b, c };
        string[] operators = { "*", "+", "-" };
        int minValue = int.MaxValue;

        foreach (var op1 in operators)
        {
            foreach (var op2 in operators)
            {
                int result = Calculate(a,b,c,op1,op2);
                minValue = Math.Min(minValue, result);
            }
            
            // Local function
            static int Calculate(int num1, int num2, int num3, string operator1, string operator2)
            {
                int temp;
                if(operator1 == "*")
                    temp = num1 * num2;
                else if(operator1 == "+")
                    temp = num1 + num2;
                else
                    temp = num1 - num2;

                if(operator2 == "*")
                    return temp * num3;

                else if (operator2 == "+")
                    return temp + num3;
                else
                    return temp - num3;
            }
        }
        return minValue;
    }
}
