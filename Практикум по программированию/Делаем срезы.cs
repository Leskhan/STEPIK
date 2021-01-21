/*
STEPIK
Делаем срезы

Выполните разбор строки, согласно приведенным правилам.

Входные данные

Дана строка.

Выходные данные

Сначала выведите третий символ этой строки.

Во второй строке выведите предпоследний символ этой строки.

В третьей строке выведите первые пять символов этой строки.

В четвертой строке выведите всю строку, кроме последних двух символов.

В пятой строке выведите все символы с четными индексами (считая, что индексация начинается с 0, поэтому символы выводятся начиная с первого).

В шестой строке выведите все символы с нечетными индексами, то есть начиная со второго символа строки.

В седьмой строке выведите все символы в обратном порядке.

В восьмой строке выведите все символы строки через один в обратном порядке, начиная с последнего.

В девятой строке выведите длину данной строки.

Sample Input:

Abrakadabra
Sample Output:

r
r
Abrak
Abrakadab
Arkdba
baaar
arbadakarbA
abdkrA
11
*/



using System;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(text[2]);
            Console.WriteLine(text[text.Length - 2]);
            Console.WriteLine(text.Substring(0, 5));
            Console.WriteLine(text.Substring(0, text.Length - 2));
            for (int i = 0; i < text.Length; i += 2)
                Console.Write(text[i]);
            Console.WriteLine();
            for (int i = 1; i < text.Length; i += 2)
                Console.Write(text[i]);
            Console.WriteLine();
            for (int i = text.Length - 1; i >= 0; i--)
                Console.Write(text[i]);
            Console.WriteLine();
            for (int i = text.Length - 1; i >= 0; i -= 2)
                Console.Write(text[i]);
            Console.WriteLine();
            Console.WriteLine(text.Length);
        }
    }
}
