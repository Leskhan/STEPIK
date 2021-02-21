/*
STEPIK
Структура set

Напишите программу, которая будет выполнять последовательность запросов вида ADD num, PRESENT num и COUNT (без параметра). Программу обязательно следует писать с использованием шаблонного типа set.

Выполнение каждого запроса вида ADD num должно добавлять элемент num во множество (если такой элемент уже есть, добавление ещё одной копии не изменяет множество), на экран при этом ничего не выводится.

При выполнении каждого запроса вида PRESENT num должно выдаваться сообщение «YES» или «NO» (большими буквами, в отдельной строке), соответственно тому, есть ли такой элемент во множестве; значение множества при этом не изменяется.

При выполнении каждого запроса вида COUNT должна выдаваться на экран в отдельной строке текущее количество различных элементов в множестве; значение множества при этом не изменяется.

Входные данные

В первой строке стандартного входного потока задано количество запросов N (1 < N < 100000), далее следуют N строк, каждая из которых содержит по одному запросу согласно описанного формата.

Значения чисел не превышают по модулю 100000000.

Выходные данные

Выводите на стандартный выход (экран) в отдельных строках результаты запросов PRESENT и COUNT; на запросы ADD ничего выводить не надо.

Sample Input:

7
ADD 5
ADD 7
COUNT
PRESENT 3
PRESENT 5
ADD 3
COUNT
Sample Output:

2
NO
YES
3
*/



using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static bool IsHere(HashSet<string> ts, string str)
        {
            foreach (var item in ts)
            {
                if (item == str)
                    return true;
            }

            return false;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            var hashSet = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {    
                string command = Console.ReadLine();

                if (command.Trim() != "COUNT")
                {
                    string[] array = command.Split();
                    switch (array[0])
                    {
                        case "ADD":
                            hashSet.Add(array[1]);
                            break;
                        case "PRESENT":
                            Console.WriteLine(IsHere(hashSet, array[1]) ? "YES" : "NO");
                            break;
                        default:
                            break;
                    }
                }
                else
                    Console.WriteLine(hashSet.Count);
            }
        }
    }
}
