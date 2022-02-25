// See https://aka.ms/new-console-template for more information
//a console program that implements a simple calculator
using System;

namespace programe01
{
    internal static class caculator01
    {
        static double calculate(double num1, double num2, string oper)
        {
            double result = 0;
            switch (oper)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                default:
                    throw new InvalidOperationException("operator can't identify." +
                        "\nPlease, choose operator in ['+','-','*','/']");
            }
            return result;
        }

        static void Main()
        {
            Console.WriteLine("Please enter two numbers to calculate:");
            double? num1 = null, num2 = null;
            while (true)
            {
                try
                {
                    string s1 = Console.ReadLine();
                    num1 = double.Parse(s1);

                    string s2 = Console.ReadLine();
                    num2 = double.Parse(s2);

                    break;

                }
                catch (FormatException e)
                {
                    Console.WriteLine("Error: The enter is not numbers");
                    Console.WriteLine("Please enter two numbers to calculate again:");
                }

            }
            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter a operator(+,-,*,/) to calculate:");
                    string oper = Console.ReadLine();

                    Console.WriteLine("The calculation result is: " + calculate((double)num1, (double)num2, oper));

                    break;

                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine("operator can't identify." +
                        "\nPlease, choose operator in ['+','-','*','/']");
                }
            }
        }
    }
}