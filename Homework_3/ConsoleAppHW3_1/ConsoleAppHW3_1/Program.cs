/* Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.
14212->нет
12821->да
23432->да*/

using System;

int reverseDigits(int number)
{
    int revNum = 0;
    while (number > 0)
    {
        revNum = revNum * 10 + number % 10;
        number = number / 10;
    }
    return revNum;
}

Console.WriteLine("Введи пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999 && number < 100000)
{
int revNum = reverseDigits(number);
    if (number == revNum) Console.WriteLine($"{number} - Палиндром");
    else Console.WriteLine($"{number} - Не палиндром");
}
else
{
    Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
}