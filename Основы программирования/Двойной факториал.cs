/*
STEPIK
8.2 Функция. Практика

Описать функцию Fact2(N)Fact2(N), вычисляющую двойной факториал:

N!! = \left\{   \begin{aligned}& 1 \cdot 3 \cdot 5 \cdot ... \cdot N, \quad N - нечетное \\& 2 \cdot 4 \cdot 6 \cdot ... \cdot N, \quad N - четное \end{aligned}\right.N!!={  
​	
  
1⋅3⋅5⋅...⋅N,N−нечетное
2⋅4⋅6⋅...⋅N,N−четное
​	
 

С помощью этой функции найти двойные факториалы трех целых чисел.

Входные данные
Вводятся три натуральных числа A, B, C (1 \le A, B, C \le 16)A,B,C(1≤A,B,C≤16).

Выходные данные
Выведите двойные факториалы A, B, C.A,B,C.

Примечание: предполагается задачу решить с помощью функции.
*/



using System;
using System.Linq;

namespace STEPIK_C_SHARP
{
    class Program
    {       
        static int Fact2(int n)
        {
            int result = 1;

            if (n % 2 == 0)
            {
                for (int i = 2; i <= n; i += 2)
                    result *= i;
            }
            else
            {
                for (int i = 1; i <= n; i += 2)
                    result *= i;
            }

            return result;
        }

        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.Write(Fact2(a) + " " + Fact2(b) + " " + Fact2(c));
        }
    }
}
