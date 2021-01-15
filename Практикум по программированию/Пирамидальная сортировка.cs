/*
STEPIK
Пирамидальная сортировка

Отсортируйте данный массив. Используйте пирамидальную сортировку.

Входные данные

Первая строка входных данных содержит количество элементов в массиве N,  N  ≤  105. Далее задаются N целых чисел, не превосходящих по абсолютной величине 109.

Выходные данные

Выведите эти числа в порядке неубывания.

Sample Input:

5
5 4 3 2 1
Sample Output:

1 2 3 4 5
*/



using System;

namespace STEPIK_C_SHARP
{
    class MainProgram
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;
                        
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(arr, n, i);
                        
            for (int i = n - 1; i >= 0; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                Heapify(arr, i, 0);
            }
        }

        static void Heapify(int[] arr, int n, int i)
        {
            int largest = i;
            
            int l = 2 * i + 1; 
            int r = 2 * i + 2; 

            if (l < n && arr[l] > arr[largest])
                largest = l;

            if (r < n && arr[r] > arr[largest])
                largest = r;

            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                Heapify(arr, n, largest);
            }
        }

        static void PrintArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
        }

        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] temp = Console.ReadLine().Split();

            int[] numbers = new int[n];
            for (int i = 0; i < temp.Length; i++)
                numbers[i] = Convert.ToInt32(temp[i]);

            Sort(numbers);
            PrintArray(numbers);
        }
    }
}
