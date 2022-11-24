// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

void FillArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(10, 100);

                for (int l = 0; l < k; l++)
                {
                    if (array[i, j, l] == array[i, j, k])
                    {
                        k--;
                    }
                }
            }
                
        }
    }
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"{array[i, j, k]}   ({i}, {j}, {k})");
            }     
        }        
    }
}

Console.WriteLine("Vvedite M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedite N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedite N: ");
int p = Convert.ToInt32(Console.ReadLine());

int[,,] array = new int[m, n, p];

FillArray(array);

PrintArray(array);