/*
STEPIK
Переставить два слова

Дана строка, состоящая ровно из двух слов, разделенных пробелом. Переставьте эти слова местами. Результат запишите в строку и выведите получившуюся строку.

При решении этой задачи нельзя пользоваться циклами и инструкцией if.

Входные данные

Вводится строка.

Выходные данные

Выведите ответ на задачу.

Sample Input:

Hello, world!
Sample Output:

world! Hello,
*/



using System;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Array.Reverse(words);
            Console.WriteLine(string.Join(" ", words));
        }
    }
}
