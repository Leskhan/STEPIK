/*
STEPIK

7.4 Многомерные массивы
Симметричная ли матрица?

Проверьте, является ли двумерный массив симметричным относительно главной диагонали. Главная диагональ — та, которая идёт из левого верхнего угла двумерного массива в правый нижний.

Входные данные

Программа получает на вход число n, n \le 100n,n≤100, являющееся числом строк и столбцов в массиве.
Далее во входном потоке идет nn строк по nn чисел разделенных пробелами, являющихся элементами массива.

Выходные данные

Программа должна выводить "YES" для симметричного массива и "NO" для несимметричного.

Sample Input:

3
1 2 3
2 8 6
3 6 9
Sample Output:

YES
*/



using System;
using System.Linq;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] numbers = new int[n, n];
            bool check = false;

            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    numbers[i, j] = int.Parse(arr[j]);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (numbers[i, j] == numbers[j, i])
                        check = true;
                    else
                    {
                        check = false;
                        goto stop;
                    }
                }
            }

        stop:
            Console.WriteLine(check ? "YES" : "NO");
        }
    }
}
