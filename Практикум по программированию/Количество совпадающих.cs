/*
STEPIK
Количество совпадающих

Даны два списка чисел, которые могут содержать до 100000 чисел каждый. Посчитайте, сколько чисел содержится одновременно как в первом списке, так и во втором.

Примечание. Эту задачу на Питоне можно решить в одну строчку.

Входные данные

Вводятся два списка чисел. Все числа каждого списка находятся на отдельной строке.

Выходные данные

Выведите ответ на задачу.

Sample Input:

1 3 2
4 3 2
Sample Output:

2
*/



using System;
using System.Linq;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstNumbers = Console.ReadLine().Split();
            string[] secondNumbers = Console.ReadLine().Split();

            var result = firstNumbers.Intersect(secondNumbers).ToArray();

            Console.WriteLine(result.Length);
        }
    }
}
