/*
STEPIK

небольшое число Фибоначчи
2.2 Числа Фибоначчи

Дано целое число 1 \le n \le 401≤n≤40, необходимо вычислить nn-е число Фибоначчи (напомним, что F_0=0F 
0
​	
 =0, F_1=1F 
1
​	
 =1 и F_n=F_{n-1}+F_{n-2}F 
n
​	
 =F 
n−1
​	
 +F 
n−2
​	
  при n \ge 2n≥2).

Sample Input:

3
Sample Output:

2
*/



using System;

namespace STEPIK_C_SHARP
{
    class MainProgram
    {
        static int Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int first = 0;
            int second = 1;
            int answer = 0;
            int i = 1;
            
            if (n == 1)
            {
                Console.WriteLine(1);
                return 0;
            }

            while (i < n)
            {
                answer = first + second;
                first = second;
                second = answer;
                i++;
            }

            Console.WriteLine(answer);
            return 0;
        }
    }
}
