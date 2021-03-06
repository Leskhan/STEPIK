/*
STEPIK
Ферзи

Известно, что на доске 8×8 можно расставить 8 ферзей так, чтобы они не били друг друга. Вам дана расстановка 8 ферзей на доске, определите, есть ли среди них пара бьющих друг друга.

Входные данные

Программа получает на вход восемь пар чисел, каждое число от 1 до 8 - координаты 8 ферзей.

Выходные данные

Если ферзи не бьют друг друга, выведите слово NO, иначе выведите YES.

Sample Input 1:

1 7
2 4
3 2
4 8
5 6
6 1
7 3
8 5
Sample Output 1:

NO
Sample Input 2:

1 8
2 7
3 6
4 5
5 4
6 3
7 2
8 1
Sample Output 2:

YES
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
            var list = new List<List<int>>();
            bool beat = false;

            for (int i = 0; i < 8; i++)
            {
                list.Add(Console.ReadLine().Split().Select(e => int.Parse(e)).ToList());
            }

            for (int i = 0; i < 7; i++)
            {
                for (int j = i + 1; j < 8; j++)
                {
                    if (Math.Abs(list[i][0] - list[j][0]) == Math.Abs(list[i][1] - list[j][1]) || list[i][0] == list[j][0] || list[i][1] == list[j][1])
                    {
                        beat = true;
                        goto finish;
                    }
                }
            }

        finish:
            Console.WriteLine(beat ? "YES" : "NO");
        }
    }
}
