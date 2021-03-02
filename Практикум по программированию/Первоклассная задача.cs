/*
STEPIK
Первоклассная задача

Преподаватель по программированию некоего Центра для одаренных детей, узнав, что его ученики знают математику 3-го класса на 97.001 процентов, решил проверить их знания по курсу математики 1-го класса. Для этого он взял за основу популярнейшую у математиков 1-го класса задачу. Первоклассник должен был продолжить следующую последовательность рядов:

1

11

21

1211

111221

312211

13112221

Входные данные

В единственной строке входного файла записаны два целых числа через пробел: x (0 <= x <= 100) - первый член последовательности и n (1 <= n <= 25).

Выходные данные

Выведите n-ый ряд x-ой последовательности.

Sample Input:

1 4
Sample Output:

1211
*/



using System;
using System.Text;
using System.Numerics;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static int Xz(string str)
        {
            int c = 0;
            char ch = str[str.Length - 1];

            for (int i = str.Length - 1; i >= 0; i--)
                if (str[i] == ch)
                    c++;
                else
                    return c;

            return c;
        }

        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split();
            string numbers = a[0];
            int n = int.Parse(a[1]);

            int index = 0;
            int counter = 0;
            string str = "";

            for (int z = 0; z < n - 1; z++)
            {
                var strBuilder = new StringBuilder();
                for (int i = index; i < numbers.Length; i = ++index)
                {
                    
                    if (i == numbers.Length - Xz(numbers) + 1)
                        break;

                    for (int j = i; j < numbers.Length; j++)
                    {
                        if (numbers[index] == numbers[j])
                        {
                            counter++;
                        }
                        else
                        {
                            index = j - 1;
                            break;
                        }
                    }
                    strBuilder.Append(counter);
                    strBuilder.Append(numbers[index]);
                    str = strBuilder.ToString();
                    counter = 0;
                }
                numbers = str;
                index = 0;
            }

            Console.WriteLine(numbers);
        }
    }
}
