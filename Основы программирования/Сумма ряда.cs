/*
STEPIK
8.1 Понятие функция

По данному числу xx, вычислить сумму ряда 

s = \sum\limits_{i=1}^5 (-1)\cdot i\cdot (\dfrac{x}{i!})s= 
i=1
∑
5
​	
 (−1)⋅i⋅( 
i!
x
​	
 )

 

Данная формула расписывается следующим образом: -1\cdot (\dfrac{x}{1!}) -2\cdot (\dfrac{x}{2!}) -3\cdot (\dfrac{x}{3!}) -4\cdot (\dfrac{x}{4!}) -5\cdot (\dfrac{x}{5!})−1⋅( 
1!
x
​	
 )−2⋅( 
2!
x
​	
 )−3⋅( 
3!
x
​	
 )−4⋅( 
4!
x
​	
 )−5⋅( 
5!
x
​	
 ).


Входные данные

Вводится целое число xx, которое по модулю не превосходит 10001000.


Выходные данные
Выведите сумму ряда по этому значению x.x.

Примечание: предполагается задачу решить с помощью функции.

Sample Input:

3
Sample Output:

-8.125
*/



using System;
using System.Linq;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static double ss(double x)
        {
            double result = 0;

            for (int i = 1; i <= 5; i++)
            {
                result += -1 * i * (x / fact(i));
            }

            return result;
        }

        static double fact(double x)
        {
            double result = 1;
            for (int i = 1; i <= x; i++)
                result *= i;

            return result;
        }

        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            Console.WriteLine(ss(n));
        }
    }
}
