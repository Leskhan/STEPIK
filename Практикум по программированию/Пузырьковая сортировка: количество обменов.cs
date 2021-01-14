/*
STEPIK
Пузырьковая сортировка: количество обменов

Ввод и вывод данных производятся через стандартные потоки ввода-вывода.

Определите, сколько обменов сделает алгоритм пузырьковой сортировки по возрастанию для данного массива.

Входные данные

На первой строке дано число N (1 ≤ N ≤ 1000) – количество элементов в массиве. На второй строке – сам массив. Гарантируется, что все элементы массива различны и не превышают по модулю 109.

Выходные данные

Выведите одно число – количество обменов пузырьковой сортировки.

Sample Input:

5
1 2 3 4 5
Sample Output:

0
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

        static int BubbleSort(ref int[] numbers)
        {
            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = numbers.Length - 1; j > i; j--)
                {
                    if (numbers[j - 1] > numbers[j])
                    {
                        counter++;
                        int t = numbers[j];
                        numbers[j] = numbers[j - 1];
                        numbers[j - 1] = t;
                    }
                }
            }

            return counter;
        }

        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] temp = Console.ReadLine().Split();

            int[] numbers = new int[n];
            ConvertToNumbers(temp, numbers);
            Console.WriteLine(BubbleSort(ref numbers));            
        }
    }
}
