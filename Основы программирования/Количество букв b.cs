/*
STEPIK
8.2 Функция. Практика

Даны два предложения. Найти общее количество букв 'bb' в них.

 

Входные данные

Вводятся две строки, каждое из которых по длине не превосходит 10001000.

Выходные данные
Выведите  общее количество букв 'bb' в них.

Примечание: предполагается задачу решить с помощью функции.

Sample Input:

abaca
baba
Sample Output:

3
*/



using System;
using System.Linq;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static int CountChar(string str)
        {
            int result = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'b')
                    result++;
            }

            return result;
        }
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            Console.Write(CountChar(a) + CountChar(b));
        }
    }
}
