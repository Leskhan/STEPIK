/*
STEPIK
Является ли строка палиндромом?

Дана строка, состоящая из строчных латинских букв и пробелов. Проверьте, является ли она палиндромом без учета пробелов (например, "аргентина манит негра").

Входные данные

На вход подается 1 строка длины не более 100, содержащая пробелы. Подряд может идти произвольное число пробелов.

Выходные данные

Необходимо вывести yes, если данная строка является палиндромом, и no в противном случае.

Sample Input:

ab a
Sample Output:

yes
*/



using System;
using System.Text;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static string ReverseString(string str)
        {
            var stringBuilder = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
                stringBuilder.Append(str[i]);

            return stringBuilder.ToString();
        }
        static void Main(string[] args)
        {
            string str = Console.ReadLine().Replace(" ", "");

            Console.WriteLine(str == ReverseString(str) ? "yes" : "no");
        }
    }
}
