/*
STEPIK
Хипуй!

В этой задаче вам необходимо организовать структуру данных Heap для хранения целых чисел, над которой определены следующие операции:

   a) Insert(k) – добавить в Heap число k (1 ≤  k ≤ 1000000) ;
   b) Extract достать из Heap наибольшее число (удалив его при этом).

Входные данные

В первой строке содержится количество команд N (1 ≤  N ≤ 100000), далее следуют N команд, каждая в своей строке.  Команда может иметь  формат: “0 <число>” или “1”, обозначающий, соответственно, операции Insert(<число>) и Extract. Гарантируется, что при выполенении команды Extract в структуре находится по крайней мере один элемент.

Выходные данные

Для каждой команды извлечения необходимо отдельной строкой вывести число, полученное при выполнении команды Extract.

Sample Input:

2
0 10000
1
Sample Output:

10000
*/



using System;
using System.Collections;
using System.Linq;

namespace STEPIK_C_SHARP
{
    class MainProgram
    {
        static ArrayList list = new ArrayList();

        public static void Insert(int number)
        {
            list.Add(number);
        }

        public static int Extract()
        {
            int index = 0; 
            int max = Convert.ToInt32(list[0]);

            for (int i = 0; i < list.Count; i++)
            {
                if ((int)list[i] > max)
                {
                    index = i;
                    max = (int)list[i];
                }
            }

            list.RemoveAt(index);
            return max;
        }

        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int command = 0, number = 0;

            for (int i = 0; i < n; i++)
            {
                string[] temp = Console.ReadLine().Split();
                if (temp.Length == 2)
                {
                    command = Convert.ToInt32(temp[0]);
                    number = Convert.ToInt32(temp[1]);
                }
                else
                {
                    command = Convert.ToInt32(temp[0]);
                }

                if (command == 0)
                    Insert(number);
                else if (command == 1)
                    Console.WriteLine(Extract());
            }
        }
    }
}
