/*
STEPIK
8.2 Функция. Практика

Реализуйте функцию SumRange(X, Y)SumRange(X,Y), находящую сумму всех целых чисел от XX до YY включительно (XX и YY — целые). Если X \gt YX>Y, то функция возвращает 00.

С помощью этой функции вычислите суммы чисел от AA до BB и от BB до CC, если даны числа A, B, C.A,B,C. А затем найдите сумму найденных двух чисел.

Например: A = 1, B = 5, C = 10.A=1,B=5,C=10. Сумма чисел от AA до BB равна 1+2+3+4+5=151+2+3+4+5=15. Сумма чисел от BB до CC равна 5+6+7+8+9+10=455+6+7+8+9+10=45. Затем находим сумму данных чисел: 15+45=6015+45=60.

 

Входные данные
Вводятся три целых числа A, B, C (-10^3 \le A, B, C \le 10^3)A,B,C(−10 
3
 ≤A,B,C≤10 
3
 )

 

Выходные данные
Вычислите суммы чисел от AA до BB и от BB до CC, а затем найдите сумму найденных двух чисел.

 

Примечание: предполагается задачу решить с помощью функции.

Sample Input:

1
5
10
Sample Output:

60
*/



using System;
using System.Linq;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static int SumRange(int a, int b)
        {
            int sum = 0;

            if (a > b)
                return 0;

            for (int i = a; i <= b; i++)
            {
                sum += i;
            }

            return sum;
        }
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());

            Console.Write(SumRange(A, B) + SumRange(B, C));
        }
    }
}
