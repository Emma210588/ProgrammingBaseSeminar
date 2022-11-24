// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int SumLine(int[,] array, int i)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i, j];
    }
    return sum;
}


int[,] array = new int[3, 4];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 5);
        Console.Write(array[i, j] + "   ");
    }
    Console.WriteLine();
}

Console.WriteLine();


int minSumLine = SumLine(array, 0);
int NumberMinSumLine = 0;
for (int i = 0; i < array.GetLength(0); i++)
{

    if (minSumLine > SumLine(array, i))
    {
        minSumLine = SumLine(array, i);
        NumberMinSumLine = i;
    }
 }

Console.WriteLine(NumberMinSumLine+1);



















