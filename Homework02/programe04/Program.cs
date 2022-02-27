using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programe04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("请输入矩阵行数:");
                    int m = int.Parse(Console.ReadLine());
                    Console.WriteLine("请输入矩阵列数:");
                    int n = int.Parse(Console.ReadLine());
                    int[,] matrix = new int[m, n];
                    Console.WriteLine("请填入矩阵:");
                    for (int i = 0; i < m; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            matrix[i, j] = int.Parse(Console.ReadLine());
                        }
                    }

                    Console.WriteLine("输入的矩阵如下:");
                    for (int i = 0; i < m; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(matrix[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("该矩阵{0}托普利茨矩阵", IsToplitzMatrix(matrix) ? "是" : "不是");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("输入错误: " + ex.Message);
                    Console.WriteLine("请重新输入");
                }
            }
        }

        static bool IsToplitzMatrix(int[,] matrix)
        {
            if (matrix == null) return false;

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    if (i + 1 < matrix.GetLength(0) && j + 1 < matrix.GetLength(1) && matrix[i, j] != matrix[i + 1, j + 1])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
