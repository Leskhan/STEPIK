/*
STEPIK
Столбцы

Дана таблица N × N, заполненная целыми числами. Петр Первый считает столбец хорошим, если тот содержит число Х. Требуется для каждого столбца выяснить, является ли тот хорошим.

Входные данные

В первой строке число X, не превышающее по модулю 2*109. Во второй строке число N (1 <= N <= 100), В следующих N строках по N целых чисел, не превышающих по модулю 2*109 – числа в ячейках таблицы.

Выходные данные

Для каждого столбца выведите YES, если в нем есть число Х, и NO в противном случае. (Каждый ответ с новой строки)

Sample Input:

1789
1
1789
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
            int x = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] vs = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = Convert.ToInt32(vs[j]);
                }
            }

            for (int i = 0; i < n; i++)
            {
                int count = 0;
                for (int j = 0; j < n; j++)
                {                    
                    if (array[j, i] == x)
                        count++;
                }

                if (count != 0)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
        }
	  }
}
