/*
STEPIK
Сортировка выбором максимума

Требуется отсортировать массив по неубыванию методом "выбор максимума".

Входные данные

В первой строке вводится одно натуральное число, не превосходящее 1000 – размер массива. Во второй строке задаются N чисел – элементы массива (целые числа, не превосходящие по модулю 1000).

Выходные данные

Вывести получившийся массив.

Sample Input:

2
3 1
Sample Output:

1 3
*/



using System;
using System.Linq;

namespace STEPIK_C_SHARP
{
    class MainProgram
    {
        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] temp = Console.ReadLine().Split();

            int[] numbers = new int[n];
            for (int i = 0; i < temp.Length; i++)
                numbers[i] = Convert.ToInt32(temp[i]);

            int indexOfMax = 0;
            int maxItem = numbers[0];
            int size = temp.Length;
            while (size != 0)
            {
                for (int i = 0; i < size; i++)
                {
                    if (numbers[i] > maxItem)
                    {
                        indexOfMax = i;
                        maxItem = numbers[i];
                    }
                }

                int t = numbers[indexOfMax];
                numbers[indexOfMax] = numbers[size - 1];
                numbers[size - 1] = t;

                indexOfMax = 0;
                maxItem = numbers[0];
                size--;
            }

            foreach (var item in numbers)
                Console.Write(item + " ");
        }
    }
}
