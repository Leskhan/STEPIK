/*
STEPIK
Удали пробелы

Дана строка, Вам требуется преобразовать все идущие подряд пробелы в один. Если пробелы есть в начале и в конце строки - их нужно убрать.

Входные данные

Длина строки не превосходит 1000.

Выходные данные

Выведите измененную строку.

Sample Input:

nz d urp lren s bwz  boom  t a   j    ho    vi
Sample Output:

nz d urp lren s bwz boom t a j ho vi
*/



using System;
using System.Collections.Generic;
using System.Linq;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] words = text.Split().Where(e => !e.Equals(String.Empty)).ToArray();

            Console.WriteLine(String.Join(" ", words));
        }
    }
}
