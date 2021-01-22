/*
STEPIK
Удаление фрагмента

Дана строка, в которой буква h встречается минимум два раза. Удалите из этой строки первое и последнее вхождение буквы h, а также все символы, находящиеся между ними.

Входные данные

Вводится строка.

Выходные данные

Выведите ответ на задачу.

Sample Input:

In the hole in the ground there lived a hobbit
Sample Output:

In tobbit
*/



using System;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            word = word.Replace('H', 'h');
            int firstIndex = word.IndexOf('h');
            int lastIndex = word.LastIndexOf('h');

            string wordAfterRemove = word.Substring(firstIndex, lastIndex - firstIndex + 1);
            Console.WriteLine(word.Replace(wordAfterRemove, ""));
        }
    }
}
