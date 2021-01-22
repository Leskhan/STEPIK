/*
STEPIK
Дублирование фрагмента

Дана строка, в которой буква h встречается как минимум два раза. Повторите последовательность символов, заключенную между первым и последним появлением буквы h два раза, сами буквы h повторять не надо.

Входные данные

Вводится строка.

Выходные данные

Выведите ответ на задачу.

Sample Input:

In the hole in the ground there lived a hobbit
Sample Output:

In the hole in the ground there lived a e hole in the ground there lived a hobbit
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
            string copyWord = String.Copy(word);

            word = word.Replace('H', 'h');
            int firstIndex = word.IndexOf('h');
            int lastIndex = word.LastIndexOf('h');

            string substring = copyWord.Substring(firstIndex + 1, lastIndex - firstIndex - 1);
            string firstPart = copyWord.Substring(0, firstIndex + 1);
            string lastPart = copyWord.Substring(lastIndex);

            StringBuilder str = new StringBuilder(copyWord);
            str.Insert(lastIndex, substring);

            Console.WriteLine(str);
        }
    }
}
