/*
STEPIK

2.2 Числа Фибоначчи
Последняя цифра большого числа Фибоначчи

Дано число 1 \le n \le 10^71≤n≤10 
7
 , необходимо найти последнюю цифру nn-го числа Фибоначчи.

Как мы помним, числа Фибоначчи растут очень быстро, поэтому при их вычислении нужно быть аккуратным с переполнением. В данной задаче, впрочем, этой проблемы можно избежать, поскольку нас интересует только последняя цифра числа Фибоначчи: если 0 \le a,b \le 90≤a,b≤9 — последние цифры чисел F_iF 
i
​	
  и F_{i+1}F 
i+1
​	
  соответственно, то (a+b) \bmod{10}(a+b)mod10 — последняя цифра числа F_{i+2}F 
i+2
​	
 .





Sample Input:

841645
Sample Output:

5
*/



using System;

namespace STEPIK_C_SHARP
{
    class MainProgram
    {
        static ulong F(ulong n)
        {
            ulong f1 = 0;
            ulong f2 = 1;
            ulong f3 = 0;

            for (ulong i = 1; i < n; i++)
            {
                f3 = f1 + f2 % 10;
                f1 = f2;
                f2 = f3;
            }

            return f3;
        }
       
        static void Main(string[] args)
        {
            ulong number = Convert.ToUInt64(Console.ReadLine());

            ulong a = F(number - 1);
            ulong b = F(number - 2);

            Console.WriteLine((a + b) % 10);
        }
    }
}
