/*
STEPIK
Проверить, является ли символ цифрой

На вход подается единственный символ. Необходимо определить, является ли данный символ цифрой или нет.

Входные данные

Задан единственный символ c.

Выходные данные

Необходимо вывести  строку yes, если символ является цифрой, и строку no в противном случае.

Sample Input:

с
Sample Output:

no
*/



using System;

public class MainClass
{
    public static void Main()
    {
        Console.WriteLine(Char.IsDigit(Convert.ToChar(Console.ReadLine())) ? "yes" : "no");
    }
}
