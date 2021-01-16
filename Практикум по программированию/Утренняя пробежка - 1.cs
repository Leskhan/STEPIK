/*
STEPIK
Утренняя пробежка - 1

В первый день спортсмен пробежал x километров, а затем он каждый день увеличивал пробег на 70% от предыдущего значения. По данному числу y определите номер дня, на который пробег спортсмена составит не менее y километров.

Входные данные

На вход программа получает два действительных числа x и y . Числа положительные, действительные, не превосходят 1000, заданы с точностью до шести знаков после запятой.

Выходные данные

Программа должна вывести единственное целое число.

Sample Input:

10 30
Sample Output:

4
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

            while (Math.Abs(a - b) > epsilon && (a - b < epsilon))
            {
                a *= 1.7;
                counter++;
            }

            Console.WriteLine(counter + 1);
        }
    }
}
