using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programe01
{
    //输出用户指定数据的所有素数因子
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("请输入一个大于1的正整数:");
                    int n = int.Parse(Console.ReadLine());
                    Console.Write($"{n}的所有素数因子为:");
                    List<int> primeFactors = FindPrimeFactors(n);
                    foreach (int i in primeFactors)
                    {
                        Console.Write(i + " ");
                    }
                    break;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("输入错误: " + ex.Message);
                    Console.WriteLine("请重新输入");
                }
            }
        }

        static List<int> FindPrimeFactors(int n)
        {
            List<int> primeFactors = new List<int>();
            for (int i = 2; i <= n;)
            {
                if (n % i == 0)
                {
                    n /= i;
                    primeFactors.Add(i);
                }
                else
                {
                    i++;
                }
            }
            return primeFactors;
        }
    }
}
