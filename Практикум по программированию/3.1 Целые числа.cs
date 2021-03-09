/*
STEPIK
k-я секунда суток

Идёт k-я секунда суток. Определите, сколько целых часов h и целых минут m прошло с начала суток. Например, если

k=13257=3⋅3600+40⋅60+57,

то h=3 и m=40.

Входные данные

На вход программе подается целое число k (0 ≤ k ≤ 86399).

Выходные данные

Выведите на экран фразу:

It is ... hours ... minutes.

Вместо многоточий программа должна выводить значения h и m, отделяя их от слов ровно одним пробелом.

Sample Input:

13257
Sample Output:

It is 3 hours 40 minutes.
*/



using System;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            long second = Convert.ToInt32(Console.ReadLine());

            long hour = second / 3600;
            second %= 3600;

            long minut = second / 60;

            if (hour >= 24)
                hour %= 24;

            Console.WriteLine($"It is {hour} hours {minut} minutes.");
        }
    }
}   
