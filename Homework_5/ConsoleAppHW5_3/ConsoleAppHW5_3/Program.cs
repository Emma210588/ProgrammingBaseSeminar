// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double differenceMaxMin(double[]array)
{
    double difference = 0;
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
        difference = max - min;
    }

    return difference;
}

Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToDouble(new Random().Next()) / 100;
    Console.WriteLine(array[i] + " "); 
}

Console.WriteLine($"Разницу между максимальным и минимальным элементов массива: {differenceMaxMin(array)}");