/*
STEPIK
Две половинки

Дана строка. Разрежьте ее на две равные части (если длина строки — четная, а если длина строки нечетная, то длина первой части должна быть на один символ больше). Переставьте эти две части местами, результат запишите в новую строку и выведите на экран.

При решении этой задачи нельзя пользоваться инструкцией if.

Входные данные

Вводится строка.

Выходные данные

Выведите ответ на задачу.

Sample Input 1:

Hi
Sample Output 1:

iH
Sample Input 2:

Hello
Sample Output 2:

loHel
*/



using System;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static int SizeForSubstring(int size)
        {
            if (size % 2 == 0)
                return size / 2;
            return size / 2 + 1;
        }

        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int left = SizeForSubstring(text.Length);
            int right = SizeForSubstring(text.Length);

            string leftSubstring = text.Substring(0, left);
            string rightSubstring = text.Substring(right);

            Console.WriteLine(rightSubstring + leftSubstring);
        }
    }
}
