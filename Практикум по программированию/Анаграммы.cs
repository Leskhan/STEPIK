/*
STEPIK
Анаграммы

Слово называется анаграммой другого слова, если оно может быть получено перестановкой его символов.

Входные данные

Даны два слова на отдельных строках. Слова состоят из строчных латинских букв и цифр. Длины слов не превышают 255.

Выходные данные

Требуется вывести "YES"  – если введенные слова являются анаграммами друг друга, "NO"  – если нет.

Sample Input:

sharm
marsh
Sample Output:

YES
*/



using System;
using System.Linq;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static bool Equals(char[] arr1, char[] arr2)
        {
            if (arr1.Length != arr2.Length)
                return false;

            for (int i = 0; i < arr1.Length; i++)
                if (arr1[i] != arr2[i])
                    return false;

            return true;
        }

        static void Main(string[] args)
        {
            var string1 = Console.ReadLine().ToCharArray();
            var string2 = Console.ReadLine().ToCharArray();

            Array.Sort(string1);
            Array.Sort(string2);

            Console.WriteLine(Equals(string1, string2) ? "YES" : "NO");
        }
    }
}   
