/*
STEPIK
8.2 Функция. Практика

Проверьте, является ли число простым.

Входные данные
Вводится одно натуральное число nn, принимающие значения от 22 до 2\cdot10^52⋅10 
5
 .

Выходные данные
Необходимо вывести "prime", если число простое, или "composite", если число составное.

Примечание: данную задачу предполагается решить с помощью функций.

Sample Input 1:

3
Sample Output 1:

prime
Sample Input 2:

4
Sample Output 2:

composite
*/



using System;
using System.Linq;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static string IsPrime(int n)
        {
            if (n <= 1)
                return "composite";

            for (int i = 2; i <= n / i; i++)
            {
                if (n % i == 0)
                    return "composite";
            }

            return "prime";
        }
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(IsPrime(number));
        }
    }
}
