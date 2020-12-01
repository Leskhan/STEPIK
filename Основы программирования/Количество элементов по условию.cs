/*
STEPIK

7.5 Итоговый тест
Количество элементов по условию

Дан список положительных целых чисел. Найдите все числа кратные 33 и при этом оканчивающиеся на 77, и замените каждое из этих чисел на их количество в массиве.

Входные данные
Сначала задано число NN — количество элементов в массиве (1\le N\le 1001≤N≤100). Далее через пробел записаны NN чисел — элементы массива. Массив состоит из целых положительных чисел, каждое из которых не превосходит 10001000.

Формат выходных данных

Выведите ответ на задачу.

Sample Input 1:

4
10 15 27 3
Sample Output 1:

10 15 1 3
Sample Input 2:

9
57 27 57 1 25 64 8 2 1
Sample Output 2:

3 3 3 1 25 64 8 2 1
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
            string[] arr = Console.ReadLine().Split();
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(arr[i]);
            }

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                count = numbers.Count(k => k % 3 == 0 && k % 10 == 7);
            }

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] % 3 == 0 && numbers[i] % 10 == 7)
                    Console.Write(count + " ");
                else
                    Console.Write(numbers[i] + " ");
            }
        }
    }
}
