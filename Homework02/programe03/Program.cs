using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programe03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2~100内的所有素数为:");
            int[] primes = FindPrime(100);
            for (int i = 0; i < 100 - 1; i++)
            {
                if (primes[i] != 0)
                {
                    Console.Write(primes[i] + " ");
                }
            }
        }


        static int[] FindPrime(int endNumb)
        {
            int[] numbs = new int[endNumb - 1];

            //待筛选数组初始化赋值2~endNumb
            for (int i = 0; i < endNumb - 1; i++)
            {
                numbs[i] = i + 2;
            }

            //i作为除数, 将数组中能够被i整除切大于i的数去掉(置零)
            for (int i = 2; i <= endNumb; i++)
            {
                for (int j = i - 1; j < endNumb - 1; j++)
                {
                    if (numbs[j] != 0 && numbs[j] % i == 0)
                    {
                        numbs[j] = 0;
                    }
                }
            }
            return numbs;
        }
    }
}
