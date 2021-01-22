/*
STEPIK
Первое и последнее вхождение

Дана строка. Если в этой строке буква f встречается только один раз, выведите её индекс. Если она встречается два и более раз, выведите индекс её первого и последнего появления. Если буква f в данной строке не встречается, ничего не выводите.

При решении этой задачи нельзя использовать метод count и циклы.

Входные данные

Вводится строка.

Выходные данные

Выведите ответ на задачу.

Sample Input 1:

comfort
Sample Output 1:

3
Sample Input 2:

office
Sample Output 2:

1 2
*/



using System;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int leftIndex = word.IndexOf('f');
            int rightIndex = word.LastIndexOf('f');

            if (leftIndex == rightIndex && (leftIndex != -1 || rightIndex != -1))
                Console.WriteLine(leftIndex);
            else if (leftIndex >= 0 && rightIndex >= 0)
                Console.WriteLine($"{leftIndex} {rightIndex}");
        }
    }
}
