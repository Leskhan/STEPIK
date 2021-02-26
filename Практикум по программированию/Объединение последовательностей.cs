/*
STEPIK
Объединение последовательностей

Даны две бесконечных возрастающих последовательности чисел A и B. i-ый член последовательности A равен i2. i-ый член последовательности B равен i3.

Требуется найти Cx, где C – возрастающая последовательность, полученная при объединении последовательностей A и B. Если существует некоторое число, которое встречается и в последовательности A и в последовательности B, то в последовательность C это число попадает в единственном экземпляре.

Входные данные

В единственной строке на входе дано натуральное число x (1 ≤ x ≤ 107).

Выходные данные

Выведите Cx. Числа выводить в строчку, разделять пробелом.

Sample Input:

2
Sample Output:

1 4 8
*/



using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            var A = new List<int>();
            var B = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                A.Add(i * i);
                B.Add(i * i * i);
            }

            var result = A.Union(B).ToList();
            result.Sort();

            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
