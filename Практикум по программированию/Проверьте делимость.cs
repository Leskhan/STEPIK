/*
STEPIK
Проверьте делимость

Даны два натуральных числа n и m. Если одно из них делится на другое нацело, выведите 1, иначе выведите 0.

Входные данные

Вводятся два натуральных числа n и m.

Выходные данные

Выведите ответ на задачу.

Примечание

При решении этой задачи нельзя пользоваться условной инструкцией if и циклами. 

Sample Input:

2
8
Sample Output:

1
*/



using System;
using System.Linq;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static bool Div(int n, int m)
        {
            return n % m == 0 || m % n == 0;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Convert.ToInt32(Div(n, m)));
        }
    }
}
