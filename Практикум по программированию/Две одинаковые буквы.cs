/*
STEPIK
Две одинаковые буквы

Дана строка. Известно, что она содержит ровно две одинаковые буквы. Найдите эти буквы. Гарантируется, что повторяются буквы только одного вида.

Входные данные

На вход подается 1 строка.

Выходные данные

Необходимо вывести  букву, которая встречается в строке дважды.

Sample Input:

fif
Sample Output:

f
*/



using System;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int counter = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];
                for (int j = 0; j < text.Length; j++)
                {
                    if (symbol == text[j])
                    {
                        counter++;
                        if (counter == 2)
                        {
                            Console.WriteLine(symbol);
                            goto finish;
                        }
                    }
                }
                counter = 0;
            }

        finish:;

        }
    }
}
