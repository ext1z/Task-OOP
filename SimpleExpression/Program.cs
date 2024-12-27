
using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int minValue = FindMinimum(a, b, c);
        Console.WriteLine(minValue);
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
                int result = Calculate(a, b, c, op1, op2);
                minValue = Math.Min(minValue, result);
            }

            // Local function
            static int Calculate(int num1, int num2, int num3, string operator1, string operator2)
            {
                int temp;

                if (operator2 == "*")
                {
                    temp = num2 * num3;
                    return operator1 == "+" ? num1 + temp : num1 - temp;
                }
                else if (operator1 == "*" && operator2 != "*")
                {
                    temp = num1 * num2;
                    return operator2 == "+" 
                        ? temp + num3 
                        : temp - num3;
                }
                else
                {
                    temp = operator1 == "+" 
                        ? num1 + num2 
                        : num1 - num2;
                    return operator2 == "+" 
                        ? temp + num3 
                        : temp - num3;
                }
            }
        }
        return minValue;
    }
}


