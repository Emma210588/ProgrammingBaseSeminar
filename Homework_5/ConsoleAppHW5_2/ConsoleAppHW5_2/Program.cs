// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6]-> 0

int sumUnevenNumbers(int[] array) 
{
    int Sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            Sum += array[i];
        }
    }
    

    return Sum;
}
int[] array = new int[5];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,10);
    Console.WriteLine(array[i] + " ");
}
 
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях равна {sumUnevenNumbers(array)}");
