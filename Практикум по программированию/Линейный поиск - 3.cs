/*
STEPIK
Линейный поиск - 3

Напишите программу, которая выводит номера элементов массива, равных данному числу.

Входные данные

В первой строке задается одно натуральное число N, не превосходящее 1000 – размер массива.

Во второй строке вводятся N чисел – элементы массива (целые числа, не превосходящие по модулю 1000).

В третьей строке содержится одно целое число x, не превосходящее по модулю 1000.

Выходные данные

Вывести через пробел номера элементов, равных данному, в порядке возрастания. Если таких элементов нет, ничего выводить не нужно.

Sample Input:

5
1 2 3 4 5
3
Sample Output:

3
*/



using System;
using System.Linq;

namespace STEPIK_C_SHARP
{
    class MainProgram
    {
        public static void Main()
        {
            int size = Convert.ToInt32(Console.ReadLine());
            string[] vs = Console.ReadLine().Split();
            int find = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[size];

            for (int i = 0; i < vs.Length; i++)
                numbers[i] = Convert.ToInt32(vs[i]);

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == find)
                    Console.Write((i + 1) + " ");
            }
        }
    }
}
