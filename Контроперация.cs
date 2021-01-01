/*
STEPIK
Контроперация

Хакер Василий получил доступ к классному журналу и хочет заменить все свои минимальные оценки на максимальные. Напишите программу, которая заменяет оценки Василия, но наоборот (все максимальные - на минимальные).

Входные данные

Дано количество оценок Василия (не больше 100), затем сами оценки.

Выходные данные

Требуется вывести исправленные оценки в том же порядке.

Sample Input:

5 1 3 3 3 4
Sample Output:

1 3 3 3 1
*/



using System;
using System.Linq;

namespace STEPIK_C_SHARP
{
    class MainProgram
    {
        public static void Main()
		{            
            string[] vs = Console.ReadLine().Split();
            int n = Convert.ToInt32(vs[0]);
            int[] numbers = new int[n];

            for (int i = 0; i < vs.Length - 1; i++)
            {
                numbers[i] = Convert.ToInt32(vs[i + 1]);
            }

            int minNumber = numbers.Min();
            int maxNumber = numbers.Max();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == maxNumber)
                    Console.Write(minNumber + " ");
                else
                    Console.Write(numbers[i] + " ");
            }
        }
	}
}
