/*
STEPIK
Результаты олимпиады (1)

Во время проведения олимпиады каждый из участников получил свой идентификационный номер – натуральное число. Необходимо отсортировать список участников олимпиады по количеству набранных ими баллов.

Входные данные

На первой строке дано число N (1 ≤ N ≤ 1000) – количество участников. На каждой следующей строке даны идентификационный номер и набранное число баллов соответствующего участника. Все числа во входном файле не превышают 105.

Выходные данные

В выходной файл выведите исходный список в порядке убывания баллов. Если у некоторых участников одинаковые баллы, то их между собой нужно упорядочить в порядке возрастания идентификационного номера.

Sample Input:

3
101 80
305 90
200 14
Sample Output:

305 90
101 80
200 14
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
            var dict = new Dictionary<int, int>(n);

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split();
                dict.Add(int.Parse(values[0]), int.Parse(values[1]));
            }

            dict = dict.OrderBy(pair => pair.Key).ToDictionary(p => p.Key, p => p.Value);
            dict = dict.OrderByDescending(pair => pair.Value).ToDictionary(p => p.Key, p => p.Value);

            foreach (var e in dict)
                Console.WriteLine($"{e.Key} {e.Value}");
        }
    }
}
