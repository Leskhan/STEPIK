/*
STEPIK

7.5 Итоговый тест
Четные и количество

Дано целое число NN и набор из NN целых чисел. Вывести все четные числа из данного набора и кол-во таких чисел.

Входные данные
Сначала задано число NN — количество элементов в массиве (1\le N\le 1001≤N≤100). Далее через пробел записаны NN чисел — элементы массива. Массив состоит из целых чисел, каждое из которых по модулю не превосходит 10001000.

Выходные данные
Необходимо вывести  в том же порядке все четные числа из данного набора на одной строке через пробел и количество таких чисел на следующей строке.

Sample Input:

5
1 3 4 52 1
Sample Output:

4 52
2
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
                if (numbers[i] % 2 == 0)
                {
                    Console.Write(numbers[i] + " ");
                    count++;
                }    
            }
            Console.WriteLine("\n" + count);
        }
    }
}
