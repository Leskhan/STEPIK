/*
STEPIK
8.1 Понятие функция

Дано два натуральных числа. Найдите количество разрядов каждого из них и выведите их произведение.

Входные данные
Вводятся два натуральных числа - n, m,n,m, каждое из которых не превосходит 10^910 
9
 .

Выходные данные
Выведите произведение количества разрядов данных чисел.

Примечание: предполагается задачу решить с помощью функции.
Sample Input:

15
6
Sample Output:

2
*/



using System;
using System.Linq;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static int Raz(int a)
        {
            int count = 0;
            while (a > 0)
            {
                a /= 10;
                count++;
            }

            return count;
        }

        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Raz(m) * Raz(n));
        }
    }
}
