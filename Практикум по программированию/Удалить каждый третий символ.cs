/*
STEPIK
Удалить каждый третий символ

Дана строка. Удалите из нее все символы, чьи индексы делятся на 3.

Входные данные

Вводится строка.

Выходные данные

Выведите ответ на задачу.

Sample Input:

Python
Sample Output:

yton
*/



using System;
using System.Text;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            StringBuilder str = new StringBuilder();

            for (int i = 0; i < word.Length; i++)
            {
                if (i % 3 != 0)
                    str.Append(word[i]);
            }

            Console.WriteLine(str);
        }
    }
}
