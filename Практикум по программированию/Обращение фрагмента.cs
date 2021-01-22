/*
STEPIK
Обращение фрагмента

Дана строка, в которой буква h встречается как минимум два раза. Разверните последовательность символов, заключенную между первым и последним появлением буквы h, в противоположном порядке.

Входные данные

Вводится строка.

Выходные данные

Выведите ответ на задачу.

Sample Input:

In the hole in the ground there lived a hobbit
Sample Output:

In th a devil ereht dnuorg eht ni eloh ehobbit
*/



using System;

namespace STEPIK_C_SHARP
{
    class Program
    {
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

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
            string reverseString = ReverseString(substring);

            Console.WriteLine(firstPart + reverseString + lastPart);
        }
    }
}
