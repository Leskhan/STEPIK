/*
STEPIK
5.1 Линейный поиск в массиве

Напишите программу, которая находит значение максимального элемента массива.

Входные данные

В первой строке задается одно натуральное число N, не превосходящее 1000 – размер массива.

Во второй строке вводятся N чисел – элементы массива (целые числа, не превосходящие по модулю 1000).

Выходные данные

Вывести одно число – значение максимального элемента в массиве.

Sample Input:

5
1 2 3 4 5
Sample Output:

5
*/



using System;
using System.Linq;

public class MainClass
{
    public static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        string[] vs = Console.ReadLine().Split();
        int find = Convert.ToInt32(Console.ReadLine());

        int[] numbers = new int[size];
            
        for (int i = 0; i < vs.Length; i++)
            numbers[i] = Convert.ToInt32(vs[i]);
        
        Console.WriteLine(numbers.Max());
    }
}
