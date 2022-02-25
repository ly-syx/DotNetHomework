// See https://aka.ms/new-console-template for more information
//a console program that implements a simple calculator

namespace programe01
{
    internal static class caculator01
    {
        static double calculate(double num1, double num2, string oper)
        {
            double result=0; 
            switch (oper)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 *num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
            }
            return result;
        }

        static void Main()
        {
            Console.WriteLine("Please enter two numbers to calculate:");
            string s1 = Console.ReadLine();
            double num1 = Convert.ToSingle(s1);

            string s2 = Console.ReadLine();
            double num2 = Convert.ToSingle(s2);

            Console.WriteLine("Please enter a operator(+,-,*,/) to calculate:");
            string oper = Console.ReadLine();

            Console.WriteLine("The calculation result is: " + calculate(num1, num2, oper));
        }
    }
    
}