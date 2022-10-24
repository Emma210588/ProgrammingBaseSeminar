/* Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456-> 5
782-> 8
918-> 1 */

Console.Write("Введите цeлое трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int first = number / 100;
int second = (number - first * 100) / 10;

Console.WriteLine($"Вторая цифра трехзначного числа = {second}");