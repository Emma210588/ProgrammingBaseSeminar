/* Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
 * Для решения задания использование цикла for является обязательным условием. 
 * Не использовать встроенный метод возведения в степень.*/

int Pow(int a, int b)
{
    int res = a;
    for (int i = 1; i < b; i++)
    { 
    res = res * a;
    }
    return res;
}
Console.WriteLine("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Число А в степени В равно: {Pow(a,b)}");