/*
STEPIK

7.5 Итоговый тест
Количество каждой буквы

По данному слову, состоящему из строчных латинских букв, посчитайте количество каждой буквы.

Входные данные

На вход подается одна строка без пробелов, состоящая не более 1000 строчных латинских букв. 

Выходные данные

Выведите на каждой строке в алфавитном порядке только те символы, которые встречаются в строке. Возле каждого символа выведите сколько раз встречается данный символ.

Sample Input:

beegeek
Sample Output:

b 1
e 4
g 1
k 1
*/



using System;
using System.Linq;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] word = Console.ReadLine().ToCharArray();
            char[] checkedSymbols = new char[word.Length];
            int k = 0;

            Array.Sort(word);

            for (int i = 0; i < word.Length; i++)
            {
                char ch = (char)word[i];
                if (!Array.Exists(checkedSymbols, item => item == ch))
                {
                    Console.WriteLine((char)word[i] + " " + word.Count(e => e == (char)word[i]));
                    checkedSymbols[k] = (char)word[i];
                    k++;
                }
                else
                    continue;
            }
        }
    }
}
