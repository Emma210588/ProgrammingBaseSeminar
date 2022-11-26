﻿// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30

int SumNaturalNum(int m, int n)
{
    int sum = 0;
    if (m == n)
    {
        return n;
    }
    sum = m + SumNaturalNum(m + 1, n);
    return sum;
}

Console.WriteLine("Vvedite M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Vvedite N: ");
int n = Convert.ToInt32(Console.ReadLine());

if(n < m)
{
    int temp = n;
    n = m;
    m = temp;
}

Console.WriteLine(" ");

int result = SumNaturalNum(m, n);
Console.WriteLine(result);