/*
STEPIK
Симметричная ли матрица?

Проверьте, является ли двумерный массив симметричным относительно главной диагонали. Главная диагональ — та, которая идёт из левого верхнего угла двумерного массива в правый нижний.

Входные данные

Программа получает на вход число n, n ≤ 100, являющееся числом строк и столбцов в массиве. Далее во входном потоке идет n строк по nчисел, являющихся элементами массива.

Выходные данные

Программа должна выводить слово yes для симметричного массива и слово no для несимметричного.

Sample Input:

3
0 1 2
1 5 3
2 3 4
Sample Output:

yes
*/



using System;
using System.Collections.Generic;
using System.Text;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static bool IsSymmetry(int[,] arr, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[i, j] != arr[j, i])
                        return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] arr = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                var numbers = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = int.Parse(numbers[j]);
                }
            }

            Console.WriteLine(IsSymmetry(arr, n) ? "YES" : "NO");
        }
    }
}
