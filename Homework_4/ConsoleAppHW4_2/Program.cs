/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Для решения задания использование цикла for является обязательным условием
452-> 11
82-> 10
9012-> 12*/

int SumNumber(int number)
{
    string strNum = Math.Abs(number).ToString();
    int lenght = strNum.Length;
    int Sum = 0;

    for (int i = 0; i < lenght; i++)
        {
        int num_1 = Convert.ToInt32(strNum[i].ToString());
        Sum = Sum + num_1;
        }
    return Sum;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма чисел равна: {SumNumber(number)}");