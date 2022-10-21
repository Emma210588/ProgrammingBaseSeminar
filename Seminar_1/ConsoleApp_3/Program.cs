// Программа, которая выдает название дня недели по заданному номеру
Console.Write("Введите число дня недели: ");
int numberWeek = Convert.ToInt32(Console.ReadLine());
if (numberWeek > 7 || numberWeek <1)
{
    Console.Write("Дней недели всего 7");
} 
else
{
    if (numberWeek == 1) Console.Write("Это же понедельник!");
    if (numberWeek == 2) Console.Write("Это же вторник!");
    if (numberWeek == 3) Console.Write("Это же среда!");
    if (numberWeek == 4) Console.Write("Это же четверг!");
    if (numberWeek == 5) Console.Write("Это же пятница!");
    if (numberWeek == 6) Console.Write("Это же суббота!");
    if (numberWeek == 7) Console.Write("Это же воскресенье!");
}