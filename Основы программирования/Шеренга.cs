/*
STEPIK

7.5 Итоговый тест
Шеренга

Петя впервые пришел на урок физкультуры в новой школе. Перед началом урока ученики выстраиваются по росту, в порядке невозрастания. Напишите программу, которая определит на какое место в шеренге Пете нужно встать, чтобы не нарушить традицию, если заранее известен рост каждого ученика и эти данные уже расположены по невозрастанию (то есть каждое следующее число не больше предыдущего). Если в классе есть несколько учеников с таким же ростом, как у Пети, то программа должна расположить его после них.

Входные данные
Сначала задано число NN — количество учеников (не считая Петю)(1 \le N \le 1001≤N≤100). Далее через пробел записаны NN чисел — элементы массива. Массив состоит из натуральных чисел, не превосходящих 200200 (рост учеников в сантиметрах). Затем, на новой строке, вводится рост самого Пети.

Выходные данные
Необходимо вывести единственное число - номер Пети в шеренге учеников.

Sample Input:

5
180 170 140 135 130
165
Sample Output:

3
*/



using System;
using System.Linq;
using System.Collections.Generic;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr = Console.ReadLine().Split();            
            int height = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(arr[i]);
            }

            bool ch = false;
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                if (height > numbers[i])
                {
                    ch = true;
                    index = i;
                    break;
                }
            }


            if (!ch)
            {
                Console.WriteLine(n + 1);
            }
            else
            {
                Console.WriteLine(index + 1);
            }
        }
    }
}
