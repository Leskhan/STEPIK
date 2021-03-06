/*
STEPIK
Серебряная медаль

Спортсмен Василий участвовал в соревнованиях по хоккейболу и получил в личном зачете серебряную медаль. Известно, что участники, получившие одинаковое количество очков, награждаются одинаковыми наградами. Известно, что были разыграны золотые серебряные и бронзовые медали. В задаче не спрашиваются правила хоккейбола. Необходимо только определить сколько очков набрал Василий.

Для решения данной задачи массив лучше не использовать.

Входные данные

На первой строке дано число N (2 ≤ N ≤ 1000) количество спортсменов, участвовавших в соревнованиях, на второй N целых чисел – результаты через пробел.

Выходные данные

Требуется вывести одно число – результат Василия

Sample Input:

5
4 3 3 1 2
Sample Output:

3
*/



using System;

namespace STEPIK_C_SHARP
{
    class MainProgram
    {
        public static void Main()
		{
            int n = Convert.ToInt32(Console.ReadLine());
            string[] vs = Console.ReadLine().Split();

            int[] numbers = new int[n];
            for (int i = 0; i < vs.Length; i++)
                numbers[i] = Convert.ToInt32(vs[i]);

            Array.Sort(numbers);

            for (int i = numbers.Length - 1; i > 0; i--)
            {
                if (numbers[i] != numbers[i - 1])
                {
                    Console.WriteLine(numbers[i - 1]);
                    break;
                }    
            }
        }
	}
}
