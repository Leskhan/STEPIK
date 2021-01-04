/*
STEPIK
5.2 Бинарный поиск

Приближенный двоичный поиск
Реализуйте алгоритм приближенного бинарного поиска.

Входные данные

В первой строке входных данных содержатся числа N и K (0 < N, K  < 100001). Во второй строке задаются N чисел первого массива, отсортированного по неубыванию, а в третьей строке – K чисел второго массива. Каждое число в обоих массивах по модулю не превосходит 2*10^9 
9
 .

Выходные данные

Для каждого из K чисел выведите в отдельную строку число из первого массива, наиболее близкое к данному. Если таких несколько, выведите меньшее из них.

Sample Input:

5 5
1 3 5 7 9
2 4 8 1 6
Sample Output:

1
3
7
1
5
*/



using System;

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
                int num = numbers2[i];
                int left = 0;
                int right = numbers1.Length;

                if (numbers1[n / 2] > num)
                    right = n / 2;
                else
                    left = n / 2;

                int index = 0;
                int min = 1000000000;
                for (int j = left; j < right; j++)
                {                    
                    if (Math.Abs(numbers1[j] - num) < min)
                    {
                        min = Math.Abs(numbers1[j] - num);
                        index = j;
                    }
                }

                Console.WriteLine(numbers1[index]);
            }
        }
    }
}
