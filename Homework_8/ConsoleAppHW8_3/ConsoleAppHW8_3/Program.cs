// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "   ");
        }
        Console.WriteLine();
    }
}

int[,] MatrixMultiplication (int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for(int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int Sum = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                Sum = Sum + (firstMatrix[i, k] * secondMatrix[k, j]);
            }
            resultMatrix[i, j] = Sum;
        }
    }
        
    return resultMatrix;
} 

Console.WriteLine("Введите количество строк первой матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы и количество строк второй: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов второй матрицы: ");
int p = Convert.ToInt32(Console.ReadLine());

int[,] firstMatrix = new int[m, n];
FillArray(firstMatrix);
Console.WriteLine("Первая матрица: ");
PrintArray(firstMatrix);

int[,] secondMatrix = new int[n, p];
FillArray(secondMatrix);
Console.WriteLine("Вторая матрица: ");
PrintArray(secondMatrix);

Console.WriteLine(" ");
int[,] resultArray = MatrixMultiplication(firstMatrix, secondMatrix);
PrintArray(resultArray);