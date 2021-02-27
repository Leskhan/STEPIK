/*
STEPIK
Похожие массивы

Назовем два массива похожими, если они состоят из одних и тех же элементов (без учета кратности). По двум данным массивам выясните, похожие они или нет.

Входные данные

В первой строке содержится число N  (1 ≤ N ≤ 100000) – размер первого массива. Во второй строке идет N целых чисел, не превосходящих по модулю 109 – элементы массива. Далее аналогично задается второй массив.

Выходные данные

Программа должна вывести слово YES, если массивы похожи, и слово NO в противном случае.

Sample Input:

3
1 7 9
4
9 7 7 1
Sample Output:

YES
*/



using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static SortedSet<string> ConvertToSet(string[] arr)
        {
            var sortedSet = new SortedSet<string>();

            for (int i = 0; i < arr.Length; i++)
            {
                sortedSet.Add(arr[i]);
            }

            return sortedSet;
        }

        static string[] ConvertToArray(SortedSet<string> s)
        {
            string[] arr = new string[s.Count];
            int index = 0;
            
            foreach (var i in s)
            {
                arr[index] = i;
                index++;
            }

            return arr;
        }
        
        static bool EqualsSet(string[] arr, string[] arr1)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != arr1[i])
                    return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr = Console.ReadLine().Split();
            int n1 = Convert.ToInt32(Console.ReadLine());
            string[] arr1 = Console.ReadLine().Split();

            var numbers1 = ConvertToArray(ConvertToSet(arr));
            var numbers2 = ConvertToArray(ConvertToSet(arr1));

            bool b = EqualsSet(numbers2, numbers1);
            Console.WriteLine(b ? "YES" : "NO");
        }
    }
}
