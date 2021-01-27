/*
STEPIK
Самое длинное слово

Дана строка, содержащая пробелы. Найдите в ней самое длинное слово, выведите  это слово и его длину. Если таких слов несколько, выведите первое из них.

Входные данные

Задана одна строка, содержащая пробелы. Слова разделены ровно одним пробелом. Пробелы в начале и конце строки допускаются.

Выходные данные

Необходимо вывести самое длинное слово в строке и его длину.

Sample Input:

one two three four five six
Sample Output:

three
5
*/



using System;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            string text = words[0];
            int size = words[0].Length;

            for (int i = 1; i < words.Length; i++)
            {
                if (words[i].Length > size)
                {
                    text = words[i];
                    size = words[i].Length;
                }
            }

            Console.WriteLine(text + "\n" + size);
        }
    }
}
