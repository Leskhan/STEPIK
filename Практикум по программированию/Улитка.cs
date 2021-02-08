/*
STEPIK
Улитка

Улитка ползёт по вертикальному шесту высотой h метров, поднимаясь за день на a метров, а за ночь спускаясь на b метров. На какой день улитка доползёт до вершины шеста?

Входные данные

Программа получает на вход натуральные числа h, a, b. Гарантируется, что a>b.

Выходные данные

Программа должна вывести одно натуральное число.

Примечание

При решении этой задачи нельзя пользоваться условной инструкцией if и циклами.

Sample Input:

10
3
2
Sample Output:

8
*/



using System;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            double h = Convert.ToInt32(Console.ReadLine());
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Math.Ceiling(((h - a) / (a - b))) + 1);
        }
    }
}
