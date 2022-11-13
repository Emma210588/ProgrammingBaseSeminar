// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int QuantityEvenInteger(int[] array) 
{
    int count = 0;
    for (int i = 0; i < 15; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;  

}

int[] array = new int[15];
for (int i = 0; i < 15; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.WriteLine(array[i] + " ");
}
 
Console.WriteLine(QuantityEvenInteger(array));
 