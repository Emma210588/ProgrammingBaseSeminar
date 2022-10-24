/* Напишите программу, которая выводит третью цифру заданного числа
или сообщает, что третьей цифры нет.
645-> 5
78->третьей цифры нет
32679 -> 6 */

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
    Console.Write("Третьей цифры нет");
else
{
    while (number > 999)
    {
       number = number / 10;
    }

    int result = number % 10;
    Console.Write($"Третья цифра заданного числа: {result}");
}

