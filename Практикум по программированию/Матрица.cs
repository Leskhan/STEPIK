/*
STEPIK
Матрица

Задана матрица K, содержащая n строк и m столбцов. Седловой точкой этой матрицы назовем элемент, который одновременно является минимумом в своей строке и максимумом в своем столбце.

Найдите количество седловых точек заданной матрицы.

Входные данные

Первая строка содержит целые числа n и m (1 ≤ n, m ≤ 750). Далее следуют n строк по m чисел в каждой. j-ое число i-ой строки равно kij. Все kij по модулю не превосходят 1000.

Выходные данные

Выведите ответ на задачу.

Sample Input:

2 2
0 0
0 0
Sample Output:

4
*/



using System;

namespace STEPIK_C_SHARP
{
    class MainProgram
    {
        public static void Main()
		{
            string[] vs = Console.ReadLine().Split();
            int n = Convert.ToInt32(vs[0]);
            int m = Convert.ToInt32(vs[1]);

            int[,] matrix = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                string[] temp = Console.ReadLine().Split();
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = Convert.ToInt32(temp[j]);
                }
            }

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int min = matrix[i, j];
                    int max = matrix[i, j];

                    for (int k = 0; k < m; k++)
                    {                        
                        if (matrix[i, k] < min)
                             min = matrix[i, k];                                          
                    }

                    for (int q = 0; q < n; q++)
                    {
                        if (matrix[q, j] > max)
                            max = matrix[q, j];
                    }

                    if (min == matrix[i, j] && max == matrix[i, j])
                        count++;
                }
            }

            Console.WriteLine(count);
        }
	}
}
