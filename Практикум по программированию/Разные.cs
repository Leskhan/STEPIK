/*
STEPIK
5.4 Быстрая сортировка

Дано N чисел, требуется выяснить, сколько среди них различных.

Входные данные

В первой строке дано число N – количество чисел. (1 <= N <= 100000) Во второй строке даны через пробел N чисел, каждое не превышает 2*109 по модулю.

Выходные данные

Выведите число, равное количеству различных чисел среди данных.

Sample Input:

5
1 0 1 2 0
Sample Output:

3
*/



using System;

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

            int[] results = new int[n];

            int index = 0;
            bool isZero = false;

            foreach (var item in numbers)
            {
                if (item == 0)
                {
                    isZero = true;
                    continue;
                }

                if (Array.IndexOf(results, item) < 0)
                {
                    results[index] = Convert.ToInt32(item);
                    index++;
                }
            }

            if (isZero)
                Console.WriteLine(index + 1);
            else
                Console.WriteLine(index);
        }
    }
}
