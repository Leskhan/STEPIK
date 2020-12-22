/*
STEPIK
Номер максимального элемента массива

Напишите программу, которая находит номер максимального элемента массива.

Входные данные

В первой строке задается одно натуральное число N, не превосходящее 1000 – размер массива.

Во второй строке вводится N чисел – элементы массива (целые числа, не превосходящие по модулю 1000).

Выходные данные

Вывести одно число – номер максимального элемента в массиве (номера элементов в массиве считаем начиная с единицы). 

Sample Input:

5
5 4 3 2 1
Sample Output:

1
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

            int[] numbers = new int[size];
            
            for (int i = 0; i < vs.Length; i++)
                numbers[i] = Convert.ToInt32(vs[i]);
                       
            Console.WriteLine(Array.IndexOf(numbers, numbers.Max()) + 1);
        }
	  }
}
