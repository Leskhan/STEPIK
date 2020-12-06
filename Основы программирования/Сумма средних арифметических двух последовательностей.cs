/*
STEPIK
8.2 Функция. Практика

Даны две последовательности. Первая: 1,2,3, ...,n,1,2,3,...,n, а вторая: 1,2,3,...,m.1,2,3,...,m. Найдите средние арифметические обеих последовательностей и выведите их сумму.

 

Входные данные

Вводятся два натуральных числа - n, mn,m, каждое из которых не превосходит 10001000.

Выходные данные
Выведите сумму двух средних арифметических.

Примечание: предполагается задачу решить с помощью функции.

Sample Input:

3
5
Sample Output:

5
*/



using System;
using System.Linq;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static double Func(double n)
        {
            double result = 0;
            for (int i = 1; i <= n; i++)
                result += i;

            return result / n;
        }
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine(Func(a) + Func(b));
        }
    }
}
