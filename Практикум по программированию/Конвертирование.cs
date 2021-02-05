/*
STEPIK
Конвертирование

using System;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static char[] ToCharArrayWithEmpty(string text)
        {
            char[] array = new char[text.Length + 1];
            array[0] = '0';

            for (int i = 0; i < text.Length; i++)
            {
                array[i + 1] = text[i];
            }

            return array;
        }

        static void Main(string[] args)
        {
            string vs = Console.ReadLine();
            string[] numbers = Console.ReadLine().Split();
            int i = int.Parse(numbers[0]);
            int j = int.Parse(numbers[1]);

            var text = ToCharArrayWithEmpty(vs);

            for (int indexI = i, indexJ = j; indexI <= indexJ; indexI++, indexJ--)
            {
                var temp = text[indexI];
                text[indexI] = text[indexJ];
                text[indexJ] = temp;
            }

            Console.WriteLine(String.Join("", text).Substring(1));
        }
    }
}
*/
