/*
STEPIK
Поиск подстроки

Даны две строки. Определите, является ли первая строка подстрокой второй строки.

Входные данные

На вход подается 2 строки длины не более 10000, состоящие только из маленьких букв латинского алфавита.

Выходные данные

Необходимо вывести  слово yes, если первая строка является подстрокой второй строки, или слово no в противном случае.

Sample Input:

abac
ababacaba
Sample Output:

yes
*/



using System;
using System.Text;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            string subText = Console.ReadLine();
            string text = Console.ReadLine();
            bool check = false;

            for (int i = 0; i < text.Length - subText.Length + 1; i++)
            {
                if (subText == text.Substring(i, subText.Length))
                {
                    check = true;
                    break;
                }
            }

            if (check)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
        }
    }
}
