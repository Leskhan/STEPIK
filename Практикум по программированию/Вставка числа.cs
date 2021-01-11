/*
STEPIK
Вставка числа

Требуется вставить в данный массив на данное место данный элемент, сдвинув остальные элементы вправо.

Входные данные

В первой строке вводится одно натуральное число, не превосходящее 1000 – размер массива. Во второй строке задаются N чисел – элементы массива (целые числа, не превосходящие по модулю 1000). В третьей строке вводится число, которое необходимо вставить, и номер места, на которое его нужно вставить.

Выходные данные

Вывести получившийся массив.

Sample Input:

5
1 2 3 4 5
2 3
Sample Output:

1 2 2 3 4 5
*/



using System;
using System.Linq;

namespace STEPIK_C_SHARP
{
    class MainProgram
    {      
        static void AddElement(ref int[] array, int item, int index)
        {
            int[] numbers = new int[array.Length + 1];

            for (int i = 0; i < index - 1; i++)
                numbers[i] = array[i];

            numbers[index - 1] = item;

            for (int i = index; i < numbers.Length; i++)
                numbers[i] = array[i - 1];

            array = numbers;
        }

        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] temp = Console.ReadLine().Split();
            string[] vs = Console.ReadLine().Split();

            int[] numbers = new int[n];
            for (int i = 0; i < temp.Length; i++)
                numbers[i] = Convert.ToInt32(temp[i]);

            int item, numberOfItem;
            item = Convert.ToInt32(vs[0]);
            numberOfItem = Convert.ToInt32(vs[1]);

            AddElement(ref numbers, item, numberOfItem);

            foreach (var e in numbers)
                Console.Write(e + " ");
        }
    }
}
