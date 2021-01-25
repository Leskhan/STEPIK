/*
STEPIK
Вставка символов

Дана строка. Получите новую строку, вставив между двумя символами исходной строки символ *. Выведите полученную строку.

Входные данные

Вводится строка.

Выходные данные

Выведите ответ на задачу.

Sample Input:

Python
Sample Output:

P*y*t*h*o*n
*/



using System;
using System.Text;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder str = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                str.Append(text[i]);
                str.Append('*');
            }

            Console.WriteLine(str.Remove(str.Length - 1, 1));
        }
    }
}
