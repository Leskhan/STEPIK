/*
STEPIK

7.4 Многомерные массивы
Таблица умножения

Даны два числа nn и mm. Создайте двумерный массив A[n,m]A[n,m], заполните его таблицей умножения A[i,j]=i \cdot jA[i,j]=i⋅j и выведите на экран.

 

Входные данные

Программа получает на вход строку, в которой через пробел даны два числа nn и mm – количество строк и столбцов, соответственно.

 

Выходные данные

Программа должна вывести полученный массив. Числа разделяйте одним пробелом.

Sample Input 1:

2 3
Sample Output 1:

1 2 3
2 4 6
Sample Input 2:

3 2
Sample Output 2:

1 2
2 4
3 6
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
            int a = 1, b = 1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = a * b;
                    b++;
                }
                b = 1;
                a++;
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
