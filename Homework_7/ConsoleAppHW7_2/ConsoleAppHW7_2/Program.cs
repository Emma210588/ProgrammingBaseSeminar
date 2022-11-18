// Напишите программу, которая будет принимать от пользователя позицию (M, N) двумерного массива
// и возвращать значение элемента, стоящего в этой позиции.
// Если такой позиции в массиве нет, то сообщить об этом пользователю.
// Сгенерировать массив случайным образом. Размерность массива определить самостоятельно.
// Использование методов для заполнения массива обязательно. Остальное можно реализовать в главной программе.

void FillArray(int[,] array)
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

int[,] array = new int[7, 5];

FillArray(array);
Console.WriteLine();

Console.WriteLine("Vvedite M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Vvedite N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m < array.GetLength(0) && n < array.GetLength(1))
{
    Console.WriteLine(array[m, n]);
}
else
{
    Console.WriteLine($"{m}   {n} -> В массиве отсутствует элемент в такой позиции");
}








