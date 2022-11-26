// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3->A(m, n) = 9
// m = 3, n = 2->A(m, n) = 29

int FunctionsAckerman (int m, int n)
{
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0 && m > 0)
        {
            return FunctionsAckerman(m - 1, 1);
        }
        else
        {
            return FunctionsAckerman(m - 1, FunctionsAckerman(m, n - 1));
        }
}


Console.WriteLine("Vvedite M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Vvedite N: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = FunctionsAckerman(m, n);
Console.WriteLine($"A(m, n) = {result}");