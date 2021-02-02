/*
STEPIK
Шифр Юлия
Юлий Цезарь использовал свой способ шифрования текста. Каждая буква заменялась на следующую по алфавиту через K позиций по кругу. Необходимо по заданной шифровке определить исходный текст.
Входные данные
В первой строке дана шифровка, состоящая из заглавных латинских букв. Во второй строке число K (1 ≤ K ≤ 10).
Выходные данные
Требуется вывести результат расшифровки.
Sample Input 1:
XPSE
1
Sample Output 1:
WORD
Sample Input 2:
ZABC
3
Sample Output 2:
WXYZ
*/



using System;
using System.Collections.Generic;
using System.Text;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int k = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] - k < 65)
                    Console.Write((char)(text[i] + 26 - k));
                else
                    Console.Write((char)(text[i] - k));
            }
        }
    }
}
