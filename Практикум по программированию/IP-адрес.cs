/*
STEPIK
IP-адрес

Для того чтобы выходить в Интернет, каждому компьютеру присваивается так называемый IP-адрес. Он состоит из четырех целых чисел в диапазоне от 0 до 255, разделенных точками. В следующих трех строках показаны три правильных IP-адреса:

127.0.0.0
192.168.0.01
255.00.255.255
Напишите программу, которая определяет, является ли заданная строка правильным IP-адресом.

Входные данные

На вход программе подается строка длиной не более 15 символов, которая включает цифры и ровно три точки.

Выходные данные

Если строка является правильным IP-адресом, необходимо вывести 1, иначе 0.

Sample Input:

127.0.0.1
Sample Output:

1
*/



using System;
using System.Linq;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static bool IsCorrectString(string address)
        {
            if (address.Count(i => i == '.') == 3)
                return true; 

            return false;
        }

        static bool IsCorrectIP(int n)
        {
            return 0 <= n && n <= 255;
        }

        static bool IsCorrectAddress(string[] address)
        {
            if (address.Length != 4)
                return false;

            foreach (string item in address)
            {
                if (!IsCorrectIP(Convert.ToInt32(item)))
                    return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            string address = Console.ReadLine();

            if (IsCorrectString(address) && address.Length != 3 && address.Length > 3)
            {
                string[] numbers = address.Split('.').Where(it => !it.Equals(String.Empty)).ToArray(); ;

                Console.WriteLine(IsCorrectAddress(numbers) ? 1 : 0);
            }
            else
                Console.WriteLine(0);
        }
    }
}
