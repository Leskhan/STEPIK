/*
STEPIK
Капитан Флинт

Капитан Флинт зарыл клад на Острове сокровищ. Он оставил описание, как найти клад. Описание состоит из строк вида: "North 5", где  слово – одно из "North", "South", "East", "West", – задает направление движения, а  число – количество шагов, которое необходимо пройти в этом направлении.

Напишите программу, которая по описанию пути к кладу определяет точные координаты клада, считая, что начало координат находится в начале пути, ось OX направлена на восток, ось OY – на север.

Входные данные

На вход подается последовательность строк указанного формата. Гарантируется, что числа не превосходят 10^810 
8
 .

Выходные данные

Необходимо вывести  координаты клада – два целых числа через пробел. Гарантируется, что эти числа не превосходят 10^810 
8
 .

Sample Input:

South 19
Sample Output:

0 -19
*/



using System;
using System.Linq;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0;

            while (true)
            {
                var line = Console.ReadLine();
                if (line != null)
                {
                    string[] vs = line.Split();
                    string direction = vs[0];
                    int coor = Convert.ToInt32(vs[1]);

                    switch (direction)
                    {
                        case "North": y += coor; break;
                        case "South": y -= coor; break;
                        case "East": x += coor; break;
                        case "West": x -= coor; break;
                    }
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine($"{x} {y}");
        }
    }
}
