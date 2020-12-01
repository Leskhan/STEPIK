/*
STEPIK

7.5 Итоговый тест
Меньше следующего

Дан массив, состоящий из целых чисел. Напишите программу, которая подсчитает количество элементов массива, которые меньше следующего за ним элемента.

 

Входные данные

Сначала задано число NN — количество элементов в массиве (1\le N\le 1001≤N≤100). Далее через пробел записаны NN чисел — элементы массива. Массив состоит из целых чисел, каждое из которых по модулю не превосходит 10001000.

Выходные данные

Необходимо вывести количество элементов массива меньше следующего за ним элемента.

Sample Input:

3
6 2 4
Sample Output:

1
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
            for (int i = 0; i < n - 1; i++)
            {
                if (numbers[i] < numbers[i + 1])
                    count++;
            }
            Console.WriteLine(count);
        }
    }
}
