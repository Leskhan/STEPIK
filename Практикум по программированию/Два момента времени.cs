/*
STEPIK
Два момента времени

Даны значения двух моментов времени, принадлежащих одним и тем же суткам: часы, потом минуты и секунды для каждого из моментов времени. Известно, что второй момент времени наступил не раньше первого. Определите, сколько секунд прошло между двумя моментами времени.

Входные данные

В первой строке входных данных находятся три целых числа — часы, минуты и секунды первого момента времени. Во второй строке — три числа, характеризующие второй момент времени. Число часов лежит в диапазоне от 0 до 23, число минут и секунд — от 0 до 59.

Выходные данные

Выведите число секунд между двумя моментами времени.

Sample Input:

1 1 1
2 2 2
Sample Output:

3661
*/



using System;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static int Seconds(string[] numbers)
        {
            int hour = Convert.ToInt32(numbers[0]);
            int minut = Convert.ToInt32(numbers[1]);

            return hour * 3600 + minut * 60 + int.Parse(numbers[2]);
        }

        static void Main(string[] args)
        {
            int firstTime = Seconds(Console.ReadLine().Split());
            int secondTime = Seconds(Console.ReadLine().Split());

            Console.WriteLine(secondTime - firstTime);
        }
    }
}   
