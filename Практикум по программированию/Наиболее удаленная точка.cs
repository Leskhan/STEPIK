/*
STEPIK
Наиболее удаленная точка

Выведите координаты наиболее удаленной от начала координат точки.

Входные данные

Программа получает на вход набор точек на плоскости. Сначала задано количество точек n, затем идет последовательность из n строк, каждая из которых содержит два числа: координаты точки. Величина n не превосходит 100, все исходные координаты – целые числа, не превосходящие 10^310 
3
  по абсолютной величине.

Выходные данные

Выведите  координаты точки, наиболее удаленной от начала координат.

Sample Input:

2
1 2
2 3
Sample Output:

2 3
*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static double GetVectorLength(int x, int y)
        {
            return Math.Sqrt(x * x + y * y);
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string[] coor = Console.ReadLine().Split();
            int x = int.Parse(coor[0]);
            int y = int.Parse(coor[1]);

            double maxLength = GetVectorLength(x, y);
            int[] maxVector = { x, y };

            for (int i = 0; i < n - 1; i++)
            {
                string[] vs = Console.ReadLine().Split();
                int x1 = int.Parse(vs[0]);
                int y1 = int.Parse(vs[1]);

                if (GetVectorLength(x1, y1) > maxLength)
                {
                    maxLength = GetVectorLength(x1, y1);
                    maxVector[0] = x1;
                    maxVector[1] = y1;
                }
            }

            Console.WriteLine(maxVector[0] + " " + maxVector[1]);

        }
    }
}
