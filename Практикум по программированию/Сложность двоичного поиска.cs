/*
STEPIK
5.2 Бинарный поиск

Вася загадал число от 1 до N. За какое наименьшее количество вопросов (на которые Вася отвечает "да" или "нет") Петя может угадать Васино число?

Входные данные

Вводится одно число N

Выходные данные

Выведите наименьшее количество вопросов, которого гарантированно хватит Пете, чтобы угадать Васино число.

Sample Input:

5
Sample Output:

3
*/



using System;

namespace STEPIK_C_SHARP
{
    class MainProgram
    {          
        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int counter = 0;
            while (n != 0)
            {
                n /= 2;
                counter++;
            }

            Console.WriteLine(counter);
        }
    }
}
