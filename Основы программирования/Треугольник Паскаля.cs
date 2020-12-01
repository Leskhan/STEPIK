/*
STEPIK

7.4 Многомерные массивы
Треугольник Паскаля

Даны два числа nn и mm. Создайте двумерный массив A[n,m]A[n,m] и заполните его по следующим правилам: Числа, стоящие в строке 0 или в столбце 0 равны 1. Для всех остальных элементов массива- элемент равен сумме двух элементов, стоящих слева и сверху от него.

 

Входные данные

Программа получает на вход строку, в котором через пробел записаны два натуральных числа nn и mm через пробел, каждое из которых не превышает 10.10.

 

Выходные данные

Выведите полученный массив.

Sample Input:

2 2
Sample Output:

1 1
1 2
*/



using System;
using System.Linq;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            int n = int.Parse(numbers[0]);
            int m = int.Parse(numbers[1]);
            int[,] array = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i == 0 || j == 0)
                        array[i, j] = 1;
                }
            }

            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < m; j++)
                {
                    array[i, j] = array[i - 1, j] + array[i, j - 1];
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
