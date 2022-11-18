// Запросите от пользователя размерности двумерного массива.
// Напишите метод для заполнения массива случайными числами.
// Напишите метод для поиска ср. арифметического значения каждого столбца.

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + "   ");
        }
        Console.WriteLine();
    }
}

void Average(double[,] array)
{
    double sum = 0;
    double average = 0;

    for(int i = 0; i < array.GetLength(1); i++)
    {
        for(int j = 0; j < array.GetLength(0); j++)
        {
            sum = sum + array[j, i];
        }
        average = sum / array.GetLength(0);
        sum = 0;
        Console.WriteLine(average);
    }
  }

Console.WriteLine("Vvedite M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Vvedite N: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];

FillArray(array);
Console.WriteLine();
Average(array);
