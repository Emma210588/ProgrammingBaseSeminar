// Программа, которая на вход принимает два числа и поверяет, является ли первое число квадратом второго
Console.Write("Введите первое целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое целое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2 * number2)
{
   Console.Write("Первое число является квадратом второго");  
}
else
{
    Console.Write ("Первое число не является квадратом второго"); 
}