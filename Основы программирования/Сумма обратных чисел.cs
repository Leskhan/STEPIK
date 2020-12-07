/*
STEPIK
8.2 Функция. Практика

Дано два натуральных числа, не заканчивающиеся на 00. Замените каждое число на обратное и вычислите их сумму. 

 

Например, дается два числа 624624 и 10241024. Каждое заменяем на обратное, то есть 624\Rightarrow426, 1024\Rightarrow4201.624⇒426,1024⇒4201. Затем находим их сумму: 426 + 4201 = 4627.426+4201=4627.
 

Входные данные

Вводятся два натуральных числа, каждый из которых не превосходит 10^810 
8
 . Гарантируется, что каждое число не оканчивается на 00.

Выходные данные
Выведите сумму обратных чисел.

Примечание: предполагается задачу решить с помощью функции.

Sample Input:

624
1024
Sample Output:

4627
*/



using System;
using System.Linq;

namespace STEPIK_C_SHARP
{
    class Program
    {       
        static int Func(string number)
        {
            char[] arr = number.ToCharArray();
            int index = arr.Length - 2;
            int i = 1;
            string n = Convert.ToString(arr[arr.Length - 1]);

            while(index >= 0)
            {
                n = n.Insert(i, Convert.ToString(arr[index]));
                i++;
                index--;
            }

            return Convert.ToInt32(n);
        }
        static void Main(string[] args)
        {
            string number1 = Console.ReadLine();
            string number2 = Console.ReadLine();
                        
            Console.WriteLine(Func(number1) + Func(number2));
        }
    }
}
