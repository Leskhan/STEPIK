/*
STEPIK

7.4 Многомерные массивы
Побочная диагональ

Дано число n, n\le100n,n≤100. Создайте массив n\times nn×n и заполните его по следующему правилу:
числа на диагонали, идущей из правого верхнего в левый нижний угол, равны 1;
числа, стоящие выше этой диагонали, равны 00;
числа, стоящие ниже этой диагонали, равны 22.
Входные данные
Программа получает на вход число nn.

Выходные данные
Необходимо вывести полученный массив. Числа разделяйте одним пробелом.
Sample Input:

3
Sample Output:

0 0 1
0 1 2
1 2 2
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

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j == n - 1)
                        numbers[i, j] = 1;

                    if (i + j >= n)
                        numbers[i, j] = 2;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(numbers[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
