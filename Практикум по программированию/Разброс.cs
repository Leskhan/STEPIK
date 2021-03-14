/*
STEPIK
Разброс

Дано N целых чисел, которые требуется отсортировать в порядке неубывания. В связи с нормами СЭС среди чисел не будет двух, разница между которыми превышает $107.

Входные данные

Первая строка входного файла содержит целое число N. (1 <= N <= 100000), вторая строка – N целых чисел, не превышающих по модулю 2*109. Никакие два числ не различаются более, чем на $107.

Выходные данные

Выведите данные числа в порядке неубывания.

Sample Input:

1
863961129
Sample Output:

863961129
*/



using System;
using System.Linq;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static int[] GetVs(string[] arr)
        {
            int[] n = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
                n[i] = int.Parse(arr[i]);

            return n;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr = Console.ReadLine().Split();
            int[] numbers = GetVs(arr);

            Array.Sort(numbers);

            foreach (var item in numbers)
                Console.Write(item + " ");
        }
    }
}   
