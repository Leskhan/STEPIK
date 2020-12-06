/*
STEPIK
8.1 Понятие функция

Найдите значение z = sign(a) + sign(b)z=sign(a)+sign(b), где
  
−1,x<0
0,x=0
1,x>0
​	
 

Входные данные
Вводится два целых числа aa и bb.

Выходные данные
Необходимо вывести значение zz.

Примечание: данную задачу предполагается решить с помощью функций.
Sample Input 1:

8 11
Sample Output 1:

2
Sample Input 2:

8 -11
Sample Output 2:

0

*/



using System;
using System.Linq;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static int sign(int x)
        {
            if (x < 0)
                return -1;
            else if (x == 0)
                return 0;
            else
                return 1;
        }

        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            int a = int.Parse(numbers[0]);
            int b = int.Parse(numbers[1]);

            Console.WriteLine(sign(a) + sign(b));
        }
    }
}
