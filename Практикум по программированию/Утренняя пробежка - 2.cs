/*
STEPIK
Утренняя пробежка - 2

В первый день спортсмен пробежал x километров, а затем он каждый день увеличивал пробег на 70% от предыдущего значения. По данному числу y определите номер дня, на который суммарный пробег спортсмена составит не менее y километров.

Входные данные

На вход программа получает два действительных числа x и y. Числа положительные, действительные, не превосходят 1000, заданы с точностью до шести знаков после запятой.

Выходные данные

Программа должна вывести единственное целое число.

Sample Input:

1 20
Sample Output:

6

*/



using System;

namespace STEPIK_C_SHARP
{
    class MainProgram
    {     
        public static void Main()
        {
            string[] temp = Console.ReadLine().Split();
            double a = Convert.ToDouble(temp[0]);
            double b = Convert.ToDouble(temp[1]);
            double epsilon = 0.000001;
            int counter = 0;
            double sum = Convert.ToDouble(temp[0]);

            while (Math.Abs(sum - b) > epsilon && (sum - b < epsilon))
            {
                a *= 1.7;
                sum += a;
                counter++;
            }

            Console.WriteLine(counter + 1);
        }
    }
}
