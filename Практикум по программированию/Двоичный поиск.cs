/*
STEPIK
5.2 Бинарный поиск

Двоичный поиск
Реализуйте алгоритм бинарного поиска.

Входные данные

В первой строке входных данных содержатся натуральные числа N и K (0 < N, K < 100000). Во второй строке задаются N элементов первого массива, отсортированного по возрастанию, а в третьей строке – K элементов второго массива. Элементы обоих массивов - целые числа, каждое из которых по модулю не превосходит 109

Выходные данные

Требуется для каждого из K чисел вывести в отдельную строку "YES", если это число встречается в первом массиве, и "NO" в противном случае.

Sample Input:

10 5
1 2 3 4 5 6 7 8 9 10
-2 0 4 9 12
Sample Output:

NO
NO
YES
YES
NO
*/



using System;
using System.Linq;

namespace STEPIK_C_SHARP
{
    class MainProgram
    {
        static void ConvertArrays(ref string[] array1, ref int[] numbers)
        {
            for (int i = 0; i < array1.Length; i++)
            {
                numbers[i] = Convert.ToInt32(array1[i]);
            }
        }

        public static void Main()
        {
            string[] vs = Console.ReadLine().Split();
            string[] array1 = Console.ReadLine().Split();
            string[] array2 = Console.ReadLine().Split();

            int n = Convert.ToInt32(vs[0]);
            int m = Convert.ToInt32(vs[1]);
            int[] numbers1 = new int[n];
            int[] numbers2 = new int[m];

            ConvertArrays(ref array1, ref numbers1);
            ConvertArrays(ref array2, ref numbers2);

            for (int i = 0; i < numbers2.Length; i++)
            {
                int item = numbers2[i];

                if (Array.BinarySearch(numbers1, item) < 0)
                    Console.WriteLine("NO");
                else
                    Console.WriteLine("YES");
            }
        }
    }
}
