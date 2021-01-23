/*
STEPIK
Замена подстроки

Дана строка. Замените в этой строке все цифры 1 на слово one.

Входные данные

Вводится строка.

Выходные данные

Выведите ответ на задачу.

Sample Input:

1+1=2
Sample Output:

one+one=2
*/



using System;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Console.ReadLine().Replace("1", "one"));
        }
    }
}
