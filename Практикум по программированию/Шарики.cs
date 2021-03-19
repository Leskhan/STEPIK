/*
STEPIK
Шарики

В одной компьютерной игре игрок выставляет в линию шарики разных цветов. Когда образуется непрерывная цепочка из трех и более шариков одного цвета, она удаляется из линии. Все шарики при этом сдвигаются друг к другу, и ситуация может повториться.

Напишите программу, которая по данной ситуации определяет, сколько шариков будет "уничтожено". Естественно, непрерывных цепочек из трех и более одноцветных шаров в начальный момент может быть не более одной.

Входные данные

Сначала вводится количество шариков в цепочке (не более 1000) и цвета шариков (от 0 до 9, каждому цвету соответствует свое целое число).

Выходные данные

Требуется вывести количество шариков, которое будет "уничтожено".

Sample Input:

5 1 3 3 3 2
Sample Output:

3
*/



using System;
using System.Collections;

namespace STEPIK_C_SHARP
{
    class Program
    {   
        static ArrayList GetArrayList(string[] arr)
        {
            var arrayList = new ArrayList();
            for (int i = 0; i < arr.Length; i++)
                arrayList.Add(arr[i]);

            return arrayList;
        }

        static void Main(string[] args)
        {
            string[] vs = Console.ReadLine().Split();
            var list = GetArrayList(vs);
            int index = 0;
            int result = 0;

            while (index < list.Count - 1)
            {
                int lastIndex = index;
                if (list[index].ToString() == list[index + 1].ToString())
                {
                    int count = 1;
                    var t = list[index].ToString();
                    for (int i = index + 1; i < list.Count && t == list[i].ToString(); i++)
                    {
                        if (list[i].ToString() == t)
                        {
                            count++;
                            index = i;
                        }
                    }
                    if (count > 2)
                    {
                        list.RemoveRange(lastIndex, count);
                        result += count;
                        index = 0;
                    }
                }
                else
                    index++;
            }

            Console.WriteLine(result);
        }
    }
}   
