/*
STEPIK
8.1 Понятие функция

Число сочетаний
По данным натуральным nn и kk вычислите значение С_n^k = {n!\over k!(n-k)!}С 
n
k
​	
 = 
k!(n−k)!
n!
​	
 (число сочетаний из nn элементов по kk). 

 

 

Входные данные

Вводятся 2 натуральных числа  nn и kk (n, k \le 10n,k≤10 ).

 

Выходные данные

Необходимо вывести значение С_n^kС 
n
k
​	
 .

 

Примечание: данную задачу предполагается решить с помощью функций. Не забывайте, что 0! = 1.0!=1.
*/



using System;
using System.Linq;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static int fact(int x)
        {
            int result = 1;
            for (int i = 1; i <= x; i++)
                result *= i;

            return result;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine(fact(n) / (fact(k) * fact(n - k)));
        }
    }
}
    
