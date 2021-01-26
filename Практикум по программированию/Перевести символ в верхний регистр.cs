/*
STEPIK
Перевести символ в верхний регистр

Необходимо перевести поданный символ в верхний регистр.

Входные данные

Задан один символ c.

Выходные данные

Если символ является строчной буквой латинского алфавита (то есть буквой от a до z), выведите вместо него аналогичную заглавную букву, иначе выведите тот же самый символ (такая операция называется "перевод в верхний регистр").

Sample Input:

e
Sample Output:

E
*/



using System;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Console.ReadLine().ToUpper());
        }
    }
}
