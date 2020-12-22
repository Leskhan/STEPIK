/*
STEPIK
Ревизия

В связи с визитом Императора Палпатина было решено обновить состав дроидов в ангаре 32. Из-за кризиса было решено новых дроидов не закупать, но выкинуть пару старых. Как известно, Палпатин не переносит дроидов с маленькими серийными номерами, так что все, что требуется - найти среди них двух, у которых серийные номера наименьшие.

Входные данные

Первая строка входного файла содержит целое число N – количество дроидов. (2 ≤ N ≤ 1000), вторая строка – N целых чисел, по модулю не превышающих 2*109 – номера дроидов

Выходные данные

Выведите два числа: первым – последний по величине из номеров дроидов (такого следует утилизировать в первую очередь), а вторым – предпоследний.

Sample Input:

5
10 2 3 1 5
Sample Output:

1 2
*/



using System;
using System.Linq;

namespace STEPIK_C_SHARP
{
    class MainProgram
    {
        public static void Main()
		{
            int size = int.Parse(Console.ReadLine());
            string[] vs = Console.ReadLine().Split();

            int[] numbers = new int[size];
            
            for (int i = 0; i < vs.Length; i++)
                numbers[i] = Convert.ToInt32(vs[i]);

            int minItem = Array.IndexOf(numbers, numbers.Min());
            Console.Write(numbers[minItem] + " ");
            numbers[minItem] = 10000000;

            minItem = Array.IndexOf(numbers, numbers.Min());
            Console.Write(numbers[minItem]);

            
        }
	}
}
