/*
STEPIK
Есть ли два элемента с одинаковыми знаками

Дан массив, состоящий из целых чисел. Напишите программу, которая определяет, есть ли в массиве пара соседних элементов с одинаковыми знаками.

Входные данные

Сначала задано число N — количество элементов в массиве (1 ≤ N ≤ 10000). Далее через пробел записаны N чисел — элементы массива. Массив состоит из целых чисел.

Выходные данные

Необходимо вывести слово YES, если существует пара соседних элементов с одинаковыми знаками. В противном случае следует вывести слово NO.

Sample Input:

5
1 -3 4 -2 1
Sample Output:

NO
*/



using System;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static int[] GetNumberArray(string[] arr)
        {
            int[] result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
                result[i] = int.Parse(arr[i]);

            return result;
        }

        static bool IsSameSign(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
                if ((numbers[i - 1] < 0 && numbers[i] < 0) || (numbers[i - 1] > 0 && numbers[i] > 0))
                    return true;
            return false;
        }

        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            string[] arr = Console.ReadLine().Split();
            int[] numbers = GetNumberArray(arr);

            Console.WriteLine(IsSameSign(numbers) ? "YES" : "NO");
        }
    }
}   
