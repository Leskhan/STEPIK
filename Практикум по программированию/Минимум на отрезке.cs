/*
STEPIK
Минимум на отрезке

Рассмотрим последовательность целых чисел длины N. По ней с шагом 1 двигается “окно” длины K, то есть сначала в “окне” видно первые K чисел, на следующем шаге в “окне” уже будут находиться K чисел, начиная со второго, и так далее до конца последовательности. Требуется для каждого положения “окна” определить минимум в нём.

Входные данные

В первой строке входных данных содержатся два числа N и K (1 ≤  N ≤  150000, 1 ≤ K ≤ 10000, K ≤  N) – длины последовательности и “окна”, соответственно. На следующей строке находятся N чисел – сама последовательность.

Выходные данные

Выходные данные должны содержать N − K + 1 строк – минимумы для каждого положения “окна”.

Sample Input:

7 3
1 3 2 4 5 3 1
Sample Output:

1
2
2
3
1
*/



using System;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vs = Console.ReadLine().Split();
            string[] temp = Console.ReadLine().Split();

            int size = int.Parse(vs[0]);
            int window = int.Parse(vs[1]);

            int[] numbers = new int[size];
            for (int i = 0; i < temp.Length; i++)
                numbers[i] = int.Parse(temp[i]);

            int start = 0, end = window, counter = 0;
            while (counter < size - window + 1)
            {
                int min = int.MaxValue;
                for (int i = start; i < end; i++)
                {
                    if (numbers[i] < min)
                        min = numbers[i];
                }

                Console.WriteLine(min);
                start++;
                end++;
                counter++;
            }
        }
    }
}
