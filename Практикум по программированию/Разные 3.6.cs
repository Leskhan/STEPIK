/*
STEPIK
Разные

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
using System.Collections.Generic;
using System.Linq;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split();

            var result = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (result.IndexOf(int.Parse(numbers[i])) < 0)
                    result.Add(int.Parse(numbers[i]));
            }

            Console.WriteLine(result.Count);
        }
    }
}
