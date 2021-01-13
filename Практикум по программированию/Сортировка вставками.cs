/*
STEPIK
Сортировка вставками

Требуется отсортировать массив по неубыванию методом "вставок".

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
        static void Sort(ref int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
                for (int j = i; j > 0 && numbers[j - 1] > numbers[j]; j--) // пока j>0 и элемент j-1 > j, x-массив int
                {
                    int t = numbers[j - 1];
                    numbers[j - 1] = numbers[j];
                    numbers[j] = t;
                }
        }        

        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] temp = Console.ReadLine().Split();

            int[] numbers = new int[n];
            for (int i = 0; i < temp.Length; i++)
                numbers[i] = Convert.ToInt32(temp[i]);

            Sort(ref numbers);

            foreach (var item in numbers)
                Console.Write(item + " ");
        }
    }
}
