/*
STEPIK
8.2 Функция. Практика

Даны два натуральных числа. Выяснить, в каком из них сумма цифр больше.

Входные данные
Вводятся два натуральных числа, каждый из которых не превосходит 10^910 
9
 .

Выходные данные
Выведите цифру 1, если сумма цифр первого числа больше, чем сумма цифр второго числа.
Выведите цифру 2, если сумма цифр второго числа больше, чем сумма цифр первого числа.
Выведите цифру 0, если сумма цифр первого числа равно сумме цифр второго числа.

Sample Input 1:

67
82
Sample Output 1:

1
Sample Input 2:

45
39
Sample Output 2:

2
Sample Input 3:

47
92
Sample Output 3:

0
*/



using System;
using System.Linq;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static int CountDigit(int n)
        {
            int result = 0;
            while (n > 0)
            {
                int t = n % 10;
                result += t;
                n /= 10;
            }

            return result;
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(CountDigit(a) > CountDigit(b) ? 1 : CountDigit(a) < CountDigit(b) ? 2 : 0);
        }
    }
}
