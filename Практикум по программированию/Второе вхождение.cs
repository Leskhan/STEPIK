/*
STEPIK
Второе вхождение

Дана строка. Найдите в этой строке второе вхождение буквы f, и выведите индекс этого вхождения. Если буква f в данной строке встречается только один раз, выведите число -1, а если не встречается ни разу, выведите число -2.

При решении этой задачи нельзя использовать метод count.

Входные данные

Вводится строка.

Выходные данные

Выведите ответ на задачу.

Sample Input 1:

comfort
Sample Output 1:

-1
Sample Input 2:

coffee
Sample Output 2:

3
*/



using System;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int index = word.IndexOf('f');
            int secondIndex = 0;
            if (index >= 0)
                secondIndex = word.IndexOf('f', index + 1);
            else 
                Console.WriteLine(-2);

            if (secondIndex > 0)
                Console.WriteLine(secondIndex);
            else if (secondIndex == -1)
                Console.WriteLine(-1);
        }
    }
}
