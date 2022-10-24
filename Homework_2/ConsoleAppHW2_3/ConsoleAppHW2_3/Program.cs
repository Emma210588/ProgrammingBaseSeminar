/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
6->да
7->да
1->нет*/

Console.Write("Введите число дня недели: ");
int numberWeek = Convert.ToInt32(Console.ReadLine());

if (numberWeek > 7 || numberWeek < 1)
{
    Console.Write("Дней недели всего 7");
}

else
{
    if (numberWeek == 6 || numberWeek == 7) 
    {
        Console.Write("Да");
    } 
        
    else
    {
        Console.Write("Нет");
    }
       
}