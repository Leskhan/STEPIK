/*
STEPIK
Двойной переворот

Дана последовательность натуральных чисел 1, 2, 3, ..., N (1 ≤ N ≤ 1000). Необходимо сначала расположить в обратном порядке часть этой последовательности от элемента с номером A до элемента с номером B, а затем от C до D (A < B; C < D; 1 ≤ A, B, C, D ≤ N).

Входные данные

Вводятся натуральные числа числа N, A, B, C, D.

Выходные данные

Требуется вывести полученную последовательность. Числа следует выводить через пробел.

Sample Input:

9 2 5 6 9
Sample Output:

1 5 4 3 2 9 8 7 6
*/



using System;
using System.Collections.Generic;
using System.Linq;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static List<int> GetList(int n)
        {
            var list = new List<int>();
            for (int i = 1; i <= n; i++)
                list.Add(i);

            return list;
        }

        static void SwapNumbers(List<int> list, int start, int end)
        {
            for (int i = start - 1, j = end - 1; i < (end + start) / 2; i++, j--)
            {
                int t = list[i];
                list[i] = list[j];
                list[j] = t;
            }
        }

        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(e => int.Parse(e)).ToArray();
            var list = GetList(numbers[0]);

            SwapNumbers(list, numbers[1], numbers[2]);
            SwapNumbers(list, numbers[3], numbers[4]);

            foreach (var e in list)
                Console.Write(e + " ");
        }
    }
}
