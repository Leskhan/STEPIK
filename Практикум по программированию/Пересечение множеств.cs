/*
STEPIK
Пересечение множеств

Даны два списка чисел, которые могут содержать до 10000 чисел каждый. Выведите все числа, которые входят как в первый, так и во второй список в порядке возрастания.

Примечание. И даже эту задачу на Питоне можно решить в одну строчку.

Входные данные

Вводятся два списка целых чисел. Все числа каждого списка находятся на отдельной строке.

Выходные данные

Выведите ответ на задачу.

Sample Input:

1 3 2
4 3 2
Sample Output:

2 3
*/



using System;
using System.Collections.Generic;
using System.Linq;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static SortedSet<int> ToSortedHash(string[] numbers)
        {
            var sortedSet = new SortedSet<int>();

            foreach (var item in numbers)
            {
                sortedSet.Add(Convert.ToInt32(item));
            }

            return sortedSet;
        }

        static void Main(string[] args)
        {
            var firstNumbers = Console.ReadLine().Split();
            var secondNumbers = Console.ReadLine().Split();

            var firstSet = ToSortedHash(firstNumbers);
            var secondSet = ToSortedHash(secondNumbers);

            firstSet.IntersectWith(secondSet);

            foreach (var item in firstSet)
            {
                Console.Write(item + " ");
            }
        }
    }
}
