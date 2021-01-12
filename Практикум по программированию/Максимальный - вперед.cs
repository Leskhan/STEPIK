/*
STEPIK
Максимальный - вперед

Требуется поменять местами первый элемент массива с максимальным.

Входные данные

В первой строке вводится одно натуральное число, не превосходящее 1000 – размер массива. Во второй строке задаются N чисел – элементы массива (целые числа, не превосходящие по модулю 1000).

Выходные данные

Вывести получившийся массив. Если максимальных элементов несколько, требуется поменять первый из них.

Sample Input:

5
1 2 3 4 5
Sample Output:

5 2 3 4 1
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
            string[] vs = Console.ReadLine().Split();
            int[] numbers = new int[n];

            for (int i = 0; i < vs.Length; i++)
                numbers[i] = Convert.ToInt32(vs[i]);

            int indexMax = Array.IndexOf(numbers, numbers.Max());

            int temp = numbers[indexMax];
            numbers[indexMax] = numbers[0];
            numbers[0] = temp;

            foreach (var item in numbers)
                Console.Write(item + " ");
        }
    }
}
