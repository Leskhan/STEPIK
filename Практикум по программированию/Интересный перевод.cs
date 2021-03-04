/*
STEPIK
Интересный перевод

На планете Роботов очень не любят десятичную систему счисления, поэтому они попросили Вас написать программу, которая заменяет все встречающиеся в тексте числа на эти же числа, но в двоичной системе счисления.

Входные данные

Единственная строка, состоящая из любых символов. Длина строки не превышает 255 символов. Гарантируется, что во всех числах нет ведущих нулей.

Выходные данные

Выведите преобразованную строку.

Sample Input:

6^&678JKjdkdl;?.,lk879Pk1kdfl4839
Sample Output:

110^&1010100110JKjdkdl;?.,lk1101101111Pk1kdfl1001011100111
*/



using System;
using System.Text;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            var strBuilder = new StringBuilder();
            string str = Console.ReadLine();
            int index = 0;

            for (int i = 0; i < str.Length; i = ++index)
            {
                string t = "";
                if ('0' <= str[i] && str[i] <= '9')
                {
                    t += str[i].ToString();
                    for (int j = i + 1; j < str.Length; j++)
                    {
                        if ('0' <= str[j] && str[j] <= '9')
                        {
                            t += str[j].ToString();
                            index = j;
                        }
                        else
                            break;
                    }
                    strBuilder.Append(Convert.ToString(int.Parse(t), 2));
                }
                else
                    strBuilder.Append(str[i]);
            }

            Console.WriteLine(strBuilder);
        }
    }
}   
