/*
STEPIK
Замена внутри фрагмента

Дана строка. Замените в этой строке все появления буквы h на букву H, кроме первого и последнего вхождения.

Входные данные

Вводится строка.

Выходные данные

Выведите ответ на задачу.

Sample Input:

In the hole in the ground there lived a hobbit
Sample Output:

In the Hole in tHe ground tHere lived a hobbit
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

            substring = substring.Replace('h', 'H');
            Console.WriteLine(firstPart + substring + lastPart);
        }
    }
}
