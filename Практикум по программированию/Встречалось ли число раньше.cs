/*
STEPIK
Встречалось ли число раньше

Во входной строке записана последовательность чисел через пробел. Для каждого числа выведите слово YES (в отдельной строке), если это число ранее встречалось в последовательности или NO, если не встречалось.

Входные данные

Вводится список чисел. Все числа списка находятся на одной строке.

Выходные данные

Выведите ответ на задачу.

Sample Input:

1 2 3 2 3 4
Sample Output:

NO
NO
NO
YES
YES
NO
*/



using System;
using System.Linq;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();

            for (int i = 0; i < numbers.Length; i++)
            {
                bool check = false;

                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] == numbers[i])
                    {
                        check = true;
                        break;
                    }
                }

                Console.WriteLine(check ? "YES" : "NO");
            }
        }
    }
}
