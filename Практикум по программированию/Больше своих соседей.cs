/*
STEPIK
Больше своих соседей

Дан список чисел. Определите, сколько в этом списке элементов, которые больше двух своих соседей и выведите количество таких элементов.

Входные данные

Вводится список чисел. Все числа списка находятся на одной строке.

Выходные данные

Выведите ответ на задачу.

Sample Input 1:

1 2 3 4 5
Sample Output 1:

0
Sample Input 2:

1 5 1 5 1
Sample Output 2:

2
*/



using System;
using System.Collections.Generic;
using System.Linq;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(e => int.Parse(e)).ToArray();
            int count = 0;

            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (numbers[i - 1] < numbers[i] && numbers[i] > numbers[i + 1])
                    count++;
            }

            Console.WriteLine(count);
        }
    }
}
