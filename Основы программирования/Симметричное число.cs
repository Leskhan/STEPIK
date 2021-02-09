/*
STEPIK
Симметричное число

Дано четырехзначное число. Определите, является ли его десятичная запись симметричной. Если число симметричное, то выведите 1, иначе выведите 0. Число может иметь меньше четырех знаков, тогда нужно считать, что его десятичная запись дополняется слева незначащими нулями.

При решении этой задачи нельзя пользоваться условной инструкцией if и циклами

Входные данные

Вводится четырехзначное число.

Выходные данные

Выведите ответ на задачу.

Sample Input:

2002
Sample Output:

1
*/



using System;
using System.Text;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static bool Simmetriya(string n)
        {
            var strB = new StringBuilder();

            for (int i = n.Length - 1; i >= 0; i--)
            {
                strB.Append(n[i]);
            }

            return n == strB.ToString() || n.Substring(0, 2) == strB.ToString().Substring(2, 2);
        }

        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string temp = "";

            int size = number.Length;
            while (size < 4)
            {
                temp += "0";
                size++;
            }

            Console.WriteLine(Convert.ToInt32(Simmetriya(temp + number)));
        }
    }
}
