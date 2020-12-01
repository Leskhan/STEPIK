/*
STEPIK

7.5 Итоговый тест
Различные элементы

Дан список, упорядоченный по неубыванию элементов в нем. Определите, сколько в нем различных элементов.

 

Входные данные

Сначала задано число NN — количество элементов в массиве (1\le N\le 1001≤N≤100). Далее через пробел записаны NN чисел — элементы массива. Массив состоит из целых чисел, каждое из которых по модулю не превосходит 10001000.

Формат выходных данных

Выведите количество различных элементов.

Sample Input:

5
1 1 2 2 3
Sample Output:

3
*/



using System;
using System.Linq;
using System.Collections.Generic;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr = Console.ReadLine().Split();
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(arr[i]);
            }

            int count = 0;

            for (int i = 0; i < n - 1; i++)
            {
                if (numbers[i] != numbers[i + 1])
                {
                    count++;
                }
            }

            Console.WriteLine(count + 1);
        }
    }
}
