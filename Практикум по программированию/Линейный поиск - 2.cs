/*
ACMP
Линейный поиск - 2

Напишите программу, которая определяет, встречается ли заданное число x в данном массиве.

Входные данные

В первой строке задается одно натуральное число N, не превосходящее 1000 – размер массива.

Во второй строке вводятся N чисел – элементы массива (целые числа, не превосходящие по модулю 1000).

В третьей строке содержится одно целое число x, не превосходящее по модулю 1000.

Выходные данные

Вывести YES , если число x встречается в данном массиве, и NO в противном случае.

Sample Input:

5
1 2 3 4 5
3
Sample Output:

YES
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
            string[] numbers = Console.ReadLine().Split();
            string find = Console.ReadLine();

            Console.WriteLine(Array.IndexOf(numbers, find) != -1 ? "YES" : "NO");
        }
	}
}
