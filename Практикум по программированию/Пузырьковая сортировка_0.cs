/*
STEPIK
Пузырьковая сортировка_0

Требуется отсортировать массив по неубыванию методом "пузырька".

Входные данные

В первой строке вводится одно натуральное число, не превосходящее 1000 – размер массива. Во второй строке задаются N чисел – элементы массива (целые числа, не превосходящие по модулю 1000).

Выходные данные

Вывести получившийся массив.

Sample Input:

5
5 4 3 2 1
Sample Output:

1 2 3 4 5
*/



using System;
using System.Linq;

namespace STEPIK_C_SHARP
{
    class MainProgram
    {
        static void ConvertToNumbers(string[] arrayStrings, int[] arrayNumbers)
        {
            for (int i = 0; i < arrayStrings.Length; i++)
            {
                arrayNumbers[i] = Convert.ToInt32(arrayStrings[i]);
            }
        }

        static void BubbleSort(ref int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = numbers.Length - 1; j > i; j--)
                {
                    if (numbers[j - 1] > numbers[j])
                    {
                        int t = numbers[j];
                        numbers[j] = numbers[j - 1];
                        numbers[j - 1] = t;
                    }
                }
            }
        }

        static void PrintArray(int[] numbers)
        {
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
        }

        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] temp = Console.ReadLine().Split();

            int[] numbers = new int[n];
            ConvertToNumbers(temp, numbers);
            BubbleSort(ref numbers);
            PrintArray(numbers);
        }
    }
}
