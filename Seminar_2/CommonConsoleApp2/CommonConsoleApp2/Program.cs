/* Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456-> 46
782-> 72
918-> 98*/

int number = new Random().Next(100, 1000);
Console.WriteLine(number);

int last = number % 10;
int first = number / 100;
int result = first * 10 + last;

Console.WriteLine($"Случайное число без второй цифры равно: {result}");
