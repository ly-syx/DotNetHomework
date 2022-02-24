// See https://aka.ms/new-console-template for more information

//a console program that implements a simple calculator
Console.WriteLine("Please enter two numbers to calculate:");
string s1 = Console.ReadLine();
float num1 = Convert.ToSingle(s1);

string s2 = Console.ReadLine();
float num2 = Convert.ToSingle(s2);

Console.WriteLine("Please enter a operator(such as '+','-'...) to calculate:");
string oper = Console.ReadLine();

Console.WriteLine("The calculation result is: ");
switch (oper)
{
    case "+": Console.WriteLine(num1 + num2);
        break;
    case "-":
        Console.WriteLine(num1 - num2);
        break;
    case "*":
        Console.WriteLine(num1 * num2);
        break;
    case "/":
        Console.WriteLine(num1 / num2);
        break;
}