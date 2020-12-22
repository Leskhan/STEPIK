/*
STEPIK
Ближайшее число

Напишите программу, которая находит в массиве элемент, самый близкий по величине к  данному числу.

Входные данные

В первой строке задается одно натуральное число N, не превосходящее 1000 – размер массива.

Во второй строке содержатся N чисел – элементы массива (целые числа, не превосходящие по модулю 1000).

В третьей строке вводится одно целое число x, не превосходящее по модулю 1000.

Выходные данные

Вывести значение элемента массива, ближайшее к x.

Sample Input:

5
1 2 3 4 5
6
Sample Output:

5
*/



using System;
using System.Linq;

namespace STEPIK_C_SHARP
{
    class MainProgram
    {
        public static void Main()
		{
            int size = int.Parse(Console.ReadLine());
            string[] vs = Console.ReadLine().Split();
            int find = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[size];

            for (int i = 0; i < vs.Length; i++)
                numbers[i] = Convert.ToInt32(vs[i]);

            int answer = 1000000;
            int index = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int temp = Math.Abs(numbers[i] - find);
                if (temp < answer)
                {
                    answer = temp;
                    index = i;
                }
            }

            Console.WriteLine(numbers[index]);
        }
	}
}
