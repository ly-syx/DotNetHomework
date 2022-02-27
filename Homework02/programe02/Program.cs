using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("请输入一行整数作为数组, 并用空格分隔它们");
                    string[] strNumbArr = Console.ReadLine().Split(' ');
                    int[] NumbArr = new int[strNumbArr.Length];
                    for (int i = 0; i < strNumbArr.Length; i++)
                    {
                        NumbArr[i] = int.Parse(strNumbArr[i]);
                    }

                    Console.WriteLine("这组数据中");
                    Console.WriteLine($"最大值是:\t{FindMax(NumbArr)}");
                    Console.WriteLine($"最小值是:\t{FindMin(NumbArr)}");
                    Console.WriteLine($"平均值是:\t{Averaging(NumbArr)}");
                    Console.WriteLine($"总和是:\t{Sum(NumbArr)}");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("请重新输入");
                }
            }
        }

        static int Sum(int[] numbs)
        {
            if (numbs == null)
            {
                Console.WriteLine("数组为空!!! 默认和为0");
                return 0;
            }

            int sum = 0;
            foreach (int i in numbs)
            {
                sum += i;
            }
            return sum;
        }

        static float Averaging(int[] numbs)
        {
            if (numbs == null)
            {
                Console.WriteLine("数组为空!!! 默认平均数为0");
                return 0;
            }

            return (float)Sum(numbs) / numbs.Length;
        }

        static int FindMax(int[] numbs)
        {
            if (numbs == null)
            {
                Console.WriteLine("数组为空!!! 默认最大值为0");
                return 0;
            }

            int max = numbs[0];
            for (int i = 1; i < numbs.Length; i++)
            {
                if (numbs[i] > max)
                {
                    max = numbs[i];
                }
            }
            return max;
        }

        static int FindMin(int[] numbs)
        {
            if (numbs == null)
            {
                Console.WriteLine("数组为空!!! 默认最小值为0");
                return 0;
            }

            int min = numbs[0];
            for (int i = 1; i < numbs.Length; i++)
            {
                if (numbs[i] < min)
                {
                    min = numbs[i];
                }
            }
            return min;
        }
    }
}
