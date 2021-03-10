/*
STEPIK
Без циклов

В книге на одной странице помещается k строк. Таким образом, на 1-й странице печатаются строки с 1-й по k-ю, на второй — с (k+1)-й по (2k)-ю и т. д. Напишите программу, по номеру строки в тексте определяющую номер страницы, на которой будет напечатана эта строка, и порядковый номер этой строки на странице.

Входные данные

На вход программе подаются число k — количество строк на странице и число n — номер строки в тексте (1 ≤ k ≤ 200, 1 ≤ n ≤ 20000).

Выходные данные

Выведите два числа — номер страницы, на которой будет напечатана эта строка, и номер строки на этой странице

Для считывания данных на языке Python 3 можно использовать следующую конструкцию:

k, n = map(int, input().split())

Sample Input:

50 1
Sample Output:

1 1
*/



using System;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vs = Console.ReadLine().Split();
            int countLine = int.Parse(vs[0]);
            int noLine = int.Parse(vs[1]);

            Console.Write($"{Math.Ceiling((double)noLine / countLine)} ");

            if (countLine == noLine)
                Console.Write(countLine);
            else if (noLine % countLine == 0)
                Console.Write(countLine);
            else
                Console.Write(noLine % countLine);
        }
    }
}   
